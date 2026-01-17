namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class SitecoreUrlTask
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
            passwordInput = new LabeledTextbox();
            usernameInput = new LabeledTextbox();
            pathInput = new LabeledTextbox();
            button1 = new Button();
            urlInput = new LabeledTextbox();
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
            tabControl1.Size = new Size(733, 719);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(passwordInput);
            tabPage1.Controls.Add(usernameInput);
            tabPage1.Controls.Add(pathInput);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(urlInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(725, 683);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "URL";
            tabPage1.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(2614, 109);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
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
            // SitecoreUrlTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "SitecoreUrlTask";
            Size = new Size(733, 719);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox passwordInput;
        private LabeledTextbox usernameInput;
        private LabeledTextbox pathInput;
        private Button button1;
        private LabeledTextbox urlInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
