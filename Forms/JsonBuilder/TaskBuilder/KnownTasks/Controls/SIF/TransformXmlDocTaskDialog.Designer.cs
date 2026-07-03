namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class TransformXmlDocTaskDialog
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
            xPathInput = new LabeledTextbox();
            filePathInput = new LabeledTextbox();
            SuspendLayout();
            //
            // xPathInput
            //
            xPathInput.Dock = DockStyle.Top;
            xPathInput.Location = new Point(3, 59);
            xPathInput.Multiline = false;
            xPathInput.Name = "xPathInput";
            xPathInput.PathSelectionFilter = "";
            xPathInput.PathSelectMode = PathSelectMode.Folder;
            xPathInput.ShowPathSelector = true;
            xPathInput.Size = new Size(698, 57);
            xPathInput.TabIndex = 7;
            xPathInput.TextInput = "";
            xPathInput.TextLabel = "Xdt Directory *";
            xPathInput.Vertical = true;
            //
            // filePathInput
            //
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(3, 3);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectionFilter = "";
            filePathInput.PathSelectMode = PathSelectMode.Folder;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(698, 56);
            filePathInput.TabIndex = 0;
            filePathInput.TextInput = "";
            filePathInput.TextLabel = "Root Directory Path *";
            filePathInput.Vertical = true;
            //
            // TransformXmlDocTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(xPathInput);
            Controls.Add(filePathInput);
            Name = "TransformXmlDocTaskDialog";
            Padding = new Padding(3);
            Size = new Size(704, 615);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox xPathInput;
        public LabeledTextbox filePathInput;
    }
}
