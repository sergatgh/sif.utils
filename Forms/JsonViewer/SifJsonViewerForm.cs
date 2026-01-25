using SIF.Utils.Forms.Common;
using SIF.Utils.JsonParser;
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
        public event EventHandler? BackClicked
        {
            add => navigationPanel.BackClicked += value;
            remove => navigationPanel.BackClicked -= value;
        }

        protected SifJsonParsingResult CurrentResult { get; set; } = SifJsonParsingResult.Empty;

        public SifJsonViewerForm()
        {
            InitializeComponent();

            toolTip1.SetToolTip(changeFileButton, "Select another file");
            toolTip1.SetToolTip(openFolderButton, "Open folder containing this JSON file");
            toolTip1.SetToolTip(executeButton, "Execute this SIF file");
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
            viewJsonTabs.SelectTab(0);
            variablesFilter.Text = string.Empty;
            paramtersFilterText.Text = string.Empty;
        }

        public SifJsonViewerForm(SifJsonParsingResult result) : this()
        {
            ShowParsingResult(result);
        }

        private async void openFileDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            await ProcessFile(openFileForViewerDialog.FileName);
        }

        public async Task<(bool, string)> ProcessFile(string filePath)
        {
            using var longOperationState = new LongOperationState();
            var parseResult = await new SifJsonService().ParseJson(filePath);
            if (parseResult.HasError)
            {
                return (false, parseResult.Error!);
            }
            OnFileParsed?.Invoke(this, parseResult);

            FilePathText.Text = filePath;
            ProcessResult(parseResult);
            return (true, "Success");
        }

        public void ProcessResult(SifJsonParsingResult parseResult)
        {
            Clear();
            CurrentResult = parseResult;
            ShowParsingResult(parseResult);
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
            tasksList.LoadTasks(result.Tasks);
            uninstallTasksList.LoadTasks(result.UninstallTasks);

            parametersList.DataSource = result.Parameters;

            variablesList.Items.AddRange(result.Variables.Select(variable => new ListViewItem([variable.Name, variable.Value])).ToArray());
            includesList.Items.AddRange(result.Includes.Select(include => new ListViewItem([include.Name, include.Source ?? ""])).ToArray());
            modulesList.Items.AddRange(result.Modules.Select(module => new ListViewItem(module.Path)).ToArray());
            registeredTasksList.Items.AddRange(result.RegisteredTasks.Select(rt => new ListViewItem([rt.Name, rt.Command])).ToArray());
            registeredConfigFunctionsList.Items.AddRange(result.RegisteredConfigFunctions.Select(rt => new ListViewItem([rt.Name, rt.Command])).ToArray());
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

            await new ConfigFunctionViewer(item.SubItems[1].Text).ShowDialogAsync();
        }

        private void tasksControl1_OnExecuteTasks(object sender, ResultEventArgs<SifJsonTaskModel[]> e)
        {
            this.OnExecuteTasks?.Invoke(sender, (false, e.Result, this.CurrentResult));
        }

        private void uninstallTasksList_OnExecuteTasks(object sender, ResultEventArgs<SifJsonTaskModel[]> e)
        {
            this.OnExecuteTasks?.Invoke(sender, (true, e.Result, this.CurrentResult));
        }
    }
}
