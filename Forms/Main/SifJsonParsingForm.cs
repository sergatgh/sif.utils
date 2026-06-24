namespace SIF.Utils
{
    using SIF.Utils.Forms.Common;
    using SIF.Utils.Forms.Learn;
    using SIF.Utils.Forms.Main;
    using SIF.Utils.Forms.SideNavigation;
    using SIF.Utils.Logic.JsonParser;
    using System.Windows.Forms;

    public partial class SifJsonParsingForm : Form
    {
        private Navigator _navigator = null!;
        private Action<SifJsonParsingResult>? _afterFileSelected;
        private NavMode _pendingNavMode;
        private bool _isOnHome;

        private enum NavMode { None, View, Script }

        public SifUtilsContext Context { get; } = new();

        private readonly SifJsonParser _sifJsonService;

        public SifJsonParsingForm(string[]? args)
        {
            DoubleBuffered = true;
            InitializeComponent();
            SideNav.BringToFront();

            _navigator = new Navigator([
                MainSelectFilePanel, MainChooseFileForm, MainJsonViewer,
                MainScriptRunnerForm, MainChooseExportFormat, MainFileParsingError, MainJsonBuilder,
            ]);

            _navigator.PageChanged += OnPageChanged;

            SideNav.AnchorStateChanged += OnAnchorStateChanged;
            SideNav.HomeClicked       += (_, _) => _navigator.GoHome(MainSelectFilePanel);
            SideNav.ViewJsonClicked   += (_, _) =>
            {
                NavigateToViewFileWorkflow();
            };
            SideNav.RunScriptClicked  += (_, _) =>
            {
                NavigateToScriptWorkflow();
            };
            SideNav.SifBuilderClicked += (_, _) =>
            {
                _navigator.RestartFrom(MainSelectFilePanel);
                _navigator.Navigate(MainJsonBuilder);
            };
            SideNav.LearnSifClicked   += (_, _) => new LearnSIF().ShowDialog();
            SideNav.AboutClicked      += (_, _) => new AboutWindow().ShowDialog();

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

        private void OnAnchorStateChanged(object? sender, bool isAnchored)
        {
            if (!_isOnHome)
                _contentArea.Padding = new Padding(isAnchored ? 210 : 50, 0, 0, 0);
        }

        private void OnPageChanged(object? sender, Control page)
        {
            bool onHome = page == MainSelectFilePanel;
            _isOnHome = onHome;
            SideNav.SetHomePage(onHome);
            _contentArea.Padding = new Padding(onHome || !SideNav.IsAnchored ? 50 : 210, 0, 0, 0);

            int idx = page == MainSelectFilePanel   ? 0
                    : page == MainJsonViewer        ? 1
                    : page == MainScriptRunnerForm  ? 2
                    : page == MainChooseExportFormat? 2
                    : page == MainJsonBuilder       ? 3
                    : page == MainChooseFileForm    ? (_pendingNavMode == NavMode.Script ? 2 : 1)
                    : -1;
            SideNav.SetSelectedIndex(idx);
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
            NavigateToViewFileWorkflow();
        }

        private void NavigateToViewFileWorkflow()
        {
            _pendingNavMode = NavMode.View;
            _afterFileSelected = NavigateToViewer;
            MainChooseFileForm.AllowRawJson = true;
            MainChooseFileForm.AllowUrl = true;
            MainChooseFileForm.UpdateInstructionLabel();
            _navigator.RestartFrom(MainSelectFilePanel);
            _navigator.Navigate(MainChooseFileForm, () => MainChooseFileForm.UpdateRecentFiles());
            MainChooseFileForm.UpdateDescription("Select a SIF JSON file to view its contents.");
        }

        private void MainSelectFilePanel_OpenExecuteFileDialog(object sender, EventArgs e)
        {
            NavigateToScriptWorkflow();
        }

        private void NavigateToScriptWorkflow()
        {
            _pendingNavMode = NavMode.Script;
            _afterFileSelected = NavigateToScriptOrExport;
            MainChooseFileForm.AllowRawJson = false;
            MainChooseFileForm.AllowUrl = false;
            MainChooseFileForm.UpdateInstructionLabel();
            _navigator.RestartFrom(MainSelectFilePanel);
            _navigator.Navigate(MainChooseFileForm, () => MainChooseFileForm.UpdateRecentFiles());
            MainChooseFileForm.UpdateDescription("Select a SIF JSON file to execute the script or generate an export script.");
        }

        private void MainSelectFilePanel_OpenJsonBuilder(object sender, EventArgs e)
        {
            _navigator.Navigate(MainJsonBuilder);
        }

        private async void MainChooseFileForm_FileSelected(object sender, ResultEventArgs<SifJsonParsingResult> e)
        {
            _navigator.DropCurrent();
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
