namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class NewSignedCertificateTaskDialog
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
            IncludePrivateKey = new CheckBox();
            passwordText = new LabeledTextbox();
            fileName = new LabeledTextbox();
            pathForCertificate = new LabeledTextbox();
            friendlyName = new LabeledTextbox();
            storeLocation = new ComboBox();
            label1 = new Label();
            dnsNameText = new LabeledTextbox();
            signerText = new LabeledTextbox();
            SuspendLayout();
            //
            // IncludePrivateKey
            //
            IncludePrivateKey.AutoSize = true;
            IncludePrivateKey.Dock = DockStyle.Top;
            IncludePrivateKey.Location = new Point(2, 258);
            IncludePrivateKey.Margin = new Padding(2, 2, 2, 2);
            IncludePrivateKey.Name = "IncludePrivateKey";
            IncludePrivateKey.Size = new Size(616, 19);
            IncludePrivateKey.TabIndex = 8;
            IncludePrivateKey.Text = "Include Private Key";
            IncludePrivateKey.UseVisualStyleBackColor = true;
            //
            // passwordText
            //
            passwordText.Dock = DockStyle.Top;
            passwordText.Location = new Point(2, 221);
            passwordText.Margin = new Padding(2, 1, 2, 1);
            passwordText.Multiline = false;
            passwordText.Name = "passwordText";
            passwordText.PathSelectionFilter = "";
            passwordText.PathSelectMode = PathSelectMode.Folder;
            passwordText.ShowPathSelector = false;
            passwordText.Size = new Size(616, 37);
            passwordText.TabIndex = 5;
            passwordText.TextInput = "";
            passwordText.TextLabel = "Password";
            passwordText.Vertical = true;
            //
            // fileName
            //
            fileName.Dock = DockStyle.Top;
            fileName.Location = new Point(2, 184);
            fileName.Margin = new Padding(2, 1, 2, 1);
            fileName.Multiline = false;
            fileName.Name = "fileName";
            fileName.PathSelectionFilter = "";
            fileName.PathSelectMode = PathSelectMode.Folder;
            fileName.ShowPathSelector = false;
            fileName.Size = new Size(616, 37);
            fileName.TabIndex = 4;
            fileName.TextInput = "sc1041-certificate";
            fileName.TextLabel = "Name";
            fileName.Vertical = true;
            //
            // pathForCertificate
            //
            pathForCertificate.Dock = DockStyle.Top;
            pathForCertificate.Location = new Point(2, 147);
            pathForCertificate.Margin = new Padding(2, 1, 2, 1);
            pathForCertificate.Multiline = false;
            pathForCertificate.Name = "pathForCertificate";
            pathForCertificate.PathSelectionFilter = "";
            pathForCertificate.PathSelectMode = PathSelectMode.Folder;
            pathForCertificate.ShowPathSelector = true;
            pathForCertificate.Size = new Size(616, 37);
            pathForCertificate.TabIndex = 3;
            pathForCertificate.TextInput = "";
            pathForCertificate.TextLabel = "Path";
            pathForCertificate.Vertical = true;
            //
            // friendlyName
            //
            friendlyName.Dock = DockStyle.Top;
            friendlyName.Location = new Point(2, 110);
            friendlyName.Margin = new Padding(2, 1, 2, 1);
            friendlyName.Multiline = false;
            friendlyName.Name = "friendlyName";
            friendlyName.PathSelectionFilter = "";
            friendlyName.PathSelectMode = PathSelectMode.Folder;
            friendlyName.ShowPathSelector = false;
            friendlyName.Size = new Size(616, 37);
            friendlyName.TabIndex = 2;
            friendlyName.TextInput = "Local Certificate for Sitecore 10.4.1";
            friendlyName.TextLabel = "Friendly Name";
            friendlyName.Vertical = true;
            //
            // storeLocation
            //
            storeLocation.Dock = DockStyle.Top;
            storeLocation.FormattingEnabled = true;
            storeLocation.Items.AddRange(new object[] { "Local Machine", "Current User" });
            storeLocation.Location = new Point(2, 87);
            storeLocation.Margin = new Padding(2, 2, 2, 2);
            storeLocation.Name = "storeLocation";
            storeLocation.Size = new Size(616, 23);
            storeLocation.TabIndex = 7;
            storeLocation.Text = "Local Machine";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 6;
            label1.Text = "Store Location";
            //
            // dnsNameText
            //
            dnsNameText.Dock = DockStyle.Top;
            dnsNameText.Location = new Point(2, 37);
            dnsNameText.Margin = new Padding(2, 1, 2, 1);
            dnsNameText.Multiline = false;
            dnsNameText.Name = "dnsNameText";
            dnsNameText.PathSelectionFilter = "";
            dnsNameText.PathSelectMode = PathSelectMode.Folder;
            dnsNameText.ShowPathSelector = false;
            dnsNameText.Size = new Size(616, 35);
            dnsNameText.TabIndex = 0;
            dnsNameText.TextInput = "sc1041.sc";
            dnsNameText.TextLabel = "DNS Name";
            dnsNameText.Vertical = true;
            //
            // signerText
            //
            signerText.Dock = DockStyle.Top;
            signerText.Location = new Point(2, 2);
            signerText.Margin = new Padding(2, 1, 2, 1);
            signerText.Multiline = false;
            signerText.Name = "signerText";
            signerText.PathSelectionFilter = "";
            signerText.PathSelectMode = PathSelectMode.Folder;
            signerText.ShowPathSelector = false;
            signerText.Size = new Size(616, 35);
            signerText.TabIndex = 9;
            signerText.TextInput = "1234567890ABCDEF00001234567890ABCDEF0000";
            signerText.TextLabel = "Signer Name or ID *";
            signerText.Vertical = true;
            //
            // NewSignedCertificateTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(IncludePrivateKey);
            Controls.Add(passwordText);
            Controls.Add(fileName);
            Controls.Add(pathForCertificate);
            Controls.Add(friendlyName);
            Controls.Add(storeLocation);
            Controls.Add(label1);
            Controls.Add(dnsNameText);
            Controls.Add(signerText);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NewSignedCertificateTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(620, 474);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public CheckBox IncludePrivateKey;
        public LabeledTextbox passwordText;
        public LabeledTextbox fileName;
        public LabeledTextbox pathForCertificate;
        public LabeledTextbox friendlyName;
        public ComboBox storeLocation;
        private Label label1;
        public LabeledTextbox dnsNameText;
        public LabeledTextbox signerText;
    }
}
