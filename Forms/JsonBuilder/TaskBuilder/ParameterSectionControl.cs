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
        return taskParameterModelBindingSource.Cast<TaskParameterModel>()
            .Where(parameter => !string.IsNullOrEmpty(parameter.Name))
            .Select(parameter => new TaskParameterModel { Name = parameter.Name, Value = parameter.Value })
            .ToList();
    }

    private void removeButton_Click(object sender, EventArgs e) => RemoveRequested?.Invoke(this, EventArgs.Empty);

    private void editButton_Click(object sender, EventArgs e) => EditRequested?.Invoke(this, EventArgs.Empty);

    private void parametersDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => DeferAdjustDataGridViewHeight((DataGridView)sender);

    private void parametersDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => DeferAdjustDataGridViewHeight((DataGridView)sender);

    // RowsAdded/RowsRemoved fire during the grid's own internal layout pass (Fill-mode
    // columns are re-measured whenever the row count changes, e.g. due to scrollbar
    // visibility). Adjusting Height synchronously here re-enters that layout pass and
    // throws "This operation cannot be performed while an auto-filled column is being
    // resized." Deferring via BeginInvoke runs the adjustment after layout completes.
    private void DeferAdjustDataGridViewHeight(DataGridView dgv)
    {
        if (IsHandleCreated)
            BeginInvoke(() => AdjustDataGridViewHeight(dgv));
        else
            AdjustDataGridViewHeight(dgv);
    }

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
