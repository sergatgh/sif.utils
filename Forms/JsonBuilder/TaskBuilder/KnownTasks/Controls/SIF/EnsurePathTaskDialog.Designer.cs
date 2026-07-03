namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class EnsurePathTaskDialog
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
            labelEnsure = new Label();
            cleanLabel = new Label();
            ensureText = new TextBox();
            cleanText = new TextBox();
            SuspendLayout();
            //
            // labelEnsure
            //
            labelEnsure.AutoSize = true;
            labelEnsure.Dock = DockStyle.Top;
            labelEnsure.Location = new Point(2, 2);
            labelEnsure.Margin = new Padding(2, 0, 2, 0);
            labelEnsure.Name = "labelEnsure";
            labelEnsure.Size = new Size(119, 15);
            labelEnsure.TabIndex = 0;
            labelEnsure.Text = "Ensure (path per line)";
            //
            // cleanLabel
            //
            cleanLabel.AutoSize = true;
            cleanLabel.Dock = DockStyle.Top;
            cleanLabel.Location = new Point(2, 109);
            cleanLabel.Margin = new Padding(2, 0, 2, 0);
            cleanLabel.Name = "cleanLabel";
            cleanLabel.Size = new Size(114, 15);
            cleanLabel.TabIndex = 1;
            cleanLabel.Text = "Clean (path per line)";
            //
            // ensureText
            //
            ensureText.Dock = DockStyle.Top;
            ensureText.Location = new Point(2, 17);
            ensureText.Margin = new Padding(2, 2, 2, 2);
            ensureText.Multiline = true;
            ensureText.Name = "ensureText";
            ensureText.Size = new Size(469, 92);
            ensureText.TabIndex = 2;
            //
            // cleanText
            //
            cleanText.Dock = DockStyle.Top;
            cleanText.Location = new Point(2, 124);
            cleanText.Margin = new Padding(2, 2, 2, 2);
            cleanText.Multiline = true;
            cleanText.Name = "cleanText";
            cleanText.Size = new Size(469, 91);
            cleanText.TabIndex = 3;
            //
            // EnsurePathTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(cleanText);
            Controls.Add(cleanLabel);
            Controls.Add(ensureText);
            Controls.Add(labelEnsure);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EnsurePathTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(473, 228);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnsure;
        private Label cleanLabel;
        public TextBox ensureText;
        public TextBox cleanText;
    }
}
