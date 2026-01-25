namespace SIF.Utils.Forms.ScriptRunner
{
    partial class ScriptRunnerForm
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
            MainChooseProperties = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            executeButton = new Button();
            reloadPropertiesButton = new Button();
            importParametersButton = new Button();
            exportParametersButton = new Button();
            propsTableForScript = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            RowAction = new DataGridViewButtonColumn();
            HasDefaultValue = new DataGridViewCheckBoxColumn();
            IsReference = new DataGridViewCheckBoxColumn();
            HasValidation = new DataGridViewCheckBoxColumn();
            controlsPanel = new Panel();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            navigationPanel = new SIF.Utils.Forms.Common.NavigationPanel();
            openSavedValues = new OpenFileDialog();
            saveParametersDialog = new SaveFileDialog();
            callActionContextMenu = new ContextMenuStrip(components);
            resetToDefaultToolStripMenuItem = new ToolStripMenuItem();
            insertPathToFolderToolStripMenuItem = new ToolStripMenuItem();
            insertFileToolStripMenuItem = new ToolStripMenuItem();
            chooseFolder = new FolderBrowserDialog();
            chooseFile = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            MainChooseProperties.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propsTableForScript).BeginInit();
            controlsPanel.SuspendLayout();
            callActionContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainChooseProperties
            // 
            MainChooseProperties.Controls.Add(flowLayoutPanel1);
            MainChooseProperties.Controls.Add(propsTableForScript);
            MainChooseProperties.Controls.Add(controlsPanel);
            MainChooseProperties.Controls.Add(navigationPanel);
            MainChooseProperties.Dock = DockStyle.Fill;
            MainChooseProperties.Location = new Point(0, 0);
            MainChooseProperties.Name = "MainChooseProperties";
            MainChooseProperties.Size = new Size(714, 676);
            MainChooseProperties.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(executeButton);
            flowLayoutPanel1.Controls.Add(reloadPropertiesButton);
            flowLayoutPanel1.Controls.Add(importParametersButton);
            flowLayoutPanel1.Controls.Add(exportParametersButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(413, 11);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(298, 59);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // executeButton
            // 
            executeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            executeButton.BackColor = Color.Transparent;
            executeButton.Font = new Font("Segoe UI", 22F);
            executeButton.Location = new Point(225, 0);
            executeButton.Margin = new Padding(0);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(73, 56);
            executeButton.TabIndex = 10;
            executeButton.Text = "▶️";
            executeButton.UseVisualStyleBackColor = false;
            executeButton.Click += executeButton_Click;
            // 
            // reloadPropertiesButton
            // 
            reloadPropertiesButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reloadPropertiesButton.BackColor = Color.Transparent;
            reloadPropertiesButton.Font = new Font("Segoe UI", 22F);
            reloadPropertiesButton.Location = new Point(152, 0);
            reloadPropertiesButton.Margin = new Padding(0);
            reloadPropertiesButton.Name = "reloadPropertiesButton";
            reloadPropertiesButton.Size = new Size(73, 56);
            reloadPropertiesButton.TabIndex = 8;
            reloadPropertiesButton.Text = "🔄️";
            reloadPropertiesButton.UseVisualStyleBackColor = false;
            reloadPropertiesButton.Click += reloadPropertiesButton_Click;
            // 
            // importParametersButton
            // 
            importParametersButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            importParametersButton.BackColor = Color.Transparent;
            importParametersButton.Font = new Font("Segoe UI", 22F);
            importParametersButton.Location = new Point(79, 0);
            importParametersButton.Margin = new Padding(0);
            importParametersButton.Name = "importParametersButton";
            importParametersButton.Size = new Size(73, 56);
            importParametersButton.TabIndex = 9;
            importParametersButton.Text = "⬇️";
            importParametersButton.UseVisualStyleBackColor = false;
            importParametersButton.Click += importParametersButton_Click;
            // 
            // exportParametersButton
            // 
            exportParametersButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportParametersButton.BackColor = Color.Transparent;
            exportParametersButton.Font = new Font("Segoe UI", 22F);
            exportParametersButton.Location = new Point(6, 0);
            exportParametersButton.Margin = new Padding(0);
            exportParametersButton.Name = "exportParametersButton";
            exportParametersButton.Size = new Size(73, 56);
            exportParametersButton.TabIndex = 11;
            exportParametersButton.Text = "⬆️";
            exportParametersButton.UseVisualStyleBackColor = false;
            exportParametersButton.Click += exportParametersButton_Click;
            // 
            // propsTableForScript
            // 
            propsTableForScript.AllowUserToAddRows = false;
            propsTableForScript.AllowUserToDeleteRows = false;
            propsTableForScript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            propsTableForScript.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, Value, RowAction, HasDefaultValue, IsReference, HasValidation });
            propsTableForScript.Dock = DockStyle.Fill;
            propsTableForScript.Location = new Point(0, 110);
            propsTableForScript.Name = "propsTableForScript";
            propsTableForScript.RowHeadersWidth = 51;
            propsTableForScript.Size = new Size(714, 566);
            propsTableForScript.TabIndex = 2;
            propsTableForScript.CellContentClick += propsTableForScript_CellContentClick;
            propsTableForScript.CellValidating += propsTableForScript_CellValidating;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            nameDataGridViewTextBoxColumn.Width = 85;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Value.DataPropertyName = "Value";
            Value.HeaderText = "Value";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            Value.SortMode = DataGridViewColumnSortMode.NotSortable;
            Value.Width = 58;
            // 
            // RowAction
            // 
            RowAction.HeaderText = "Action";
            RowAction.MinimumWidth = 6;
            RowAction.Name = "RowAction";
            RowAction.Text = "Modify";
            RowAction.UseColumnTextForButtonValue = true;
            RowAction.Width = 125;
            // 
            // HasDefaultValue
            // 
            HasDefaultValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            HasDefaultValue.DataPropertyName = "HasDefaultValue";
            HasDefaultValue.HeaderText = "Has Default";
            HasDefaultValue.MinimumWidth = 6;
            HasDefaultValue.Name = "HasDefaultValue";
            HasDefaultValue.ReadOnly = true;
            HasDefaultValue.SortMode = DataGridViewColumnSortMode.Automatic;
            HasDefaultValue.Width = 127;
            // 
            // IsReference
            // 
            IsReference.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            IsReference.DataPropertyName = "IsReference";
            IsReference.HeaderText = "Ref";
            IsReference.MinimumWidth = 6;
            IsReference.Name = "IsReference";
            IsReference.ReadOnly = true;
            IsReference.Width = 40;
            // 
            // HasValidation
            // 
            HasValidation.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            HasValidation.DataPropertyName = "HasValidation";
            HasValidation.HeaderText = "Validate";
            HasValidation.MinimumWidth = 6;
            HasValidation.Name = "HasValidation";
            HasValidation.ReadOnly = true;
            HasValidation.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // controlsPanel
            // 
            controlsPanel.Controls.Add(textBox2);
            controlsPanel.Controls.Add(checkBox1);
            controlsPanel.Dock = DockStyle.Top;
            controlsPanel.Location = new Point(0, 76);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(714, 34);
            controlsPanel.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(0, 0);
            textBox2.Margin = new Padding(3, 3, 30, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Filter";
            textBox2.Size = new Size(533, 30);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Dock = DockStyle.Right;
            checkBox1.Location = new Point(533, 0);
            checkBox1.Margin = new Padding(30, 3, 3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(10, 0, 0, 0);
            checkBox1.Size = new Size(181, 34);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Show References";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // navigationPanel
            // 
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(714, 76);
            navigationPanel.TabIndex = 6;
            navigationPanel.Title = "Set Parameters";
            // 
            // openSavedValues
            // 
            openSavedValues.AddToRecent = false;
            openSavedValues.DefaultExt = "ini";
            openSavedValues.Filter = "SIF Parameter Values|*.ini";
            openSavedValues.ReadOnlyChecked = true;
            openSavedValues.RestoreDirectory = true;
            // 
            // saveParametersDialog
            // 
            saveParametersDialog.AddToRecent = false;
            saveParametersDialog.DefaultExt = "ini";
            saveParametersDialog.FileName = "parameters";
            saveParametersDialog.Filter = "SIF Parameters|*.ini";
            saveParametersDialog.RestoreDirectory = true;
            // 
            // callActionContextMenu
            // 
            callActionContextMenu.ImageScalingSize = new Size(20, 20);
            callActionContextMenu.Items.AddRange(new ToolStripItem[] { resetToDefaultToolStripMenuItem, insertPathToFolderToolStripMenuItem, insertFileToolStripMenuItem });
            callActionContextMenu.Name = "callActionContextMenu";
            callActionContextMenu.Size = new Size(201, 88);
            // 
            // resetToDefaultToolStripMenuItem
            // 
            resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            resetToDefaultToolStripMenuItem.Size = new Size(200, 28);
            resetToDefaultToolStripMenuItem.Text = "Reset to default";
            resetToDefaultToolStripMenuItem.Click += resetToDefaultToolStripMenuItem_Click;
            // 
            // insertPathToFolderToolStripMenuItem
            // 
            insertPathToFolderToolStripMenuItem.Name = "insertPathToFolderToolStripMenuItem";
            insertPathToFolderToolStripMenuItem.Size = new Size(200, 28);
            insertPathToFolderToolStripMenuItem.Text = "Insert folder";
            insertPathToFolderToolStripMenuItem.Click += insertPathToFolderToolStripMenuItem_Click;
            // 
            // insertFileToolStripMenuItem
            // 
            insertFileToolStripMenuItem.Name = "insertFileToolStripMenuItem";
            insertFileToolStripMenuItem.Size = new Size(200, 28);
            insertFileToolStripMenuItem.Text = "Insert file";
            insertFileToolStripMenuItem.Click += insertFileToolStripMenuItem_Click;
            // 
            // chooseFolder
            // 
            chooseFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // ScriptRunnerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainChooseProperties);
            Name = "ScriptRunnerForm";
            Size = new Size(714, 676);
            MainChooseProperties.ResumeLayout(false);
            MainChooseProperties.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)propsTableForScript).EndInit();
            controlsPanel.ResumeLayout(false);
            controlsPanel.PerformLayout();
            callActionContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal Panel MainChooseProperties;
        private Common.NavigationPanel navigationPanel;
        internal DataGridView propsTableForScript;
        internal TextBox textBox2;
        internal CheckBox checkBox1;
        internal Button executeButton;
        internal Button importParametersButton;
        internal Button reloadPropertiesButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel controlsPanel;
        internal Button exportParametersButton;
        private OpenFileDialog openSavedValues;
        private SaveFileDialog saveParametersDialog;
        private ContextMenuStrip callActionContextMenu;
        private ToolStripMenuItem resetToDefaultToolStripMenuItem;
        private ToolStripMenuItem insertPathToFolderToolStripMenuItem;
        private ToolStripMenuItem insertFileToolStripMenuItem;
        private FolderBrowserDialog chooseFolder;
        private OpenFileDialog chooseFile;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewButtonColumn RowAction;
        private DataGridViewCheckBoxColumn HasDefaultValue;
        private DataGridViewCheckBoxColumn IsReference;
        private DataGridViewCheckBoxColumn HasValidation;
        private ToolTip toolTip1;
    }
}
