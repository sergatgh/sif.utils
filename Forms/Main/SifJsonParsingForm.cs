namespace SIF.Utils
{
    using SIF.Utils.Forms.Common;
    using SIF.Utils.Forms.Main;
    using SIF.Utils.Logic.JsonParser;
    using System.Windows.Forms;

    public partial class SifJsonParsingForm : Form
    {
        private readonly SifJsonParsingFormPresenter _presenter;
        public SifUtilsContext Context { get; } = new();

        private readonly SifJsonParser _sifJsonService;

        private MainViewPageType nextPage = MainViewPageType.ViewFile;

        public SifJsonParsingForm(string[]? args)
        {
            InitializeComponent();
            _presenter = new SifJsonParsingFormPresenter(this);
            _sifJsonService = new SifJsonParser();

            if (args is { Length: > 0 })
            {
                string filePath = args[0];
                NavigateToSelectedFile(filePath);
            }

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"SIF Utils v{version.Major}.{version.Minor}";
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        public async void NavigateToSelectedFile(string filePath)
        {
            if (File.Exists(filePath) && filePath.EndsWith(".json"))
            {
                var result = await MainJsonViewer.ProcessFile(filePath);

                if (result.Item1)
                {
                    _presenter.UpdateView(MainViewPageType.ViewFile);
                }
                else
                {
                    MainFileParsingError.SetData(result.Item2, await GetFileContext(filePath));
                    _presenter.UpdateView(MainViewPageType.ErrorText);
                }
            }
            else
            {
                if (!File.Exists(filePath))
                {
                    MainFileParsingError.SetData("File is not seen by the program.", "");
                    _presenter.UpdateView(MainViewPageType.ErrorText);
                }
                else
                {
                    MainFileParsingError.SetData("The specified file is not a JSON file.", "");
                    _presenter.UpdateView(MainViewPageType.ErrorText);
                }
            }
        }

        public void NavigateBack()
        {
            _presenter.GoBack();
        }

        public void SifJsonParsingForm_Load(object sender, EventArgs e)
        {
            _presenter.UpdateView(MainViewPageType.Initial);
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

        private void back_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
        }

        private void executeToolStripMenuItem_Click(object sender, ResultEventArgs<(bool Uninstall, SifJsonTaskModel[] Tasks, SifJsonParsingResult Json)> e)
        {
            if (e.Result.Json.Parameters.Count > 0)
            {
                MainScriptRunnerForm.LoadForm(e.Result.Json, e.Result.Tasks.Select(x => x.Name).ToArray(), e.Result.Uninstall);
                _presenter.UpdateView(MainViewPageType.SetPropertiesForNewPsScript);
            }
            else
            {
                MainChooseExportFormat.SetCurrentSifResult(e.Result.Json);
                MainChooseExportFormat.SetUninstallChecked(e.Result.Uninstall);
                MainChooseExportFormat.ShowTasksForScript(e.Result.Tasks.Select(x => x.Name).ToArray());
                _presenter.UpdateView(MainViewPageType.ChooseFormat);
            }
        }

        private void MainJsonViewer_OnPlay(object sender, ResultEventArgs<SifJsonParsingResult> e)
        {
            if (e.Result.Parameters.Count > 0)
            {
                MainScriptRunnerForm.LoadForm(e.Result);
                _presenter.UpdateView(MainViewPageType.SetPropertiesForNewPsScript);
            }
            else
            {
                MainChooseExportFormat.SetCurrentSifResult(e.Result);
                _presenter.UpdateView(MainViewPageType.ChooseFormat);
            }
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
                _presenter.GoBack();
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
            _presenter.UpdateView(MainViewPageType.ChooseFormat);
        }

        private async void MainScriptRunnerForm_RefreshClicked(object sender, ResultEventArgs<string> e)
        {
            var parseResult = await PrepareFile(e.Result);
            if (parseResult.HasError)
            {
                MainFileParsingError.SetData(parseResult.Error!, await GetFileContext(e.Result));
                _presenter.UpdateView(MainViewPageType.ErrorText);
                return;
            }

            MainJsonViewer.ProcessResult(parseResult);
            MainScriptRunnerForm.LoadForm(parseResult);
        }

        private void MainChooseExportFormat_OnHome(object sender, EventArgs e)
        {
            _presenter.GoHome();
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
            nextPage = MainViewPageType.ViewFile;
            _presenter.UpdateView(MainViewPageType.ChooseFile);
        }

        private void MainSelectFilePanel_OpenExecuteFileDialog(object sender, EventArgs e)
        {
            nextPage = MainViewPageType.SetPropertiesForNewPsScript;
            _presenter.UpdateView(MainViewPageType.ChooseFile);
        }

        private void MainSelectFilePanel_OpenJsonBuilder(object sender, EventArgs e)
        {
            _presenter.UpdateView(MainViewPageType.JsonBuilder);
        }

        private async void MainChooseFileForm_FileSelected(object sender, ResultEventArgs<SifJsonParsingResult> e)
        {
            _presenter.GoBack();
            var processFileResult = e.Result;
            if (!processFileResult.HasError)
            {
                if (nextPage == MainViewPageType.SetPropertiesForNewPsScript)
                {
                    if (processFileResult.Parameters.Count > 0)
                    {
                        MainScriptRunnerForm.LoadForm(processFileResult);
                        _presenter.UpdateView(MainViewPageType.SetPropertiesForNewPsScript);
                    }
                    else
                    {
                        MainChooseExportFormat.SetCurrentSifResult(processFileResult);
                        _presenter.UpdateView(MainViewPageType.ChooseFormat);
                    }
                }
                else
                {
                    MainJsonViewer.ProcessResult(processFileResult);
                    _presenter.UpdateView(nextPage);
                }
            }
            else
            {
                MainFileParsingError.SetData(processFileResult.Error!, await GetFileContext(e.Result.FilePath));
                _presenter.UpdateView(MainViewPageType.ErrorText);
            }
        }
    }
}
