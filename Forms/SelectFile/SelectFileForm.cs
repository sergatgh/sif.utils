using SIF.Utils.Forms.Common;
using SIF.Utils.Helpers;
using SIF.Utils.Logic.JsonParser;
using System.Diagnostics;
using System.Text.Json;

namespace SIF.Utils.Forms.SelectFile
{
    public partial class SelectFileForm : UserControl
    {
        public event ResultEventHandler<SifJsonParsingResult>? FileSelected;

        public SelectFileForm()
        {
            InitializeComponent();
        }

        private async void dragAndDropArea1_FileSelected(object sender, ResultEventArgs<string> e)
        {
            await ParseFile(e.Result);
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
                    new SifJsonService().ParseJson(filePath),
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

        private async void recentFiles1_FileSelected(object sender, SIF.Utils.Forms.Common.ResultEventArgs<string> e)
        {
            await ParseFile(e.Result);
        }

        private async Task<T> Wait<T>(int milliseconds, T result)
        {
            await Task.Delay(milliseconds);
            return result;
        }
    }
}
