namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

public partial class TaskEditor : UserControl
{
    public TaskEditor()
    {
        InitializeComponent();
        AdjustDataGridViewHeight(parametersDataGrid);
    }

    private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
        AdjustDataGridViewHeight((DataGridView)sender);
    }

    private void AdjustDataGridViewHeight(DataGridView dgv)
    {
        // Ensure the DataGridView has rows
        if (dgv.Rows.Count == 0)
        {
            dgv.Height = dgv.ColumnHeadersHeight; // Just header height if no rows
            return;
        }

        // Calculate the total height required
        int totalHeight = dgv.ColumnHeadersHeight; // Start with header height

        foreach (DataGridViewRow row in dgv.Rows)
        {
            totalHeight += row.Height; // Add the height of each row
        }

        // Optionally add a small buffer for aesthetics or scrollbar space
        totalHeight += 5;

        // Set the DataGridView's height
        dgv.Height = totalHeight;
    }

    private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
        AdjustDataGridViewHeight((DataGridView)sender);
    }
}

public class TaskParameterModel
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}