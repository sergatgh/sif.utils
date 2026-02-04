namespace SIF.Utils
{
    using SIF.Utils.Forms.Common;
    using SIF.Utils.Forms.Main;
    using SIF.Utils.JsonParser;
    using System.Diagnostics;
    using System.Windows.Forms;

    public partial class SifJsonParsingForm : Form
    {
        private readonly SifJsonParsingFormPresenter _presenter;
        public SifUtilsContext Context { get; } = new();

        private readonly SifJsonService _sifJsonService;

        public SifJsonParsingForm(string[]? args)
        {
            InitializeComponent();
            _presenter = new SifJsonParsingFormPresenter(this);
            _sifJsonService = new SifJsonService();

            if (args is { Length: > 0 })
            {
                string filePath = args[0];
                NavigateToFileSelection(filePath);
            }

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"SIF Utils v{version.Major}.{version.Minor}";
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        public async void NavigateToFileSelection(string filePath)
        {
            if (File.Exists(filePath) && filePath.EndsWith(".json"))
            {
                var result = await MainJsonViewer.ProcessFile(filePath);

                if (result.Item1)
                {
                    _presenter.UpdateView(MainViewPageType.FileSelected);
                }
                else
                {
                    MainFileParsingError.SetData(result.Item2, await GetContext(filePath));
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
            var result = await _sifJsonService.ParseJson(file);

            if (result.HasError)
            {
                Context.LastResult = null;
                return result;
            }

            Context.LastResult = result;

            return result;
        }

        private async void openFileDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            var processFileResult = await MainJsonViewer.ProcessFile(openFileForViewerDialog.FileName);

            if (processFileResult.Item1)
            {
                _presenter.UpdateView(MainViewPageType.FileSelected);
            }
            else
            {
                MainFileParsingError.SetData(processFileResult.Item2, await GetContext(openFileForViewerDialog.FileName));
                _presenter.UpdateView(MainViewPageType.ErrorText);
            }
        }

        private async void customFileOpenDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            var parseResult = await PrepareFile(openFileForViewerDialog.FileName);

            if (!parseResult.HasError)
            {
                if (parseResult.Parameters.Count > 0)
                {
                    MainScriptRunnerForm.LoadForm(parseResult);
                    _presenter.UpdateView(MainViewPageType.SetPropertiesForNewPsScript);
                }
                else
                {
                    MainChooseExportFormat.SetCurrentSifResult(parseResult);
                    _presenter.UpdateView(MainViewPageType.ChooseFormat);
                }
            }
            else
            {
                MainFileParsingError.SetData(parseResult.Error!, await GetContext(openFileForViewerDialog.FileName));
                _presenter.UpdateView(MainViewPageType.ErrorText);
            }
        }

        private void labelButton_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label label) label.ForeColor = SystemColors.Highlight;
        }

        private void labelButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label) label.ForeColor = SystemColors.ControlText;
        }

        private void back_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LearnSIF().ShowDialog();
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

        private void label1_Click(object sender, EventArgs e)
        {
            _presenter.UpdateView(MainViewPageType.JsonBuilder);
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is the Left arrow key AND the Alt key is held down
            if (e is not { KeyCode: Keys.Left, Alt: true }) return;

            // Prevent the default system action for Alt+Left (usually GoBack)
            e.Handled = true;
            e.SuppressKeyPress = true; // Stops the key from being processed further

            // Trigger the click event of your specific button
            // Replace "myButton" with the actual name of your button
            _presenter.GoBack();

            Trace.WriteLine("Back");
        }

        private void MainScriptRunnerForm_ExecuteClicked(object? sender, ResultEventArgs<(SifJsonParsingResult Json, ParameterEditModel[] Parameters, string[] Tasks, bool Uninstall)> e)
        {
            MainChooseExportFormat.SetCurrentSifResult(e.Result.Json);
            MainChooseExportFormat.SetUninstallChecked(e.Result.Uninstall);
            MainChooseExportFormat.ShowTasksForScript(e.Result.Tasks);
            MainChooseExportFormat.SetCurrentParameters(e.Result.Parameters);
            _presenter.UpdateView(MainViewPageType.ChooseFormat);
        }

        private async void MainScriptRunnerForm_RefreshClicked(object sender, EventArgs e)
        {
            var parseResult = await PrepareFile(openFileForViewerDialog.FileName);
            if (parseResult.HasError)
            {
                MainFileParsingError.SetData(parseResult.Error!, await GetContext(openFileForViewerDialog.FileName));
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

        private async Task<string> GetContext(string filePath)
        {
            var file = new FileInfo(filePath);
            return file.Length > 3_000_000
                ? "The file is too large to be displayed in the viewer."
                : await file.OpenText().ReadToEndAsync();
        }
    }
}
