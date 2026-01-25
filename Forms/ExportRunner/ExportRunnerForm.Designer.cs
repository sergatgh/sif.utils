namespace SIF.Utils.Forms.ExportRunner
{
    partial class ExportRunnerForm
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
            components = new System.ComponentModel.Container();
            navigationPanel1 = new SIF.Utils.Forms.Common.NavigationPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            exportToFileProperties = new Button();
            copyToClipboardProperties = new Button();
            executeInShell = new Button();
            homeNavigationButton = new Button();
            scriptToExport = new TextBox();
            scriptMenu = new MenuStrip();
            scriptOptionsToolStripMenuItem = new ToolStripMenuItem();
            errorActionDropdown = new ToolStripComboBox();
            inlineParametersOption = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            includeUninstallOption = new ToolStripMenuItem();
            includeVerboseOption = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            toolTipText = new ToolTip(components);
            flowLayoutPanel1.SuspendLayout();
            scriptMenu.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPanel1
            // 
            navigationPanel1.Dock = DockStyle.Top;
            navigationPanel1.Location = new Point(0, 0);
            navigationPanel1.Name = "navigationPanel1";
            navigationPanel1.Size = new Size(850, 83);
            navigationPanel1.TabIndex = 0;
            navigationPanel1.Title = "Export Options";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(exportToFileProperties);
            flowLayoutPanel1.Controls.Add(copyToClipboardProperties);
            flowLayoutPanel1.Controls.Add(executeInShell);
            flowLayoutPanel1.Controls.Add(homeNavigationButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(505, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(336, 58);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // exportToFileProperties
            // 
            exportToFileProperties.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportToFileProperties.BackColor = Color.Transparent;
            exportToFileProperties.Font = new Font("Segoe UI", 22F);
            exportToFileProperties.Location = new Point(263, 0);
            exportToFileProperties.Margin = new Padding(0);
            exportToFileProperties.Name = "exportToFileProperties";
            exportToFileProperties.Size = new Size(73, 56);
            exportToFileProperties.TabIndex = 18;
            exportToFileProperties.Text = "💾";
            exportToFileProperties.UseVisualStyleBackColor = false;
            exportToFileProperties.Click += exportToFileProperties_Click;
            // 
            // copyToClipboardProperties
            // 
            copyToClipboardProperties.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            copyToClipboardProperties.BackColor = Color.Transparent;
            copyToClipboardProperties.Font = new Font("Segoe UI", 22F);
            copyToClipboardProperties.Location = new Point(190, 0);
            copyToClipboardProperties.Margin = new Padding(0);
            copyToClipboardProperties.Name = "copyToClipboardProperties";
            copyToClipboardProperties.Size = new Size(73, 56);
            copyToClipboardProperties.TabIndex = 19;
            copyToClipboardProperties.Text = "📋";
            copyToClipboardProperties.UseVisualStyleBackColor = false;
            copyToClipboardProperties.Click += copyToClipboardProperties_Click;
            // 
            // executeInShell
            // 
            executeInShell.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            executeInShell.BackColor = Color.Transparent;
            executeInShell.Font = new Font("Segoe UI", 22F);
            executeInShell.Location = new Point(117, 0);
            executeInShell.Margin = new Padding(0);
            executeInShell.Name = "executeInShell";
            executeInShell.Size = new Size(73, 56);
            executeInShell.TabIndex = 18;
            executeInShell.Text = "▶️";
            executeInShell.UseVisualStyleBackColor = false;
            executeInShell.Click += executeInShell_Click;
            // 
            // homeNavigationButton
            // 
            homeNavigationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            homeNavigationButton.BackColor = Color.Transparent;
            homeNavigationButton.Font = new Font("Segoe UI", 22F);
            homeNavigationButton.Location = new Point(44, 0);
            homeNavigationButton.Margin = new Padding(0);
            homeNavigationButton.Name = "homeNavigationButton";
            homeNavigationButton.Size = new Size(73, 56);
            homeNavigationButton.TabIndex = 17;
            homeNavigationButton.Text = "🏠";
            homeNavigationButton.UseVisualStyleBackColor = false;
            // 
            // scriptToExport
            // 
            scriptToExport.Dock = DockStyle.Fill;
            scriptToExport.Location = new Point(0, 114);
            scriptToExport.Multiline = true;
            scriptToExport.Name = "scriptToExport";
            scriptToExport.ScrollBars = ScrollBars.Vertical;
            scriptToExport.Size = new Size(850, 592);
            scriptToExport.TabIndex = 16;
            // 
            // scriptMenu
            // 
            scriptMenu.ImageScalingSize = new Size(20, 20);
            scriptMenu.Items.AddRange(new ToolStripItem[] { scriptOptionsToolStripMenuItem, tasksToolStripMenuItem });
            scriptMenu.Location = new Point(0, 83);
            scriptMenu.Name = "scriptMenu";
            scriptMenu.Size = new Size(850, 31);
            scriptMenu.TabIndex = 13;
            scriptMenu.Text = "menuStrip1";
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
            inlineParametersOption.CheckedChanged += inlineParametersOption_CheckedChanged;
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
            includeVerboseOption.CheckedChanged += includeVerboseOption_CheckedChanged;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(62, 27);
            tasksToolStripMenuItem.Text = "Tasks";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "ps1";
            saveFileDialog1.FileName = "install-script";
            saveFileDialog1.Filter = "PowerShell files|*.ps1";
            // 
            // ExportRunnerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(scriptToExport);
            Controls.Add(scriptMenu);
            Controls.Add(navigationPanel1);
            Name = "ExportRunnerForm";
            Size = new Size(850, 706);
            flowLayoutPanel1.ResumeLayout(false);
            scriptMenu.ResumeLayout(false);
            scriptMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.NavigationPanel navigationPanel1;
        internal TextBox scriptToExport;
        private MenuStrip scriptMenu;
        internal ToolStripMenuItem scriptOptionsToolStripMenuItem;
        internal ToolStripComboBox errorActionDropdown;
        internal ToolStripMenuItem inlineParametersOption;
        private ToolStripMenuItem optionsToolStripMenuItem;
        internal ToolStripMenuItem includeUninstallOption;
        internal ToolStripMenuItem includeVerboseOption;
        internal ToolStripMenuItem tasksToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        internal Button homeNavigationButton;
        internal Button executeInShell;
        internal Button copyToClipboardProperties;
        internal Button exportToFileProperties;
        private SaveFileDialog saveFileDialog1;
        private ToolTip toolTipText;
    }
}
