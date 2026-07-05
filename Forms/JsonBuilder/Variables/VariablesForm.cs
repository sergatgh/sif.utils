using SIF.Utils.Forms.Common.ConfigFunctionBuilder;
using SIF.Utils.Forms.JsonBuilder.Register;
using SIF.Utils.Helpers;
using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.Variables
{
    public partial class VariablesForm : UserControl
    {
        /// <summary>Supplies parameter names live from a sibling ParametersForm, for the expression builder.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<IEnumerable<string>>? GetAvailableParameterNames { get; set; }

        /// <summary>Supplies registered config function names live from the sibling Register tab, for the expression builder.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<IEnumerable<RegisterMethodModel>>? GetRegisteredConfigFunctions { get; set; }

        public VariablesForm()
        {
            InitializeComponent();
        }

        public void Clear() => parametersDataGrid.Rows.Clear();

        public void LoadFromModels(IEnumerable<SifJsonVariableModel> models)
        {
            foreach (var model in models)
                parametersDataGrid.Rows.Add(model.Name, model.Value);
        }

        public bool HasVariables()
        {
            return this.parametersDataGrid.Rows.Count > 1;
        }

        public JsonObject GetJson()
        {
            JsonObject json = new JsonObject();
            foreach (DataGridViewRow parameter in this.parametersDataGrid.Rows)
            {
                var prop = parameter.Cells[0].Value?.ToString() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(prop))
                {
                    continue;
                }

                json[prop] = (parameter.Cells[1].Value?.ToString() ?? string.Empty).ParseConfigVariable();
            }
            return json;
        }

        private void parametersDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0 || e.ColumnIndex < 0) return;

            parametersDataGrid.ClearSelection();
            parametersDataGrid.CurrentCell = parametersDataGrid[e.ColumnIndex, e.RowIndex];
            parametersDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void buildExpressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = parametersDataGrid.CurrentCell?.RowIndex ?? -1;
            if (rowIndex >= 0) OpenBuilderForRow(rowIndex);
        }

        private void parametersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != buildExpressionDataGridColumn.Index) return;
            OpenBuilderForRow(e.RowIndex);
        }

        private void OpenBuilderForRow(int rowIndex)
        {
            var valueCell = parametersDataGrid.Rows[rowIndex].Cells[valueDataGridColumn.Index];
            var seedValue = valueCell.Value?.ToString();

            var availableVariables = parametersDataGrid.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Index != rowIndex)
                .Select(r => r.Cells[nameDataColumn.Index].Value?.ToString())
                .Where(name => !string.IsNullOrWhiteSpace(name))
                .Select(name => name!);

            using var dialog = new ConfigFunctionBuilderDialog(
                seedValue,
                availableVariables,
                GetAvailableParameterNames?.Invoke() ?? [],
                GetRegisteredConfigFunctions?.Invoke() ?? []);

            if (dialog.ShowDialog() != DialogResult.OK) return;

            valueCell.Value = dialog.GetResult();
        }
    }
}
