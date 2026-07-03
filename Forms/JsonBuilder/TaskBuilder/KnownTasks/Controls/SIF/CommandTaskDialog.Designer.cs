namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class CommandTaskDialog
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
            propertiesText = new TextBox();
            cleanLabel = new Label();
            commandPathText = new TextBox();
            labelEnsure = new Label();
            SuspendLayout();
            //
            // propertiesText
            //
            propertiesText.Dock = DockStyle.Fill;
            propertiesText.Location = new Point(2, 55);
            propertiesText.Margin = new Padding(2, 2, 2, 2);
            propertiesText.Multiline = true;
            propertiesText.Name = "propertiesText";
            propertiesText.Size = new Size(376, 177);
            propertiesText.TabIndex = 3;
            propertiesText.Text = "/W\r\nC:\\certificates\\README";
            //
            // cleanLabel
            //
            cleanLabel.AutoSize = true;
            cleanLabel.Dock = DockStyle.Top;
            cleanLabel.Location = new Point(2, 40);
            cleanLabel.Margin = new Padding(2, 0, 2, 0);
            cleanLabel.Name = "cleanLabel";
            cleanLabel.Size = new Size(251, 15);
            cleanLabel.TabIndex = 1;
            cleanLabel.Text = "Parameters passed to executable (one per line)";
            //
            // commandPathText
            //
            commandPathText.Dock = DockStyle.Top;
            commandPathText.Location = new Point(2, 17);
            commandPathText.Margin = new Padding(2, 2, 2, 2);
            commandPathText.Name = "commandPathText";
            commandPathText.Size = new Size(376, 23);
            commandPathText.TabIndex = 2;
            commandPathText.Text = "notepad";
            //
            // labelEnsure
            //
            labelEnsure.AutoSize = true;
            labelEnsure.Dock = DockStyle.Top;
            labelEnsure.Location = new Point(2, 2);
            labelEnsure.Margin = new Padding(2, 0, 2, 0);
            labelEnsure.Name = "labelEnsure";
            labelEnsure.Size = new Size(104, 15);
            labelEnsure.TabIndex = 0;
            labelEnsure.Text = "Path to executable";
            //
            // CommandTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(propertiesText);
            Controls.Add(cleanLabel);
            Controls.Add(commandPathText);
            Controls.Add(labelEnsure);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CommandTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(380, 234);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox propertiesText;
        private Label cleanLabel;
        public TextBox commandPathText;
        private Label labelEnsure;
    }
}
