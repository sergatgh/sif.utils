namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    public partial class CopyTaskDialog : UserControl
    {
        public CopyTaskDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string hack = "Select this folder";
            var dialog = new OpenFileDialog();
            dialog.ValidateNames = false;
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;
            dialog.FileName = hack;
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var name = dialog.FileName.Replace("\\" + hack, "");
                sourcePathText.Text = name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string hack = "Select this folder";
            var dialog = new OpenFileDialog();
            dialog.ValidateNames = false;
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;
            dialog.FileName = hack;
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var name = dialog.FileName.Replace("\\" + hack, "");
                destinationText.Text = name;
            }
        }
    }
}
