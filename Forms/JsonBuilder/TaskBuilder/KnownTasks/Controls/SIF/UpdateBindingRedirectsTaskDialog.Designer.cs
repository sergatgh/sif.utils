namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class UpdateBindingRedirectsTaskDialog
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
            configsFolder = new LabeledTextbox();
            binFolder = new LabeledTextbox();
            siteFolder = new LabeledTextbox();
            SuspendLayout();
            //
            // configsFolder
            //
            configsFolder.Dock = DockStyle.Fill;
            configsFolder.Location = new Point(3, 115);
            configsFolder.Multiline = true;
            configsFolder.Name = "configsFolder";
            configsFolder.PathSelectionFilter = "";
            configsFolder.PathSelectMode = PathSelectMode.Folder;
            configsFolder.ShowPathSelector = false;
            configsFolder.Size = new Size(732, 553);
            configsFolder.TabIndex = 7;
            configsFolder.TextInput = "";
            configsFolder.TextLabel = "Config Files To Patch (one per line)";
            configsFolder.Vertical = true;
            //
            // binFolder
            //
            binFolder.Dock = DockStyle.Top;
            binFolder.Location = new Point(3, 59);
            binFolder.Multiline = false;
            binFolder.Name = "binFolder";
            binFolder.PathSelectionFilter = "";
            binFolder.PathSelectMode = PathSelectMode.Folder;
            binFolder.ShowPathSelector = true;
            binFolder.Size = new Size(732, 56);
            binFolder.TabIndex = 8;
            binFolder.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Data\\jobs\\continuous\\ProcessingEngine";
            binFolder.TextLabel = "Binaries Folder";
            binFolder.Vertical = true;
            //
            // siteFolder
            //
            siteFolder.Dock = DockStyle.Top;
            siteFolder.Location = new Point(3, 3);
            siteFolder.Multiline = false;
            siteFolder.Name = "siteFolder";
            siteFolder.PathSelectionFilter = "";
            siteFolder.PathSelectMode = PathSelectMode.Folder;
            siteFolder.ShowPathSelector = true;
            siteFolder.Size = new Size(732, 56);
            siteFolder.TabIndex = 0;
            siteFolder.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Data\\jobs\\continuous\\ProcessingEngine";
            siteFolder.TextLabel = "Site Path *";
            siteFolder.Vertical = true;
            //
            // UpdateBindingRedirectsTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(configsFolder);
            Controls.Add(binFolder);
            Controls.Add(siteFolder);
            Name = "UpdateBindingRedirectsTaskDialog";
            Padding = new Padding(3);
            Size = new Size(738, 671);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox configsFolder;
        public LabeledTextbox binFolder;
        public LabeledTextbox siteFolder;
    }
}
