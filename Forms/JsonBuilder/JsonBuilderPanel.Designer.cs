namespace SIF.Utils.Forms.JsonBuilder
{
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
            viewJsonParameters = new TabPage();
            viewJsonVariables = new TabPage();
            viewJsonIncludes = new TabPage();
            viewJsonModules = new TabPage();
            viewJsonRegisteredTasks = new TabPage();
            viewJsonRegisteredConfigFunctions = new TabPage();
            viewJsonSettings = new TabPage();
            autoRegisterExtensionsSetting = new CheckBox();
            viewJsonTabs.SuspendLayout();
            viewJsonTasks.SuspendLayout();
            viewJsonSettings.SuspendLayout();
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
            viewJsonUninstallTasks.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonUninstallTasks.Location = new Point(4, 32);
            viewJsonUninstallTasks.Name = "viewJsonUninstallTasks";
            viewJsonUninstallTasks.Padding = new Padding(3);
            viewJsonUninstallTasks.Size = new Size(927, 324);
            viewJsonUninstallTasks.TabIndex = 2;
            viewJsonUninstallTasks.Text = "UninstallTasks";
            viewJsonUninstallTasks.ToolTipText = "Coming Soon";
            viewJsonUninstallTasks.UseVisualStyleBackColor = true;
            // 
            // viewJsonParameters
            // 
            viewJsonParameters.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonParameters.Location = new Point(4, 32);
            viewJsonParameters.Name = "viewJsonParameters";
            viewJsonParameters.Size = new Size(927, 324);
            viewJsonParameters.TabIndex = 3;
            viewJsonParameters.Text = "Parameters";
            viewJsonParameters.ToolTipText = "Coming Soon";
            viewJsonParameters.UseVisualStyleBackColor = true;
            // 
            // viewJsonVariables
            // 
            viewJsonVariables.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonVariables.Location = new Point(4, 32);
            viewJsonVariables.Name = "viewJsonVariables";
            viewJsonVariables.Size = new Size(927, 324);
            viewJsonVariables.TabIndex = 4;
            viewJsonVariables.Text = "Variables";
            viewJsonVariables.ToolTipText = "Coming Soon";
            viewJsonVariables.UseVisualStyleBackColor = true;
            // 
            // viewJsonIncludes
            // 
            viewJsonIncludes.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonIncludes.Location = new Point(4, 32);
            viewJsonIncludes.Name = "viewJsonIncludes";
            viewJsonIncludes.Size = new Size(927, 324);
            viewJsonIncludes.TabIndex = 5;
            viewJsonIncludes.Text = "Includes";
            viewJsonIncludes.ToolTipText = "Coming Soon";
            viewJsonIncludes.UseVisualStyleBackColor = true;
            // 
            // viewJsonModules
            // 
            viewJsonModules.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonModules.Location = new Point(4, 32);
            viewJsonModules.Name = "viewJsonModules";
            viewJsonModules.Size = new Size(927, 324);
            viewJsonModules.TabIndex = 6;
            viewJsonModules.Text = "Modules";
            viewJsonModules.ToolTipText = "Coming Soon";
            viewJsonModules.UseVisualStyleBackColor = true;
            // 
            // viewJsonRegisteredTasks
            // 
            viewJsonRegisteredTasks.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonRegisteredTasks.Location = new Point(4, 32);
            viewJsonRegisteredTasks.Name = "viewJsonRegisteredTasks";
            viewJsonRegisteredTasks.Padding = new Padding(3);
            viewJsonRegisteredTasks.Size = new Size(927, 324);
            viewJsonRegisteredTasks.TabIndex = 7;
            viewJsonRegisteredTasks.Text = "Registered Tasks";
            viewJsonRegisteredTasks.ToolTipText = "Coming Soon";
            viewJsonRegisteredTasks.UseVisualStyleBackColor = true;
            // 
            // viewJsonRegisteredConfigFunctions
            // 
            viewJsonRegisteredConfigFunctions.BackColor = Color.FromArgb(224, 224, 224);
            viewJsonRegisteredConfigFunctions.Location = new Point(4, 32);
            viewJsonRegisteredConfigFunctions.Name = "viewJsonRegisteredConfigFunctions";
            viewJsonRegisteredConfigFunctions.Padding = new Padding(3);
            viewJsonRegisteredConfigFunctions.Size = new Size(927, 324);
            viewJsonRegisteredConfigFunctions.TabIndex = 8;
            viewJsonRegisteredConfigFunctions.Text = "Registered Functions";
            viewJsonRegisteredConfigFunctions.ToolTipText = "Coming Soon";
            viewJsonRegisteredConfigFunctions.UseVisualStyleBackColor = true;
            // 
            // viewJsonSettings
            // 
            viewJsonSettings.Controls.Add(autoRegisterExtensionsSetting);
            viewJsonSettings.Location = new Point(4, 32);
            viewJsonSettings.Name = "viewJsonSettings";
            viewJsonSettings.Padding = new Padding(3);
            viewJsonSettings.Size = new Size(927, 324);
            viewJsonSettings.TabIndex = 9;
            viewJsonSettings.Text = "Settings";
            viewJsonSettings.UseVisualStyleBackColor = true;
            // 
            // autoRegisterExtensionsSetting
            // 
            autoRegisterExtensionsSetting.AutoSize = true;
            autoRegisterExtensionsSetting.Location = new Point(6, 6);
            autoRegisterExtensionsSetting.Name = "autoRegisterExtensionsSetting";
            autoRegisterExtensionsSetting.Size = new Size(220, 27);
            autoRegisterExtensionsSetting.TabIndex = 0;
            autoRegisterExtensionsSetting.Text = "Auto Register Extensions";
            autoRegisterExtensionsSetting.UseVisualStyleBackColor = true;
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
            viewJsonSettings.ResumeLayout(false);
            viewJsonSettings.PerformLayout();
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
        private TabPage viewJsonSettings;
        private TabPage viewJsonVariables;
        private TaskBuilderPanel taskBuilderPanel1;
        private CheckBox autoRegisterExtensionsSetting;
    }
}
