using SIF.Utils.Forms.Common;
using SIF.Utils.Forms.SelectFile;
using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;

namespace SIF.Utils.Forms.JsonViewer
{
    public partial class SifJsonViewerForm : UserControl
    {
        [Browsable(true)]
        public event ResultEventHandler<SifJsonParsingResult>? OnFileParsed;

        [Browsable(true)]
        public event ResultEventHandler<SifJsonParsingResult>? OnPlay;

        [Browsable(true)]
        public event ResultEventHandler<(bool Uninstall, SifJsonTaskModel[] Tasks, SifJsonParsingResult Json)>? OnExecuteTasks;

        [Browsable(true)]
        public event ResultEventHandler<SifJsonParsingResult>? OnOpenInBuilder;

        [Browsable(true)]
        public event EventHandler? BackClicked
        {
            add => navigationPanel.BackClicked += value;
            remove => navigationPanel.BackClicked -= value;
        }

        protected SifJsonParsingResult CurrentResult { get; set; } = SifJsonParsingResult.Empty;

        private bool _showEmptyTabs = true;
        private bool _showTabCounts = false;

        [Browsable(true)]
        [DefaultValue(true)]
        public bool ShowEmptyTabs
        {
            get => _showEmptyTabs;
            set
            {
                _showEmptyTabs = value;
                if (!ReferenceEquals(CurrentResult, SifJsonParsingResult.Empty))
                    UpdateTabs(CurrentResult);
            }
        }

        [Browsable(true)]
        [DefaultValue(false)]
        public bool ShowTabCounts
        {
            get => _showTabCounts;
            set
            {
                _showTabCounts = value;
                if (!ReferenceEquals(CurrentResult, SifJsonParsingResult.Empty))
                    UpdateTabs(CurrentResult);
            }
        }

        private record TabInfo(TabPage Page, string BaseText, Func<SifJsonParsingResult, int> CountGetter, string SectionKey = "", bool ShowCount = true);
        private readonly List<TabInfo> _orderedTabs = [];

        public SifJsonViewerForm()
        {
            DoubleBuffered = true;
            InitializeComponent();

            toolTip1.SetToolTip(changeFileButton, "Select another file");
            toolTip1.SetToolTip(openFolderButton, "Open folder containing this JSON file");
            toolTip1.SetToolTip(executeButton, "Execute this SIF file");
            toolTip1.SetToolTip(openInBuilderButton, "Open in Builder (alpha)");

            navigationPanel.controlsPanel.Controls.Add(executeButton);
            navigationPanel.controlsPanel.Controls.Add(changeFileButton);
            navigationPanel.controlsPanel.Controls.Add(openFolderButton);
            navigationPanel.controlsPanel.Controls.Add(openInBuilderButton);

            _orderedTabs.AddRange([
                new(viewJsonTasks, "Tasks", r => r.Tasks.Count, "Tasks"),
                new(viewJsonUninstallTasks, "UninstallTasks", r => r.UninstallTasks.Count, "UninstallTasks"),
                new(viewJsonParameters, "Parameters", r => r.Parameters.Count, "Parameters"),
                new(viewJsonVariables, "Variables", r => r.Variables.Count, "Variables"),
                new(viewJsonIncludes, "Includes", r => r.Includes.Count, "Includes"),
                new(viewJsonModules, "Modules", r => r.Modules.Count, "Modules"),
                new(viewJsonRegisteredTasks, "Registered Tasks", r => r.RegisteredTasks.Count, "Register"),
                new(viewJsonRegisteredConfigFunctions, "Registered Functions", r => r.RegisteredConfigFunctions.Count, "Register"),
                new(viewJsonSettings, "Settings", r => r.Settings != null ? 1 : 0, "Settings", false),
                new(viewJsonWarnings, "ℹ️ Parse Warnings", r => r.Warnings.Count),
            ]);
        }

        public void Clear()
        {
            CurrentResult = SifJsonParsingResult.Empty;

            parametersList.DataSource = null;
            variablesList.Items.Clear();
            uninstallTasksList.Clear();
            tasksList.Clear();
            includesList.Items.Clear();
            modulesList.Items.Clear();
            registeredTasksList.Items.Clear();
            registeredConfigFunctionsList.Items.Clear();
            RestoreAllTabs();
            viewJsonTabs.SelectTab(0);
            variablesFilter.Text = string.Empty;
            paramtersFilterText.Text = string.Empty;
            autoRegisterExtensionsCheck.Checked = false;
            infoActionText.TextInput = string.Empty;
            warnActionText.TextInput = string.Empty;
            errorActionText.TextInput = string.Empty;
            warningsList.Items.Clear();
        }

        public SifJsonViewerForm(SifJsonParsingResult result) : this()
        {
            ShowParsingResult(result);
        }

        private void openFileDialog_Click(object sender, EventArgs e)
        {
            using var dialog = new SelectJsonFileDialog("Select File");
            dialog.ShowDialog(this);
            if (dialog.Result != null)
            {
                OnFileParsed?.Invoke(this, dialog.Result);
                ProcessResult(dialog.Result);
            }
        }

        public async Task<(bool, string)> ProcessFile(string filePath)
        {
            using var longOperationState = new LongOperationState();
            var parseResult = await new SifJsonParser().Parse(filePath);
            if (parseResult.HasError)
            {
                return (false, parseResult.Error!);
            }
            OnFileParsed?.Invoke(this, parseResult);

            ProcessResult(parseResult);
            return (true, "Success");
        }

        public void ProcessResult(SifJsonParsingResult parseResult)
        {
            Clear();
            CurrentResult = parseResult;
            ShowParsingResult(parseResult);
        }

        private void openInBuilderButton_Click(object? sender, EventArgs e)
        {
            OnOpenInBuilder?.Invoke(this, CurrentResult);
        }

        private void openFolderButton_Click(object? sender, EventArgs e)
        {
            var filePath = CurrentResult.FilePath;
            if (string.IsNullOrWhiteSpace(filePath)) return;
            var argument = "/select, \"" + filePath + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void executeButton_Click(object? sender, EventArgs e)
        {
            OnPlay?.Invoke(this, CurrentResult);
        }

        public void ShowParsingResult(SifJsonParsingResult result)
        {
            FilePathText.Text = result.IsRawJson ? string.Empty : result.FilePath;

            var allowActions = !result.IsRawJson;
            executeButton.Enabled = allowActions;
            openFolderButton.Enabled = allowActions;
            openInBuilderButton.Enabled = true;
            tasksList.AllowExecution = allowActions;
            uninstallTasksList.AllowExecution = allowActions;
            tasksList.LoadTasks(result.Tasks);
            uninstallTasksList.LoadTasks(result.UninstallTasks);

            parametersList.DataSource = result.Parameters;

            variablesList.Items.AddRange(result.Variables.Select(variable => new ListViewItem([variable.Name, variable.Value])).ToArray());
            includesList.Items.AddRange(result.Includes.Select(include => new ListViewItem([include.Name, include.OriginalValue ?? ""])).ToArray());
            modulesList.Items.AddRange(result.Modules.Select(module => new ListViewItem(module.Path)).ToArray());
            registeredTasksList.Items.AddRange(result.RegisteredTasks.Select(rt => new ListViewItem([rt.Name, rt.Command])).ToArray());
            registeredConfigFunctionsList.Items.AddRange(result.RegisteredConfigFunctions.Select(rt => new ListViewItem([rt.Name, rt.Command])).ToArray());

            if (result.Settings != null)
            {
                autoRegisterExtensionsCheck.Checked = result.Settings.AutoRegisterExtensions;
                infoActionText.TextInput = result.Settings.InformationAction ?? string.Empty;
                warnActionText.TextInput = result.Settings.WarningAction ?? string.Empty;
                errorActionText.TextInput = result.Settings.ErrorAction ?? string.Empty;
            }

            if (result.HasWarnings)
            {
                warningsList.Items.AddRange(result.Warnings.Select(warning => new ListViewItem(warning)).ToArray());
            }

            UpdateTabs(result, preserveSelection: false);
        }

        private void RestoreAllTabs()
        {
            viewJsonTabs.TabPages.Clear();
            foreach (var tab in _orderedTabs)
            {
                tab.Page.Text = tab.BaseText;
                viewJsonTabs.TabPages.Add(tab.Page);
            }
        }

        private void UpdateTabs(SifJsonParsingResult result, bool preserveSelection = true)
        {
            var selectedTab = preserveSelection ? viewJsonTabs.SelectedTab : null;
            viewJsonTabs.SuspendLayout();
            viewJsonTabs.TabPages.Clear();

            var sectionIndex = result.SectionOrder
                .Select((s, i) => (s, i))
                .ToDictionary(x => x.s, x => x.i, StringComparer.OrdinalIgnoreCase);

            var visibleTabs = _orderedTabs
                .Select(tab => (tab, count: tab.CountGetter(result)))
                .Where(x => _showEmptyTabs || x.count > 0)
                .OrderBy(x => sectionIndex.TryGetValue(x.tab.SectionKey, out int idx) ? idx : int.MaxValue);

            foreach (var (tab, count) in visibleTabs)
            {
                tab.Page.Text = _showTabCounts && tab.ShowCount
                    ? $"{tab.BaseText} ({count})"
                    : tab.BaseText;

                viewJsonTabs.TabPages.Add(tab.Page);
            }

            if (selectedTab != null && viewJsonTabs.TabPages.Contains(selectedTab))
                viewJsonTabs.SelectedTab = selectedTab;
            else if (viewJsonTabs.TabPages.Count > 0)
                viewJsonTabs.SelectedIndex = 0;

            viewJsonTabs.ResumeLayout();
        }

        private void parametersFilter_TextChanged(object sender, EventArgs e)
        {
            parametersList.DataSource = paramtersFilterText.Text.Length == 0
                ? CurrentResult?.Parameters
                : CurrentResult?.Parameters
                    .Where(p => p.Name.Contains(paramtersFilterText.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();
        }

        private async void includesList_MouseDoubleClick(object sender, EventArgs e)
        {
            var list = sender as ListView;
            if (list?.SelectedIndices.Count != 1) return;

            var includeParseResult = CurrentResult.Includes[list.SelectedIndices[0]].ParseResult;
            if (includeParseResult != null)
            {
                OnFileParsed?.Invoke(this, includeParseResult);
                ProcessResult(includeParseResult);
                return;
            }

            if (CurrentResult.IsRawJson) return;

            var item = list.SelectedItems[0];

            var directory = CurrentResult?.Folder;

            var includeFileName = item.SubItems[1].Text.Replace("\\\\", "\\");
            var includeFilePath = Path.Combine(directory!, includeFileName);

            if (!includeFilePath.EndsWith(".json"))
            {
                includeFilePath += ".json";
            }

            if (!File.Exists(includeFilePath)) return;

            await ProcessFile(includeFilePath);
        }

        private void variablesFilter_TextChanged(object sender, EventArgs e)
        {
            variablesList.Items.Clear();
            var text = variablesFilter.Text.Trim().ToLower();
            var variables = string.IsNullOrWhiteSpace(text)
                ? CurrentResult.Variables
                : CurrentResult.Variables.Where(x =>
                    x.Name.ToLower().Contains(text) ||
                    x.Value.ToLower().Contains(text));
            variablesList.Items.AddRange(variables.Select(variable => new ListViewItem([variable.Name, variable.Value])).ToArray());
        }

        private async void variablesList_DoubleClick(object sender, EventArgs e)
        {
            var list = sender as ListView;
            if (list?.SelectedIndices.Count != 1) return;

            var item = list.SelectedItems[0];

            var configFunctionName = item.SubItems[0].Text;
            var variable = CurrentResult.Variables.FirstOrDefault(v => v.Name == configFunctionName);

            if (variable?.ConfigFunction is null)
            {
                return;
            }

            var dialog = new ConfigFunctionViewer();
            dialog.LoadConfigFunction(variable.ConfigFunction);
            await dialog.ShowDialogAsync();
        }

        private void tasksControl1_OnExecuteTasks(object sender, ResultEventArgs<SifJsonTaskModel[]> e)
        {
            this.OnExecuteTasks?.Invoke(sender, (false, e.Result, this.CurrentResult));
        }

        private void uninstallTasksList_OnExecuteTasks(object sender, ResultEventArgs<SifJsonTaskModel[]> e)
        {
            this.OnExecuteTasks?.Invoke(sender, (true, e.Result, this.CurrentResult));
        }

        private void variablesContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (variablesList.SelectedItems.Count != 1)
            {
                e.Cancel = true;
                return;
            }

            var name = variablesList.SelectedItems[0].Text;
            var variable = CurrentResult.Variables.FirstOrDefault(v => v.Name == name);

            if (variable == null)
            {
                e.Cancel = true;
                return;
            }

            bool hasSingleReference = variable.ConfigFunction is { HasError: false } && ((variable.ConfigFunction.VariablesReferences.Count == 1 && variable.ConfigFunction.ParametersReferences.Count == 0) || (variable.ConfigFunction.VariablesReferences.Count == 0 && variable.ConfigFunction.ParametersReferences.Count == 1));
            var hasReferences = !hasSingleReference && variable.ConfigFunction is { HasError: false } &&
                (variable.ConfigFunction.VariablesReferences.Count > 0 || variable.ConfigFunction.ParametersReferences.Count > 0);
            var hasReferrers = variable.ReferencedVariables.Count > 0;

            showReferencesMenuItem.Visible = hasReferences;
            showReferrersMenuItem.Visible = hasReferrers;
            showReferenceMenuItem.Visible = hasSingleReference;

            if (!hasReferences && !hasReferrers && !hasSingleReference)
                e.Cancel = true;
        }

        private void showReferencesMenuItem_Click(object sender, EventArgs e)
        {
            if (variablesList.SelectedItems.Count != 1) return;

            var name = variablesList.SelectedItems[0].Text;
            var variable = CurrentResult.Variables.FirstOrDefault(v => v.Name == name);
            if (variable?.ConfigFunction is not { HasError: false }) return;

            var items = variable.ConfigFunction.VariablesReferences
                .Select(v => new ReferencesDialog.ReferenceItem("Variable", v.Name))
                .Concat(variable.ConfigFunction.ParametersReferences
                    .Select(p => new ReferencesDialog.ReferenceItem("Parameter", p.Name)));

            using var dialog = new ReferencesDialog($"References: {name}", items);
            if (dialog.ShowDialog() == DialogResult.OK && dialog.SelectedReference != null)
                NavigateToReference(dialog.SelectedReference);
        }

        private void showReferrersMenuItem_Click(object sender, EventArgs e)
        {
            if (variablesList.SelectedItems.Count != 1) return;

            var name = variablesList.SelectedItems[0].Text;
            var variable = CurrentResult.Variables.FirstOrDefault(v => v.Name == name);
            if (variable == null) return;

            var items = variable.ReferencedVariables
                .Select(v => new ReferencesDialog.ReferenceItem("Variable", v.Name));

            using var dialog = new ReferencesDialog($"Referrers: {name}", items);
            if (dialog.ShowDialog() == DialogResult.OK && dialog.SelectedReference != null)
                NavigateToReference(dialog.SelectedReference);
        }

        private void parametersContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (parametersList.SelectedRows.Count != 1)
            {
                e.Cancel = true;
                return;
            }

            var name = parametersList.SelectedRows[0].Cells["nameDataGridViewTextBoxColumn"].Value?.ToString();
            var parameter = CurrentResult.Parameters.FirstOrDefault(p => p.Name == name);

            showParameterReferrersMenuItem.Visible = parameter?.ReferencedVariables.Count > 0;

            if (parameter == null || parameter.ReferencedVariables.Count == 0)
                e.Cancel = true;
        }

        private void showParameterReferrersMenuItem_Click(object sender, EventArgs e)
        {
            if (parametersList.SelectedRows.Count != 1) return;

            var name = parametersList.SelectedRows[0].Cells["nameDataGridViewTextBoxColumn"].Value?.ToString();
            var parameter = CurrentResult.Parameters.FirstOrDefault(p => p.Name == name);
            if (parameter == null) return;

            var items = parameter.ReferencedVariables
                .Select(v => new ReferencesDialog.ReferenceItem("Variable", v.Name));

            using var dialog = new ReferencesDialog($"Referrers: {name}", items);
            if (dialog.ShowDialog() == DialogResult.OK && dialog.SelectedReference != null)
                NavigateToReference(dialog.SelectedReference);
        }

        private void parametersList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                parametersList.ClearSelection();
                parametersList.Rows[e.RowIndex].Selected = true;
            }
        }

        private void NavigateToReference(ReferencesDialog.ReferenceItem reference)
        {
            if (reference.Kind == "Variable")
            {
                viewJsonTabs.SelectedTab = viewJsonVariables;
                variablesFilter.Clear();
                var item = variablesList.Items.Cast<ListViewItem>()
                    .FirstOrDefault(i => i.Text == reference.Name);
                if (item == null) return;
                item.Selected = true;
                item.EnsureVisible();
                variablesList.Focus();
            }
            else if (reference.Kind == "Parameter")
            {
                viewJsonTabs.SelectedTab = viewJsonParameters;
                paramtersFilterText.Clear();
                var row = parametersList.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["nameDataGridViewTextBoxColumn"].Value?.ToString() == reference.Name);
                if (row == null) return;
                parametersList.ClearSelection();
                row.Selected = true;
                parametersList.FirstDisplayedScrollingRowIndex = row.Index;
                parametersList.Focus();
            }
        }

        private void showReferenceMenuItem_Click(object sender, EventArgs e)
        {
            if (variablesList.SelectedItems.Count != 1) return;

            var name = variablesList.SelectedItems[0].Text;
            var variable = CurrentResult.Variables.FirstOrDefault(v => v.Name == name);
            if (variable?.ConfigFunction is not { HasError: false }) return;

            var item = variable.ConfigFunction.VariablesReferences
                .Select(v => new ReferencesDialog.ReferenceItem("Variable", v.Name))
                .Concat(variable.ConfigFunction.ParametersReferences
                    .Select(p => new ReferencesDialog.ReferenceItem("Parameter", p.Name)))
                .FirstOrDefault();

            if (item == null) return;

            NavigateToReference(item);
        }
    }
}
