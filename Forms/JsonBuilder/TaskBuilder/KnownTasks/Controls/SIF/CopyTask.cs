namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
    using System.Text.Json.Nodes;

    public partial class CopyTask : AdvancedTask
    {
        public CopyTask()
        {
            InitializeComponent();
            InitializeBase();
        }

        public override TaskEditor TaskEditor => this.taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>();
            dict["Source"] = JsonValue.Create(this.sourcePathText.Text);
            dict["Destination"] = JsonValue.Create(this.destinationText.Text);

            return dict;
        }

        public override string GetDefaultName()
        {
            return "CopyTask";
        }

        public override string GetDefaultDescription()
        {
            if (this.sourcePathText.Text.Length > 0 && this.destinationText.Text.Length > 0)
            {
                return $"Copy files from [{this.sourcePathText.Text.Split('\\', '/').Last()}] to [{this.destinationText.Text.Split('\\', '/').Last()}].";
            }

            return "Copies files from source to destination.";
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
