namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    public partial class WebSiteTaskDialog : UserControl
    {
        public WebSiteTaskDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var directorySelectResult = selectWebsiteFolder.ShowDialog();
            if (directorySelectResult != DialogResult.OK) return;

            pathInput.TextInput = selectWebsiteFolder.SelectedPath;
        }
    }
}
