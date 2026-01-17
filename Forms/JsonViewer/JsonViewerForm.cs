using SIF.Utils.Forms.Common;
using SIF.Utils.JsonParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;

namespace SIF.Utils.Forms.JsonViewer
{
    using JsonViewer = SIF.Utils.JsonViewer;

    public partial class JsonViewerForm : UserControl
    {
        [Browsable(true)]
        public event ResultEventHandler<SifJsonParsingResult>? OnFileParsed;

        [Browsable(true)]
        public event ResultEventHandler<SifJsonParsingResult>? OnPlay;

        [Browsable(true)]
        public event ResultEventHandler<string>? OnError;

        [Browsable(true)]
        public event EventHandler? BackClicked
        {
            add => navigationPanel.BackClicked += value;
            remove => navigationPanel.BackClicked -= value;
        }

        protected SifJsonParsingResult? CurrentResult { get; set; }

        public JsonViewerForm()
        {
            InitializeComponent();
        }

        public JsonViewerForm(string file) : this()
        {
            ProcessFile(file).Wait();
        }


        public JsonViewerForm(SifJsonParsingResult result) : this()
        {
            ShowParsingResult(result);
        }

        private async void openFileDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            await ProcessFile(openFileForViewerDialog.FileName);
        }

        public async Task ProcessFile(string filePath)
        {
            using var longOperationState = new LongOperationState(this);
            var parseResult = await new SifJsonService().ParseJson(filePath);
            if (parseResult.HasError)
            {
                OnError?.Invoke(this, parseResult.Error!);
                return;
            }
            OnFileParsed?.Invoke(this, parseResult);

            CurrentResult = parseResult;
            FilePathText.Text = filePath;
            ClearAllTabs();
            ShowParsingResult(parseResult);
        }

        private void openFolderButton_Click(object? sender, EventArgs e)
        {
            var filePath = CurrentResult?.FilePath;
            if (string.IsNullOrWhiteSpace(filePath)) return;
            var argument = "/select, \"" + filePath + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void executeButton_Click(object? sender, EventArgs e)
        {
            if (CurrentResult != null) OnPlay?.Invoke(this, CurrentResult);
        }

        public void ShowParsingResult(SifJsonParsingResult result)
        {
            ResultToListItemsConverter converter = new();
            filterText.Clear();
            tasksViewer.Items.AddRange(converter.GetGroupItems(result.Tasks).ToArray());
            uninstallTasksList.Items.AddRange(converter.GetGroupItems(result.UninstallTasks).ToArray());

            parametersList.DataSource = result.Parameters;

            variablesList.Items.AddRange(result.Variables.Select(variable => new ListViewItem([variable.Name, variable.Value])).ToArray());
            includesList.Items.AddRange(result.Includes.Select(include => new ListViewItem([include.Name, include.Source ?? ""])).ToArray());
            modulesList.Items.AddRange(result.Modules.Select(module => new ListViewItem(module.Path)).ToArray());
            registeredTasksList.Items.AddRange(result.RegisteredTasks.Select(rt => new ListViewItem([rt.Name, rt.Command])).ToArray());
            registeredConfigFunctionsList.Items.AddRange(result.RegisteredConfigFunctions.Select(rt => new ListViewItem([rt.Name, rt.Command])).ToArray());
        }

        public void ClearAllTabs()
        {
            parametersList.DataSource = null;
            variablesList.Items.Clear();
            uninstallTasksList.Items.Clear();
            includesList.Items.Clear();
            modulesList.Items.Clear();
            tasksViewer.Items.Clear();
            registeredTasksList.Items.Clear();
            registeredConfigFunctionsList.Items.Clear();
        }

        private void parametersFilter_TextChanged(object sender, EventArgs e)
        {
            parametersList.DataSource = textBox1.Text.Length == 0
                ? CurrentResult?.Parameters
                : CurrentResult?.Parameters
                    .Where(p => p.Name.Contains(textBox1.Text, StringComparison.OrdinalIgnoreCase))
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
                ? CurrentResult?.Variables ?? []
                : CurrentResult?.Variables.Where(x =>
                    x.Name.ToLower().Contains(text) ||
                    x.Value.ToLower().Contains(text)) ?? [];
            variablesList.Items.AddRange(variables.Select(variable => new ListViewItem([variable.Name, variable.Value])).ToArray());
        }

        private void tasksViewer_DoubleClick(object sender, EventArgs e)
        {
            var list = sender as ListView;
            if (list?.SelectedIndices.Count != 1) return;

            var item = list.SelectedItems[0];

            var taskName = item.Text;
            var task =
                list.Tag?.ToString() == "Tasks" ?
                    CurrentResult?.Tasks.FirstOrDefault(t => t.Name == taskName) :
                    list?.Tag?.ToString() == "UninstallTasks" ?
                        CurrentResult?.UninstallTasks.FirstOrDefault(t => t.Name == taskName) :
                        null;

            if (task == null) return;

            using var detailsForm = new JsonViewer(task.Name, task.Element.Value);
            detailsForm.ShowDialog();
        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            var text = this.filterText.Text.Trim().ToLower();

            tasksViewer.Items.Clear();
            var tasks = string.IsNullOrWhiteSpace(text)
                ? CurrentResult?.Tasks ?? []
                : CurrentResult?.Tasks.Where(x =>
                    x.Name.ToLower().Contains(text) ||
                    x.Description.ToLower().Contains(text)) ?? [];

            ResultToListItemsConverter converter = new();
            var listItems = converter.GetGroupItems(
                tasks
            ).ToArray();

            tasksViewer.Items.AddRange(listItems);
        }

        private async void variablesList_DoubleClick(object sender, EventArgs e)
        {
            var list = sender as ListView;
            if (list?.SelectedIndices.Count != 1) return;

            var item = list.SelectedItems[0];

            await new ConfigFunctionViewer(item.SubItems[1].Text).ShowDialogAsync();
        }

    }
}
