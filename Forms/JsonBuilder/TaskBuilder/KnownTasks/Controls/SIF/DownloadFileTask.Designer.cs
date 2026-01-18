namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class DownloadFileTask
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            hashComboBox = new ComboBox();
            label1 = new Label();
            hashInput = new LabeledTextbox();
            destinationPathInput = new LabeledTextbox();
            sourceTextInput = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(705, 604);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(hashComboBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(hashInput);
            tabPage1.Controls.Add(destinationPathInput);
            tabPage1.Controls.Add(sourceTextInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(697, 568);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Download";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // hashComboBox
            // 
            hashComboBox.Dock = DockStyle.Top;
            hashComboBox.FormattingEnabled = true;
            hashComboBox.Items.AddRange(new object[] { "MACTripleDES", "MD5", "RIPEMD160", "SHA1", "SHA256", "SHA384", "SHA512" });
            hashComboBox.Location = new Point(3, 198);
            hashComboBox.Name = "hashComboBox";
            hashComboBox.Size = new Size(691, 31);
            hashComboBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 175);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 3;
            label1.Text = "Hash Algorithm";
            // 
            // hashInput
            // 
            hashInput.Dock = DockStyle.Top;
            hashInput.Location = new Point(3, 119);
            hashInput.Multiline = false;
            hashInput.Name = "hashInput";
            hashInput.PathSelectMode = PathSelectMode.Folder;
            hashInput.ShowPathSelector = false;
            hashInput.Size = new Size(691, 56);
            hashInput.TabIndex = 2;
            hashInput.TextInput = "";
            hashInput.TextLabel = "Hash";
            hashInput.Vertical = true;
            // 
            // destinationPathInput
            // 
            destinationPathInput.Dock = DockStyle.Top;
            destinationPathInput.Location = new Point(3, 63);
            destinationPathInput.Multiline = false;
            destinationPathInput.Name = "destinationPathInput";
            destinationPathInput.PathSelectMode = PathSelectMode.Folder;
            destinationPathInput.ShowPathSelector = true;
            destinationPathInput.Size = new Size(691, 56);
            destinationPathInput.TabIndex = 1;
            destinationPathInput.TextInput = "C:\\test\\WebDeploy_x86_en-US.msi";
            destinationPathInput.TextLabel = "Destination Path * (PowerShell < 7.4 requires a file name, not just a folder)";
            destinationPathInput.Vertical = true;
            // 
            // sourceTextInput
            // 
            sourceTextInput.Dock = DockStyle.Top;
            sourceTextInput.Location = new Point(3, 3);
            sourceTextInput.Multiline = false;
            sourceTextInput.Name = "sourceTextInput";
            sourceTextInput.PathSelectMode = PathSelectMode.Folder;
            sourceTextInput.ShowPathSelector = false;
            sourceTextInput.Size = new Size(691, 60);
            sourceTextInput.TabIndex = 0;
            sourceTextInput.TextInput = "https://download.microsoft.com/download/b/d/8/bd882ec4-12e0-481a-9b32-0fae8e3c0b78/WebDeploy_x86_en-US.msi";
            sourceTextInput.TextLabel = "Source URI *";
            sourceTextInput.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 64);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(3, 3);
            taskEditor1.MinimumSize = new Size(50, 50);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(186, 58);
            taskEditor1.TabIndex = 0;
            // 
            // DownloadFileTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "DownloadFileTask";
            Size = new Size(705, 604);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private ComboBox hashComboBox;
        private Label label1;
        private LabeledTextbox hashInput;
        private LabeledTextbox destinationPathInput;
        private LabeledTextbox sourceTextInput;
    }
}
