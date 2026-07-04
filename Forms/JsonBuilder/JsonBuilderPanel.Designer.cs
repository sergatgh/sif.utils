namespace SIF.Utils.Forms.JsonBuilder
{
    using SIF.Utils.Forms.JsonBuilder.SectionOrder;
    using SIF.Utils.Forms.JsonBuilder.TaskBuilder;

    partial class JsonBuilderPanel
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
            viewJsonTabs = new TabControl();
            viewJsonTasks = new TabPage();
            taskBuilderPanel1 = new TaskBuilderPanel();
            viewJsonUninstallTasks = new TabPage();
            uninstallTaskBuilderPanel = new TaskBuilderPanel();
            viewJsonParameters = new TabPage();
            parametersForm1 = new SIF.Utils.Forms.JsonBuilder.Parameters.ParametersForm();
            viewJsonVariables = new TabPage();
            variablesForm1 = new SIF.Utils.Forms.JsonBuilder.Variables.VariablesForm();
            viewJsonIncludes = new TabPage();
            includeFiles1 = new SIF.Utils.Forms.JsonBuilder.Includes.IncludeFiles();
            viewJsonModules = new TabPage();
            modulesControlPanel1 = new SIF.Utils.Forms.JsonBuilder.Modules.ModulesControlPanel();
            viewJsonRegisteredTasks = new TabPage();
            registerTasks = new SIF.Utils.Forms.JsonBuilder.Register.RegisterMethodTable();
            viewJsonRegisteredConfigFunctions = new TabPage();
            registerFunctions = new SIF.Utils.Forms.JsonBuilder.Register.RegisterMethodTable();
            viewJsonSettings = new TabPage();
            settingsForm1 = new SIF.Utils.Forms.JsonBuilder.Settings.SettingsForm();
            viewJsonSectionOrder = new TabPage();
            sectionOrderPanel1 = new SectionOrderPanel();
            viewJsonTabs.SuspendLayout();
            viewJsonTasks.SuspendLayout();
            viewJsonUninstallTasks.SuspendLayout();
            viewJsonParameters.SuspendLayout();
            viewJsonVariables.SuspendLayout();
            viewJsonIncludes.SuspendLayout();
            viewJsonModules.SuspendLayout();
            viewJsonRegisteredTasks.SuspendLayout();
            viewJsonRegisteredConfigFunctions.SuspendLayout();
            viewJsonSettings.SuspendLayout();
            viewJsonSectionOrder.SuspendLayout();
            SuspendLayout();
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
            viewJsonTabs.Controls.Add(viewJsonSectionOrder);
            viewJsonTabs.Dock = DockStyle.Fill;
            viewJsonTabs.Location = new Point(0, 0);
            viewJsonTabs.Name = "viewJsonTabs";
            viewJsonTabs.SelectedIndex = 0;
            viewJsonTabs.Size = new Size(935, 360);
            viewJsonTabs.TabIndex = 4;
            // 
            // viewJsonTasks
            // 
            viewJsonTasks.Controls.Add(taskBuilderPanel1);
            viewJsonTasks.Location = new Point(4, 32);
            viewJsonTasks.Name = "viewJsonTasks";
            viewJsonTasks.Padding = new Padding(3);
            viewJsonTasks.Size = new Size(927, 324);
            viewJsonTasks.TabIndex = 1;
            viewJsonTasks.Text = "Tasks";
            viewJsonTasks.UseVisualStyleBackColor = true;
            // 
            // taskBuilderPanel1
            // 
            taskBuilderPanel1.Dock = DockStyle.Fill;
            taskBuilderPanel1.Location = new Point(3, 3);
            taskBuilderPanel1.Name = "taskBuilderPanel1";
            taskBuilderPanel1.Size = new Size(921, 318);
            taskBuilderPanel1.TabIndex = 0;
            taskBuilderPanel1.TaskAdded += taskBuilderPanel1_TaskAdded;
            // 
            // viewJsonUninstallTasks
            // 
            viewJsonUninstallTasks.Controls.Add(uninstallTaskBuilderPanel);
            viewJsonUninstallTasks.Location = new Point(4, 32);
            viewJsonUninstallTasks.Name = "viewJsonUninstallTasks";
            viewJsonUninstallTasks.Padding = new Padding(3);
            viewJsonUninstallTasks.Size = new Size(192, 64);
            viewJsonUninstallTasks.TabIndex = 2;
            viewJsonUninstallTasks.Text = "UninstallTasks";
            viewJsonUninstallTasks.ToolTipText = "Coming Soon";
            viewJsonUninstallTasks.UseVisualStyleBackColor = true;
            // 
            // uninstallTaskBuilderPanel
            // 
            uninstallTaskBuilderPanel.Dock = DockStyle.Fill;
            uninstallTaskBuilderPanel.Location = new Point(3, 3);
            uninstallTaskBuilderPanel.Name = "uninstallTaskBuilderPanel";
            uninstallTaskBuilderPanel.Size = new Size(186, 58);
            uninstallTaskBuilderPanel.TabIndex = 1;
            // 
            // viewJsonParameters
            // 
            viewJsonParameters.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonParameters.Controls.Add(parametersForm1);
            viewJsonParameters.Location = new Point(4, 32);
            viewJsonParameters.Name = "viewJsonParameters";
            viewJsonParameters.Size = new Size(192, 64);
            viewJsonParameters.TabIndex = 3;
            viewJsonParameters.Text = "Parameters";
            viewJsonParameters.ToolTipText = "Coming Soon";
            viewJsonParameters.UseVisualStyleBackColor = true;
            // 
            // parametersForm1
            // 
            parametersForm1.BackColor = Color.Transparent;
            parametersForm1.Dock = DockStyle.Fill;
            parametersForm1.Location = new Point(0, 0);
            parametersForm1.Name = "parametersForm1";
            parametersForm1.Size = new Size(192, 64);
            parametersForm1.TabIndex = 0;
            // 
            // viewJsonVariables
            // 
            viewJsonVariables.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonVariables.Controls.Add(variablesForm1);
            viewJsonVariables.Location = new Point(4, 32);
            viewJsonVariables.Name = "viewJsonVariables";
            viewJsonVariables.Size = new Size(192, 64);
            viewJsonVariables.TabIndex = 4;
            viewJsonVariables.Text = "Variables";
            viewJsonVariables.ToolTipText = "Coming Soon";
            viewJsonVariables.UseVisualStyleBackColor = true;
            // 
            // variablesForm1
            // 
            variablesForm1.Dock = DockStyle.Fill;
            variablesForm1.Location = new Point(0, 0);
            variablesForm1.Name = "variablesForm1";
            variablesForm1.Size = new Size(192, 64);
            variablesForm1.TabIndex = 0;
            // 
            // viewJsonIncludes
            // 
            viewJsonIncludes.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonIncludes.Controls.Add(includeFiles1);
            viewJsonIncludes.Location = new Point(4, 32);
            viewJsonIncludes.Name = "viewJsonIncludes";
            viewJsonIncludes.Size = new Size(927, 324);
            viewJsonIncludes.TabIndex = 5;
            viewJsonIncludes.Text = "Includes";
            viewJsonIncludes.ToolTipText = "Coming Soon";
            viewJsonIncludes.UseVisualStyleBackColor = true;
            // 
            // includeFiles1
            // 
            includeFiles1.Dock = DockStyle.Fill;
            includeFiles1.Location = new Point(0, 0);
            includeFiles1.Name = "includeFiles1";
            includeFiles1.Size = new Size(927, 324);
            includeFiles1.TabIndex = 0;
            // 
            // viewJsonModules
            // 
            viewJsonModules.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonModules.Controls.Add(modulesControlPanel1);
            viewJsonModules.Location = new Point(4, 32);
            viewJsonModules.Name = "viewJsonModules";
            viewJsonModules.Size = new Size(192, 64);
            viewJsonModules.TabIndex = 6;
            viewJsonModules.Text = "Modules";
            viewJsonModules.ToolTipText = "Coming Soon";
            viewJsonModules.UseVisualStyleBackColor = true;
            // 
            // modulesControlPanel1
            // 
            modulesControlPanel1.Dock = DockStyle.Fill;
            modulesControlPanel1.Location = new Point(0, 0);
            modulesControlPanel1.Name = "modulesControlPanel1";
            modulesControlPanel1.Size = new Size(192, 64);
            modulesControlPanel1.TabIndex = 0;
            // 
            // viewJsonRegisteredTasks
            // 
            viewJsonRegisteredTasks.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonRegisteredTasks.Controls.Add(registerTasks);
            viewJsonRegisteredTasks.Location = new Point(4, 32);
            viewJsonRegisteredTasks.Name = "viewJsonRegisteredTasks";
            viewJsonRegisteredTasks.Padding = new Padding(3);
            viewJsonRegisteredTasks.Size = new Size(192, 64);
            viewJsonRegisteredTasks.TabIndex = 7;
            viewJsonRegisteredTasks.Text = "Registered Tasks";
            viewJsonRegisteredTasks.ToolTipText = "Coming Soon";
            viewJsonRegisteredTasks.UseVisualStyleBackColor = true;
            // 
            // registerTasks
            // 
            registerTasks.Dock = DockStyle.Fill;
            registerTasks.Location = new Point(3, 3);
            registerTasks.Name = "registerTasks";
            registerTasks.Size = new Size(186, 58);
            registerTasks.TabIndex = 0;
            registerTasks.MethodAdded += registerTasks_MethodAdded;
            registerTasks.MethodRemoved += registerTasks_MethodRemoved;
            // 
            // viewJsonRegisteredConfigFunctions
            // 
            viewJsonRegisteredConfigFunctions.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonRegisteredConfigFunctions.Controls.Add(registerFunctions);
            viewJsonRegisteredConfigFunctions.Location = new Point(4, 32);
            viewJsonRegisteredConfigFunctions.Name = "viewJsonRegisteredConfigFunctions";
            viewJsonRegisteredConfigFunctions.Padding = new Padding(3);
            viewJsonRegisteredConfigFunctions.Size = new Size(192, 64);
            viewJsonRegisteredConfigFunctions.TabIndex = 8;
            viewJsonRegisteredConfigFunctions.Text = "Registered Functions";
            viewJsonRegisteredConfigFunctions.ToolTipText = "Coming Soon";
            viewJsonRegisteredConfigFunctions.UseVisualStyleBackColor = true;
            // 
            // registerFunctions
            // 
            registerFunctions.Dock = DockStyle.Fill;
            registerFunctions.Location = new Point(3, 3);
            registerFunctions.Name = "registerFunctions";
            registerFunctions.Size = new Size(186, 58);
            registerFunctions.TabIndex = 1;
            // 
            // viewJsonSettings
            // 
            viewJsonSettings.Controls.Add(settingsForm1);
            viewJsonSettings.Location = new Point(4, 32);
            viewJsonSettings.Name = "viewJsonSettings";
            viewJsonSettings.Padding = new Padding(3);
            viewJsonSettings.Size = new Size(192, 64);
            viewJsonSettings.TabIndex = 9;
            viewJsonSettings.Text = "Settings";
            viewJsonSettings.UseVisualStyleBackColor = true;
            // 
            // settingsForm1
            // 
            settingsForm1.Dock = DockStyle.Fill;
            settingsForm1.Location = new Point(3, 3);
            settingsForm1.Name = "settingsForm1";
            settingsForm1.Size = new Size(186, 58);
            settingsForm1.TabIndex = 0;
            // 
            // viewJsonSectionOrder
            // 
            viewJsonSectionOrder.Controls.Add(sectionOrderPanel1);
            viewJsonSectionOrder.Location = new Point(4, 32);
            viewJsonSectionOrder.Name = "viewJsonSectionOrder";
            viewJsonSectionOrder.Padding = new Padding(3);
            viewJsonSectionOrder.Size = new Size(192, 64);
            viewJsonSectionOrder.TabIndex = 10;
            viewJsonSectionOrder.Text = "Section Order";
            viewJsonSectionOrder.UseVisualStyleBackColor = true;
            // 
            // sectionOrderPanel1
            // 
            sectionOrderPanel1.Dock = DockStyle.Fill;
            sectionOrderPanel1.Location = new Point(3, 3);
            sectionOrderPanel1.Name = "sectionOrderPanel1";
            sectionOrderPanel1.Size = new Size(186, 58);
            sectionOrderPanel1.TabIndex = 0;
            // 
            // JsonBuilderPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewJsonTabs);
            Name = "JsonBuilderPanel";
            Size = new Size(935, 360);
            viewJsonTabs.ResumeLayout(false);
            viewJsonTasks.ResumeLayout(false);
            viewJsonUninstallTasks.ResumeLayout(false);
            viewJsonParameters.ResumeLayout(false);
            viewJsonVariables.ResumeLayout(false);
            viewJsonIncludes.ResumeLayout(false);
            viewJsonModules.ResumeLayout(false);
            viewJsonRegisteredTasks.ResumeLayout(false);
            viewJsonRegisteredConfigFunctions.ResumeLayout(false);
            viewJsonSettings.ResumeLayout(false);
            viewJsonSectionOrder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl viewJsonTabs;
        private TabPage viewJsonTasks;
        private TabPage viewJsonUninstallTasks;
        private TabPage viewJsonParameters;
        private TabPage viewJsonIncludes;
        private TabPage viewJsonModules;
        internal TabPage viewJsonRegisteredTasks;
        private TabPage viewJsonRegisteredConfigFunctions;
        private TabPage viewJsonVariables;
        private TaskBuilderPanel taskBuilderPanel1;
        private Modules.ModulesControlPanel modulesControlPanel1;
        private Register.RegisterMethodTable registerTasks;
        private Register.RegisterMethodTable registerFunctions;
        private TaskBuilderPanel uninstallTaskBuilderPanel;
        private Parameters.ParametersForm parametersForm1;
        private Variables.VariablesForm variablesForm1;
        private Includes.IncludeFiles includeFiles1;
        private TabPage viewJsonSettings;
        private Settings.SettingsForm settingsForm1;
        private TabPage viewJsonSectionOrder;
        private SectionOrderPanel sectionOrderPanel1;
    }
}
