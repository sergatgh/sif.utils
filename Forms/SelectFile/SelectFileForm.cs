using SIF.Utils.Forms.Common;
using SIF.Utils.Helpers;
using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;
using System.Text.Json;

namespace SIF.Utils.Forms.SelectFile
{
    public partial class SelectFileForm : UserControl
    {
        public event ResultEventHandler<SifJsonParsingResult>? FileSelected;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowRawJson
        {
            get => dragAndDropArea1.AllowRawJson;
            set => dragAndDropArea1.AllowRawJson = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowUrl
        {
            get => dragAndDropArea1.AllowUrl;
            set => dragAndDropArea1.AllowUrl = value;
        }

        public SelectFileForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private async void dragAndDropArea1_FileSelected(object sender, ResultEventArgs<string> e)
        {
            var input = e.Result.Trim();

            if (File.Exists(input))
            {
                await ParseFile(input);
            }
            else if (input.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                     input.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                await ParseUrl(input);
            }
            else
            {
                await ParseRawJson(input);
            }
        }

        protected async Task ParseFile(string filePath)
        {
            dragAndDropArea1.Visible = false;
            recentFiles1.Visible = false;
            loadingImage.Visible = true;

            SifJsonParsingResult parseResult;
            using (new LongOperationState())
            {
                var parsed = await Task.WhenAll(
                    new SifJsonParser().Parse(filePath),
                    Wait(1000, SifJsonParsingResult.Empty)// Showing the loading image for at least 500ms to avoid flickering for fast operations
                );
                parseResult = parsed[0];
            }

            if (!parseResult.HasError)
            {
                ProcessRecentFile(filePath);
            }

            FileSelected?.Invoke(this, parseResult);
            dragAndDropArea1.Visible = true;
            recentFiles1.Visible = true;
            loadingImage.Visible = false;
        }

        public void ProcessRecentFile(string path)
        {
            var recentFiles = Properties.Settings.Default.RecentFiles.ParseJsonList<RecentFileModel>();
            var recentFile = recentFiles.FirstOrDefault(x => x.FilePath == path);
            if (recentFile == null)
            {
                if (recentFiles.Count >= 5)
                {
                    var oldestFile = recentFiles.OrderBy(x => x.LastOpened).First();
                    oldestFile.LastOpened = DateTime.Now;
                    oldestFile.FilePath = path;
                }
                else
                {
                    recentFiles.Add(new RecentFileModel(path));
                }
            }
            else
            {
                recentFile.LastOpened = DateTime.Now;
            }

            Properties.Settings.Default.RecentFiles = JsonSerializer.Serialize(recentFiles.OrderByDescending(x => x.LastOpened));
            Properties.Settings.Default.Save();
        }

        public void UpdateRecentFiles()
        {
            var recentFiles = Properties.Settings.Default.RecentFiles.ParseJsonList<RecentFileModel>();
            if (recentFiles.Count == 0)
            {
                this.recentFiles1.Visible = false;
                return;
            }

            this.recentFiles1.UpdateRecentFiles(recentFiles);
        }

        public void UpdateInstructionLabel()
        {
            dragAndDropArea1.UpdateInstructionLabel();
        }

        private async void recentFiles1_FileSelected(object sender, ResultEventArgs<string> e)
        {
            await ParseFile(e.Result);
        }

        protected async Task ParseUrl(string url)
        {
            dragAndDropArea1.Visible = false;
            recentFiles1.Visible = false;
            loadingImage.Visible = true;

            SifJsonParsingResult parseResult;
            using (new LongOperationState())
            {
                try
                {
                    var parsed = await Task.WhenAll(
                        new SifJsonParser().ParseUrl(url),
                        Wait(1000, SifJsonParsingResult.Empty)
                    );
                    parseResult = parsed[0];
                    if (!parseResult.HasError)
                        parseResult.FilePath = url;
                }
                catch (Exception ex)
                {
                    parseResult = new SifJsonParsingResult { Error = $"Failed to download URL: {ex.Message}", IsRawJson = true };
                }
            }

            FileSelected?.Invoke(this, parseResult);
            dragAndDropArea1.Visible = true;
            recentFiles1.Visible = true;
            loadingImage.Visible = false;
        }

        protected async Task ParseRawJson(string jsonContent)
        {
            dragAndDropArea1.Visible = false;
            recentFiles1.Visible = false;
            loadingImage.Visible = true;

            SifJsonParsingResult parseResult;
            using (new LongOperationState())
            {
                var parsed = await Task.WhenAll(
                    new SifJsonParser().ParseContent(jsonContent),
                    Wait(1000, SifJsonParsingResult.Empty)
                );
                parseResult = parsed[0];
            }

            FileSelected?.Invoke(this, parseResult);
            dragAndDropArea1.Visible = true;
            recentFiles1.Visible = true;
            loadingImage.Visible = false;
        }

        private async Task<T> Wait<T>(int milliseconds, T result)
        {
            await Task.Delay(milliseconds);
            return result;
        }

        public void UpdateDescription(string description)
        {
            this.labelSelectFile.Text = description;
        }
    }
}
