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
            TasksContextMenu = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            copyTaskName = new ToolStripMenuItem();
            copyTaskDescription = new ToolStripMenuItem();
            executeToolStripMenuItem = new ToolStripMenuItem();
            sifJsonParameterModelBindingSource = new BindingSource(components);
            MainCreatePowershell = new Panel();
            customFileOpenDialog = new Label();
            singleDeveloperOption = new Label();
            creatingPsNavigation = new FlowLayoutPanel();
            backFromPsCreation = new Button();
            creatingPsTitle = new Label();
            MainChooseProperties = new Panel();
            propsTableForScript = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            HasDefaultValue = new DataGridViewCheckBoxColumn();
            IsReference = new DataGridViewCheckBoxColumn();
            HasValidation = new DataGridViewCheckBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            RowAction = new DataGridViewButtonColumn();
            parameterEditModelBindingSource = new BindingSource(components);
            flowLayoutPanel10 = new FlowLayoutPanel();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            setPropsNavPanel = new Panel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            finishSettingProperties = new Button();
            setPropertiesOption = new MenuStrip();
            propertiesFileOptions = new ToolStripMenuItem();
            reloadPropertiesToolStripMenuItem = new ToolStripMenuItem();
            importParametersToolStripMenuItem = new ToolStripMenuItem();
            exportParametersToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel5 = new FlowLayoutPanel();
            backFromSettingProperties = new Button();
            letsSetPropertiesLabel = new Label();
            MainChooseExportFormat = new Panel();
            scriptToExport = new TextBox();
            scriptMenu = new MenuStrip();
            scriptOptionsToolStripMenuItem = new ToolStripMenuItem();
            errorActionDropdown = new ToolStripComboBox();
            inlineParametersOption = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            includeUninstallOption = new ToolStripMenuItem();
            includeVerboseOption = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
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
            saveParametersDialog = new SaveFileDialog();
            openSavedValues = new OpenFileDialog();
            callActionContextMenu = new ContextMenuStrip(components);
            resetToDefaultToolStripMenuItem = new ToolStripMenuItem();
            insertPathToFolderToolStripMenuItem = new ToolStripMenuItem();
            insertFileToolStripMenuItem = new ToolStripMenuItem();
            chooseFolder = new FolderBrowserDialog();
            chooseFile = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            MainJsonBuilder = new SIF.Utils.Forms.JsonBuilder.JsonBuilderForm();
            MainJsonViewer = new SIF.Utils.Forms.JsonViewer.JsonViewerForm();
            MainSelectFilePanel.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            TasksContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).BeginInit();
            MainCreatePowershell.SuspendLayout();
            creatingPsNavigation.SuspendLayout();
            MainChooseProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propsTableForScript).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parameterEditModelBindingSource).BeginInit();
            flowLayoutPanel10.SuspendLayout();
            setPropsNavPanel.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            setPropertiesOption.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            MainChooseExportFormat.SuspendLayout();
            scriptMenu.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            MainNavigation.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            MainFileParsingError.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            callActionContextMenu.SuspendLayout();
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
            // TasksContextMenu
            // 
            TasksContextMenu.ImageScalingSize = new Size(20, 20);
            TasksContextMenu.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, copyToolStripMenuItem, executeToolStripMenuItem });
            TasksContextMenu.Name = "contextMenuStrip1";
            TasksContextMenu.Size = new Size(140, 88);
            TasksContextMenu.Opening += TasksContextMenu_Opening;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(139, 28);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyTaskName, copyTaskDescription });
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(139, 28);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // copyTaskName
            // 
            copyTaskName.Name = "copyTaskName";
            copyTaskName.Size = new Size(180, 28);
            copyTaskName.Text = "Name";
            copyTaskName.Click += copyTaskName_Click;
            // 
            // copyTaskDescription
            // 
            copyTaskDescription.Name = "copyTaskDescription";
            copyTaskDescription.Size = new Size(180, 28);
            copyTaskDescription.Text = "Description";
            copyTaskDescription.Click += copyTaskDescription_Click;
            // 
            // executeToolStripMenuItem
            // 
            executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            executeToolStripMenuItem.Size = new Size(139, 28);
            executeToolStripMenuItem.Text = "Execute";
            executeToolStripMenuItem.Click += executeToolStripMenuItem_Click;
            // 
            // sifJsonParameterModelBindingSource
            // 
            sifJsonParameterModelBindingSource.DataSource = typeof(SifJsonParameterModel);
            // 
            // MainCreatePowershell
            // 
            MainCreatePowershell.Controls.Add(customFileOpenDialog);
            MainCreatePowershell.Controls.Add(singleDeveloperOption);
            MainCreatePowershell.Controls.Add(creatingPsNavigation);
            MainCreatePowershell.Dock = DockStyle.Fill;
            MainCreatePowershell.Location = new Point(0, 0);
            MainCreatePowershell.Name = "MainCreatePowershell";
            MainCreatePowershell.Size = new Size(800, 450);
            MainCreatePowershell.TabIndex = 4;
            // 
            // customFileOpenDialog
            // 
            customFileOpenDialog.Cursor = Cursors.Hand;
            customFileOpenDialog.Dock = DockStyle.Top;
            customFileOpenDialog.Font = new Font("Segoe UI", 15F);
            customFileOpenDialog.Location = new Point(0, 151);
            customFileOpenDialog.Name = "customFileOpenDialog";
            customFileOpenDialog.Padding = new Padding(20);
            customFileOpenDialog.Size = new Size(800, 75);
            customFileOpenDialog.TabIndex = 7;
            customFileOpenDialog.Text = "👉 Create for Custom Script (Open File)";
            customFileOpenDialog.Click += customFileOpenDialog_Click;
            customFileOpenDialog.MouseLeave += labelButton_MouseLeave;
            customFileOpenDialog.MouseHover += labelButton_MouseHover;
            // 
            // singleDeveloperOption
            // 
            singleDeveloperOption.Cursor = Cursors.Hand;
            singleDeveloperOption.Dock = DockStyle.Top;
            singleDeveloperOption.Font = new Font("Segoe UI", 15F);
            singleDeveloperOption.Location = new Point(0, 76);
            singleDeveloperOption.Name = "singleDeveloperOption";
            singleDeveloperOption.Padding = new Padding(20);
            singleDeveloperOption.Size = new Size(800, 75);
            singleDeveloperOption.TabIndex = 6;
            singleDeveloperOption.Text = "👉 Create For XP0-SingleDeveloper.json";
            singleDeveloperOption.Click += singleDeveloperOption_Click;
            singleDeveloperOption.MouseLeave += labelButton_MouseLeave;
            singleDeveloperOption.MouseHover += labelButton_MouseHover;
            // 
            // creatingPsNavigation
            // 
            creatingPsNavigation.AutoSize = true;
            creatingPsNavigation.Controls.Add(backFromPsCreation);
            creatingPsNavigation.Controls.Add(creatingPsTitle);
            creatingPsNavigation.Dock = DockStyle.Top;
            creatingPsNavigation.Location = new Point(0, 0);
            creatingPsNavigation.Name = "creatingPsNavigation";
            creatingPsNavigation.Padding = new Padding(10);
            creatingPsNavigation.Size = new Size(800, 76);
            creatingPsNavigation.TabIndex = 1;
            // 
            // backFromPsCreation
            // 
            backFromPsCreation.Font = new Font("Segoe UI", 22F);
            backFromPsCreation.Location = new Point(10, 10);
            backFromPsCreation.Margin = new Padding(0);
            backFromPsCreation.Name = "backFromPsCreation";
            backFromPsCreation.Size = new Size(73, 56);
            backFromPsCreation.TabIndex = 0;
            backFromPsCreation.Text = "<";
            backFromPsCreation.UseVisualStyleBackColor = true;
            backFromPsCreation.Click += backFromPsCreation_Click;
            // 
            // creatingPsTitle
            // 
            creatingPsTitle.AutoSize = true;
            creatingPsTitle.Font = new Font("Segoe UI", 24F);
            creatingPsTitle.Location = new Point(86, 10);
            creatingPsTitle.Name = "creatingPsTitle";
            creatingPsTitle.Size = new Size(562, 54);
            creatingPsTitle.TabIndex = 1;
            creatingPsTitle.Text = "Let's choose a SIF setup to run";
            // 
            // MainChooseProperties
            // 
            MainChooseProperties.Controls.Add(propsTableForScript);
            MainChooseProperties.Controls.Add(flowLayoutPanel10);
            MainChooseProperties.Controls.Add(setPropsNavPanel);
            MainChooseProperties.Dock = DockStyle.Fill;
            MainChooseProperties.Location = new Point(0, 0);
            MainChooseProperties.Name = "MainChooseProperties";
            MainChooseProperties.Size = new Size(800, 450);
            MainChooseProperties.TabIndex = 8;
            // 
            // propsTableForScript
            // 
            propsTableForScript.AllowUserToAddRows = false;
            propsTableForScript.AllowUserToDeleteRows = false;
            propsTableForScript.AutoGenerateColumns = false;
            propsTableForScript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            propsTableForScript.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, HasDefaultValue, IsReference, HasValidation, Value, RowAction });
            propsTableForScript.DataSource = parameterEditModelBindingSource;
            propsTableForScript.Dock = DockStyle.Fill;
            propsTableForScript.Location = new Point(0, 116);
            propsTableForScript.Name = "propsTableForScript";
            propsTableForScript.RowHeadersWidth = 51;
            propsTableForScript.Size = new Size(800, 334);
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
            // parameterEditModelBindingSource
            // 
            parameterEditModelBindingSource.DataSource = typeof(ParameterEditModel);
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Controls.Add(textBox2);
            flowLayoutPanel10.Controls.Add(checkBox1);
            flowLayoutPanel10.Dock = DockStyle.Top;
            flowLayoutPanel10.Location = new Point(0, 76);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(800, 40);
            flowLayoutPanel10.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Filter";
            textBox2.Size = new Size(230, 30);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(239, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(160, 27);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Show References";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // setPropsNavPanel
            // 
            setPropsNavPanel.Controls.Add(flowLayoutPanel6);
            setPropsNavPanel.Controls.Add(flowLayoutPanel5);
            setPropsNavPanel.Dock = DockStyle.Top;
            setPropsNavPanel.Location = new Point(0, 0);
            setPropsNavPanel.Name = "setPropsNavPanel";
            setPropsNavPanel.Size = new Size(800, 76);
            setPropsNavPanel.TabIndex = 3;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(finishSettingProperties);
            flowLayoutPanel6.Controls.Add(setPropertiesOption);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(398, 0);
            flowLayoutPanel6.Margin = new Padding(0);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10);
            flowLayoutPanel6.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel6.Size = new Size(402, 76);
            flowLayoutPanel6.TabIndex = 4;
            // 
            // finishSettingProperties
            // 
            finishSettingProperties.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            finishSettingProperties.Font = new Font("Segoe UI", 14F);
            finishSettingProperties.Location = new Point(245, 13);
            finishSettingProperties.Name = "finishSettingProperties";
            finishSettingProperties.RightToLeft = RightToLeft.No;
            finishSettingProperties.Size = new Size(134, 56);
            finishSettingProperties.TabIndex = 2;
            finishSettingProperties.Text = "Next >";
            finishSettingProperties.UseVisualStyleBackColor = true;
            finishSettingProperties.Click += finishSettingProperties_Click;
            // 
            // setPropertiesOption
            // 
            setPropertiesOption.ImageScalingSize = new Size(20, 20);
            setPropertiesOption.Items.AddRange(new ToolStripItem[] { propertiesFileOptions });
            setPropertiesOption.Location = new Point(181, 10);
            setPropertiesOption.Name = "setPropertiesOption";
            setPropertiesOption.Size = new Size(61, 36);
            setPropertiesOption.TabIndex = 5;
            setPropertiesOption.Text = "menuStrip2";
            // 
            // propertiesFileOptions
            // 
            propertiesFileOptions.DropDownItems.AddRange(new ToolStripItem[] { reloadPropertiesToolStripMenuItem, importParametersToolStripMenuItem, exportParametersToolStripMenuItem });
            propertiesFileOptions.Font = new Font("Segoe UI", 12F);
            propertiesFileOptions.Name = "propertiesFileOptions";
            propertiesFileOptions.RightToLeft = RightToLeft.No;
            propertiesFileOptions.Size = new Size(53, 32);
            propertiesFileOptions.Text = "🔧";
            // 
            // reloadPropertiesToolStripMenuItem
            // 
            reloadPropertiesToolStripMenuItem.Name = "reloadPropertiesToolStripMenuItem";
            reloadPropertiesToolStripMenuItem.Size = new Size(291, 32);
            reloadPropertiesToolStripMenuItem.Text = "🔄️ Reload Parameters";
            reloadPropertiesToolStripMenuItem.Click += reloadPropertiesToolStripMenuItem_Click;
            // 
            // importParametersToolStripMenuItem
            // 
            importParametersToolStripMenuItem.Name = "importParametersToolStripMenuItem";
            importParametersToolStripMenuItem.Size = new Size(291, 32);
            importParametersToolStripMenuItem.Text = "⬇️ Import Parameters";
            importParametersToolStripMenuItem.Click += downloadTheValues_Click;
            // 
            // exportParametersToolStripMenuItem
            // 
            exportParametersToolStripMenuItem.Name = "exportParametersToolStripMenuItem";
            exportParametersToolStripMenuItem.Size = new Size(291, 32);
            exportParametersToolStripMenuItem.Text = "⬆️ Export Parameters";
            exportParametersToolStripMenuItem.Click += exportParametersToolStripMenuItem_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(backFromSettingProperties);
            flowLayoutPanel5.Controls.Add(letsSetPropertiesLabel);
            flowLayoutPanel5.Dock = DockStyle.Left;
            flowLayoutPanel5.Location = new Point(0, 0);
            flowLayoutPanel5.Margin = new Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(398, 76);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // backFromSettingProperties
            // 
            backFromSettingProperties.Font = new Font("Segoe UI", 22F);
            backFromSettingProperties.Location = new Point(10, 10);
            backFromSettingProperties.Margin = new Padding(0);
            backFromSettingProperties.Name = "backFromSettingProperties";
            backFromSettingProperties.Size = new Size(73, 56);
            backFromSettingProperties.TabIndex = 0;
            backFromSettingProperties.Text = "<";
            backFromSettingProperties.UseVisualStyleBackColor = true;
            backFromSettingProperties.Click += backFromPropertiesButton_Click;
            // 
            // letsSetPropertiesLabel
            // 
            letsSetPropertiesLabel.AutoSize = true;
            letsSetPropertiesLabel.Font = new Font("Segoe UI", 24F);
            letsSetPropertiesLabel.Location = new Point(86, 10);
            letsSetPropertiesLabel.Name = "letsSetPropertiesLabel";
            letsSetPropertiesLabel.Size = new Size(287, 54);
            letsSetPropertiesLabel.TabIndex = 1;
            letsSetPropertiesLabel.Text = "Let's set values";
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
            exportToFileProperties.Click += exportToFile_Click;
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
            // saveParametersDialog
            // 
            saveParametersDialog.AddToRecent = false;
            saveParametersDialog.DefaultExt = "ini";
            saveParametersDialog.FileName = "parameters";
            saveParametersDialog.Filter = "SIF Parameters|*.ini";
            saveParametersDialog.RestoreDirectory = true;
            saveParametersDialog.FileOk += saveFileDialog1_FileOk;
            // 
            // openSavedValues
            // 
            openSavedValues.AddToRecent = false;
            openSavedValues.DefaultExt = "ini";
            openSavedValues.Filter = "SIF Parameter Values|*.ini";
            openSavedValues.ReadOnlyChecked = true;
            openSavedValues.RestoreDirectory = true;
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
            // saveFileDialog1
            // 
            saveFileDialog1.AddToRecent = false;
            saveFileDialog1.DefaultExt = "ps1";
            saveFileDialog1.FileName = "run-script";
            saveFileDialog1.Filter = "PowerShell|*.ps1";
            saveFileDialog1.RestoreDirectory = true;
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
            MainJsonViewer.BackClicked += back_Click;
            // 
            // SifJsonParsingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainJsonViewer);
            Controls.Add(MainJsonBuilder);
            Controls.Add(MainChooseProperties);
            Controls.Add(MainChooseExportFormat);
            Controls.Add(MainFileParsingError);
            Controls.Add(MainCreatePowershell);
            Controls.Add(MainSelectFilePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SifJsonParsingForm";
            Text = "SIF Utils";
            Load += SifJsonParsingForm_Load;
            MainSelectFilePanel.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            TasksContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).EndInit();
            MainCreatePowershell.ResumeLayout(false);
            MainCreatePowershell.PerformLayout();
            creatingPsNavigation.ResumeLayout(false);
            creatingPsNavigation.PerformLayout();
            MainChooseProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)propsTableForScript).EndInit();
            ((System.ComponentModel.ISupportInitialize)parameterEditModelBindingSource).EndInit();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            setPropsNavPanel.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            setPropertiesOption.ResumeLayout(false);
            setPropertiesOption.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            MainChooseExportFormat.ResumeLayout(false);
            MainChooseExportFormat.PerformLayout();
            scriptMenu.ResumeLayout(false);
            scriptMenu.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            MainNavigation.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            MainFileParsingError.ResumeLayout(false);
            MainFileParsingError.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            callActionContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileForViewerDialog;
        internal Panel MainSelectFilePanel;
        private Label welcomeLabel;
        private Label welcomeWhatDoWeDo;
        private Button backFromPsCreation;
        internal Panel MainCreatePowershell;
        private Label viewJsonLabel;
        private Label createPsScriptLabel;
        private FlowLayoutPanel creatingPsNavigation;
        private Label creatingPsTitle;
        private Label singleDeveloperOption;
        private Label customFileOpenDialog;
        internal Panel MainChooseProperties;
        private Button backFromSettingProperties;
        private Label letsSetPropertiesLabel;
        internal DataGridView propsTableForScript;
        private Panel setPropsNavPanel;
        private Button finishSettingProperties;
        private Panel MainNavigation;
        private Button backFromExport;
        private Label copyToClipboardProperties;
        private Label exportToFileProperties;
        internal Panel MainChooseExportFormat;
        internal TextBox scriptToExport;
        internal BindingSource parameterEditModelBindingSource;
        internal Label navigationLabel;
        internal Button homeNavigationButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label label2;
        internal TextBox documentText;
        internal Panel MainFileParsingError;
        internal Label errorDescription;
        private Label executeInShell;
        private SaveFileDialog saveParametersDialog;
        private ContextMenuStrip TasksContextMenu;
        private ToolStripMenuItem viewToolStripMenuItem;
        private BindingSource sifJsonParameterModelBindingSource;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel5;
        private OpenFileDialog openSavedValues;
        private MenuStrip setPropertiesOption;
        private ToolStripMenuItem propertiesFileOptions;
        private ToolStripMenuItem reloadPropertiesToolStripMenuItem;
        private ToolStripMenuItem importParametersToolStripMenuItem;
        private ToolStripMenuItem exportParametersToolStripMenuItem;
        private MenuStrip scriptMenu;
        private ToolStripMenuItem optionsToolStripMenuItem;
        internal ToolStripMenuItem scriptOptionsToolStripMenuItem;
        internal ToolStripComboBox errorActionDropdown;
        internal ToolStripMenuItem inlineParametersOption;
        internal ToolStripMenuItem includeUninstallOption;
        internal ToolStripMenuItem includeVerboseOption;
        internal ToolStripMenuItem tasksToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyTaskName;
        private ToolStripMenuItem copyTaskDescription;
        private ToolStripMenuItem executeToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel10;
        internal TextBox textBox2;
        internal CheckBox checkBox1;
        private ContextMenuStrip callActionContextMenu;
        private ToolStripMenuItem resetToDefaultToolStripMenuItem;
        private ToolStripMenuItem insertPathToFolderToolStripMenuItem;
        private ToolStripMenuItem insertFileToolStripMenuItem;
        private FolderBrowserDialog chooseFolder;
        private OpenFileDialog chooseFile;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn HasDefaultValue;
        private DataGridViewCheckBoxColumn IsReference;
        private DataGridViewCheckBoxColumn HasValidation;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewButtonColumn RowAction;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        internal Forms.JsonBuilder.JsonBuilderForm MainJsonBuilder;
        internal Forms.JsonViewer.JsonViewerForm MainJsonViewer;
    }
}
