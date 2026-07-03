namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class IoXmlTaskDialog
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
            xpathTextInput = new LabeledTextbox();
            folderPathInput = new LabeledTextbox();
            SuspendLayout();
            //
            // xpathTextInput
            //
            xpathTextInput.Dock = DockStyle.Top;
            xpathTextInput.Location = new Point(3, 61);
            xpathTextInput.Multiline = false;
            xpathTextInput.Name = "xpathTextInput";
            xpathTextInput.PathSelectionFilter = "IOXML|*.ioxml";
            xpathTextInput.PathSelectMode = PathSelectMode.File;
            xpathTextInput.ShowPathSelector = true;
            xpathTextInput.Size = new Size(555, 58);
            xpathTextInput.TabIndex = 1;
            xpathTextInput.TextInput = "";
            xpathTextInput.TextLabel = "IO Xml Path *";
            xpathTextInput.Vertical = true;
            //
            // folderPathInput
            //
            folderPathInput.Dock = DockStyle.Top;
            folderPathInput.Location = new Point(3, 3);
            folderPathInput.Multiline = false;
            folderPathInput.Name = "folderPathInput";
            folderPathInput.PathSelectionFilter = "";
            folderPathInput.PathSelectMode = PathSelectMode.Folder;
            folderPathInput.ShowPathSelector = true;
            folderPathInput.Size = new Size(555, 58);
            folderPathInput.TabIndex = 0;
            folderPathInput.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config\\Include";
            folderPathInput.TextLabel = "Root Directory Path *";
            folderPathInput.Vertical = true;
            //
            // IoXmlTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(xpathTextInput);
            Controls.Add(folderPathInput);
            Name = "IoXmlTaskDialog";
            Padding = new Padding(3);
            Size = new Size(561, 565);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox xpathTextInput;
        public LabeledTextbox folderPathInput;
    }
}
