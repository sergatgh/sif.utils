namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class InsertXmlTaskDialog
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
            xmlInput = new LabeledTextbox();
            xpathTextInput = new LabeledTextbox();
            filePathInput = new LabeledTextbox();
            SuspendLayout();
            //
            // xmlInput
            //
            xmlInput.Dock = DockStyle.Fill;
            xmlInput.Location = new Point(3, 119);
            xmlInput.Multiline = true;
            xmlInput.Name = "xmlInput";
            xmlInput.PathSelectMode = PathSelectMode.Folder;
            xmlInput.ShowPathSelector = false;
            xmlInput.Size = new Size(626, 404);
            xmlInput.TabIndex = 2;
            xmlInput.TextInput = "<add name=\"core\" connectionString=\"Data Source=.;Initial Catalog=sc1041_Core;User ID=coreuser;Password=b\" />";
            xmlInput.TextLabel = "XML *";
            xmlInput.Vertical = true;
            //
            // xpathTextInput
            //
            xpathTextInput.Dock = DockStyle.Top;
            xpathTextInput.Location = new Point(3, 61);
            xpathTextInput.Multiline = false;
            xpathTextInput.Name = "xpathTextInput";
            xpathTextInput.PathSelectMode = PathSelectMode.Folder;
            xpathTextInput.ShowPathSelector = false;
            xpathTextInput.Size = new Size(626, 58);
            xpathTextInput.TabIndex = 1;
            xpathTextInput.TextInput = "//connectionStrings";
            xpathTextInput.TextLabel = "XPath *";
            xpathTextInput.Vertical = true;
            //
            // filePathInput
            //
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(3, 3);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectMode = PathSelectMode.File;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(626, 58);
            filePathInput.TabIndex = 0;
            filePathInput.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config\\ConnectionStrings.config";
            filePathInput.TextLabel = "File Path *";
            filePathInput.Vertical = true;
            //
            // InsertXmlTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(xmlInput);
            Controls.Add(xpathTextInput);
            Controls.Add(filePathInput);
            Name = "InsertXmlTaskDialog";
            Padding = new Padding(3);
            Size = new Size(632, 526);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox xpathTextInput;
        public LabeledTextbox filePathInput;
        public LabeledTextbox xmlInput;
    }
}
