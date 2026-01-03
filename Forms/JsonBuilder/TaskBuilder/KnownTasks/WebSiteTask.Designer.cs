namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class WebSiteTask
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
            button1 = new Button();
            portInput = new LabeledTextbox();
            hostInput = new LabeledTextbox();
            appPoolInput = new LabeledTextbox();
            pathInput = new LabeledTextbox();
            nameInput = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            selectWebsiteFolder = new FolderBrowserDialog();
            ipAddressInput = new LabeledTextbox();
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
            tabControl1.Size = new Size(618, 549);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(ipAddressInput);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(portInput);
            tabPage1.Controls.Add(hostInput);
            tabPage1.Controls.Add(appPoolInput);
            tabPage1.Controls.Add(pathInput);
            tabPage1.Controls.Add(nameInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(610, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Website";
            tabPage1.UseVisualStyleBackColor = true;
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
            hostInput.KeyDown += hostInput_KeyDown;
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
            appPoolInput.KeyDown += appPoolInput_KeyDown;
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
            pathInput.KeyDown += pathInput_KeyDown;
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
            nameInput.TextChanged += nameInput_TextChanged;
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
            // WebSiteTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "WebSiteTask";
            Size = new Size(618, 549);
            Load += WebSiteTask_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox pathInput;
        private LabeledTextbox appPoolInput;
        private LabeledTextbox nameInput;
        private LabeledTextbox portInput;
        private LabeledTextbox hostInput;
        private Button button1;
        private FolderBrowserDialog selectWebsiteFolder;
        private LabeledTextbox ipAddressInput;
    }
}
