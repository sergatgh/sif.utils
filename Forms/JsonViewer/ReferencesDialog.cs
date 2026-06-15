namespace SIF.Utils.Forms.JsonViewer;

public partial class ReferencesDialog : Form
{
    public record ReferenceItem(string Kind, string Name);

    public ReferenceItem? SelectedReference { get; private set; }

    public ReferencesDialog(string title, IEnumerable<ReferenceItem> items)
    {
        InitializeComponent();
        Text = title;
        foreach (var item in items)
        {
            referencesList.Items.Add(new ListViewItem([item.Kind, item.Name]) { Tag = item });
        }
    }

    private void referencesList_DoubleClick(object sender, EventArgs e) => SelectCurrent();

    private void referencesList_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            SelectCurrent();
    }

    private void closeButton_Click(object sender, EventArgs e) => Close();

    private void SelectCurrent()
    {
        if (referencesList.SelectedItems.Count != 1) return;
        SelectedReference = referencesList.SelectedItems[0].Tag as ReferenceItem;
        DialogResult = DialogResult.OK;
        Close();
    }
}
