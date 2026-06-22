namespace SIF.Utils
{
    using SIF.Utils.Forms.Common;
    using SIF.Utils.Forms.Main;
    using SIF.Utils.Logic.JsonParser;
    using System.Windows.Forms;

    public partial class SifJsonParsingForm : Form
    {
        private Navigator _navigator = null!;
        private Action<SifJsonParsingResult>? _afterFileSelected;

        public SifUtilsContext Context { get; } = new();

        private readonly SifJsonParser _sifJsonService;

        public SifJsonParsingForm(string[]? args)
        {
            InitializeComponent();

            _navigator = new Navigator([
                MainSelectFilePanel, MainChooseFileForm, MainJsonViewer,
                MainScriptRunnerForm, MainChooseExportFormat, MainFileParsingError, MainJsonBuilder,
            ]);

            MainJsonViewer.OnOpenInBuilder += (_, e) =>
            {
                MainJsonBuilder.LoadFromResult(e.Result);
                _navigator.Navigate(MainJsonBuilder);
            };

            _sifJsonService = new SifJsonParser();

            if (args is { Length: > 0 })
            {
                string filePath = args[0];
                NavigateToSelectedFile(filePath);
            }

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"SIF Utils";
            if (version != null)
            {
                this.Text += $" v{version.Major}.{version.Minor}";
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        public async void NavigateToSelectedFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MainFileParsingError.SetData("File is not seen by the program.", "");
                _navigator.Navigate(MainFileParsingError);
                return;
            }

            if (!filePath.EndsWith(".json"))
            {
                MainFileParsingError.SetData("The specified file is not a JSON file.", "");
                _navigator.Navigate(MainFileParsingError);
                return;
            }

            var result = await MainJsonViewer.ProcessFile(filePath);

            if (result.Item1)
            {
                _navigator.Navigate(MainJsonViewer);
            }
            else
            {
                MainFileParsingError.SetData(result.Item2, await GetFileContext(filePath));
                _navigator.Navigate(MainFileParsingError);
            }
        }

        public void SifJsonParsingForm_Load(object sender, EventArgs e)
        {
            _navigator.Navigate(MainSelectFilePanel);
        }

        private async Task<SifJsonParsingResult> PrepareFile(string file)
        {
            using var _ = new LongOperationState();
            var result = await _sifJsonService.Parse(file);

            if (result.HasError)
            {
                Context.LastResult = null;
                return result;
            }

            Context.LastResult = result;

            return result;
        }

        public void NavigateBack() => _navigator.GoBack();

        private void back_Click(object sender, EventArgs e)
        {
            _navigator.GoBack();
        }

        private void executeToolStripMenuItem_Click(object sender, ResultEventArgs<(bool Uninstall, SifJsonTaskModel[] Tasks, SifJsonParsingResult Json)> e)
        {
            if (e.Result.Json.Parameters.Count > 0)
            {
                MainScriptRunnerForm.LoadForm(e.Result.Json, e.Result.Tasks.Select(x => x.Name).ToArray(), e.Result.Uninstall);
                _navigator.Navigate(MainScriptRunnerForm);
            }
            else
            {
                MainChooseExportFormat.SetCurrentSifResult(e.Result.Json);
                MainChooseExportFormat.SetUninstallChecked(e.Result.Uninstall);
                MainChooseExportFormat.ShowTasksForScript(e.Result.Tasks.Select(x => x.Name).ToArray());
                _navigator.Navigate(MainChooseExportFormat, () => MainChooseExportFormat.GenerateExportScript());
            }
        }

        private void MainJsonViewer_OnPlay(object sender, ResultEventArgs<SifJsonParsingResult> e)
        {
            NavigateToScriptOrExport(e.Result);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData is (Keys.Control | Keys.W))
            {
                Application.Exit();
                return true;
            }

            if (keyData is (Keys.Alt | Keys.Left))
            {
                _navigator.GoBack();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void MainScriptRunnerForm_ExecuteClicked(object? sender, ResultEventArgs<(SifJsonParsingResult Json, ParameterEditModel[] Parameters, string[] Tasks, bool Uninstall)> e)
        {
            MainChooseExportFormat.SetCurrentSifResult(e.Result.Json);
            MainChooseExportFormat.SetUninstallChecked(e.Result.Uninstall);
            MainChooseExportFormat.ShowTasksForScript(e.Result.Tasks);
            MainChooseExportFormat.SetCurrentParameters(e.Result.Parameters);
            _navigator.Navigate(MainChooseExportFormat, () => MainChooseExportFormat.GenerateExportScript());
        }

        private async void MainScriptRunnerForm_RefreshClicked(object sender, ResultEventArgs<string> e)
        {
            var parseResult = await PrepareFile(e.Result);
            if (parseResult.HasError)
            {
                MainFileParsingError.SetData(parseResult.Error!, await GetFileContext(e.Result));
                _navigator.Navigate(MainFileParsingError);
                return;
            }

            MainJsonViewer.ProcessResult(parseResult);
            MainScriptRunnerForm.LoadForm(parseResult);
        }

        private void MainChooseExportFormat_OnHome(object sender, EventArgs e)
        {
            _navigator.GoHome(MainSelectFilePanel);
        }

        private async Task<string> GetFileContext(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return "File not found.";
            }

            var file = new FileInfo(filePath);
            return file.Length > 3_000_000
                ? "The file is too large to be displayed in the viewer."
                : await file.OpenText().ReadToEndAsync();
        }

        private void MainSelectFilePanel_OpenViewFileDialog(object sender, EventArgs e)
        {
            _afterFileSelected = NavigateToViewer;
            _navigator.Navigate(MainChooseFileForm, () => MainChooseFileForm.UpdateRecentFiles());
        }

        private void MainSelectFilePanel_OpenExecuteFileDialog(object sender, EventArgs e)
        {
            _afterFileSelected = NavigateToScriptOrExport;
            _navigator.Navigate(MainChooseFileForm, () => MainChooseFileForm.UpdateRecentFiles());
        }

        private void MainSelectFilePanel_OpenJsonBuilder(object sender, EventArgs e)
        {
            _navigator.Navigate(MainJsonBuilder);
        }

        private async void MainChooseFileForm_FileSelected(object sender, ResultEventArgs<SifJsonParsingResult> e)
        {
            _navigator.GoBack();
            if (e.Result.HasError)
            {
                MainFileParsingError.SetData(e.Result.Error!, await GetFileContext(e.Result.FilePath));
                _navigator.Navigate(MainFileParsingError);
                return;
            }
            _afterFileSelected?.Invoke(e.Result);
            _afterFileSelected = null;
        }

        private void NavigateToViewer(SifJsonParsingResult result)
        {
            MainJsonViewer.ProcessResult(result);
            _navigator.Navigate(MainJsonViewer);
        }

        private void NavigateToScriptOrExport(SifJsonParsingResult result)
        {
            if (result.Parameters.Count > 0)
            {
                MainScriptRunnerForm.LoadForm(result);
                _navigator.Navigate(MainScriptRunnerForm);
            }
            else
            {
                MainChooseExportFormat.SetCurrentSifResult(result);
                _navigator.Navigate(MainChooseExportFormat, () => MainChooseExportFormat.GenerateExportScript());
            }
        }
    }
}
