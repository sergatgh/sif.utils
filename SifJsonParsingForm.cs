namespace SIF.Utils
{
    using SIF.Utils.Forms.Common;
    using SIF.Utils.JsonParser;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public enum SifJsonParsingFormState
    {
        None,
        Initial,
        FileSelected,
        SetPropertiesForNewPsScript,
        ChooseFormat,
        ErrorText,
        JsonBuilder,
    }

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
                if (File.Exists(filePath) && filePath.EndsWith(".json"))
                {
                    MainJsonViewer.ProcessFile(openFileForViewerDialog.FileName).Wait();
                    _presenter.UpdateView(SifJsonParsingFormState.FileSelected);
                }
                else
                {
                    MessageBox.Show($"The specified file '{filePath}' must be a valid JSON.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void NavigateBack()
        {
            _presenter.GoBack();
        }

        public void SifJsonParsingForm_Load(object sender, EventArgs e)
        {
            _presenter.UpdateView(SifJsonParsingFormState.Initial);
        }

        private async Task PrepareFile(string file)
        {
            Cursor.Current = Cursors.WaitCursor;
            var result = await _sifJsonService.ParseJson(file);

            if (result.HasError)
            {
                Context.LastResult = null;
                errorDescription.Text = result.Error;
                documentText.Text = await File.ReadAllTextAsync(file);
                _presenter.UpdateView(SifJsonParsingFormState.ErrorText);
                return;
            }

            Context.LastResult = result;

            Cursor.Current = Cursors.Default;
        }

        private void backFromPsCreation_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
        }

        private async void openFileDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            await MainJsonViewer.ProcessFile(openFileForViewerDialog.FileName);
            _presenter.UpdateView(SifJsonParsingFormState.FileSelected);
        }

        private void backFromPropertiesButton_Click(object sender, EventArgs e)
        {
            Context.TasksToExecute = [];
            Context.ExecuteInUninstallMode = false;
            _presenter.GoBack();
        }

        private void singleDeveloperOption_Click(object sender, EventArgs e)
        {
            _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
        }

        private async void customFileOpenDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            await PrepareFile(openFileForViewerDialog.FileName);

            _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            _presenter.GoHome();
        }

        private void copyToClipboardProperties_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(scriptToExport.Text);
        }

        private void backFromExport_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
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

        private void errorActionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.GenerateExportScript();
        }

        private void includeUninstallOption_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.ShowTasksForScript();
            _presenter.GenerateExportScript();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            executeInShell.Enabled = inlineParametersOption.Checked;
            _presenter.GenerateExportScript();
        }

        private void executeScriptInPowershell_Click(object sender, EventArgs e)
        {
            var text = scriptToExport.Text;
            if (string.IsNullOrWhiteSpace(text)) return;

            var directory = Context.LastResult?.Folder;
            var cdCommand = $"cd \\\"{directory}\\\"";

            var argument = $" -NoExit -Command \"{cdCommand};{text.Replace("\"", "\\\"")}\"";
            System.Diagnostics.Process.Start("powershell.exe", argument);
        }

        private void verboseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presenter.GenerateExportScript();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LearnSIF().ShowDialog();
        }

        private void executeToolStripMenuItem_Click(object sender, ResultEventArgs<(bool, string[])> e)
        {
            Context.ExecuteInUninstallMode = e.Result.Item1;
            Context.TasksToExecute = e.Result.Item2;
            _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _presenter.UpdateView(SifJsonParsingFormState.JsonBuilder);
        }

        private void MainJsonViewer_OnPlay(object sender, SIF.Utils.Forms.Common.ResultEventArgs<SIF.Utils.JsonParser.SifJsonParsingResult> e)
        {
            Context.LastResult = e.Result;
            _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is the Left arrow key AND the Alt key is held down
            if (e is { KeyCode: Keys.Left, Alt: true })
            {
                // Prevent the default system action for Alt+Left (usually GoBack)
                e.Handled = true;
                e.SuppressKeyPress = true; // Stops the key from being processed further

                // Trigger the click event of your specific button
                // Replace "myButton" with the actual name of your button
                _presenter.GoBack();

                Trace.WriteLine("Back");
            }
        }

        private void MainScriptRunnerForm_ExecuteClicked(object sender, SIF.Utils.Forms.Common.ResultEventArgs<SIF.Utils.ParameterEditModel[]> e)
        {
            Context.ParametersToEdit = e.Result;
            _presenter.UpdateView(SifJsonParsingFormState.ChooseFormat);
        }

        private async void MainScriptRunnerForm_RefreshClicked(object sender, EventArgs e)
        {
            await PrepareFile(openFileForViewerDialog.FileName);
            if (Context.LastResult == null) return;

            MainJsonViewer.ProcessResult(Context.LastResult);
            MainScriptRunnerForm.ShowProperties(Context.LastResult.Parameters);
        }
    }

    public class SifJsonService
    {
        public Task<SifJsonParsingResult> ParseJson(string? fileName = null)
        {
            return fileName == null
                ? Task.FromResult(new SifJsonParsingResult { Error = "File is not specified" })
                : new SifJsonParser().Parse(fileName);
        }
    }

    public class SifJsonParsingFormPresenter(SifJsonParsingForm view)
    {
        private readonly ResultToListItemsConverter _converter = new();
        private readonly Stack<SifJsonParsingFormState> _stateStack = new();

        public SifJsonParsingFormState CurrentState => _stateStack.Any() ? _stateStack.Peek() : SifJsonParsingFormState.None;

        public void UpdateView(SifJsonParsingFormState state)
        {
            ShowState(state);

            if (state != CurrentState) _stateStack.Push(state);
        }

        public void GoHome()
        {
            _stateStack.Clear();
            UpdateView(SifJsonParsingFormState.Initial);
        }

        protected void ShowState(SifJsonParsingFormState state, bool back = false)
        {
            HideAllPanels();

            switch (state)
            {
                case SifJsonParsingFormState.Initial:
                    view.MainSelectFilePanel.Visible = true;
                    break;

                case SifJsonParsingFormState.FileSelected:
                    view.MainJsonViewer.Visible = true;
                    break;

                case SifJsonParsingFormState.SetPropertiesForNewPsScript:
                    if (view.Context.LastResult?.Parameters.Count > 0)
                    {
                        if (!back) view.MainScriptRunnerForm.ShowProperties(view.Context.LastResult.Parameters);
                        view.MainScriptRunnerForm.Visible = true;
                    }
                    else
                    {
                        UpdateView(SifJsonParsingFormState.ChooseFormat);
                    }

                    break;

                case SifJsonParsingFormState.ChooseFormat:
                    ShowNavigation("Choose export option", true);
                    view.MainChooseExportFormat.Visible = true;
                    view.includeUninstallOption.Checked = view.Context.ExecuteInUninstallMode;
                    view.includeVerboseOption.Checked = false;
                    view.inlineParametersOption.Checked = true;
                    view.errorActionDropdown.SelectedItem = null;
                    ShowTasksForScript();
                    GenerateExportScript();
                    break;

                case SifJsonParsingFormState.ErrorText:
                    view.MainFileParsingError.Visible = true;
                    break;

                case SifJsonParsingFormState.JsonBuilder:
                    view.MainJsonBuilder.Visible = true;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }

        public void GoBack()
        {
            if (_stateStack.Count <= 1) return;
            // Pop current state
            _stateStack.Pop();
            // Get previous state
            var previousState = _stateStack.Peek();
            ShowState(previousState, true);
        }

        public void HideAllPanels()
        {
            view.Controls.OfType<Control>().Where(x => x.Name.StartsWith("Main")).ToList().ForEach(panel => panel.Visible = false);
        }

        public void GenerateExportScript()
        {
            var options = new PsScriptSerializerOptions
            {
                Path = view.Context.LastResult?.FilePath ?? "",
                Uninstall = view.includeUninstallOption.Checked,
                Verbose = view.includeVerboseOption.Checked,
                ErrorAction = view.errorActionDropdown.SelectedItem?.ToString(),
                Inline = view.inlineParametersOption.Checked,
                IncludeTasks = view.tasksToolStripMenuItem.DropDownItems
                    .Cast<ToolStripMenuItem>()
                    .Where(item => item.Checked)
                    .Select(item => item.Text)
                    .ToArray()!,
            };

            var parameterEditModels = view.Context.ParametersToEdit;

            var text = new PsScriptSerializer().SerializeToString(parameterEditModels, options);

            view.scriptToExport.Text = text;
        }

        public void ShowNavigation(string title, bool showHome = false)
        {
            view.navigationLabel.Text = title;
            view.homeNavigationButton.Visible = showHome;
        }

        public void ShowTasksForScript()
        {
            view.tasksToolStripMenuItem.DropDownItems.Clear();

            var tasks =
                view.includeUninstallOption.Checked ?
                view.Context.LastResult?.UninstallTasks ?? [] :
                view.Context.LastResult?.Tasks ?? [];

            view.tasksToolStripMenuItem.DropDownItems.AddRange(
                tasks.Select(task =>
                {
                    var item = new ToolStripMenuItem(task.Name);
                    item.CheckOnClick = true;
                    item.Checked = view.Context.TasksToExecute?.Contains(task.Name) ?? false;
                    item.CheckStateChanged += (_, _) =>
                    {
                        GenerateExportScript();
                    };
                    return item;
                }).ToArray<ToolStripItem>()
            );
        }

        public void ShowJson(SifBaseProperties element)
        {
            var detailsForm = new JsonViewer(element.Name, element.Element.Value);
            detailsForm.ShowDialog();
        }

    }

    public class ResultToListItemsConverter
    {
        public void ResultToListView(SifJsonParsingResult result, ListView listView)
        {
            listView.Items.Clear();
            if (result.HasError)
            {
                var errorItem = new ListViewItem("Error: " + (result.Error ?? "Unknown error"));
                listView.Items.Add(errorItem);
                return;
            }

            MakeGroup("tasks", result.Tasks, listView);
            MakeGroup("parameters", result.Parameters, listView);
        }

        public void MakeGroup(string name, IEnumerable<SifBaseProperties> props, ListView listView)
        {
            var listViewGroup = GetOrCreateGroup(name, listView);

            var items = GetGroupItems(props);

            items.ForEach(x => x.Group = listViewGroup);
            listViewGroup.Footer = "Total: " + items.Count;

            listView.Items.AddRange(items.ToArray());
        }

        public ListViewGroup GetOrCreateGroup(string name, ListView listView)
        {
            var group = listView.Groups[name + "Group"];
            if (group is not null) return group;

            var title = name[0].ToString().ToUpper() + name[1..].ToLower();
            group = new ListViewGroup(name + "Group", title);
            listView.Groups.Add(group);

            return group;
        }

        public List<ListViewItem> GetGroupItems(IEnumerable<SifBaseProperties> props)
        {
            return props.Select(task => new ListViewItem([task.Name, task.Description])).ToList();
        }
    }
}
