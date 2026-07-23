using SIF.Utils.Forms.Common.ConfigFunctionBuilder;
using SIF.Utils.Forms.JsonBuilder.Register;
using System.ComponentModel;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    public partial class SetXmlTaskDialog : UserControl
    {
        /// <summary>Supplies variable names for the expression builder.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<IEnumerable<string>>? GetAvailableVariableNames { get; set; }

        /// <summary>Supplies parameter names for the expression builder.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<IEnumerable<string>>? GetAvailableParameterNames { get; set; }

        /// <summary>Supplies registered config function names for the expression builder.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<IEnumerable<RegisterMethodModel>>? GetRegisteredConfigFunctions { get; set; }

        public SetXmlTaskDialog()
        {
            InitializeComponent();
        }

        private void parametersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != buildExpressionDataGridColumn.Index) return;

            var valueCell = parametersDataGrid.Rows[e.RowIndex].Cells[valueColumn.Index];
            var seedValue = valueCell.Value?.ToString();

            using var dialog = new ConfigFunctionBuilderDialog(
                seedValue,
                GetAvailableVariableNames?.Invoke() ?? [],
                GetAvailableParameterNames?.Invoke() ?? [],
                GetRegisteredConfigFunctions?.Invoke() ?? []);

            if (dialog.ShowDialog() != DialogResult.OK) return;

            valueCell.Value = dialog.GetResult();
        }
    }
}
