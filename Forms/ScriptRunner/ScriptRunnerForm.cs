using SIF.Utils.Forms.Common;
using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;

namespace SIF.Utils.Forms.ScriptRunner
{
    public partial class ScriptRunnerForm : UserControl
    {
        private ParameterEditModel? _currentEditingParameter;
        protected ParameterEditModel[] ParametersToEdit { get; set; } = [];

        protected SifJsonParsingResult CurrentResult { get; set; } = SifJsonParsingResult.Empty;

        protected string[] Tasks { get; set; } = [];

        protected bool UninstallMode { get; set; }

        [Browsable(true)]
        public event ResultEventHandler<(SifJsonParsingResult Json, ParameterEditModel[] Parameters, string[] Tasks, bool Uninstall)>? ExecuteClicked;

        [Browsable(true)]
        public event ResultEventHandler<string>? RefreshClicked;

        [Browsable(true)]
        public event EventHandler? BackClicked
        {
            add => navigationPanel.BackClicked += value;
            remove => navigationPanel.BackClicked -= value;
        }

        public ScriptRunnerForm()
        {
            InitializeComponent();

            toolTip1.SetToolTip(executeButton, "Select execution options");
            toolTip1.SetToolTip(reloadPropertiesButton, "Reload parameters from SIF JSON file");
            toolTip1.SetToolTip(importParametersButton, "Import parameters from *.ini file");
            toolTip1.SetToolTip(exportParametersButton, "Export parameters to *.ini file");
        }

        public void FilterPropertiesForScript()
        {
            var filtered = string.IsNullOrWhiteSpace(textBox2.Text)
                ? ParametersToEdit
                : ParametersToEdit
                    .Where(p => p.Name.Contains(textBox2.Text, StringComparison.OrdinalIgnoreCase))
                    .ToArray();

            filtered = checkBox1.Checked
                ? filtered
                : filtered.Where(p => !p.IsReference).ToArray();

            propsTableForScript.DataSource = filtered;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FilterPropertiesForScript();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FilterPropertiesForScript();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            var hasErrors = false;
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

            ExecuteClicked?.Invoke(this, (this.CurrentResult, ParametersToEdit, Tasks, UninstallMode));
        }

        private void reloadPropertiesButton_Click(object sender, EventArgs e)
        {
            RefreshClicked?.Invoke(this, CurrentResult.FilePath);
        }

        private async void importParametersButton_Click(object sender, EventArgs e)
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

        private void exportParametersButton_Click(object sender, EventArgs e)
        {
            var result = saveParametersDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            var filePath = saveParametersDialog.FileName;

            using var writer = new StreamWriter(filePath);
            var parameterEditModels = ParametersToEdit;
            foreach (var param in parameterEditModels)
            {
                if (param.IsDefaultValueSet()) continue;

                writer.WriteLine($"{param.Name}={param.Value}");
            }
        }

        private void propsTableForScript_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == propsTableForScript.Columns["RowAction"]?.Index)
            {
                var row = propsTableForScript.Rows[e.RowIndex];
                var model = (ParameterEditModel)row.DataBoundItem!;
                _currentEditingParameter = model;

                callActionContextMenu.Show(Cursor.Position);
            }
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentEditingParameter == null) return;

            _currentEditingParameter.ResetToDefault();
            propsTableForScript.Refresh();
        }

        private void insertFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentEditingParameter == null) return;

            var result = chooseFile.ShowDialog();

            if (result != DialogResult.OK) return;

            _currentEditingParameter.Value = chooseFile.FileName;
            propsTableForScript.Refresh();
        }

        private void insertPathToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentEditingParameter == null) return;

            var result = chooseFolder.ShowDialog();

            if (result != DialogResult.OK) return;

            _currentEditingParameter.Value = chooseFolder.SelectedPath;
            propsTableForScript.Refresh();
        }

        public void LoadForm(SifJsonParsingResult result, string[]? tasksToExecute = null, bool uninstall = false)
        {
            Clear();
            CurrentResult = result;
            Tasks = tasksToExecute ?? [];
            UninstallMode = uninstall;

            propsTableForScript.DataSource = ParametersToEdit = result.Parameters.Select(ParameterEditModel.FromSifJsonParameterModel)
                .OrderBy(x => x.IsReference)
                .ThenBy(x => x.HasDefaultValue)
                .ThenBy(x => x.HasValidation)
                .ToArray();
        }

        public void Clear()
        {
            CurrentResult = SifJsonParsingResult.Empty;
            Tasks = [];
            UninstallMode = false;
            propsTableForScript.DataSource = Array.Empty<ParameterEditModel>();
        }

        private void propsTableForScript_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.DataSource is not IList<ParameterEditModel> list)
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

    }
}
