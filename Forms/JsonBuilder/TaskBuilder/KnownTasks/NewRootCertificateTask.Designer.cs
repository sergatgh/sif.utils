namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class NewRootCertificateTask
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
            IncludePrivateKey = new CheckBox();
            passwordText = new LabeledTextbox();
            fileName = new LabeledTextbox();
            pathForCertificate = new LabeledTextbox();
            friendlyName = new LabeledTextbox();
            storeLocation = new ComboBox();
            label1 = new Label();
            dnsNameText = new LabeledTextbox();
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
            tabControl1.Size = new Size(756, 713);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(IncludePrivateKey);
            tabPage1.Controls.Add(passwordText);
            tabPage1.Controls.Add(fileName);
            tabPage1.Controls.Add(pathForCertificate);
            tabPage1.Controls.Add(friendlyName);
            tabPage1.Controls.Add(storeLocation);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dnsNameText);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(748, 677);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Certificate";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // IncludePrivateKey
            // 
            IncludePrivateKey.AutoSize = true;
            IncludePrivateKey.Dock = DockStyle.Top;
            IncludePrivateKey.Location = new Point(3, 334);
            IncludePrivateKey.Name = "IncludePrivateKey";
            IncludePrivateKey.Size = new Size(742, 27);
            IncludePrivateKey.TabIndex = 8;
            IncludePrivateKey.Text = "Include Private Key";
            IncludePrivateKey.UseVisualStyleBackColor = true;
            // 
            // passwordText
            // 
            passwordText.Dock = DockStyle.Top;
            passwordText.Location = new Point(3, 278);
            passwordText.Multiline = false;
            passwordText.Name = "passwordText";
            passwordText.PathSelectionFilter = "";
            passwordText.PathSelectMode = PathSelectMode.Folder;
            passwordText.ShowPathSelector = false;
            passwordText.Size = new Size(742, 56);
            passwordText.TabIndex = 5;
            passwordText.TextInput = "";
            passwordText.TextLabel = "Password";
            passwordText.Vertical = true;
            // 
            // fileName
            // 
            fileName.Dock = DockStyle.Top;
            fileName.Location = new Point(3, 222);
            fileName.Multiline = false;
            fileName.Name = "fileName";
            fileName.PathSelectionFilter = "";
            fileName.PathSelectMode = PathSelectMode.Folder;
            fileName.ShowPathSelector = false;
            fileName.Size = new Size(742, 56);
            fileName.TabIndex = 4;
            fileName.TextInput = "sc1041-certificate";
            fileName.TextLabel = "Name";
            fileName.Vertical = true;
            // 
            // pathForCertificate
            // 
            pathForCertificate.Dock = DockStyle.Top;
            pathForCertificate.Location = new Point(3, 166);
            pathForCertificate.Multiline = false;
            pathForCertificate.Name = "pathForCertificate";
            pathForCertificate.PathSelectionFilter = "";
            pathForCertificate.PathSelectMode = PathSelectMode.Folder;
            pathForCertificate.ShowPathSelector = true;
            pathForCertificate.Size = new Size(742, 56);
            pathForCertificate.TabIndex = 3;
            pathForCertificate.TextInput = "";
            pathForCertificate.TextLabel = "Path";
            pathForCertificate.Vertical = true;
            // 
            // friendlyName
            // 
            friendlyName.Dock = DockStyle.Top;
            friendlyName.Location = new Point(3, 110);
            friendlyName.Multiline = false;
            friendlyName.Name = "friendlyName";
            friendlyName.PathSelectionFilter = "";
            friendlyName.PathSelectMode = PathSelectMode.Folder;
            friendlyName.ShowPathSelector = false;
            friendlyName.Size = new Size(742, 56);
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
            storeLocation.Location = new Point(3, 79);
            storeLocation.Name = "storeLocation";
            storeLocation.Size = new Size(742, 31);
            storeLocation.TabIndex = 7;
            storeLocation.Text = "Local Machine";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 56);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 6;
            label1.Text = "Store Location";
            // 
            // dnsNameText
            // 
            dnsNameText.Dock = DockStyle.Top;
            dnsNameText.Location = new Point(3, 3);
            dnsNameText.Multiline = false;
            dnsNameText.Name = "dnsNameText";
            dnsNameText.PathSelectionFilter = "";
            dnsNameText.PathSelectMode = PathSelectMode.Folder;
            dnsNameText.ShowPathSelector = false;
            dnsNameText.Size = new Size(742, 53);
            dnsNameText.TabIndex = 0;
            dnsNameText.TextInput = "sc1041.sc";
            dnsNameText.TextLabel = "DNS Name";
            dnsNameText.Vertical = true;
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
            // NewRootCertificateTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "NewRootCertificateTask";
            Size = new Size(756, 713);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox storeLocation;
        private Label label1;
        private LabeledTextbox passwordText;
        private LabeledTextbox friendlyName;
        private LabeledTextbox pathForCertificate;
        private LabeledTextbox fileName;
        private LabeledTextbox dnsNameText;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private CheckBox IncludePrivateKey;
    }
}
