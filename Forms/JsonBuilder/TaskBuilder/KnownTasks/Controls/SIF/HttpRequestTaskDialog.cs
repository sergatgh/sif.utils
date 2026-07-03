namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    public partial class HttpRequestTaskDialog : UserControl
    {
        public HttpRequestTaskDialog()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            statusNumber.Enabled = checkBox1.Checked;
        }
    }
}
