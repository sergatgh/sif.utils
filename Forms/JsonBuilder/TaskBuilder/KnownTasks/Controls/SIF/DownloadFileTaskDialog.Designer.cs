namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class DownloadFileTaskDialog
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
            hashComboBox = new ComboBox();
            label1 = new Label();
            hashInput = new LabeledTextbox();
            destinationPathInput = new LabeledTextbox();
            sourceTextInput = new LabeledTextbox();
            SuspendLayout();
            //
            // hashComboBox
            //
            hashComboBox.Dock = DockStyle.Top;
            hashComboBox.FormattingEnabled = true;
            hashComboBox.Items.AddRange(new object[] { "MACTripleDES", "MD5", "RIPEMD160", "SHA1", "SHA256", "SHA384", "SHA512" });
            hashComboBox.Location = new Point(2, 130);
            hashComboBox.Margin = new Padding(2, 2, 2, 2);
            hashComboBox.Name = "hashComboBox";
            hashComboBox.Size = new Size(536, 23);
            hashComboBox.TabIndex = 4;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 115);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Hash Algorithm";
            //
            // hashInput
            //
            hashInput.Dock = DockStyle.Top;
            hashInput.Location = new Point(2, 78);
            hashInput.Margin = new Padding(2, 1, 2, 1);
            hashInput.Multiline = false;
            hashInput.Name = "hashInput";
            hashInput.PathSelectionFilter = "";
            hashInput.PathSelectMode = PathSelectMode.Folder;
            hashInput.ShowPathSelector = false;
            hashInput.Size = new Size(536, 37);
            hashInput.TabIndex = 2;
            hashInput.TextInput = "";
            hashInput.TextLabel = "Hash";
            hashInput.Vertical = true;
            //
            // destinationPathInput
            //
            destinationPathInput.Dock = DockStyle.Top;
            destinationPathInput.Location = new Point(2, 41);
            destinationPathInput.Margin = new Padding(2, 1, 2, 1);
            destinationPathInput.Multiline = false;
            destinationPathInput.Name = "destinationPathInput";
            destinationPathInput.PathSelectionFilter = "";
            destinationPathInput.PathSelectMode = PathSelectMode.Folder;
            destinationPathInput.ShowPathSelector = true;
            destinationPathInput.Size = new Size(536, 37);
            destinationPathInput.TabIndex = 1;
            destinationPathInput.TextInput = "C:\\test\\WebDeploy_x86_en-US.msi";
            destinationPathInput.TextLabel = "Destination Path * (PowerShell < 7.4 requires a file name, not just a folder)";
            destinationPathInput.Vertical = true;
            //
            // sourceTextInput
            //
            sourceTextInput.Dock = DockStyle.Top;
            sourceTextInput.Location = new Point(2, 2);
            sourceTextInput.Margin = new Padding(2, 1, 2, 1);
            sourceTextInput.Multiline = false;
            sourceTextInput.Name = "sourceTextInput";
            sourceTextInput.PathSelectionFilter = "";
            sourceTextInput.PathSelectMode = PathSelectMode.Folder;
            sourceTextInput.ShowPathSelector = false;
            sourceTextInput.Size = new Size(536, 39);
            sourceTextInput.TabIndex = 0;
            sourceTextInput.TextInput = "https://download.microsoft.com/download/b/d/8/bd882ec4-12e0-481a-9b32-0fae8e3c0b78/WebDeploy_x86_en-US.msi";
            sourceTextInput.TextLabel = "Source URI *";
            sourceTextInput.Vertical = true;
            //
            // DownloadFileTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(hashComboBox);
            Controls.Add(label1);
            Controls.Add(hashInput);
            Controls.Add(destinationPathInput);
            Controls.Add(sourceTextInput);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DownloadFileTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(540, 366);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox hashComboBox;
        private Label label1;
        public LabeledTextbox hashInput;
        public LabeledTextbox destinationPathInput;
        public LabeledTextbox sourceTextInput;
    }
}
