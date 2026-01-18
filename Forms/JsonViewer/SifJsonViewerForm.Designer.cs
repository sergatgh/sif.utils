namespace SIF.Utils.Forms.JsonViewer
{
    partial class SifJsonViewerForm
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
            navigationPanel = new SIF.Utils.Forms.Common.NavigationPanel();
            openFolderButton = new Button();
            executeButton = new Button();
            FilePathText = new TextBox();
            viewJsonTabs = new TabControl();
            viewJsonTasks = new TabPage();
            tasksViewer = new ListView();
            tasksTabNameColumn = new ColumnHeader();
            tasksTabDescriptionColumn = new ColumnHeader();
            TasksContextMenu = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            copyTaskName = new ToolStripMenuItem();
            copyTaskDescription = new ToolStripMenuItem();
            executeToolStripMenuItem = new ToolStripMenuItem();
            tasksFilters = new FlowLayoutPanel();
            filterText = new TextBox();
            viewJsonUninstallTasks = new TabPage();
            uninstallTasksList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            viewJsonParameters = new TabPage();
            parametersList = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defaultValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            referenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            validateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sifJsonParameterModelBindingSource = new BindingSource(components);
            flowLayoutPanel9 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            viewJsonVariables = new TabPage();
            variablesList = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            flowLayoutPanel8 = new FlowLayoutPanel();
            variablesFilter = new TextBox();
            viewJsonIncludes = new TabPage();
            includesList = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            viewJsonModules = new TabPage();
            modulesList = new ListView();
            columnHeader9 = new ColumnHeader();
            viewJsonRegisteredTasks = new TabPage();
            registeredTasksList = new ListView();
            customTask = new ColumnHeader();
            powershellTask = new ColumnHeader();
            viewJsonRegisteredConfigFunctions = new TabPage();
            registeredConfigFunctionsList = new ListView();
            customFunction = new ColumnHeader();
            powershellFunction = new ColumnHeader();
            viewJsonSettings = new TabPage();
            viewJsonWarnings = new TabPage();
            changeFileButton = new Button();
            openFileForViewerDialog = new OpenFileDialog();
            viewJsonTabs.SuspendLayout();
            viewJsonTasks.SuspendLayout();
            TasksContextMenu.SuspendLayout();
            tasksFilters.SuspendLayout();
            viewJsonUninstallTasks.SuspendLayout();
            viewJsonParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parametersList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).BeginInit();
            flowLayoutPanel9.SuspendLayout();
            viewJsonVariables.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            viewJsonIncludes.SuspendLayout();
            viewJsonModules.SuspendLayout();
            viewJsonRegisteredTasks.SuspendLayout();
            viewJsonRegisteredConfigFunctions.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(761, 76);
            navigationPanel.TabIndex = 2;
            navigationPanel.Title = "SIF Viewer";
            // 
            // openFolderButton
            // 
            openFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            openFolderButton.BackColor = Color.Transparent;
            openFolderButton.Font = new Font("Segoe UI", 22F);
            openFolderButton.Location = new Point(523, 8);
            openFolderButton.Margin = new Padding(0);
            openFolderButton.Name = "openFolderButton";
            openFolderButton.Size = new Size(73, 56);
            openFolderButton.TabIndex = 7;
            openFolderButton.Text = "📂";
            openFolderButton.UseVisualStyleBackColor = false;
            openFolderButton.Click += openFolderButton_Click;
            // 
            // executeButton
            // 
            executeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            executeButton.BackColor = Color.Transparent;
            executeButton.Font = new Font("Segoe UI", 22F);
            executeButton.Location = new Point(669, 8);
            executeButton.Margin = new Padding(0);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(73, 56);
            executeButton.TabIndex = 7;
            executeButton.Text = "▶️";
            executeButton.UseVisualStyleBackColor = false;
            executeButton.Click += executeButton_Click;
            // 
            // FilePathText
            // 
            FilePathText.Dock = DockStyle.Top;
            FilePathText.Font = new Font("Segoe UI", 11F);
            FilePathText.Location = new Point(0, 76);
            FilePathText.Name = "FilePathText";
            FilePathText.ReadOnly = true;
            FilePathText.ScrollBars = ScrollBars.Horizontal;
            FilePathText.Size = new Size(761, 32);
            FilePathText.TabIndex = 3;
            // 
            // viewJsonTabs
            // 
            viewJsonTabs.Controls.Add(viewJsonTasks);
            viewJsonTabs.Controls.Add(viewJsonUninstallTasks);
            viewJsonTabs.Controls.Add(viewJsonParameters);
            viewJsonTabs.Controls.Add(viewJsonVariables);
            viewJsonTabs.Controls.Add(viewJsonIncludes);
            viewJsonTabs.Controls.Add(viewJsonModules);
            viewJsonTabs.Controls.Add(viewJsonRegisteredTasks);
            viewJsonTabs.Controls.Add(viewJsonRegisteredConfigFunctions);
            viewJsonTabs.Controls.Add(viewJsonSettings);
            viewJsonTabs.Controls.Add(viewJsonWarnings);
            viewJsonTabs.Dock = DockStyle.Fill;
            viewJsonTabs.Location = new Point(0, 108);
            viewJsonTabs.Name = "viewJsonTabs";
            viewJsonTabs.SelectedIndex = 0;
            viewJsonTabs.Size = new Size(761, 508);
            viewJsonTabs.TabIndex = 4;
            // 
            // viewJsonTasks
            // 
            viewJsonTasks.Controls.Add(tasksViewer);
            viewJsonTasks.Controls.Add(tasksFilters);
            viewJsonTasks.Location = new Point(4, 32);
            viewJsonTasks.Name = "viewJsonTasks";
            viewJsonTasks.Padding = new Padding(3);
            viewJsonTasks.Size = new Size(753, 472);
            viewJsonTasks.TabIndex = 1;
            viewJsonTasks.Text = "Tasks";
            viewJsonTasks.UseVisualStyleBackColor = true;
            // 
            // tasksViewer
            // 
            tasksViewer.Columns.AddRange(new ColumnHeader[] { tasksTabNameColumn, tasksTabDescriptionColumn });
            tasksViewer.ContextMenuStrip = TasksContextMenu;
            tasksViewer.Dock = DockStyle.Fill;
            tasksViewer.FullRowSelect = true;
            tasksViewer.GridLines = true;
            tasksViewer.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tasksViewer.Location = new Point(3, 43);
            tasksViewer.Name = "tasksViewer";
            tasksViewer.ShowGroups = false;
            tasksViewer.ShowItemToolTips = true;
            tasksViewer.Size = new Size(747, 426);
            tasksViewer.TabIndex = 0;
            tasksViewer.Tag = "Tasks";
            tasksViewer.UseCompatibleStateImageBehavior = false;
            tasksViewer.View = View.Details;
            tasksViewer.DoubleClick += tasksViewer_DoubleClick;
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
            // tasksFilters
            // 
            tasksFilters.Controls.Add(filterText);
            tasksFilters.Dock = DockStyle.Top;
            tasksFilters.Location = new Point(3, 3);
            tasksFilters.Name = "tasksFilters";
            tasksFilters.Size = new Size(747, 40);
            tasksFilters.TabIndex = 1;
            // 
            // filterText
            // 
            filterText.Dock = DockStyle.Top;
            filterText.Location = new Point(3, 3);
            filterText.Name = "filterText";
            filterText.PlaceholderText = "Filter";
            filterText.Size = new Size(778, 30);
            filterText.TabIndex = 0;
            filterText.TextChanged += filterText_TextChanged;
            // 
            // viewJsonUninstallTasks
            // 
            viewJsonUninstallTasks.Controls.Add(uninstallTasksList);
            viewJsonUninstallTasks.Location = new Point(4, 32);
            viewJsonUninstallTasks.Name = "viewJsonUninstallTasks";
            viewJsonUninstallTasks.Padding = new Padding(3);
            viewJsonUninstallTasks.Size = new Size(753, 472);
            viewJsonUninstallTasks.TabIndex = 2;
            viewJsonUninstallTasks.Text = "UninstallTasks";
            viewJsonUninstallTasks.UseVisualStyleBackColor = true;
            // 
            // uninstallTasksList
            // 
            uninstallTasksList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            uninstallTasksList.ContextMenuStrip = TasksContextMenu;
            uninstallTasksList.Dock = DockStyle.Fill;
            uninstallTasksList.FullRowSelect = true;
            uninstallTasksList.GridLines = true;
            uninstallTasksList.Location = new Point(3, 3);
            uninstallTasksList.Name = "uninstallTasksList";
            uninstallTasksList.ShowGroups = false;
            uninstallTasksList.Size = new Size(747, 466);
            uninstallTasksList.TabIndex = 1;
            uninstallTasksList.Tag = "UninstallTasks";
            uninstallTasksList.UseCompatibleStateImageBehavior = false;
            uninstallTasksList.View = View.Details;
            uninstallTasksList.DoubleClick += tasksViewer_DoubleClick;
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
            viewJsonParameters.Controls.Add(flowLayoutPanel9);
            viewJsonParameters.Location = new Point(4, 32);
            viewJsonParameters.Name = "viewJsonParameters";
            viewJsonParameters.Size = new Size(753, 472);
            viewJsonParameters.TabIndex = 3;
            viewJsonParameters.Text = "Parameters";
            viewJsonParameters.UseVisualStyleBackColor = true;
            // 
            // parametersList
            // 
            parametersList.AutoGenerateColumns = false;
            parametersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametersList.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, defaultValueDataGridViewTextBoxColumn, referenceDataGridViewTextBoxColumn, validateDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            parametersList.DataSource = sifJsonParameterModelBindingSource;
            parametersList.Dock = DockStyle.Fill;
            parametersList.Location = new Point(0, 40);
            parametersList.Name = "parametersList";
            parametersList.ReadOnly = true;
            parametersList.RowHeadersWidth = 51;
            parametersList.Size = new Size(753, 432);
            parametersList.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // defaultValueDataGridViewTextBoxColumn
            // 
            defaultValueDataGridViewTextBoxColumn.DataPropertyName = "DefaultValue";
            defaultValueDataGridViewTextBoxColumn.HeaderText = "DefaultValue";
            defaultValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            defaultValueDataGridViewTextBoxColumn.Name = "defaultValueDataGridViewTextBoxColumn";
            defaultValueDataGridViewTextBoxColumn.ReadOnly = true;
            defaultValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            referenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            referenceDataGridViewTextBoxColumn.ReadOnly = true;
            referenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // validateDataGridViewTextBoxColumn
            // 
            validateDataGridViewTextBoxColumn.DataPropertyName = "Validate";
            validateDataGridViewTextBoxColumn.HeaderText = "Validate";
            validateDataGridViewTextBoxColumn.MinimumWidth = 6;
            validateDataGridViewTextBoxColumn.Name = "validateDataGridViewTextBoxColumn";
            validateDataGridViewTextBoxColumn.ReadOnly = true;
            validateDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifJsonParameterModelBindingSource
            // 
            sifJsonParameterModelBindingSource.DataSource = typeof(JsonParser.SifJsonParameterModel);
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(textBox1);
            flowLayoutPanel9.Dock = DockStyle.Top;
            flowLayoutPanel9.Location = new Point(0, 0);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(753, 40);
            flowLayoutPanel9.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Filter";
            textBox1.Size = new Size(778, 30);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += parametersFilter_TextChanged;
            // 
            // viewJsonVariables
            // 
            viewJsonVariables.Controls.Add(variablesList);
            viewJsonVariables.Controls.Add(flowLayoutPanel8);
            viewJsonVariables.Location = new Point(4, 32);
            viewJsonVariables.Name = "viewJsonVariables";
            viewJsonVariables.Size = new Size(753, 472);
            viewJsonVariables.TabIndex = 4;
            viewJsonVariables.Text = "Variables";
            viewJsonVariables.UseVisualStyleBackColor = true;
            // 
            // variablesList
            // 
            variablesList.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            variablesList.Dock = DockStyle.Fill;
            variablesList.FullRowSelect = true;
            variablesList.GridLines = true;
            variablesList.Location = new Point(0, 40);
            variablesList.MultiSelect = false;
            variablesList.Name = "variablesList";
            variablesList.Size = new Size(753, 432);
            variablesList.TabIndex = 1;
            variablesList.Tag = "Variables";
            variablesList.UseCompatibleStateImageBehavior = false;
            variablesList.View = View.Details;
            variablesList.DoubleClick += variablesList_DoubleClick;
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
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(variablesFilter);
            flowLayoutPanel8.Dock = DockStyle.Top;
            flowLayoutPanel8.Location = new Point(0, 0);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(753, 40);
            flowLayoutPanel8.TabIndex = 2;
            // 
            // variablesFilter
            // 
            variablesFilter.Dock = DockStyle.Top;
            variablesFilter.Location = new Point(3, 3);
            variablesFilter.Name = "variablesFilter";
            variablesFilter.PlaceholderText = "Filter";
            variablesFilter.Size = new Size(778, 30);
            variablesFilter.TabIndex = 0;
            variablesFilter.TextChanged += variablesFilter_TextChanged;
            // 
            // viewJsonIncludes
            // 
            viewJsonIncludes.Controls.Add(includesList);
            viewJsonIncludes.Location = new Point(4, 32);
            viewJsonIncludes.Name = "viewJsonIncludes";
            viewJsonIncludes.Size = new Size(753, 472);
            viewJsonIncludes.TabIndex = 5;
            viewJsonIncludes.Text = "Includes";
            viewJsonIncludes.UseVisualStyleBackColor = true;
            // 
            // includesList
            // 
            includesList.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8 });
            includesList.Dock = DockStyle.Fill;
            includesList.FullRowSelect = true;
            includesList.GridLines = true;
            includesList.Location = new Point(0, 0);
            includesList.MultiSelect = false;
            includesList.Name = "includesList";
            includesList.Size = new Size(753, 472);
            includesList.TabIndex = 1;
            includesList.UseCompatibleStateImageBehavior = false;
            includesList.View = View.Details;
            includesList.DoubleClick += includesList_MouseDoubleClick;
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
            viewJsonModules.Size = new Size(753, 472);
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
            modulesList.Size = new Size(753, 472);
            modulesList.TabIndex = 1;
            modulesList.UseCompatibleStateImageBehavior = false;
            modulesList.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Path";
            columnHeader9.Width = 700;
            // 
            // viewJsonRegisteredTasks
            // 
            viewJsonRegisteredTasks.Controls.Add(registeredTasksList);
            viewJsonRegisteredTasks.Location = new Point(4, 32);
            viewJsonRegisteredTasks.Name = "viewJsonRegisteredTasks";
            viewJsonRegisteredTasks.Padding = new Padding(3);
            viewJsonRegisteredTasks.Size = new Size(753, 472);
            viewJsonRegisteredTasks.TabIndex = 7;
            viewJsonRegisteredTasks.Text = "Registered Tasks";
            viewJsonRegisteredTasks.UseVisualStyleBackColor = true;
            // 
            // registeredTasksList
            // 
            registeredTasksList.Columns.AddRange(new ColumnHeader[] { customTask, powershellTask });
            registeredTasksList.Dock = DockStyle.Fill;
            registeredTasksList.FullRowSelect = true;
            registeredTasksList.GridLines = true;
            registeredTasksList.Location = new Point(3, 3);
            registeredTasksList.MultiSelect = false;
            registeredTasksList.Name = "registeredTasksList";
            registeredTasksList.Size = new Size(747, 466);
            registeredTasksList.TabIndex = 2;
            registeredTasksList.UseCompatibleStateImageBehavior = false;
            registeredTasksList.View = View.Details;
            // 
            // customTask
            // 
            customTask.Text = "Custom Task";
            customTask.Width = 200;
            // 
            // powershellTask
            // 
            powershellTask.Text = "PowerShell Task";
            powershellTask.Width = 600;
            // 
            // viewJsonRegisteredConfigFunctions
            // 
            viewJsonRegisteredConfigFunctions.Controls.Add(registeredConfigFunctionsList);
            viewJsonRegisteredConfigFunctions.Location = new Point(4, 32);
            viewJsonRegisteredConfigFunctions.Name = "viewJsonRegisteredConfigFunctions";
            viewJsonRegisteredConfigFunctions.Padding = new Padding(3);
            viewJsonRegisteredConfigFunctions.Size = new Size(753, 472);
            viewJsonRegisteredConfigFunctions.TabIndex = 8;
            viewJsonRegisteredConfigFunctions.Text = "Registered Functions";
            viewJsonRegisteredConfigFunctions.UseVisualStyleBackColor = true;
            // 
            // registeredConfigFunctionsList
            // 
            registeredConfigFunctionsList.Columns.AddRange(new ColumnHeader[] { customFunction, powershellFunction });
            registeredConfigFunctionsList.Dock = DockStyle.Fill;
            registeredConfigFunctionsList.FullRowSelect = true;
            registeredConfigFunctionsList.GridLines = true;
            registeredConfigFunctionsList.Location = new Point(3, 3);
            registeredConfigFunctionsList.MultiSelect = false;
            registeredConfigFunctionsList.Name = "registeredConfigFunctionsList";
            registeredConfigFunctionsList.Size = new Size(747, 466);
            registeredConfigFunctionsList.TabIndex = 2;
            registeredConfigFunctionsList.UseCompatibleStateImageBehavior = false;
            registeredConfigFunctionsList.View = View.Details;
            // 
            // customFunction
            // 
            customFunction.Text = "Custom Function";
            customFunction.Width = 200;
            // 
            // powershellFunction
            // 
            powershellFunction.Text = "PowerShell Function";
            powershellFunction.Width = 600;
            // 
            // viewJsonSettings
            // 
            viewJsonSettings.Location = new Point(4, 32);
            viewJsonSettings.Name = "viewJsonSettings";
            viewJsonSettings.Padding = new Padding(3);
            viewJsonSettings.Size = new Size(753, 472);
            viewJsonSettings.TabIndex = 9;
            viewJsonSettings.Text = "Settings";
            viewJsonSettings.UseVisualStyleBackColor = true;
            // 
            // viewJsonWarnings
            // 
            viewJsonWarnings.Location = new Point(4, 32);
            viewJsonWarnings.Name = "viewJsonWarnings";
            viewJsonWarnings.Padding = new Padding(3);
            viewJsonWarnings.Size = new Size(753, 472);
            viewJsonWarnings.TabIndex = 10;
            viewJsonWarnings.Text = "ℹ️ Parse Warnings";
            viewJsonWarnings.UseVisualStyleBackColor = true;
            // 
            // changeFileButton
            // 
            changeFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            changeFileButton.BackColor = Color.Transparent;
            changeFileButton.Font = new Font("Segoe UI", 22F);
            changeFileButton.Location = new Point(596, 8);
            changeFileButton.Margin = new Padding(0);
            changeFileButton.Name = "changeFileButton";
            changeFileButton.Size = new Size(73, 56);
            changeFileButton.TabIndex = 6;
            changeFileButton.Text = "🔃";
            changeFileButton.UseVisualStyleBackColor = false;
            changeFileButton.Click += openFileDialog_Click;
            // 
            // openFileForViewerDialog
            // 
            openFileForViewerDialog.AddToRecent = false;
            openFileForViewerDialog.DefaultExt = "json";
            openFileForViewerDialog.Filter = "SIF JSON|*.json";
            openFileForViewerDialog.ReadOnlyChecked = true;
            openFileForViewerDialog.RestoreDirectory = true;
            // 
            // SifJsonViewerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(executeButton);
            Controls.Add(openFolderButton);
            Controls.Add(changeFileButton);
            Controls.Add(viewJsonTabs);
            Controls.Add(FilePathText);
            Controls.Add(navigationPanel);
            Name = "SifJsonViewerForm";
            Size = new Size(761, 616);
            viewJsonTabs.ResumeLayout(false);
            viewJsonTasks.ResumeLayout(false);
            TasksContextMenu.ResumeLayout(false);
            tasksFilters.ResumeLayout(false);
            tasksFilters.PerformLayout();
            viewJsonUninstallTasks.ResumeLayout(false);
            viewJsonParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)parametersList).EndInit();
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).EndInit();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            viewJsonVariables.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            viewJsonIncludes.ResumeLayout(false);
            viewJsonModules.ResumeLayout(false);
            viewJsonRegisteredTasks.ResumeLayout(false);
            viewJsonRegisteredConfigFunctions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.NavigationPanel navigationPanel;
        private TextBox FilePathText;
        private TabControl viewJsonTabs;
        private TabPage viewJsonTasks;
        internal ListView tasksViewer;
        private ColumnHeader tasksTabNameColumn;
        private ColumnHeader tasksTabDescriptionColumn;
        private FlowLayoutPanel tasksFilters;
        internal TextBox filterText;
        private TabPage viewJsonUninstallTasks;
        internal ListView uninstallTasksList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TabPage viewJsonParameters;
        internal DataGridView parametersList;
        private FlowLayoutPanel flowLayoutPanel9;
        internal TextBox textBox1;
        private TabPage viewJsonVariables;
        internal ListView variablesList;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private FlowLayoutPanel flowLayoutPanel8;
        internal TextBox variablesFilter;
        private TabPage viewJsonIncludes;
        internal ListView includesList;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TabPage viewJsonModules;
        internal ListView modulesList;
        private ColumnHeader columnHeader9;
        internal TabPage viewJsonRegisteredTasks;
        public ListView registeredTasksList;
        private ColumnHeader customTask;
        private ColumnHeader powershellTask;
        private TabPage viewJsonRegisteredConfigFunctions;
        internal ListView registeredConfigFunctionsList;
        private ColumnHeader customFunction;
        private ColumnHeader powershellFunction;
        private TabPage viewJsonSettings;
        public TabPage viewJsonWarnings;
        internal Button changeFileButton;
        internal Button executeButton;
        internal Button openFolderButton;
        private OpenFileDialog openFileForViewerDialog;
        private BindingSource sifJsonParameterModelBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defaultValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn validateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ContextMenuStrip TasksContextMenu;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyTaskName;
        private ToolStripMenuItem copyTaskDescription;
        private ToolStripMenuItem executeToolStripMenuItem;
    }
}
