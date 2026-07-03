namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class WebSiteTaskDialog
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
            button1 = new Button();
            portInput = new LabeledTextbox();
            hostInput = new LabeledTextbox();
            appPoolInput = new LabeledTextbox();
            pathInput = new LabeledTextbox();
            nameInput = new LabeledTextbox();
            selectWebsiteFolder = new FolderBrowserDialog();
            ipAddressInput = new LabeledTextbox();
            SuspendLayout();
            //
            // button1
            //
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(571, 97);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // portInput
            //
            portInput.Dock = DockStyle.Top;
            portInput.Location = new Point(3, 283);
            portInput.Multiline = false;
            portInput.Name = "portInput";
            portInput.Size = new Size(604, 70);
            portInput.TabIndex = 4;
            portInput.TextInput = "80";
            portInput.TextLabel = "Port";
            portInput.Vertical = true;
            //
            // hostInput
            //
            hostInput.Dock = DockStyle.Top;
            hostInput.Location = new Point(3, 213);
            hostInput.Multiline = false;
            hostInput.Name = "hostInput";
            hostInput.Size = new Size(604, 70);
            hostInput.TabIndex = 3;
            hostInput.TextInput = "sc10.local";
            hostInput.TextLabel = "Hostname";
            hostInput.Vertical = true;
            //
            // appPoolInput
            //
            appPoolInput.Dock = DockStyle.Top;
            appPoolInput.Location = new Point(3, 143);
            appPoolInput.Multiline = false;
            appPoolInput.Name = "appPoolInput";
            appPoolInput.Size = new Size(604, 70);
            appPoolInput.TabIndex = 1;
            appPoolInput.TextInput = "sc10.local";
            appPoolInput.TextLabel = "Application Pool *";
            appPoolInput.Vertical = true;
            //
            // pathInput
            //
            pathInput.Dock = DockStyle.Top;
            pathInput.Location = new Point(3, 73);
            pathInput.Multiline = false;
            pathInput.Name = "pathInput";
            pathInput.Size = new Size(604, 70);
            pathInput.TabIndex = 2;
            pathInput.TextInput = "C:\\inetpub\\wwwroot\\sc10.local";
            pathInput.TextLabel = "Physical Path *";
            pathInput.Vertical = true;
            //
            // nameInput
            //
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(3, 3);
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(604, 70);
            nameInput.TabIndex = 0;
            nameInput.TextInput = "sc10.local";
            nameInput.TextLabel = "Name *";
            nameInput.Vertical = true;
            //
            // selectWebsiteFolder
            //
            selectWebsiteFolder.InitialDirectory = "C:\\inetpub\\wwwroot";
            selectWebsiteFolder.RootFolder = Environment.SpecialFolder.MyDocuments;
            //
            // ipAddressInput
            //
            ipAddressInput.Dock = DockStyle.Top;
            ipAddressInput.Location = new Point(3, 353);
            ipAddressInput.Multiline = false;
            ipAddressInput.Name = "ipAddressInput";
            ipAddressInput.Size = new Size(604, 70);
            ipAddressInput.TabIndex = 6;
            ipAddressInput.TextInput = "*";
            ipAddressInput.TextLabel = "IP Address";
            ipAddressInput.Vertical = true;
            //
            // WebSiteTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(ipAddressInput);
            Controls.Add(button1);
            Controls.Add(portInput);
            Controls.Add(hostInput);
            Controls.Add(appPoolInput);
            Controls.Add(pathInput);
            Controls.Add(nameInput);
            Name = "WebSiteTaskDialog";
            Padding = new Padding(3);
            Size = new Size(610, 513);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox pathInput;
        public LabeledTextbox appPoolInput;
        public LabeledTextbox nameInput;
        public LabeledTextbox portInput;
        public LabeledTextbox hostInput;
        private Button button1;
        private FolderBrowserDialog selectWebsiteFolder;
        public LabeledTextbox ipAddressInput;
    }
}
