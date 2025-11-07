namespace SIF.Utils
{
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
            openFileForViewerDialog = new OpenFileDialog();
            MainSelectFilePanel = new Panel();
            createPsScriptLabel = new Label();
            viewJsonLabel = new Label();
            welcomeWhatDoWeDo = new Label();
            welcomeLabel = new Label();
            MainJsonActionsPanel = new Panel();
            tabControl1 = new TabControl();
            viewJsonTasks = new TabPage();
            tasksViewer = new ListView();
            tasksTabNameColumn = new ColumnHeader();
            tasksTabDescriptionColumn = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            tasksFilters = new FlowLayoutPanel();
            filterText = new TextBox();
            viewJsonUninstallTasks = new TabPage();
            uninstallTasksList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            viewJsonParameters = new TabPage();
            parametersList = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            viewJsonVariables = new TabPage();
            variablesList = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            viewJsonIncludes = new TabPage();
            includesList = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            viewJsonModules = new TabPage();
            modulesList = new ListView();
            columnHeader9 = new ColumnHeader();
            tabPage1 = new TabPage();
            label1 = new Label();
            filePathInformationLayout = new FlowLayoutPanel();
            button2 = new Button();
            FilePathText = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            openContainingFolderToolStripMenuItem = new ToolStripMenuItem();
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
            parameterEditModelBindingSource = new BindingSource(components);
            setPropsNavPanel = new Panel();
            finishSettingProperties = new Button();
            letsSetPropertiesLabel = new Label();
            backFromSettingProperties = new Button();
            MainChooseExportFormat = new Panel();
            scriptToExport = new TextBox();
            executeInShell = new Label();
            copyToClipboardProperties = new Label();
            exportToFileProperties = new Label();
            exportMainContent = new Panel();
            inlineParametersOption = new CheckBox();
            includeTasks = new CheckedListBox();
            errorActionDropdown = new ComboBox();
            includeUninstallOption = new CheckBox();
            MainNavigation = new Panel();
            homeNavigationButton = new Button();
            navigationLabel = new Label();
            backFromExport = new Button();
            MainFileParsingError = new Panel();
            documentText = new TextBox();
            errorDescription = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            label2 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            MainSelectFilePanel.SuspendLayout();
            MainJsonActionsPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            viewJsonTasks.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tasksFilters.SuspendLayout();
            viewJsonUninstallTasks.SuspendLayout();
            viewJsonParameters.SuspendLayout();
            viewJsonVariables.SuspendLayout();
            viewJsonIncludes.SuspendLayout();
            viewJsonModules.SuspendLayout();
            tabPage1.SuspendLayout();
            filePathInformationLayout.SuspendLayout();
            menuStrip1.SuspendLayout();
            MainCreatePowershell.SuspendLayout();
            creatingPsNavigation.SuspendLayout();
            MainChooseProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propsTableForScript).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parameterEditModelBindingSource).BeginInit();
            setPropsNavPanel.SuspendLayout();
            MainChooseExportFormat.SuspendLayout();
            exportMainContent.SuspendLayout();
            MainNavigation.SuspendLayout();
            MainFileParsingError.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileForViewerDialog
            // 
            openFileForViewerDialog.AddToRecent = false;
            openFileForViewerDialog.DefaultExt = "json";
            openFileForViewerDialog.Filter = "SIF JSON|*.json";
            openFileForViewerDialog.ReadOnlyChecked = true;
            openFileForViewerDialog.RestoreDirectory = true;
            openFileForViewerDialog.FileOk += OpenFileForViewerDialogFileForViewerOk;
            // 
            // MainSelectFilePanel
            // 
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
            createPsScriptLabel.Text = "👉 Create Powershell Running Script";
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
            // MainJsonActionsPanel
            // 
            MainJsonActionsPanel.Controls.Add(tabControl1);
            MainJsonActionsPanel.Controls.Add(filePathInformationLayout);
            MainJsonActionsPanel.Dock = DockStyle.Fill;
            MainJsonActionsPanel.Location = new Point(0, 0);
            MainJsonActionsPanel.Name = "MainJsonActionsPanel";
            MainJsonActionsPanel.Size = new Size(800, 450);
            MainJsonActionsPanel.TabIndex = 2;
            MainJsonActionsPanel.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(viewJsonTasks);
            tabControl1.Controls.Add(viewJsonUninstallTasks);
            tabControl1.Controls.Add(viewJsonParameters);
            tabControl1.Controls.Add(viewJsonVariables);
            tabControl1.Controls.Add(viewJsonIncludes);
            tabControl1.Controls.Add(viewJsonModules);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 374);
            tabControl1.TabIndex = 3;
            // 
            // viewJsonTasks
            // 
            viewJsonTasks.Controls.Add(tasksViewer);
            viewJsonTasks.Controls.Add(tasksFilters);
            viewJsonTasks.Location = new Point(4, 32);
            viewJsonTasks.Name = "viewJsonTasks";
            viewJsonTasks.Padding = new Padding(3);
            viewJsonTasks.Size = new Size(792, 338);
            viewJsonTasks.TabIndex = 1;
            viewJsonTasks.Text = "Tasks";
            viewJsonTasks.UseVisualStyleBackColor = true;
            // 
            // tasksViewer
            // 
            tasksViewer.Columns.AddRange(new ColumnHeader[] { tasksTabNameColumn, tasksTabDescriptionColumn });
            tasksViewer.ContextMenuStrip = contextMenuStrip1;
            tasksViewer.Dock = DockStyle.Fill;
            tasksViewer.FullRowSelect = true;
            tasksViewer.GridLines = true;
            tasksViewer.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tasksViewer.Location = new Point(3, 43);
            tasksViewer.Name = "tasksViewer";
            tasksViewer.ShowGroups = false;
            tasksViewer.ShowItemToolTips = true;
            tasksViewer.Size = new Size(786, 292);
            tasksViewer.TabIndex = 0;
            tasksViewer.UseCompatibleStateImageBehavior = false;
            tasksViewer.View = View.Details;
            // 
            // tasksTabNameColumn
            // 
            tasksTabNameColumn.Text = "Name";
            tasksTabNameColumn.Width = 200;
            // 
            // tasksTabDescriptionColumn
            // 
            tasksTabDescriptionColumn.Text = "Description";
            tasksTabDescriptionColumn.Width = 600;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 32);
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(116, 28);
            viewToolStripMenuItem.Text = "View";
            // 
            // tasksFilters
            // 
            tasksFilters.Controls.Add(filterText);
            tasksFilters.Dock = DockStyle.Top;
            tasksFilters.Location = new Point(3, 3);
            tasksFilters.Name = "tasksFilters";
            tasksFilters.Size = new Size(786, 40);
            tasksFilters.TabIndex = 1;
            // 
            // filterText
            // 
            filterText.Location = new Point(3, 3);
            filterText.Name = "filterText";
            filterText.PlaceholderText = "Filter";
            filterText.Size = new Size(230, 30);
            filterText.TabIndex = 0;
            filterText.TextChanged += filterText_TextChanged;
            // 
            // viewJsonUninstallTasks
            // 
            viewJsonUninstallTasks.Controls.Add(uninstallTasksList);
            viewJsonUninstallTasks.Location = new Point(4, 32);
            viewJsonUninstallTasks.Name = "viewJsonUninstallTasks";
            viewJsonUninstallTasks.Padding = new Padding(3);
            viewJsonUninstallTasks.Size = new Size(792, 338);
            viewJsonUninstallTasks.TabIndex = 2;
            viewJsonUninstallTasks.Text = "UninstallTasks";
            viewJsonUninstallTasks.UseVisualStyleBackColor = true;
            // 
            // uninstallTasksList
            // 
            uninstallTasksList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            uninstallTasksList.Dock = DockStyle.Fill;
            uninstallTasksList.Location = new Point(3, 3);
            uninstallTasksList.Name = "uninstallTasksList";
            uninstallTasksList.Size = new Size(786, 332);
            uninstallTasksList.TabIndex = 1;
            uninstallTasksList.UseCompatibleStateImageBehavior = false;
            uninstallTasksList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Description";
            columnHeader2.Width = 600;
            // 
            // viewJsonParameters
            // 
            viewJsonParameters.Controls.Add(parametersList);
            viewJsonParameters.Location = new Point(4, 32);
            viewJsonParameters.Name = "viewJsonParameters";
            viewJsonParameters.Size = new Size(792, 338);
            viewJsonParameters.TabIndex = 3;
            viewJsonParameters.Text = "Parameters";
            viewJsonParameters.UseVisualStyleBackColor = true;
            // 
            // parametersList
            // 
            parametersList.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            parametersList.Dock = DockStyle.Fill;
            parametersList.Location = new Point(0, 0);
            parametersList.Name = "parametersList";
            parametersList.Size = new Size(792, 338);
            parametersList.TabIndex = 1;
            parametersList.UseCompatibleStateImageBehavior = false;
            parametersList.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Description";
            columnHeader4.Width = 550;
            // 
            // viewJsonVariables
            // 
            viewJsonVariables.Controls.Add(variablesList);
            viewJsonVariables.Location = new Point(4, 32);
            viewJsonVariables.Name = "viewJsonVariables";
            viewJsonVariables.Size = new Size(792, 338);
            viewJsonVariables.TabIndex = 4;
            viewJsonVariables.Text = "Variables";
            viewJsonVariables.UseVisualStyleBackColor = true;
            // 
            // variablesList
            // 
            variablesList.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            variablesList.Dock = DockStyle.Fill;
            variablesList.Location = new Point(0, 0);
            variablesList.Name = "variablesList";
            variablesList.Size = new Size(792, 338);
            variablesList.TabIndex = 1;
            variablesList.UseCompatibleStateImageBehavior = false;
            variablesList.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Name";
            columnHeader5.Width = 300;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Description";
            columnHeader6.Width = 400;
            // 
            // viewJsonIncludes
            // 
            viewJsonIncludes.Controls.Add(includesList);
            viewJsonIncludes.Location = new Point(4, 32);
            viewJsonIncludes.Name = "viewJsonIncludes";
            viewJsonIncludes.Size = new Size(792, 338);
            viewJsonIncludes.TabIndex = 5;
            viewJsonIncludes.Text = "Includes";
            viewJsonIncludes.UseVisualStyleBackColor = true;
            // 
            // includesList
            // 
            includesList.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8 });
            includesList.Dock = DockStyle.Fill;
            includesList.Location = new Point(0, 0);
            includesList.Name = "includesList";
            includesList.Size = new Size(792, 338);
            includesList.TabIndex = 1;
            includesList.UseCompatibleStateImageBehavior = false;
            includesList.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Name";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Source";
            columnHeader8.Width = 600;
            // 
            // viewJsonModules
            // 
            viewJsonModules.Controls.Add(modulesList);
            viewJsonModules.Location = new Point(4, 32);
            viewJsonModules.Name = "viewJsonModules";
            viewJsonModules.Size = new Size(792, 338);
            viewJsonModules.TabIndex = 6;
            viewJsonModules.Text = "Modules";
            viewJsonModules.UseVisualStyleBackColor = true;
            // 
            // modulesList
            // 
            modulesList.Columns.AddRange(new ColumnHeader[] { columnHeader9 });
            modulesList.Dock = DockStyle.Fill;
            modulesList.Location = new Point(0, 0);
            modulesList.Name = "modulesList";
            modulesList.Size = new Size(792, 338);
            modulesList.TabIndex = 1;
            modulesList.UseCompatibleStateImageBehavior = false;
            modulesList.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Path";
            columnHeader9.Width = 700;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 338);
            tabPage1.TabIndex = 7;
            tabPage1.Text = "Register";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(786, 332);
            label1.TabIndex = 0;
            label1.Text = "Coming Soon!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filePathInformationLayout
            // 
            filePathInformationLayout.AutoSize = true;
            filePathInformationLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filePathInformationLayout.Controls.Add(button2);
            filePathInformationLayout.Controls.Add(FilePathText);
            filePathInformationLayout.Controls.Add(menuStrip1);
            filePathInformationLayout.Dock = DockStyle.Top;
            filePathInformationLayout.Location = new Point(0, 0);
            filePathInformationLayout.Name = "filePathInformationLayout";
            filePathInformationLayout.Padding = new Padding(10);
            filePathInformationLayout.Size = new Size(800, 76);
            filePathInformationLayout.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 22F);
            button2.Location = new Point(10, 10);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(73, 56);
            button2.TabIndex = 4;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FilePathText
            // 
            FilePathText.Font = new Font("Segoe UI", 11F);
            FilePathText.Location = new Point(86, 13);
            FilePathText.Name = "FilePathText";
            FilePathText.ReadOnly = true;
            FilePathText.ScrollBars = ScrollBars.Horizontal;
            FilePathText.Size = new Size(545, 32);
            FilePathText.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(634, 10);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(55, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, openContainingFolderToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Segoe UI", 11F);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(47, 29);
            toolStripMenuItem1.Text = "🔧";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(323, 30);
            toolStripMenuItem3.Text = "🔃 Choose Another File";
            toolStripMenuItem3.Click += chooseAnotherJsonButton_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(323, 30);
            toolStripMenuItem4.Text = "▶️ Create Run Script";
            toolStripMenuItem4.Click += executeJson_Click;
            // 
            // openContainingFolderToolStripMenuItem
            // 
            openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            openContainingFolderToolStripMenuItem.Size = new Size(323, 30);
            openContainingFolderToolStripMenuItem.Text = "📂 Open Containing folder";
            openContainingFolderToolStripMenuItem.Click += openContainingFolderToolStripMenuItem_Click;
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
            propsTableForScript.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, HasDefaultValue, IsReference, HasValidation, Value });
            propsTableForScript.DataSource = parameterEditModelBindingSource;
            propsTableForScript.Dock = DockStyle.Fill;
            propsTableForScript.Location = new Point(0, 76);
            propsTableForScript.Name = "propsTableForScript";
            propsTableForScript.RowHeadersWidth = 51;
            propsTableForScript.Size = new Size(800, 374);
            propsTableForScript.TabIndex = 2;
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
            HasDefaultValue.HeaderText = "Default";
            HasDefaultValue.MinimumWidth = 6;
            HasDefaultValue.Name = "HasDefaultValue";
            HasDefaultValue.ReadOnly = true;
            HasDefaultValue.SortMode = DataGridViewColumnSortMode.Automatic;
            HasDefaultValue.Width = 94;
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
            HasValidation.HeaderText = "Validation";
            HasValidation.MinimumWidth = 6;
            HasValidation.Name = "HasValidation";
            HasValidation.ReadOnly = true;
            HasValidation.SortMode = DataGridViewColumnSortMode.Programmatic;
            HasValidation.Width = 115;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Value.DataPropertyName = "Value";
            Value.HeaderText = "Value";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            Value.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // parameterEditModelBindingSource
            // 
            parameterEditModelBindingSource.DataSource = typeof(ParameterEditModel);
            // 
            // setPropsNavPanel
            // 
            setPropsNavPanel.Controls.Add(finishSettingProperties);
            setPropsNavPanel.Controls.Add(letsSetPropertiesLabel);
            setPropsNavPanel.Controls.Add(backFromSettingProperties);
            setPropsNavPanel.Dock = DockStyle.Top;
            setPropsNavPanel.Location = new Point(0, 0);
            setPropsNavPanel.Name = "setPropsNavPanel";
            setPropsNavPanel.Size = new Size(800, 76);
            setPropsNavPanel.TabIndex = 3;
            // 
            // finishSettingProperties
            // 
            finishSettingProperties.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            finishSettingProperties.Font = new Font("Segoe UI", 14F);
            finishSettingProperties.Location = new Point(654, 8);
            finishSettingProperties.Name = "finishSettingProperties";
            finishSettingProperties.Size = new Size(134, 56);
            finishSettingProperties.TabIndex = 2;
            finishSettingProperties.Text = "Next >";
            finishSettingProperties.UseVisualStyleBackColor = true;
            finishSettingProperties.Click += finishSettingProperties_Click;
            // 
            // letsSetPropertiesLabel
            // 
            letsSetPropertiesLabel.AutoSize = true;
            letsSetPropertiesLabel.Font = new Font("Segoe UI", 24F);
            letsSetPropertiesLabel.Location = new Point(86, 8);
            letsSetPropertiesLabel.Name = "letsSetPropertiesLabel";
            letsSetPropertiesLabel.Size = new Size(287, 54);
            letsSetPropertiesLabel.TabIndex = 1;
            letsSetPropertiesLabel.Text = "Let's set values";
            // 
            // backFromSettingProperties
            // 
            backFromSettingProperties.Font = new Font("Segoe UI", 22F);
            backFromSettingProperties.Location = new Point(10, 8);
            backFromSettingProperties.Margin = new Padding(0);
            backFromSettingProperties.Name = "backFromSettingProperties";
            backFromSettingProperties.Size = new Size(73, 56);
            backFromSettingProperties.TabIndex = 0;
            backFromSettingProperties.Text = "<";
            backFromSettingProperties.UseVisualStyleBackColor = true;
            backFromSettingProperties.Click += universalBackButton_Click;
            // 
            // MainChooseExportFormat
            // 
            MainChooseExportFormat.Controls.Add(scriptToExport);
            MainChooseExportFormat.Controls.Add(executeInShell);
            MainChooseExportFormat.Controls.Add(copyToClipboardProperties);
            MainChooseExportFormat.Controls.Add(exportToFileProperties);
            MainChooseExportFormat.Controls.Add(exportMainContent);
            MainChooseExportFormat.Controls.Add(MainNavigation);
            MainChooseExportFormat.Dock = DockStyle.Fill;
            MainChooseExportFormat.Location = new Point(0, 0);
            MainChooseExportFormat.Name = "MainChooseExportFormat";
            MainChooseExportFormat.Size = new Size(800, 450);
            MainChooseExportFormat.TabIndex = 3;
            // 
            // scriptToExport
            // 
            scriptToExport.Dock = DockStyle.Top;
            scriptToExport.Location = new Point(0, 192);
            scriptToExport.Multiline = true;
            scriptToExport.Name = "scriptToExport";
            scriptToExport.ScrollBars = ScrollBars.Vertical;
            scriptToExport.Size = new Size(800, 193);
            scriptToExport.TabIndex = 11;
            // 
            // executeInShell
            // 
            executeInShell.AutoSize = true;
            executeInShell.Cursor = Cursors.Hand;
            executeInShell.Enabled = false;
            executeInShell.Font = new Font("Segoe UI", 15F);
            executeInShell.Location = new Point(539, 375);
            executeInShell.Name = "executeInShell";
            executeInShell.Padding = new Padding(20);
            executeInShell.Size = new Size(254, 75);
            executeInShell.TabIndex = 12;
            executeInShell.Text = "▶️ Execute in Shell";
            executeInShell.Click += executeScriptInPowershell_Click;
            // 
            // copyToClipboardProperties
            // 
            copyToClipboardProperties.AutoSize = true;
            copyToClipboardProperties.Cursor = Cursors.Hand;
            copyToClipboardProperties.Font = new Font("Segoe UI", 15F);
            copyToClipboardProperties.Location = new Point(246, 375);
            copyToClipboardProperties.Name = "copyToClipboardProperties";
            copyToClipboardProperties.Padding = new Padding(20);
            copyToClipboardProperties.Size = new Size(299, 75);
            copyToClipboardProperties.TabIndex = 8;
            copyToClipboardProperties.Text = "📋 Copy to Clipboard";
            copyToClipboardProperties.Click += copyToClipboardProperties_Click;
            copyToClipboardProperties.MouseLeave += labelButton_MouseLeave;
            copyToClipboardProperties.MouseHover += labelButton_MouseHover;
            // 
            // exportToFileProperties
            // 
            exportToFileProperties.AutoSize = true;
            exportToFileProperties.Cursor = Cursors.Hand;
            exportToFileProperties.Font = new Font("Segoe UI", 15F);
            exportToFileProperties.ForeColor = SystemColors.ControlText;
            exportToFileProperties.Location = new Point(3, 375);
            exportToFileProperties.Name = "exportToFileProperties";
            exportToFileProperties.Padding = new Padding(20);
            exportToFileProperties.Size = new Size(237, 75);
            exportToFileProperties.TabIndex = 7;
            exportToFileProperties.Text = "📄 Export to file";
            exportToFileProperties.Click += exportToFile_Click;
            exportToFileProperties.MouseLeave += labelButton_MouseLeave;
            exportToFileProperties.MouseHover += labelButton_MouseHover;
            // 
            // exportMainContent
            // 
            exportMainContent.Controls.Add(inlineParametersOption);
            exportMainContent.Controls.Add(includeTasks);
            exportMainContent.Controls.Add(errorActionDropdown);
            exportMainContent.Controls.Add(includeUninstallOption);
            exportMainContent.Dock = DockStyle.Top;
            exportMainContent.Location = new Point(0, 76);
            exportMainContent.Name = "exportMainContent";
            exportMainContent.Size = new Size(800, 116);
            exportMainContent.TabIndex = 10;
            // 
            // inlineParametersOption
            // 
            inlineParametersOption.AutoSize = true;
            inlineParametersOption.Font = new Font("Segoe UI", 14F);
            inlineParametersOption.Location = new Point(35, 64);
            inlineParametersOption.Name = "inlineParametersOption";
            inlineParametersOption.Size = new Size(169, 36);
            inlineParametersOption.TabIndex = 4;
            inlineParametersOption.Text = " Inline Script";
            inlineParametersOption.UseVisualStyleBackColor = true;
            inlineParametersOption.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // includeTasks
            // 
            includeTasks.FormattingEnabled = true;
            includeTasks.Location = new Point(481, 6);
            includeTasks.Name = "includeTasks";
            includeTasks.Size = new Size(307, 104);
            includeTasks.TabIndex = 3;
            includeTasks.SelectedIndexChanged += includeTasks_SelectedIndexChanged;
            // 
            // errorActionDropdown
            // 
            errorActionDropdown.FormattingEnabled = true;
            errorActionDropdown.Items.AddRange(new object[] { "Break", "Continue", "Ignore", "Inquire", "SilentlyContinue", "Stop", "Suspend" });
            errorActionDropdown.Location = new Point(319, 24);
            errorActionDropdown.Name = "errorActionDropdown";
            errorActionDropdown.Size = new Size(151, 31);
            errorActionDropdown.TabIndex = 2;
            errorActionDropdown.Text = "ErrorAction";
            errorActionDropdown.SelectedIndexChanged += errorActionDropdown_SelectedIndexChanged;
            // 
            // includeUninstallOption
            // 
            includeUninstallOption.AutoSize = true;
            includeUninstallOption.Font = new Font("Segoe UI", 14F);
            includeUninstallOption.Location = new Point(35, 18);
            includeUninstallOption.Name = "includeUninstallOption";
            includeUninstallOption.Size = new Size(233, 36);
            includeUninstallOption.TabIndex = 0;
            includeUninstallOption.Text = "-Uninstall (Option)";
            includeUninstallOption.UseVisualStyleBackColor = true;
            includeUninstallOption.CheckedChanged += includeUninstallOption_CheckedChanged;
            // 
            // MainNavigation
            // 
            MainNavigation.Controls.Add(homeNavigationButton);
            MainNavigation.Controls.Add(navigationLabel);
            MainNavigation.Controls.Add(backFromExport);
            MainNavigation.Dock = DockStyle.Top;
            MainNavigation.Location = new Point(0, 0);
            MainNavigation.Name = "MainNavigation";
            MainNavigation.Size = new Size(800, 76);
            MainNavigation.TabIndex = 4;
            // 
            // homeNavigationButton
            // 
            homeNavigationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            homeNavigationButton.BackColor = Color.Transparent;
            homeNavigationButton.Font = new Font("Segoe UI", 22F);
            homeNavigationButton.Location = new Point(715, 10);
            homeNavigationButton.Margin = new Padding(0);
            homeNavigationButton.Name = "homeNavigationButton";
            homeNavigationButton.Size = new Size(73, 56);
            homeNavigationButton.TabIndex = 2;
            homeNavigationButton.Text = "🏠";
            homeNavigationButton.UseVisualStyleBackColor = false;
            homeNavigationButton.Click += label3_Click;
            // 
            // navigationLabel
            // 
            navigationLabel.AutoSize = true;
            navigationLabel.Font = new Font("Segoe UI", 24F);
            navigationLabel.Location = new Point(86, 8);
            navigationLabel.Name = "navigationLabel";
            navigationLabel.Size = new Size(408, 54);
            navigationLabel.TabIndex = 1;
            navigationLabel.Text = "Choose export option";
            // 
            // backFromExport
            // 
            backFromExport.BackColor = Color.Transparent;
            backFromExport.Font = new Font("Segoe UI", 22F);
            backFromExport.Location = new Point(10, 8);
            backFromExport.Margin = new Padding(0);
            backFromExport.Name = "backFromExport";
            backFromExport.Size = new Size(73, 56);
            backFromExport.TabIndex = 0;
            backFromExport.Text = "<";
            backFromExport.UseVisualStyleBackColor = false;
            backFromExport.Click += backFromExport_Click;
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
            button1.Click += universalBackButton_Click;
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
            // saveFileDialog1
            // 
            saveFileDialog1.AddToRecent = false;
            saveFileDialog1.DefaultExt = "ps1";
            saveFileDialog1.FileName = "run-script";
            saveFileDialog1.Filter = "PowerShell|*.ps1";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // SifJsonParsingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainJsonActionsPanel);
            Controls.Add(MainChooseExportFormat);
            Controls.Add(MainChooseProperties);
            Controls.Add(MainCreatePowershell);
            Controls.Add(MainSelectFilePanel);
            Controls.Add(MainFileParsingError);
            MainMenuStrip = menuStrip1;
            Name = "SifJsonParsingForm";
            Text = "SIF Utils";
            Load += SifJsonParsingForm_Load;
            MainSelectFilePanel.ResumeLayout(false);
            MainJsonActionsPanel.ResumeLayout(false);
            MainJsonActionsPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            viewJsonTasks.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tasksFilters.ResumeLayout(false);
            tasksFilters.PerformLayout();
            viewJsonUninstallTasks.ResumeLayout(false);
            viewJsonParameters.ResumeLayout(false);
            viewJsonVariables.ResumeLayout(false);
            viewJsonIncludes.ResumeLayout(false);
            viewJsonModules.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            filePathInformationLayout.ResumeLayout(false);
            filePathInformationLayout.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MainCreatePowershell.ResumeLayout(false);
            MainCreatePowershell.PerformLayout();
            creatingPsNavigation.ResumeLayout(false);
            creatingPsNavigation.PerformLayout();
            MainChooseProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)propsTableForScript).EndInit();
            ((System.ComponentModel.ISupportInitialize)parameterEditModelBindingSource).EndInit();
            setPropsNavPanel.ResumeLayout(false);
            setPropsNavPanel.PerformLayout();
            MainChooseExportFormat.ResumeLayout(false);
            MainChooseExportFormat.PerformLayout();
            exportMainContent.ResumeLayout(false);
            exportMainContent.PerformLayout();
            MainNavigation.ResumeLayout(false);
            MainNavigation.PerformLayout();
            MainFileParsingError.ResumeLayout(false);
            MainFileParsingError.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileForViewerDialog;
        internal Panel MainSelectFilePanel;
        private TextBox FilePathText;
        internal Panel MainJsonActionsPanel;
        private FlowLayoutPanel filePathInformationLayout;
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
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn HasDefaultValue;
        private DataGridViewCheckBoxColumn IsReference;
        private DataGridViewCheckBoxColumn HasValidation;
        private DataGridViewTextBoxColumn Value;
        private Panel MainNavigation;
        private Button backFromExport;
        private Label copyToClipboardProperties;
        private Label exportToFileProperties;
        internal Panel MainChooseExportFormat;
        private Panel exportMainContent;
        private TabControl tabControl1;
        private TabPage viewJsonTasks;
        private TabPage viewJsonUninstallTasks;
        private TabPage viewJsonParameters;
        private TabPage viewJsonVariables;
        private TabPage viewJsonIncludes;
        private TabPage viewJsonModules;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem openContainingFolderToolStripMenuItem;
        internal TextBox scriptToExport;
        internal CheckBox includeUninstallOption;
        internal ComboBox errorActionDropdown;
        internal BindingSource parameterEditModelBindingSource;
        internal Label navigationLabel;
        internal Button homeNavigationButton;
        private FlowLayoutPanel tasksFilters;
        internal TextBox filterText;
        internal ListView tasksViewer;
        private ColumnHeader tasksTabNameColumn;
        private ColumnHeader tasksTabDescriptionColumn;
        internal ListView uninstallTasksList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        internal ListView parametersList;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        internal ListView variablesList;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        internal ListView includesList;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        internal ListView modulesList;
        private ColumnHeader columnHeader9;
        private TabPage tabPage1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label label2;
        internal TextBox documentText;
        internal Panel MainFileParsingError;
        internal Label errorDescription;
        internal CheckBox inlineParametersOption;
        internal CheckedListBox includeTasks;
        private Label executeInShell;
        private SaveFileDialog saveFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}
