namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class SitecoreUrlTaskDialog
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
            passwordInput = new LabeledTextbox();
            usernameInput = new LabeledTextbox();
            pathInput = new LabeledTextbox();
            urlInput = new LabeledTextbox();
            SuspendLayout();
            //
            // passwordInput
            //
            passwordInput.Dock = DockStyle.Top;
            passwordInput.Location = new Point(3, 160);
            passwordInput.Multiline = false;
            passwordInput.Name = "passwordInput";
            passwordInput.PathSelectionFilter = "";
            passwordInput.PathSelectMode = PathSelectMode.Folder;
            passwordInput.ShowPathSelector = false;
            passwordInput.Size = new Size(719, 53);
            passwordInput.TabIndex = 9;
            passwordInput.TextInput = "b";
            passwordInput.TextLabel = "Password *";
            passwordInput.Vertical = true;
            //
            // usernameInput
            //
            usernameInput.Dock = DockStyle.Top;
            usernameInput.Location = new Point(3, 107);
            usernameInput.Multiline = false;
            usernameInput.Name = "usernameInput";
            usernameInput.PathSelectionFilter = "";
            usernameInput.PathSelectMode = PathSelectMode.Folder;
            usernameInput.ShowPathSelector = false;
            usernameInput.Size = new Size(719, 53);
            usernameInput.TabIndex = 8;
            usernameInput.TextInput = "admin";
            usernameInput.TextLabel = "Username *";
            usernameInput.Vertical = true;
            //
            // pathInput
            //
            pathInput.Dock = DockStyle.Top;
            pathInput.Location = new Point(3, 54);
            pathInput.Multiline = false;
            pathInput.Name = "pathInput";
            pathInput.PathSelectionFilter = "";
            pathInput.PathSelectMode = PathSelectMode.Folder;
            pathInput.ShowPathSelector = false;
            pathInput.Size = new Size(719, 53);
            pathInput.TabIndex = 7;
            pathInput.TextInput = "sitecore/admin/showconfig.aspx";
            pathInput.TextLabel = "Sitecore Action Path *";
            pathInput.Vertical = true;
            //
            // urlInput
            //
            urlInput.Dock = DockStyle.Top;
            urlInput.Location = new Point(3, 3);
            urlInput.Multiline = false;
            urlInput.Name = "urlInput";
            urlInput.PathSelectionFilter = "";
            urlInput.PathSelectMode = PathSelectMode.File;
            urlInput.ShowPathSelector = false;
            urlInput.Size = new Size(719, 51);
            urlInput.TabIndex = 0;
            urlInput.TextInput = "https://sc1041.sc/";
            urlInput.TextLabel = "Sitecore Instance Root *";
            urlInput.Vertical = true;
            //
            // SitecoreUrlTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(pathInput);
            Controls.Add(urlInput);
            Name = "SitecoreUrlTaskDialog";
            Padding = new Padding(3);
            Size = new Size(725, 683);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox passwordInput;
        public LabeledTextbox usernameInput;
        public LabeledTextbox pathInput;
        public LabeledTextbox urlInput;
    }
}
