using SIF.Utils.Logic.JsonParser;

namespace SIF.Utils.Forms.JsonBuilder.Parameters;

public partial class ParameterEditDialog : Form
{
    public ParameterEditDialog(IEnumerable<string> existingParamNames, IEnumerable<SifJsonIncludeModel> includes)
    {
        InitializeComponent();
        typeComboBox.Items.AddRange(["string", "int", "bool"]);
        typeComboBox.SelectedIndex = 0;
        toolTip1.SetToolTip(hasDefaultValueCheckBox,
            "If left unchecked, this parameter has no default value and will be required: " +
            "a value must be passed from the console when executing the SIF JSON file. " +
            "Check this box to provide a default value, which may be an empty string.");
        defaultValueTextBox.Enabled = hasDefaultValueCheckBox.Checked;
        BuildReferenceAutoComplete(existingParamNames, includes);
    }

    private void BuildReferenceAutoComplete(IEnumerable<string> existingParamNames, IEnumerable<SifJsonIncludeModel> includes)
    {
        var suggestions = new AutoCompleteStringCollection();
        foreach (var name in existingParamNames)
            suggestions.Add(name);
        foreach (var include in includes)
        {
            if (include.ParseResult?.Parameters == null) continue;
            foreach (var param in include.ParseResult.Parameters)
                suggestions.Add($"{include.Name}:{param.Name}");
        }
        referenceTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        referenceTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        referenceTextBox.AutoCompleteCustomSource = suggestions;
    }

    public SifJsonParameterModel GetModel() => new()
    {
        Name = nameTextBox.Text.Trim(),
        Type = typeComboBox.Text,
        DefaultValue = hasDefaultValueCheckBox.Checked ? defaultValueTextBox.Text : null,
        Reference = NullIfEmpty(referenceTextBox.Text),
        Validate = NullIfEmpty(validateTextBox.Text),
        Description = NullIfEmpty(descriptionTextBox.Text),
    };

    public void SetModel(SifJsonParameterModel model)
    {
        nameTextBox.Text = model.Name;
        typeComboBox.Text = string.IsNullOrEmpty(model.Type) ? "String" : model.Type;
        hasDefaultValueCheckBox.Checked = model.DefaultValue is not null;
        defaultValueTextBox.Text = model.DefaultValue ?? "";
        defaultValueTextBox.Enabled = hasDefaultValueCheckBox.Checked;
        referenceTextBox.Text = model.Reference ?? "";
        validateTextBox.Text = model.Validate ?? "";
        descriptionTextBox.Text = model.Description ?? "";
    }

    private void hasDefaultValueCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        defaultValueTextBox.Enabled = hasDefaultValueCheckBox.Checked;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nameTextBox.Text))
        {
            MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private static string? NullIfEmpty(string value) =>
        string.IsNullOrWhiteSpace(value) ? null : value;
}
