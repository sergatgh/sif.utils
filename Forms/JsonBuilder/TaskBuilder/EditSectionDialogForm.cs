namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

public partial class EditSectionDialogForm : Form
{
    public EditSectionDialogForm(UserControl content, string title)
    {
        InitializeComponent();
        Text = title;
        content.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(content);
    }
}
