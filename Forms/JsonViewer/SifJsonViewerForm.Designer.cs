using SIF.Utils.Logic.JsonParser;

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
            executeButton = new Button();
            changeFileButton = new Button();
            openFolderButton = new Button();
            openInBuilderButton = new Button();
            FilePathText = new TextBox();
            viewJsonTabs = new TabControl();
            viewJsonTasks = new TabPage();
            tasksList = new SIF.Utils.Forms.JsonViewer.Tasks.TasksList();
            viewJsonUninstallTasks = new TabPage();
            uninstallTasksList = new SIF.Utils.Forms.JsonViewer.Tasks.TasksList();
            viewJsonParameters = new TabPage();
            parametersList = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defaultValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            referenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            validateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametersContextMenu = new ContextMenuStrip(components);
            showParameterReferrersMenuItem = new ToolStripMenuItem();
            sifJsonParameterModelBindingSource = new BindingSource(components);
            flowLayoutPanel9 = new FlowLayoutPanel();
            paramtersFilterText = new TextBox();
            viewJsonVariables = new TabPage();
            variablesList = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            variablesContextMenu = new ContextMenuStrip(components);
            showReferencesMenuItem = new ToolStripMenuItem();
            showReferrersMenuItem = new ToolStripMenuItem();
            showReferenceMenuItem = new ToolStripMenuItem();
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
            errorActionText = new SIF.Utils.Forms.JsonBuilder.LabeledTextbox();
            warnActionText = new SIF.Utils.Forms.JsonBuilder.LabeledTextbox();
            infoActionText = new SIF.Utils.Forms.JsonBuilder.LabeledTextbox();
            autoRegisterExtensionsCheck = new CheckBox();
            viewJsonWarnings = new TabPage();
            warningsList = new ListView();
            textColumn = new ColumnHeader();
            openFileForViewerDialog = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            viewJsonTabs.SuspendLayout();
            viewJsonTasks.SuspendLayout();
            viewJsonUninstallTasks.SuspendLayout();
            viewJsonParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parametersList).BeginInit();
            parametersContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).BeginInit();
            flowLayoutPanel9.SuspendLayout();
            viewJsonVariables.SuspendLayout();
            variablesContextMenu.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            viewJsonIncludes.SuspendLayout();
            viewJsonModules.SuspendLayout();
            viewJsonRegisteredTasks.SuspendLayout();
            viewJsonRegisteredConfigFunctions.SuspendLayout();
            viewJsonSettings.SuspendLayout();
            viewJsonWarnings.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Margin = new Padding(3, 2, 3, 2);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(760, 76);
            navigationPanel.TabIndex = 2;
            navigationPanel.Title = "SIF Viewer";
            // 
            // executeButton
            // 
            executeButton.BackColor = Color.Transparent;
            executeButton.Font = new Font("Segoe UI", 22F);
            executeButton.Location = new Point(231, 8);
            executeButton.Margin = new Padding(0);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(73, 56);
            executeButton.TabIndex = 7;
            executeButton.Text = "▶️";
            executeButton.UseVisualStyleBackColor = false;
            executeButton.Click += executeButton_Click;
            // 
            // changeFileButton
            // 
            changeFileButton.BackColor = Color.Transparent;
            changeFileButton.Font = new Font("Segoe UI", 22F);
            changeFileButton.Location = new Point(158, 8);
            changeFileButton.Margin = new Padding(0);
            changeFileButton.Name = "changeFileButton";
            changeFileButton.Size = new Size(73, 56);
            changeFileButton.TabIndex = 6;
            changeFileButton.Text = "🔃";
            changeFileButton.UseVisualStyleBackColor = false;
            changeFileButton.Click += openFileDialog_Click;
            // 
            // openFolderButton
            // 
            openFolderButton.BackColor = Color.Transparent;
            openFolderButton.Font = new Font("Segoe UI", 22F);
            openFolderButton.Location = new Point(85, 8);
            openFolderButton.Margin = new Padding(0);
            openFolderButton.Name = "openFolderButton";
            openFolderButton.Size = new Size(73, 56);
            openFolderButton.TabIndex = 7;
            openFolderButton.Text = "📂";
            openFolderButton.UseVisualStyleBackColor = false;
            openFolderButton.Click += openFolderButton_Click;
            // 
            // openInBuilderButton
            // 
            openInBuilderButton.BackColor = Color.Transparent;
            openInBuilderButton.Font = new Font("Segoe UI", 22F);
            openInBuilderButton.Location = new Point(0, 0);
            openInBuilderButton.Margin = new Padding(0);
            openInBuilderButton.Name = "openInBuilderButton";
            openInBuilderButton.Size = new Size(73, 56);
            openInBuilderButton.TabIndex = 8;
            openInBuilderButton.Text = "🔨";
            openInBuilderButton.UseVisualStyleBackColor = false;
            openInBuilderButton.Click += openInBuilderButton_Click;
            // 
            // FilePathText
            // 
            FilePathText.Dock = DockStyle.Top;
            FilePathText.Font = new Font("Segoe UI", 11F);
            FilePathText.Location = new Point(0, 76);
            FilePathText.Margin = new Padding(3, 2, 3, 2);
            FilePathText.Name = "FilePathText";
            FilePathText.ReadOnly = true;
            FilePathText.ScrollBars = ScrollBars.Horizontal;
            FilePathText.Size = new Size(760, 32);
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
            viewJsonTabs.Margin = new Padding(3, 2, 3, 2);
            viewJsonTabs.Name = "viewJsonTabs";
            viewJsonTabs.SelectedIndex = 0;
            viewJsonTabs.Size = new Size(760, 508);
            viewJsonTabs.TabIndex = 4;
            // 
            // viewJsonTasks
            // 
            viewJsonTasks.Controls.Add(tasksList);
            viewJsonTasks.Location = new Point(4, 32);
            viewJsonTasks.Margin = new Padding(3, 2, 3, 2);
            viewJsonTasks.Name = "viewJsonTasks";
            viewJsonTasks.Padding = new Padding(3, 2, 3, 2);
            viewJsonTasks.Size = new Size(752, 472);
            viewJsonTasks.TabIndex = 1;
            viewJsonTasks.Text = "Tasks";
            viewJsonTasks.UseVisualStyleBackColor = true;
            // 
            // tasksList
            // 
            tasksList.Dock = DockStyle.Fill;
            tasksList.Location = new Point(3, 2);
            tasksList.Margin = new Padding(3, 2, 3, 2);
            tasksList.Name = "tasksList";
            tasksList.Size = new Size(746, 468);
            tasksList.TabIndex = 0;
            tasksList.OnExecuteTasks += tasksControl1_OnExecuteTasks;
            // 
            // viewJsonUninstallTasks
            // 
            viewJsonUninstallTasks.Controls.Add(uninstallTasksList);
            viewJsonUninstallTasks.Location = new Point(4, 32);
            viewJsonUninstallTasks.Margin = new Padding(3, 2, 3, 2);
            viewJsonUninstallTasks.Name = "viewJsonUninstallTasks";
            viewJsonUninstallTasks.Padding = new Padding(3, 2, 3, 2);
            viewJsonUninstallTasks.Size = new Size(752, 471);
            viewJsonUninstallTasks.TabIndex = 2;
            viewJsonUninstallTasks.Text = "UninstallTasks";
            viewJsonUninstallTasks.UseVisualStyleBackColor = true;
            // 
            // uninstallTasksList
            // 
            uninstallTasksList.Dock = DockStyle.Fill;
            uninstallTasksList.Location = new Point(3, 2);
            uninstallTasksList.Margin = new Padding(3, 2, 3, 2);
            uninstallTasksList.Name = "uninstallTasksList";
            uninstallTasksList.Size = new Size(746, 467);
            uninstallTasksList.TabIndex = 0;
            uninstallTasksList.OnExecuteTasks += uninstallTasksList_OnExecuteTasks;
            // 
            // viewJsonParameters
            // 
            viewJsonParameters.Controls.Add(parametersList);
            viewJsonParameters.Controls.Add(flowLayoutPanel9);
            viewJsonParameters.Location = new Point(4, 32);
            viewJsonParameters.Margin = new Padding(3, 2, 3, 2);
            viewJsonParameters.Name = "viewJsonParameters";
            viewJsonParameters.Size = new Size(752, 471);
            viewJsonParameters.TabIndex = 3;
            viewJsonParameters.Text = "Parameters";
            viewJsonParameters.UseVisualStyleBackColor = true;
            // 
            // parametersList
            // 
            parametersList.AutoGenerateColumns = false;
            parametersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametersList.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, defaultValueDataGridViewTextBoxColumn, referenceDataGridViewTextBoxColumn, validateDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            parametersList.ContextMenuStrip = parametersContextMenu;
            parametersList.DataSource = sifJsonParameterModelBindingSource;
            parametersList.Dock = DockStyle.Fill;
            parametersList.Location = new Point(0, 40);
            parametersList.Margin = new Padding(3, 2, 3, 2);
            parametersList.MultiSelect = false;
            parametersList.Name = "parametersList";
            parametersList.ReadOnly = true;
            parametersList.RowHeadersWidth = 51;
            parametersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            parametersList.Size = new Size(752, 431);
            parametersList.TabIndex = 0;
            parametersList.CellMouseDown += parametersList_CellMouseDown;
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
            // parametersContextMenu
            // 
            parametersContextMenu.ImageScalingSize = new Size(20, 20);
            parametersContextMenu.Items.AddRange(new ToolStripItem[] { showParameterReferrersMenuItem });
            parametersContextMenu.Name = "parametersContextMenu";
            parametersContextMenu.Size = new Size(194, 32);
            parametersContextMenu.Opening += parametersContextMenu_Opening;
            // 
            // showParameterReferrersMenuItem
            // 
            showParameterReferrersMenuItem.Name = "showParameterReferrersMenuItem";
            showParameterReferrersMenuItem.Size = new Size(193, 28);
            showParameterReferrersMenuItem.Text = "Show Referrers";
            showParameterReferrersMenuItem.Click += showParameterReferrersMenuItem_Click;
            // 
            // sifJsonParameterModelBindingSource
            // 
            sifJsonParameterModelBindingSource.DataSource = typeof(SifJsonParameterModel);
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(paramtersFilterText);
            flowLayoutPanel9.Dock = DockStyle.Top;
            flowLayoutPanel9.Location = new Point(0, 0);
            flowLayoutPanel9.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(752, 40);
            flowLayoutPanel9.TabIndex = 2;
            // 
            // paramtersFilterText
            // 
            paramtersFilterText.Dock = DockStyle.Top;
            paramtersFilterText.Location = new Point(3, 2);
            paramtersFilterText.Margin = new Padding(3, 2, 3, 2);
            paramtersFilterText.Name = "paramtersFilterText";
            paramtersFilterText.PlaceholderText = "Filter";
            paramtersFilterText.Size = new Size(778, 30);
            paramtersFilterText.TabIndex = 0;
            paramtersFilterText.TextChanged += parametersFilter_TextChanged;
            // 
            // viewJsonVariables
            // 
            viewJsonVariables.Controls.Add(variablesList);
            viewJsonVariables.Controls.Add(flowLayoutPanel8);
            viewJsonVariables.Location = new Point(4, 32);
            viewJsonVariables.Margin = new Padding(3, 2, 3, 2);
            viewJsonVariables.Name = "viewJsonVariables";
            viewJsonVariables.Size = new Size(752, 472);
            viewJsonVariables.TabIndex = 4;
            viewJsonVariables.Text = "Variables";
            viewJsonVariables.UseVisualStyleBackColor = true;
            // 
            // variablesList
            // 
            variablesList.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            variablesList.ContextMenuStrip = variablesContextMenu;
            variablesList.Dock = DockStyle.Fill;
            variablesList.FullRowSelect = true;
            variablesList.GridLines = true;
            variablesList.Location = new Point(0, 40);
            variablesList.Margin = new Padding(3, 2, 3, 2);
            variablesList.MultiSelect = false;
            variablesList.Name = "variablesList";
            variablesList.Size = new Size(752, 432);
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
            // variablesContextMenu
            // 
            variablesContextMenu.ImageScalingSize = new Size(20, 20);
            variablesContextMenu.Items.AddRange(new ToolStripItem[] { showReferencesMenuItem, showReferrersMenuItem, showReferenceMenuItem });
            variablesContextMenu.Name = "variablesContextMenu";
            variablesContextMenu.Size = new Size(209, 88);
            variablesContextMenu.Opening += variablesContextMenu_Opening;
            // 
            // showReferencesMenuItem
            // 
            showReferencesMenuItem.Name = "showReferencesMenuItem";
            showReferencesMenuItem.Size = new Size(208, 28);
            showReferencesMenuItem.Text = "Show References";
            showReferencesMenuItem.Click += showReferencesMenuItem_Click;
            // 
            // showReferrersMenuItem
            // 
            showReferrersMenuItem.Name = "showReferrersMenuItem";
            showReferrersMenuItem.Size = new Size(208, 28);
            showReferrersMenuItem.Text = "Show Referrers";
            showReferrersMenuItem.Click += showReferrersMenuItem_Click;
            // 
            // showReferenceMenuItem
            // 
            showReferenceMenuItem.Name = "showReferenceMenuItem";
            showReferenceMenuItem.Size = new Size(208, 28);
            showReferenceMenuItem.Text = "Show Reference";
            showReferenceMenuItem.Click += showReferenceMenuItem_Click;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(variablesFilter);
            flowLayoutPanel8.Dock = DockStyle.Top;
            flowLayoutPanel8.Location = new Point(0, 0);
            flowLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(752, 40);
            flowLayoutPanel8.TabIndex = 2;
            // 
            // variablesFilter
            // 
            variablesFilter.Dock = DockStyle.Top;
            variablesFilter.Location = new Point(3, 2);
            variablesFilter.Margin = new Padding(3, 2, 3, 2);
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
            viewJsonIncludes.Margin = new Padding(3, 2, 3, 2);
            viewJsonIncludes.Name = "viewJsonIncludes";
            viewJsonIncludes.Size = new Size(752, 471);
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
            includesList.Margin = new Padding(3, 2, 3, 2);
            includesList.MultiSelect = false;
            includesList.Name = "includesList";
            includesList.Size = new Size(752, 471);
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
            viewJsonModules.Margin = new Padding(3, 2, 3, 2);
            viewJsonModules.Name = "viewJsonModules";
            viewJsonModules.Size = new Size(752, 471);
            viewJsonModules.TabIndex = 6;
            viewJsonModules.Text = "Modules";
            viewJsonModules.UseVisualStyleBackColor = true;
            // 
            // modulesList
            // 
            modulesList.Columns.AddRange(new ColumnHeader[] { columnHeader9 });
            modulesList.Dock = DockStyle.Fill;
            modulesList.Location = new Point(0, 0);
            modulesList.Margin = new Padding(3, 2, 3, 2);
            modulesList.Name = "modulesList";
            modulesList.Size = new Size(752, 471);
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
            viewJsonRegisteredTasks.Margin = new Padding(3, 2, 3, 2);
            viewJsonRegisteredTasks.Name = "viewJsonRegisteredTasks";
            viewJsonRegisteredTasks.Padding = new Padding(3, 2, 3, 2);
            viewJsonRegisteredTasks.Size = new Size(752, 471);
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
            registeredTasksList.Location = new Point(3, 2);
            registeredTasksList.Margin = new Padding(3, 2, 3, 2);
            registeredTasksList.MultiSelect = false;
            registeredTasksList.Name = "registeredTasksList";
            registeredTasksList.Size = new Size(746, 467);
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
            viewJsonRegisteredConfigFunctions.Margin = new Padding(3, 2, 3, 2);
            viewJsonRegisteredConfigFunctions.Name = "viewJsonRegisteredConfigFunctions";
            viewJsonRegisteredConfigFunctions.Padding = new Padding(3, 2, 3, 2);
            viewJsonRegisteredConfigFunctions.Size = new Size(752, 471);
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
            registeredConfigFunctionsList.Location = new Point(3, 2);
            registeredConfigFunctionsList.Margin = new Padding(3, 2, 3, 2);
            registeredConfigFunctionsList.MultiSelect = false;
            registeredConfigFunctionsList.Name = "registeredConfigFunctionsList";
            registeredConfigFunctionsList.Size = new Size(746, 467);
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
            viewJsonSettings.Controls.Add(errorActionText);
            viewJsonSettings.Controls.Add(warnActionText);
            viewJsonSettings.Controls.Add(infoActionText);
            viewJsonSettings.Controls.Add(autoRegisterExtensionsCheck);
            viewJsonSettings.Location = new Point(4, 32);
            viewJsonSettings.Margin = new Padding(3, 2, 3, 2);
            viewJsonSettings.Name = "viewJsonSettings";
            viewJsonSettings.Padding = new Padding(3, 2, 3, 2);
            viewJsonSettings.Size = new Size(752, 471);
            viewJsonSettings.TabIndex = 9;
            viewJsonSettings.Text = "Settings";
            viewJsonSettings.UseVisualStyleBackColor = true;
            // 
            // errorActionText
            // 
            errorActionText.Enabled = false;
            errorActionText.Location = new Point(6, 159);
            errorActionText.Margin = new Padding(2);
            errorActionText.Multiline = false;
            errorActionText.Name = "errorActionText";
            errorActionText.PathSelectionFilter = "";
            errorActionText.PathSelectMode = PathSelectMode.Folder;
            errorActionText.ShowPathSelector = false;
            errorActionText.Size = new Size(366, 54);
            errorActionText.TabIndex = 3;
            errorActionText.TextInput = "";
            errorActionText.TextLabel = "Error Action";
            errorActionText.Vertical = true;
            // 
            // warnActionText
            // 
            warnActionText.Enabled = false;
            warnActionText.Location = new Point(6, 99);
            warnActionText.Margin = new Padding(2);
            warnActionText.Multiline = false;
            warnActionText.Name = "warnActionText";
            warnActionText.PathSelectionFilter = "";
            warnActionText.PathSelectMode = PathSelectMode.Folder;
            warnActionText.ShowPathSelector = false;
            warnActionText.Size = new Size(366, 54);
            warnActionText.TabIndex = 2;
            warnActionText.TextInput = "";
            warnActionText.TextLabel = "Warning Action";
            warnActionText.Vertical = true;
            // 
            // infoActionText
            // 
            infoActionText.Enabled = false;
            infoActionText.Location = new Point(6, 39);
            infoActionText.Margin = new Padding(2);
            infoActionText.Multiline = false;
            infoActionText.Name = "infoActionText";
            infoActionText.PathSelectionFilter = "";
            infoActionText.PathSelectMode = PathSelectMode.Folder;
            infoActionText.ShowPathSelector = false;
            infoActionText.Size = new Size(366, 54);
            infoActionText.TabIndex = 1;
            infoActionText.TextInput = "";
            infoActionText.TextLabel = "Information Action";
            infoActionText.Vertical = true;
            // 
            // autoRegisterExtensionsCheck
            // 
            autoRegisterExtensionsCheck.AutoSize = true;
            autoRegisterExtensionsCheck.Enabled = false;
            autoRegisterExtensionsCheck.Location = new Point(6, 6);
            autoRegisterExtensionsCheck.Margin = new Padding(3, 2, 3, 2);
            autoRegisterExtensionsCheck.Name = "autoRegisterExtensionsCheck";
            autoRegisterExtensionsCheck.Size = new Size(220, 27);
            autoRegisterExtensionsCheck.TabIndex = 0;
            autoRegisterExtensionsCheck.Text = "Auto Register Extensions";
            autoRegisterExtensionsCheck.UseVisualStyleBackColor = true;
            // 
            // viewJsonWarnings
            // 
            viewJsonWarnings.Controls.Add(warningsList);
            viewJsonWarnings.Location = new Point(4, 32);
            viewJsonWarnings.Margin = new Padding(3, 2, 3, 2);
            viewJsonWarnings.Name = "viewJsonWarnings";
            viewJsonWarnings.Padding = new Padding(3, 2, 3, 2);
            viewJsonWarnings.Size = new Size(752, 471);
            viewJsonWarnings.TabIndex = 10;
            viewJsonWarnings.Text = "ℹ️ Parse Warnings";
            viewJsonWarnings.UseVisualStyleBackColor = true;
            // 
            // warningsList
            // 
            warningsList.Columns.AddRange(new ColumnHeader[] { textColumn });
            warningsList.Dock = DockStyle.Fill;
            warningsList.Location = new Point(3, 2);
            warningsList.Margin = new Padding(3, 2, 3, 2);
            warningsList.Name = "warningsList";
            warningsList.Size = new Size(746, 467);
            warningsList.TabIndex = 0;
            warningsList.UseCompatibleStateImageBehavior = false;
            warningsList.View = View.Details;
            // 
            // textColumn
            // 
            textColumn.Text = "Warnings";
            textColumn.Width = 600;
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
            Controls.Add(viewJsonTabs);
            Controls.Add(FilePathText);
            Controls.Add(navigationPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SifJsonViewerForm";
            Size = new Size(760, 616);
            viewJsonTabs.ResumeLayout(false);
            viewJsonTasks.ResumeLayout(false);
            viewJsonUninstallTasks.ResumeLayout(false);
            viewJsonParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)parametersList).EndInit();
            parametersContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).EndInit();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            viewJsonVariables.ResumeLayout(false);
            variablesContextMenu.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            viewJsonIncludes.ResumeLayout(false);
            viewJsonModules.ResumeLayout(false);
            viewJsonRegisteredTasks.ResumeLayout(false);
            viewJsonRegisteredConfigFunctions.ResumeLayout(false);
            viewJsonSettings.ResumeLayout(false);
            viewJsonSettings.PerformLayout();
            viewJsonWarnings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.NavigationPanel navigationPanel;
        private TextBox FilePathText;
        private TabControl viewJsonTabs;
        private TabPage viewJsonTasks;
        private TabPage viewJsonUninstallTasks;
        private TabPage viewJsonParameters;
        internal DataGridView parametersList;
        private FlowLayoutPanel flowLayoutPanel9;
        internal TextBox paramtersFilterText;
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
        internal Button openInBuilderButton;
        private OpenFileDialog openFileForViewerDialog;
        private BindingSource sifJsonParameterModelBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defaultValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn validateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Tasks.TasksList tasksList;
        private Tasks.TasksList uninstallTasksList;
        private ToolTip toolTip1;
        private JsonBuilder.LabeledTextbox errorActionText;
        private JsonBuilder.LabeledTextbox warnActionText;
        private JsonBuilder.LabeledTextbox infoActionText;
        private CheckBox autoRegisterExtensionsCheck;
        private ListView warningsList;
        private ColumnHeader textColumn;
        private ContextMenuStrip variablesContextMenu;
        private ToolStripMenuItem showReferencesMenuItem;
        private ToolStripMenuItem showReferrersMenuItem;
        private ContextMenuStrip parametersContextMenu;
        private ToolStripMenuItem showParameterReferrersMenuItem;
        private ToolStripMenuItem showReferenceMenuItem;
    }
}
