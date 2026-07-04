namespace SIF.Utils.Forms.JsonBuilder.Includes
{
    public partial class IncludeAliasDialog : Form
    {
        public string Alias => aliasTextBox.Text;
        public string FilePath => pathTextBox.Text;

        public IncludeAliasDialog(string currentPath, string currentAlias)
        {
            InitializeComponent();
            pathTextBox.Text = currentPath;
            aliasTextBox.Text = currentAlias;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Filter = "SIF JSON|*.json";

            var currentDir = Path.GetDirectoryName(pathTextBox.Text);
            if (!string.IsNullOrWhiteSpace(currentDir) && Directory.Exists(currentDir))
            {
                dialog.InitialDirectory = currentDir;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = dialog.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pathTextBox.Text))
            {
                MessageBox.Show(this, "Please select a file to include.", "Missing file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
