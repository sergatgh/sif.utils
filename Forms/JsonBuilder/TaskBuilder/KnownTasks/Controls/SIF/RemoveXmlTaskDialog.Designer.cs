namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class RemoveXmlTaskDialog
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
            ignoreNoMatchesCheckbox = new CheckBox();
            xPathInput = new LabeledTextbox();
            filePathInput = new LabeledTextbox();
            SuspendLayout();
            //
            // ignoreNoMatchesCheckbox
            //
            ignoreNoMatchesCheckbox.AutoSize = true;
            ignoreNoMatchesCheckbox.Dock = DockStyle.Top;
            ignoreNoMatchesCheckbox.Location = new Point(3, 124);
            ignoreNoMatchesCheckbox.Name = "ignoreNoMatchesCheckbox";
            ignoreNoMatchesCheckbox.Size = new Size(721, 27);
            ignoreNoMatchesCheckbox.TabIndex = 8;
            ignoreNoMatchesCheckbox.Text = "Ignore No Matches";
            ignoreNoMatchesCheckbox.UseVisualStyleBackColor = true;
            //
            // xPathInput
            //
            xPathInput.Dock = DockStyle.Top;
            xPathInput.Location = new Point(3, 54);
            xPathInput.Multiline = false;
            xPathInput.Name = "xPathInput";
            xPathInput.PathSelectionFilter = "";
            xPathInput.PathSelectMode = PathSelectMode.Folder;
            xPathInput.ShowPathSelector = false;
            xPathInput.Size = new Size(721, 70);
            xPathInput.TabIndex = 7;
            xPathInput.TextInput = "";
            xPathInput.TextLabel = "XPath *";
            xPathInput.Vertical = true;
            //
            // filePathInput
            //
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(3, 3);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectionFilter = "";
            filePathInput.PathSelectMode = PathSelectMode.File;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(721, 51);
            filePathInput.TabIndex = 0;
            filePathInput.TextInput = "";
            filePathInput.TextLabel = "File Path *";
            filePathInput.Vertical = true;
            //
            // RemoveXmlTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(ignoreNoMatchesCheckbox);
            Controls.Add(xPathInput);
            Controls.Add(filePathInput);
            Name = "RemoveXmlTaskDialog";
            Padding = new Padding(3);
            Size = new Size(727, 689);
            ResumeLayout(false);
        }

        #endregion

        public CheckBox ignoreNoMatchesCheckbox;
        public LabeledTextbox xPathInput;
        public LabeledTextbox filePathInput;
    }
}
