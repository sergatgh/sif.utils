using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.Design.AxImporter;

namespace SIF.Utils
{
    public enum SifJsonParsingFormState
    {
        None,
        Initial,
        FileSelected,
        CreatePowerShellScript,
        SetPropertiesForNewPsScript,
        ChooseFormat,
        ErrorText,
    }

    public partial class SifJsonParsingForm : Form
    {
        private readonly SifJsonParsingFormPresenter _presenter;
        private readonly SifJsonParser _sifJsonParser = new();

        public SifUtilsContext Context { get; } = new SifUtilsContext();

        public SifJsonParsingForm()
        {
            InitializeComponent();
            _presenter = new SifJsonParsingFormPresenter(this);
        }

        public void SifJsonParsingForm_Load(object sender, EventArgs e)
        {
            _presenter.UpdateView(SifJsonParsingFormState.Initial);
        }

        private void OpenFileForViewerDialogFileForViewerOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Context.LastSelectedFile = openFileForViewerDialog.FileName;

            var parseTask = _sifJsonParser.Parse(Context.LastSelectedFile)
                .ContinueWith(task =>
                {
                    var result = task.Result;
                    Invoke(() =>
                    {
                        if (result.HasError)
                        {
                            errorDescription.Text = result.Error;
                            documentText.Text = File.ReadAllText(Context.LastSelectedFile!);
                            _presenter.UpdateView(SifJsonParsingFormState.ErrorText);
                        }

                        Context.LastResult = result;
                    });

                    return !result.HasError;
                });

            parseTask.ContinueWith(next =>
            {
                if (!next.Result) return;

                Invoke(() =>
                {
                    _presenter.UpdateView(Context.FileChooseMode == FileChooseMode.View ? SifJsonParsingFormState.FileSelected : SifJsonParsingFormState.SetPropertiesForNewPsScript);
                    Cursor.Current = Cursors.Default;
                    FilePathText.Text = Context.LastSelectedFile;
                });
            });
        }

        private void chooseAnotherJsonButton_Click(object sender, EventArgs e)
        {
            openFileForViewerDialog.ShowDialog();
        }

        private void backFromPsCreation_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
        }

        private void openFileDialog_Click(object sender, EventArgs e)
        {
            Context.FileChooseMode = FileChooseMode.View;
            openFileForViewerDialog.ShowDialog();
        }

        private void composePsScript_Click(object sender, EventArgs e)
        {
            _presenter.UpdateView(SifJsonParsingFormState.CreatePowerShellScript);
        }

        private void universalBackButton_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
        }

        private void singleDeveloperOption_Click(object sender, EventArgs e)
        {
            _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
        }

        private void customFileOpenDialog_Click(object sender, EventArgs e)
        {
            Context.FileChooseMode = FileChooseMode.Script;
            openFileForViewerDialog.ShowDialog();
        }

        private void finishSettingProperties_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;
            propsTableForScript.EndEdit();
            for (var i = 0; i < propsTableForScript.Rows.Count; i++)
            {
                var error = ((ParameterEditModel)propsTableForScript.Rows[i].DataBoundItem).GetErrorText();
                if (error.Length != 0)
                {
                    propsTableForScript["Value", i].ErrorText = error;
                    hasErrors = true;
                }
            }

            if (hasErrors) return;

            _presenter.UpdateView(SifJsonParsingFormState.ChooseFormat);
        }

        private void propsTableForScript_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var grid = ((DataGridView)sender);
            if (grid.DataSource is not List<ParameterEditModel> list)
            {
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= list.Count)
            {
                return;
            }

            if (grid.Columns[e.ColumnIndex].DataPropertyName != "Value")
            {
                return;
            }

            var error = ((ParameterEditModel)grid.Rows[e.RowIndex].DataBoundItem).GetErrorText(e.FormattedValue?.ToString());
            grid[e.ColumnIndex, e.RowIndex].ErrorText = error;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            _presenter.GoHome();
        }

        private async void exportToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
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

        private void executeJson_Click(object sender, EventArgs e)
        {
            _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
        }

        private void openContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = Context.LastSelectedFile;
            if (string.IsNullOrWhiteSpace(filePath)) return;
            var argument = "/select, \"" + filePath + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
        }

        private void errorActionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.GenerateExportScript();
        }

        private void includeUninstallOption_CheckedChanged(object sender, EventArgs e)
        {
            if (includeUninstallOption.Checked)
            {
                _presenter.ShowUninstallTasksForScript();
            }
            else
            {
                _presenter.ShowTasksForScript();
            }

            _presenter.GenerateExportScript();
        }

        private void includeUpdateOption_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.GenerateExportScript();
        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            _presenter.FilterTasks(filterText.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            executeInShell.Enabled = inlineParametersOption.Checked;
            _presenter.GenerateExportScript();
        }

        private void includeTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.Delay(100).ContinueWith(x =>
            {
                Invoke(() =>
                {
                    _presenter.GenerateExportScript();
                });
            });
        }

        private void executeScriptInPowershell_Click(object sender, EventArgs e)
        {
            var text = scriptToExport.Text;
            if (string.IsNullOrWhiteSpace(text)) return;

            var argument = $" -NoExit -Command \"{text}\"";
            System.Diagnostics.Process.Start("powershell.exe", argument);
        }

        private async void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var filePath = saveFileDialog1.FileName;
            await File.WriteAllTextAsync(filePath, scriptToExport.Text);
            MessageBox.Show(
                $"PowerShell script '{filePath}' has been created.", "Script Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ClearAllTabs();
                    view.MainSelectFilePanel.Visible = true;
                    break;

                case SifJsonParsingFormState.FileSelected:
                    ClearAllTabs();
                    ShowParsingResult();
                    view.MainJsonActionsPanel.Visible = true;
                    break;

                case SifJsonParsingFormState.CreatePowerShellScript:
                    ShowNavigation("Choose export option", true);
                    view.MainCreatePowershell.Visible = true;
                    break;

                case SifJsonParsingFormState.SetPropertiesForNewPsScript:
                    if (!back) ShowProperties();
                    view.MainChooseProperties.Visible = true;
                    break;

                case SifJsonParsingFormState.ChooseFormat:
                    ShowNavigation("Choose export option", true);
                    view.MainChooseExportFormat.Visible = true;
                    view.includeTasks.ClearSelected();
                    GenerateExportScript();
                    ShowTasksForScript();
                    break;

                case SifJsonParsingFormState.ErrorText:
                    view.MainFileParsingError.Visible = true;
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

        public void ShowParsingResult()
        {
            var result = view.Context.LastResult!;
            view.filterText.Clear();
            view.tasksViewer.Items.AddRange(_converter.GetGroupItems(result.Tasks).ToArray());
            view.uninstallTasksList.Items.AddRange(_converter.GetGroupItems(result.UninstallTasks).ToArray());
            view.parametersList.Items.AddRange(_converter.GetGroupItems(result.Parameters).ToArray());
            view.variablesList.Items.AddRange(result.Variables.Select(variable => new ListViewItem([variable.Name, variable.Value])).ToArray());
            view.includesList.Items.AddRange(result.Includes.Select(include => new ListViewItem([include.Name, include.Source])).ToArray());
            view.modulesList.Items.AddRange(result.Modules.Select(module => new ListViewItem(module.Path)).ToArray());
        }

        public void FilterTasks(string text)
        {
            var filterText = text.Trim().ToLower();

            view.tasksViewer.Items.Clear();
            var tasks = string.IsNullOrWhiteSpace(filterText)
                ? view.Context.LastResult?.Tasks ?? []
                : view.Context.LastResult?.Tasks.Where(x =>
                    x.Name.ToLower().Contains(filterText) ||
                    x.Description.ToLower().Contains(filterText)) ?? [];

            var listItems = _converter.GetGroupItems(
                tasks
            ).ToArray();

            view.tasksViewer.Items.AddRange(listItems);

        }

        public void HideAllPanels()
        {
            view.Controls.OfType<Panel>().Where(x => x.Name.StartsWith("Main")).ToList().ForEach(panel => panel.Visible = false);
        }

        public void ShowProperties()
        {
            view.propsTableForScript.DataSource = view.Context.LastResult?.Parameters.Select(ParameterEditModel.FromSifJsonParameterModel)
                .OrderBy(x => x.IsReference)
                .ThenBy(x => x.HasDefaultValue)
                .ThenBy(x => x.HasValidation)
                .ToList();
        }

        public void GenerateExportScript()
        {
            var options = new PsScriptSerializerOptions
            {
                Path = view.Context.LastSelectedFile ?? "",
                Uninstall = view.includeUninstallOption.Checked,
                ErrorAction = view.errorActionDropdown.SelectedItem?.ToString(),
                Inline = view.inlineParametersOption.Checked,
                IncludeTasks = view.includeTasks.CheckedItems.Cast<string>().ToArray(),
            };

            var parameterEditModels = (List<ParameterEditModel>)view.propsTableForScript.DataSource;

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
            view.includeTasks.Items.Clear();
            var tasks = view.Context.LastResult?.Tasks ?? [];
            view.includeTasks.Items.AddRange(
                tasks.Select(task => task.Name).ToArray<object>()
            );
        }

        public void ShowUninstallTasksForScript()
        {
            view.includeTasks.Items.Clear();
            var tasks = view.Context.LastResult?.UninstallTasks ?? [];
            view.includeTasks.Items.AddRange(
                tasks.Select(task => task.Name).ToArray<object>()
            );
        }

        public void ClearAllTabs()
        {
            view.parametersList.Items.Clear();
            view.variablesList.Items.Clear();
            view.uninstallTasksList.Items.Clear();
            view.includesList.Items.Clear();
            view.modulesList.Items.Clear();
            view.tasksViewer.Items.Clear();
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
