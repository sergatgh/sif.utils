using SIF.Utils.Forms.Common.ConfigFunctionBuilder;
using SIF.Utils.Forms.JsonBuilder.Register;
using System.ComponentModel;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

public partial class ParameterSectionControl : UserControl
{
    public event EventHandler? RemoveRequested;
    public event EventHandler? EditRequested;

    /// <summary>Supplies variable names live from the sibling Variables tab, for the expression builder.</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<IEnumerable<string>>? GetAvailableVariableNames { get; set; }

    /// <summary>Supplies parameter names live from the sibling Parameters tab, for the expression builder.</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<IEnumerable<string>>? GetAvailableParameterNames { get; set; }

    /// <summary>Supplies registered config function names live from the sibling Register tab, for the expression builder.</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<IEnumerable<RegisterMethodModel>>? GetRegisteredConfigFunctions { get; set; }

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

    /// <summary>Applies the given parameters onto the existing set: overrides the value of a matching
    /// name, or adds it if not present. Unlike LoadParameters, it never removes parameters that aren't
    /// mentioned - so an "Edit Section" dialog that only knows about a handful of named fields can't
    /// wipe out other parameters already present in the grid (e.g. custom ones added by hand or via
    /// JSON import).</summary>
    public void UpdateParameters(IEnumerable<TaskParameterModel> parameters)
    {
        foreach (var parameter in parameters)
        {
            var index = IndexOfParameter(parameter.Name);
            if (index >= 0)
            {
                ((TaskParameterModel)taskParameterModelBindingSource[index]!).Value = parameter.Value;
                taskParameterModelBindingSource.ResetItem(index);
            }
            else
            {
                taskParameterModelBindingSource.Add(new TaskParameterModel { Name = parameter.Name, Value = parameter.Value });
            }
        }
    }

    private int IndexOfParameter(string name)
    {
        for (var i = 0; i < taskParameterModelBindingSource.Count; i++)
        {
            if (((TaskParameterModel)taskParameterModelBindingSource[i]!).Name == name) return i;
        }

        return -1;
    }

    private void removeButton_Click(object sender, EventArgs e) => RemoveRequested?.Invoke(this, EventArgs.Empty);

    private void editButton_Click(object sender, EventArgs e) => EditRequested?.Invoke(this, EventArgs.Empty);

    private void parametersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != buildExpressionDataGridColumn.Index) return;
        OpenBuilderForRow(e.RowIndex);
    }

    private void OpenBuilderForRow(int rowIndex)
    {
        var valueCell = parametersDataGrid.Rows[rowIndex].Cells[valueDataGridViewTextBoxColumn.Index];
        var seedValue = valueCell.Value?.ToString();

        using var dialog = new ConfigFunctionBuilderDialog(
            seedValue,
            GetAvailableVariableNames?.Invoke() ?? [],
            GetAvailableParameterNames?.Invoke() ?? [],
            GetRegisteredConfigFunctions?.Invoke() ?? []);

        if (dialog.ShowDialog() != DialogResult.OK) return;

        valueCell.Value = dialog.GetResult();
    }

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
