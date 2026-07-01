using SIF.Utils.Logic.JsonParser;

namespace SIF.Utils.Forms.JsonBuilder.Parameters;

public partial class ParameterEditDialog : Form
{
    public ParameterEditDialog(IEnumerable<string> existingParamNames, IEnumerable<SifJsonIncludeModel> includes)
    {
        InitializeComponent();
        typeComboBox.Items.AddRange(new object[] { "String", "Integer", "Boolean", "PSObject" });
        typeComboBox.SelectedIndex = 0;
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
        DefaultValue = NullIfEmpty(defaultValueTextBox.Text),
        Reference = NullIfEmpty(referenceTextBox.Text),
        Validate = NullIfEmpty(validateTextBox.Text),
        Description = NullIfEmpty(descriptionTextBox.Text),
    };

    public void SetModel(SifJsonParameterModel model)
    {
        nameTextBox.Text = model.Name;
        typeComboBox.Text = string.IsNullOrEmpty(model.Type) ? "String" : model.Type;
        defaultValueTextBox.Text = model.DefaultValue ?? "";
        referenceTextBox.Text = model.Reference ?? "";
        validateTextBox.Text = model.Validate ?? "";
        descriptionTextBox.Text = model.Description ?? "";
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
