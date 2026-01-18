namespace SIF.Utils
{
    using SIF.Utils.JsonParser;

    partial class SifJsonParsingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifJsonParsingForm));
            openFileForViewerDialog = new OpenFileDialog();
            MainSelectFilePanel = new Panel();
            label1 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            createPsScriptLabel = new Label();
            viewJsonLabel = new Label();
            welcomeWhatDoWeDo = new Label();
            welcomeLabel = new Label();
            sifJsonParameterModelBindingSource = new BindingSource(components);
            MainChooseExportFormat = new Panel();
            scriptToExport = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            exportToFileProperties = new Label();
            copyToClipboardProperties = new Label();
            executeInShell = new Label();
            MainNavigation = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            homeNavigationButton = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            backFromExport = new Button();
            navigationLabel = new Label();
            MainFileParsingError = new Panel();
            documentText = new TextBox();
            errorDescription = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            label2 = new Label();
            MainJsonBuilder = new SIF.Utils.Forms.JsonBuilder.JsonBuilderForm();
            MainJsonViewer = new SIF.Utils.Forms.JsonViewer.SifJsonViewerForm();
            MainScriptRunnerForm = new SIF.Utils.Forms.ScriptRunner.ScriptRunnerForm();
            scriptOptionsToolStripMenuItem = new ToolStripMenuItem();
            errorActionDropdown = new ToolStripComboBox();
            inlineParametersOption = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            includeUninstallOption = new ToolStripMenuItem();
            includeVerboseOption = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            scriptMenu = new MenuStrip();
            MainSelectFilePanel.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).BeginInit();
            MainChooseExportFormat.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            MainNavigation.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            MainFileParsingError.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            scriptMenu.SuspendLayout();
            SuspendLayout();
            // 
            // openFileForViewerDialog
            // 
            openFileForViewerDialog.AddToRecent = false;
            openFileForViewerDialog.DefaultExt = "json";
            openFileForViewerDialog.Filter = "SIF JSON|*.json";
            openFileForViewerDialog.ReadOnlyChecked = true;
            openFileForViewerDialog.RestoreDirectory = true;
            // 
            // MainSelectFilePanel
            // 
            MainSelectFilePanel.Controls.Add(label1);
            MainSelectFilePanel.Controls.Add(flowLayoutPanel7);
            MainSelectFilePanel.Controls.Add(createPsScriptLabel);
            MainSelectFilePanel.Controls.Add(viewJsonLabel);
            MainSelectFilePanel.Controls.Add(welcomeWhatDoWeDo);
            MainSelectFilePanel.Controls.Add(welcomeLabel);
            MainSelectFilePanel.Dock = DockStyle.Fill;
            MainSelectFilePanel.Location = new Point(0, 0);
            MainSelectFilePanel.Name = "MainSelectFilePanel";
            MainSelectFilePanel.Size = new Size(800, 450);
            MainSelectFilePanel.TabIndex = 1;
            MainSelectFilePanel.Visible = false;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(0, 290);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(800, 75);
            label1.TabIndex = 8;
            label1.Text = "👉 SIF Builder";
            label1.Click += label1_Click;
            label1.MouseLeave += labelButton_MouseLeave;
            label1.MouseHover += labelButton_MouseHover;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(button3);
            flowLayoutPanel7.Controls.Add(button4);
            flowLayoutPanel7.Dock = DockStyle.Bottom;
            flowLayoutPanel7.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel7.Location = new Point(0, 382);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(800, 68);
            flowLayoutPanel7.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(643, 3);
            button3.Name = "button3";
            button3.Size = new Size(154, 57);
            button3.TabIndex = 6;
            button3.Text = "🕵️ Credits";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(459, 3);
            button4.Name = "button4";
            button4.Size = new Size(178, 57);
            button4.TabIndex = 7;
            button4.Text = "📖 Learn SIF";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // createPsScriptLabel
            // 
            createPsScriptLabel.Cursor = Cursors.Hand;
            createPsScriptLabel.Dock = DockStyle.Top;
            createPsScriptLabel.Font = new Font("Segoe UI", 15F);
            createPsScriptLabel.Location = new Point(0, 215);
            createPsScriptLabel.Name = "createPsScriptLabel";
            createPsScriptLabel.Padding = new Padding(20);
            createPsScriptLabel.Size = new Size(800, 75);
            createPsScriptLabel.TabIndex = 5;
            createPsScriptLabel.Text = "👉 Run SIF Script";
            createPsScriptLabel.Click += customFileOpenDialog_Click;
            createPsScriptLabel.MouseLeave += labelButton_MouseLeave;
            createPsScriptLabel.MouseHover += labelButton_MouseHover;
            // 
            // viewJsonLabel
            // 
            viewJsonLabel.Cursor = Cursors.Hand;
            viewJsonLabel.Dock = DockStyle.Top;
            viewJsonLabel.Font = new Font("Segoe UI", 15F);
            viewJsonLabel.Location = new Point(0, 140);
            viewJsonLabel.Name = "viewJsonLabel";
            viewJsonLabel.Padding = new Padding(20);
            viewJsonLabel.Size = new Size(800, 75);
            viewJsonLabel.TabIndex = 4;
            viewJsonLabel.Text = "👉 View JSON File";
            viewJsonLabel.Click += openFileDialog_Click;
            viewJsonLabel.MouseLeave += labelButton_MouseLeave;
            viewJsonLabel.MouseHover += labelButton_MouseHover;
            // 
            // welcomeWhatDoWeDo
            // 
            welcomeWhatDoWeDo.Dock = DockStyle.Top;
            welcomeWhatDoWeDo.Font = new Font("Segoe UI", 18F);
            welcomeWhatDoWeDo.Location = new Point(0, 94);
            welcomeWhatDoWeDo.Name = "welcomeWhatDoWeDo";
            welcomeWhatDoWeDo.Size = new Size(800, 46);
            welcomeWhatDoWeDo.TabIndex = 1;
            welcomeWhatDoWeDo.Text = "What would you like to do?";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Dock = DockStyle.Top;
            welcomeLabel.Font = new Font("Open Sans", 32F, FontStyle.Bold);
            welcomeLabel.Location = new Point(0, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(800, 94);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to SIF Utils";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sifJsonParameterModelBindingSource
            // 
            sifJsonParameterModelBindingSource.DataSource = typeof(SifJsonParameterModel);
            // 
            // MainChooseExportFormat
            // 
            MainChooseExportFormat.Controls.Add(scriptToExport);
            MainChooseExportFormat.Controls.Add(scriptMenu);
            MainChooseExportFormat.Controls.Add(flowLayoutPanel2);
            MainChooseExportFormat.Controls.Add(MainNavigation);
            MainChooseExportFormat.Dock = DockStyle.Fill;
            MainChooseExportFormat.Location = new Point(0, 0);
            MainChooseExportFormat.Name = "MainChooseExportFormat";
            MainChooseExportFormat.Size = new Size(800, 450);
            MainChooseExportFormat.TabIndex = 3;
            // 
            // scriptToExport
            // 
            scriptToExport.Dock = DockStyle.Fill;
            scriptToExport.Location = new Point(0, 107);
            scriptToExport.Multiline = true;
            scriptToExport.Name = "scriptToExport";
            scriptToExport.ScrollBars = ScrollBars.Vertical;
            scriptToExport.Size = new Size(800, 269);
            scriptToExport.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(exportToFileProperties);
            flowLayoutPanel2.Controls.Add(copyToClipboardProperties);
            flowLayoutPanel2.Controls.Add(executeInShell);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 376);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 74);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // exportToFileProperties
            // 
            exportToFileProperties.AutoSize = true;
            exportToFileProperties.Cursor = Cursors.Hand;
            exportToFileProperties.Font = new Font("Segoe UI", 14F);
            exportToFileProperties.ForeColor = SystemColors.ControlText;
            exportToFileProperties.Location = new Point(3, 0);
            exportToFileProperties.Name = "exportToFileProperties";
            exportToFileProperties.Padding = new Padding(20);
            exportToFileProperties.Size = new Size(230, 72);
            exportToFileProperties.TabIndex = 7;
            exportToFileProperties.Text = "📄 Export to file";
            exportToFileProperties.MouseLeave += labelButton_MouseLeave;
            exportToFileProperties.MouseHover += labelButton_MouseHover;
            // 
            // copyToClipboardProperties
            // 
            copyToClipboardProperties.AutoSize = true;
            copyToClipboardProperties.Cursor = Cursors.Hand;
            copyToClipboardProperties.Font = new Font("Segoe UI", 14F);
            copyToClipboardProperties.Location = new Point(239, 0);
            copyToClipboardProperties.Name = "copyToClipboardProperties";
            copyToClipboardProperties.Padding = new Padding(20);
            copyToClipboardProperties.Size = new Size(288, 72);
            copyToClipboardProperties.TabIndex = 8;
            copyToClipboardProperties.Text = "📋 Copy to Clipboard";
            copyToClipboardProperties.Click += copyToClipboardProperties_Click;
            copyToClipboardProperties.MouseLeave += labelButton_MouseLeave;
            copyToClipboardProperties.MouseHover += labelButton_MouseHover;
            // 
            // executeInShell
            // 
            executeInShell.AutoSize = true;
            executeInShell.Cursor = Cursors.Hand;
            executeInShell.Font = new Font("Segoe UI", 14F);
            executeInShell.Location = new Point(533, 0);
            executeInShell.Name = "executeInShell";
            executeInShell.Padding = new Padding(20);
            executeInShell.Size = new Size(250, 72);
            executeInShell.TabIndex = 12;
            executeInShell.Text = "▶️ Execute in Shell";
            executeInShell.Click += executeScriptInPowershell_Click;
            // 
            // MainNavigation
            // 
            MainNavigation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainNavigation.Controls.Add(flowLayoutPanel4);
            MainNavigation.Controls.Add(flowLayoutPanel3);
            MainNavigation.Dock = DockStyle.Top;
            MainNavigation.Location = new Point(0, 0);
            MainNavigation.Name = "MainNavigation";
            MainNavigation.Size = new Size(800, 76);
            MainNavigation.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(homeNavigationButton);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(513, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10);
            flowLayoutPanel4.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel4.Size = new Size(287, 76);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // homeNavigationButton
            // 
            homeNavigationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            homeNavigationButton.BackColor = Color.Transparent;
            homeNavigationButton.Font = new Font("Segoe UI", 22F);
            homeNavigationButton.Location = new Point(194, 10);
            homeNavigationButton.Margin = new Padding(0);
            homeNavigationButton.Name = "homeNavigationButton";
            homeNavigationButton.Size = new Size(73, 56);
            homeNavigationButton.TabIndex = 2;
            homeNavigationButton.Text = "🏠";
            homeNavigationButton.UseVisualStyleBackColor = false;
            homeNavigationButton.Click += label3_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(backFromExport);
            flowLayoutPanel3.Controls.Add(navigationLabel);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(513, 76);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // backFromExport
            // 
            backFromExport.BackColor = Color.Transparent;
            backFromExport.Font = new Font("Segoe UI", 22F);
            backFromExport.Location = new Point(10, 10);
            backFromExport.Margin = new Padding(0);
            backFromExport.Name = "backFromExport";
            backFromExport.Size = new Size(73, 56);
            backFromExport.TabIndex = 0;
            backFromExport.Text = "<";
            backFromExport.UseVisualStyleBackColor = false;
            backFromExport.Click += backFromExport_Click;
            // 
            // navigationLabel
            // 
            navigationLabel.Font = new Font("Segoe UI", 24F);
            navigationLabel.Location = new Point(86, 10);
            navigationLabel.Name = "navigationLabel";
            navigationLabel.Size = new Size(408, 54);
            navigationLabel.TabIndex = 1;
            navigationLabel.Text = "Choose export option";
            // 
            // MainFileParsingError
            // 
            MainFileParsingError.Controls.Add(documentText);
            MainFileParsingError.Controls.Add(errorDescription);
            MainFileParsingError.Controls.Add(flowLayoutPanel1);
            MainFileParsingError.Dock = DockStyle.Fill;
            MainFileParsingError.Location = new Point(0, 0);
            MainFileParsingError.Name = "MainFileParsingError";
            MainFileParsingError.Size = new Size(800, 450);
            MainFileParsingError.TabIndex = 6;
            // 
            // documentText
            // 
            documentText.Dock = DockStyle.Fill;
            documentText.Location = new Point(0, 179);
            documentText.Multiline = true;
            documentText.Name = "documentText";
            documentText.ReadOnly = true;
            documentText.Size = new Size(800, 271);
            documentText.TabIndex = 4;
            // 
            // errorDescription
            // 
            errorDescription.AutoEllipsis = true;
            errorDescription.Dock = DockStyle.Top;
            errorDescription.Font = new Font("Segoe UI", 18F);
            errorDescription.Location = new Point(0, 76);
            errorDescription.Name = "errorDescription";
            errorDescription.Size = new Size(800, 103);
            errorDescription.TabIndex = 3;
            errorDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla accumsan nisl et sem pretium, nec ex.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(800, 76);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(10, 10);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(73, 56);
            button1.TabIndex = 0;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += backFromPropertiesButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(86, 10);
            label2.Name = "label2";
            label2.Size = new Size(248, 54);
            label2.TabIndex = 1;
            label2.Text = "Parsing Error";
            // 
            // MainJsonBuilder
            // 
            MainJsonBuilder.Dock = DockStyle.Fill;
            MainJsonBuilder.Location = new Point(0, 0);
            MainJsonBuilder.Name = "MainJsonBuilder";
            MainJsonBuilder.Size = new Size(800, 450);
            MainJsonBuilder.TabIndex = 5;
            MainJsonBuilder.BackClicked += back_Click;
            // 
            // MainJsonViewer
            // 
            MainJsonViewer.Dock = DockStyle.Fill;
            MainJsonViewer.Location = new Point(0, 0);
            MainJsonViewer.Name = "MainJsonViewer";
            MainJsonViewer.Size = new Size(800, 450);
            MainJsonViewer.TabIndex = 4;
            MainJsonViewer.OnPlay += MainJsonViewer_OnPlay;
            MainJsonViewer.OnExecuteTasks += executeToolStripMenuItem_Click;
            MainJsonViewer.BackClicked += back_Click;
            // 
            // MainScriptRunnerForm
            // 
            MainScriptRunnerForm.Dock = DockStyle.Fill;
            MainScriptRunnerForm.Location = new Point(0, 0);
            MainScriptRunnerForm.Name = "MainScriptRunnerForm";
            MainScriptRunnerForm.Size = new Size(800, 450);
            MainScriptRunnerForm.TabIndex = 9;
            MainScriptRunnerForm.ExecuteClicked += MainScriptRunnerForm_ExecuteClicked;
            MainScriptRunnerForm.RefreshClicked += MainScriptRunnerForm_RefreshClicked;
            MainScriptRunnerForm.BackClicked += back_Click;
            // 
            // scriptOptionsToolStripMenuItem
            // 
            scriptOptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { errorActionDropdown, inlineParametersOption, optionsToolStripMenuItem });
            scriptOptionsToolStripMenuItem.Name = "scriptOptionsToolStripMenuItem";
            scriptOptionsToolStripMenuItem.Size = new Size(84, 27);
            scriptOptionsToolStripMenuItem.Text = "Options";
            // 
            // errorActionDropdown
            // 
            errorActionDropdown.Items.AddRange(new object[] { "Break", "Continue", "Ignore", "Inquire", "SilentlyContinue", "Stop", "Suspend" });
            errorActionDropdown.Name = "errorActionDropdown";
            errorActionDropdown.Size = new Size(121, 31);
            errorActionDropdown.Text = "Error Action";
            errorActionDropdown.SelectedIndexChanged += errorActionDropdown_SelectedIndexChanged;
            // 
            // inlineParametersOption
            // 
            inlineParametersOption.Checked = true;
            inlineParametersOption.CheckOnClick = true;
            inlineParametersOption.CheckState = CheckState.Checked;
            inlineParametersOption.Name = "inlineParametersOption";
            inlineParametersOption.Size = new Size(195, 28);
            inlineParametersOption.Text = "Inline Script";
            inlineParametersOption.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { includeUninstallOption, includeVerboseOption });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(195, 28);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // includeUninstallOption
            // 
            includeUninstallOption.CheckOnClick = true;
            includeUninstallOption.Name = "includeUninstallOption";
            includeUninstallOption.Size = new Size(160, 28);
            includeUninstallOption.Text = "Uninstall";
            includeUninstallOption.CheckedChanged += includeUninstallOption_CheckedChanged;
            // 
            // includeVerboseOption
            // 
            includeVerboseOption.CheckOnClick = true;
            includeVerboseOption.Name = "includeVerboseOption";
            includeVerboseOption.Size = new Size(160, 28);
            includeVerboseOption.Text = "Verbose";
            includeVerboseOption.Click += verboseToolStripMenuItem_Click;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(62, 27);
            tasksToolStripMenuItem.Text = "Tasks";
            // 
            // scriptMenu
            // 
            scriptMenu.ImageScalingSize = new Size(20, 20);
            scriptMenu.Items.AddRange(new ToolStripItem[] { scriptOptionsToolStripMenuItem, tasksToolStripMenuItem });
            scriptMenu.Location = new Point(0, 76);
            scriptMenu.Name = "scriptMenu";
            scriptMenu.Size = new Size(800, 31);
            scriptMenu.TabIndex = 5;
            scriptMenu.Text = "menuStrip1";
            // 
            // SifJsonParsingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainChooseExportFormat);
            Controls.Add(MainScriptRunnerForm);
            Controls.Add(MainJsonViewer);
            Controls.Add(MainJsonBuilder);
            Controls.Add(MainFileParsingError);
            Controls.Add(MainSelectFilePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SifJsonParsingForm";
            Text = "SIF Utils";
            Load += SifJsonParsingForm_Load;
            KeyDown += Form1_KeyDown;
            MainSelectFilePanel.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).EndInit();
            MainChooseExportFormat.ResumeLayout(false);
            MainChooseExportFormat.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            MainNavigation.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            MainFileParsingError.ResumeLayout(false);
            MainFileParsingError.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            scriptMenu.ResumeLayout(false);
            scriptMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileForViewerDialog;
        internal Panel MainSelectFilePanel;
        private Label welcomeLabel;
        private Label welcomeWhatDoWeDo;
        private Label viewJsonLabel;
        private Label createPsScriptLabel;
        private Panel MainNavigation;
        private Button backFromExport;
        private Label copyToClipboardProperties;
        private Label exportToFileProperties;
        internal Panel MainChooseExportFormat;
        internal TextBox scriptToExport;
        internal Label navigationLabel;
        internal Button homeNavigationButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label label2;
        internal TextBox documentText;
        internal Panel MainFileParsingError;
        internal Label errorDescription;
        private Label executeInShell;
        private BindingSource sifJsonParameterModelBindingSource;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button button3;
        private Button button4;
        private Label label1;
        internal Forms.JsonBuilder.JsonBuilderForm MainJsonBuilder;
        internal Forms.JsonViewer.SifJsonViewerForm MainJsonViewer;
        internal Forms.ScriptRunner.ScriptRunnerForm MainScriptRunnerForm;
        private MenuStrip scriptMenu;
        internal ToolStripMenuItem scriptOptionsToolStripMenuItem;
        internal ToolStripComboBox errorActionDropdown;
        internal ToolStripMenuItem inlineParametersOption;
        private ToolStripMenuItem optionsToolStripMenuItem;
        internal ToolStripMenuItem includeUninstallOption;
        internal ToolStripMenuItem includeVerboseOption;
        internal ToolStripMenuItem tasksToolStripMenuItem;
    }
}
