using System.ComponentModel;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

public partial class ParameterSectionControl : UserControl
{
    public event EventHandler? RemoveRequested;
    public event EventHandler? EditRequested;

    public ParameterSectionControl()
    {
        InitializeComponent();
        AdjustDataGridViewHeight(parametersDataGrid);
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string SectionTitle
    {
        get => titleLabel.Text;
        set => titleLabel.Text = value;
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool ShowRemoveButton
    {
        get => removeButton.Visible;
        set => removeButton.Visible = value;
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool ShowEditButton
    {
        get => editButton.Visible;
        set => editButton.Visible = value;
    }

    public void LoadParameters(IEnumerable<TaskParameterModel> parameters)
    {
        taskParameterModelBindingSource.Clear();
        foreach (var parameter in parameters)
        {
            taskParameterModelBindingSource.Add(new TaskParameterModel { Name = parameter.Name, Value = parameter.Value });
        }
    }

    public List<TaskParameterModel> GetParameters()
    {
        var result = new List<TaskParameterModel>();
        foreach (DataGridViewRow row in parametersDataGrid.Rows)
        {
            if (row.IsNewRow) continue;
            var name = row.Cells[0].Value?.ToString() ?? string.Empty;
            var value = row.Cells[1].Value?.ToString() ?? string.Empty;
            if (!string.IsNullOrEmpty(name))
            {
                result.Add(new TaskParameterModel { Name = name, Value = value });
            }
        }
        return result;
    }

    private void removeButton_Click(object sender, EventArgs e) => RemoveRequested?.Invoke(this, EventArgs.Empty);

    private void editButton_Click(object sender, EventArgs e) => EditRequested?.Invoke(this, EventArgs.Empty);

    private void parametersDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => AdjustDataGridViewHeight((DataGridView)sender);

    private void parametersDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => AdjustDataGridViewHeight((DataGridView)sender);

    private void AdjustDataGridViewHeight(DataGridView dgv)
    {
        if (dgv.Rows.Count == 0)
        {
            dgv.Height = dgv.ColumnHeadersHeight;
        }
        else
        {
            int totalHeight = dgv.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                totalHeight += row.Height;
            }

            totalHeight += 5;
            dgv.Height = totalHeight;
        }

        Height = headerPanel.Height + dgv.Height + Padding.Vertical + 2;
    }
}
