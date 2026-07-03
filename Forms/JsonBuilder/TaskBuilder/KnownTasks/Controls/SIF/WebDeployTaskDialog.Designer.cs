namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class WebDeployTaskDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            argsJson = new LabeledTextbox();
            checkBox1 = new CheckBox();
            pathToDeploy = new LabeledTextbox();
            actionText = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            //
            // argsJson
            //
            argsJson.Dock = DockStyle.Fill;
            argsJson.Location = new Point(2, 77);
            argsJson.Margin = new Padding(2, 1, 2, 1);
            argsJson.Multiline = true;
            argsJson.Name = "argsJson";
            argsJson.PathSelectionFilter = "";
            argsJson.PathSelectMode = PathSelectMode.Folder;
            argsJson.ShowPathSelector = false;
            argsJson.Size = new Size(580, 355);
            argsJson.TabIndex = 13;
            argsJson.TextInput = "{ }";
            argsJson.TextLabel = "Arguments object JSON";
            argsJson.Vertical = true;
            //
            // checkBox1
            //
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(858, 46);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Check Status";
            checkBox1.UseVisualStyleBackColor = true;
            //
            // pathToDeploy
            //
            pathToDeploy.Dock = DockStyle.Top;
            pathToDeploy.Location = new Point(2, 40);
            pathToDeploy.Margin = new Padding(2, 1, 2, 1);
            pathToDeploy.Multiline = false;
            pathToDeploy.Name = "pathToDeploy";
            pathToDeploy.PathSelectionFilter = "MS Deploy|*.exe";
            pathToDeploy.PathSelectMode = PathSelectMode.File;
            pathToDeploy.ShowPathSelector = true;
            pathToDeploy.Size = new Size(580, 37);
            pathToDeploy.TabIndex = 5;
            pathToDeploy.TextInput = "";
            pathToDeploy.TextLabel = "Path to msdeploy.exe";
            pathToDeploy.Vertical = true;
            //
            // actionText
            //
            actionText.Dock = DockStyle.Top;
            actionText.FormattingEnabled = true;
            actionText.Items.AddRange(new object[] { "sync", "delete", "dump", "getDependencies", "getSystemInfo" });
            actionText.Location = new Point(2, 17);
            actionText.Margin = new Padding(2, 2, 2, 2);
            actionText.Name = "actionText";
            actionText.Size = new Size(580, 23);
            actionText.TabIndex = 4;
            actionText.Text = "sync";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Verb *";
            //
            // WebDeployTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(argsJson);
            Controls.Add(checkBox1);
            Controls.Add(pathToDeploy);
            Controls.Add(actionText);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WebDeployTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(584, 434);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public CheckBox checkBox1;
        public LabeledTextbox pathToDeploy;
        public ComboBox actionText;
        private Label label1;
        public LabeledTextbox argsJson;
    }
}
