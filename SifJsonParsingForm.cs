namespace SIF.Utils
{
    using SIF.Utils.JsonParser;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public enum SifJsonParsingFormState
    {
        None,
        Initial,
        FileSelected,
        CreatePowerShellScript,
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
            var grid = (DataGridView)sender;
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
            saveParametersDialog.ShowDialog();
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

        private async void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var filePath = saveParametersDialog.FileName;
            await File.WriteAllTextAsync(filePath, scriptToExport.Text);
            MessageBox.Show(
                $"PowerShell script '{filePath}' has been created.", "Script Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void downloadTheValues_Click(object sender, EventArgs e)
        {
            var result = openSavedValues.ShowDialog();
            if (result != DialogResult.OK) return;

            var filePath = openSavedValues.FileName;
            var text = File.ReadLinesAsync(filePath);
            await foreach (var line in text)
            {
                var parts = line.Split('=', 2);
                if (parts.Length != 2) continue;
                var paramName = parts[0].Trim();
                var paramValue = parts[1].Trim();

                var row = propsTableForScript.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(p => p != null && paramName.Equals(p.Cells["nameDataGridViewTextBoxColumn"].Value?.ToString(), StringComparison.OrdinalIgnoreCase));

                if (row != null) row.Cells["Value"].Value = paramValue;
            }

        }

        private void reloadPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sifJsonService.ParseJson().ContinueWith(
                result =>
                {
                    var r = result.Result;
                    Invoke(() =>
                    {
                        Context.LastResult = r;
                        _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
                    });
                }
            );
        }

        private void propsTableForScript_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == propsTableForScript.Columns["RowAction"]?.Index)
            {
                var row = propsTableForScript.Rows[e.RowIndex];
                var model = (ParameterEditModel)row.DataBoundItem!;
                Context.CurrentEditingParameter = model;

                callActionContextMenu.Show(Cursor.Position);
            }
        }

        private void exportParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = saveParametersDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            var filePath = saveParametersDialog.FileName;

            using var writer = new StreamWriter(filePath);
            var parameterEditModels = Context.ParametersToEdit;
            foreach (var param in parameterEditModels)
            {
                if (param.Value == param.DefaultValue) continue;

                writer.WriteLine($"{param.Name}={param.Value}");
            }
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

        private void TasksContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var menu = sender as ContextMenuStrip;

            if (menu == null)
            {
                e.Cancel = true;
                return;
            }

            var list = menu.SourceControl as ListView;
            if (list == null)
            {
                e.Cancel = true;
                return;
            }

            if (list.SelectedItems.Count == 1)
            {
                viewToolStripMenuItem.Visible = true;
                copyToolStripMenuItem.Visible = true;
            }
            else
            {
                viewToolStripMenuItem.Visible = false;
                copyToolStripMenuItem.Visible = false;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var menu = menuItem?.Owner as ContextMenuStrip;
            var list = menu?.SourceControl as ListView;

            if (list == null || list.SelectedItems.Count != 1) return;

            var item = list.SelectedItems[0];
            var taskName = item.Text;

            var task =
                list?.Tag?.ToString() == "Tasks" ?
                    Context.LastResult?.Tasks.FirstOrDefault(t => t.Name == taskName) :
                    list?.Tag?.ToString() == "UninstallTasks" ?
                        Context.LastResult?.UninstallTasks.FirstOrDefault(t => t.Name == taskName) :
                        null;

            if (task == null) return;

            _presenter.ShowJson(task);
        }

        private void copyTaskName_Click(object sender, EventArgs e)
        {
            var menuItem = (sender as ToolStripMenuItem)?.Owner as ToolStripDropDownMenu;
            var menu = (menuItem?.OwnerItem)?.Owner as ContextMenuStrip;
            var list = menu?.SourceControl as ListView;

            if (list == null || list.SelectedItems.Count != 1) return;

            var item = list.SelectedItems[0];
            var taskName = item.Text;
            Clipboard.SetText(taskName);
        }

        private void copyTaskDescription_Click(object sender, EventArgs e)
        {

            var menuItem = (sender as ToolStripMenuItem)?.Owner as ToolStripDropDownMenu;
            var menu = (menuItem?.OwnerItem)?.Owner as ContextMenuStrip;
            var list = menu?.SourceControl as ListView;

            if (list == null || list.SelectedItems.Count != 1) return;

            var item = list.SelectedItems[0];
            var description = item.SubItems[1];
            Clipboard.SetText(description.Text);
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var menu = menuItem?.Owner as ContextMenuStrip;
            var list = menu?.SourceControl as ListView;

            if (list == null) return;

            Context.ExecuteInUninstallMode = list.Tag?.ToString() == "UninstallTasks";
            Context.TasksToExecute = list.SelectedItems.Cast<ListViewItem>().Select(x => x.Text).ToArray();
            _presenter.UpdateView(SifJsonParsingFormState.SetPropertiesForNewPsScript);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _presenter.FilterPropertiesForScript();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            _presenter.FilterPropertiesForScript();
        }

        private void insertPathToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Context.CurrentEditingParameter == null) return;

            var result = chooseFolder.ShowDialog();

            if (result != DialogResult.OK) return;

            Context.CurrentEditingParameter.Value = chooseFolder.SelectedPath;
            propsTableForScript.Refresh();
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Context.CurrentEditingParameter == null) return;

            Context.CurrentEditingParameter.ResetToDefault();
            propsTableForScript.Refresh();
        }

        private void insertFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Context.CurrentEditingParameter == null) return;

            var result = chooseFile.ShowDialog();

            if (result != DialogResult.OK) return;

            Context.CurrentEditingParameter.Value = chooseFile.FileName;
            propsTableForScript.Refresh();
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

        public void ShowProperties()
        {
            view.propsTableForScript.DataSource = view.Context.ParametersToEdit = view.Context.LastResult?.Parameters.Select(ParameterEditModel.FromSifJsonParameterModel)
                .OrderBy(x => x.IsReference)
                .ThenBy(x => x.HasDefaultValue)
                .ThenBy(x => x.HasValidation)
                .ToArray() ?? [];
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

        public void FilterPropertiesForScript()
        {
            var filtered = string.IsNullOrWhiteSpace(view.textBox2.Text)
                ? view.Context.ParametersToEdit
                : view.Context.ParametersToEdit
                    .Where(p => p.Name.Contains(view.textBox2.Text, StringComparison.OrdinalIgnoreCase))
                    .ToArray();

            filtered = view.checkBox1.Checked
                ? filtered
                : filtered.Where(p => !p.IsReference).ToArray();

            view.propsTableForScript.DataSource = filtered;
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
