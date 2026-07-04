namespace SIF.Utils.Forms.JsonBuilder.Includes
{
    public partial class IncludeAliasDialog : Form
    {
        public string Alias => aliasTextBox.Text;

        public IncludeAliasDialog(string currentAlias)
        {
            InitializeComponent();
            aliasTextBox.Text = currentAlias;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
