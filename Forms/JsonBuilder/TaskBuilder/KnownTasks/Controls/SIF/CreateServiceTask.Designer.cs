namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class CreateServiceTask
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
            serviceDescription = new LabeledTextbox();
            serviceType = new ComboBox();
            label1 = new Label();
            displayNameInput = new LabeledTextbox();
            executableParameters = new LabeledTextbox();
            executablePath = new LabeledTextbox();
            serviceNameInput = new LabeledTextbox();
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
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(459, 377);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(serviceDescription);
            tabPage1.Controls.Add(serviceType);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(displayNameInput);
            tabPage1.Controls.Add(executableParameters);
            tabPage1.Controls.Add(executablePath);
            tabPage1.Controls.Add(serviceNameInput);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(451, 349);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Service";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // serviceDescription
            // 
            serviceDescription.Dock = DockStyle.Top;
            serviceDescription.Location = new Point(2, 240);
            serviceDescription.Margin = new Padding(2, 1, 2, 1);
            serviceDescription.Multiline = false;
            serviceDescription.Name = "serviceDescription";
            serviceDescription.PathSelectionFilter = "";
            serviceDescription.PathSelectMode = PathSelectMode.Folder;
            serviceDescription.ShowPathSelector = false;
            serviceDescription.Size = new Size(447, 33);
            serviceDescription.TabIndex = 9;
            serviceDescription.TextInput = "";
            serviceDescription.TextLabel = "Service Description";
            serviceDescription.Vertical = true;
            // 
            // serviceType
            // 
            serviceType.Dock = DockStyle.Top;
            serviceType.FormattingEnabled = true;
            serviceType.Items.AddRange(new object[] { "Automatic", "Boot", "Disabled", "Manual", "System" });
            serviceType.Location = new Point(2, 217);
            serviceType.Margin = new Padding(2, 2, 2, 2);
            serviceType.Name = "serviceType";
            serviceType.Size = new Size(447, 23);
            serviceType.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 202);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 7;
            label1.Text = "Service Startup Type";
            // 
            // displayNameInput
            // 
            displayNameInput.Dock = DockStyle.Top;
            displayNameInput.Location = new Point(2, 169);
            displayNameInput.Margin = new Padding(2, 1, 2, 1);
            displayNameInput.Multiline = false;
            displayNameInput.Name = "displayNameInput";
            displayNameInput.PathSelectionFilter = "";
            displayNameInput.PathSelectMode = PathSelectMode.Folder;
            displayNameInput.ShowPathSelector = false;
            displayNameInput.Size = new Size(447, 33);
            displayNameInput.TabIndex = 10;
            displayNameInput.TextInput = "";
            displayNameInput.TextLabel = "Service Display Name";
            displayNameInput.Vertical = true;
            // 
            // executableParameters
            // 
            executableParameters.Dock = DockStyle.Top;
            executableParameters.Location = new Point(2, 69);
            executableParameters.Margin = new Padding(2, 1, 2, 1);
            executableParameters.Multiline = true;
            executableParameters.Name = "executableParameters";
            executableParameters.PathSelectionFilter = "";
            executableParameters.PathSelectMode = PathSelectMode.Folder;
            executableParameters.ShowPathSelector = false;
            executableParameters.Size = new Size(447, 100);
            executableParameters.TabIndex = 6;
            executableParameters.TextInput = "";
            executableParameters.TextLabel = "Parameters passed to executable (one per line)";
            executableParameters.Vertical = true;
            // 
            // executablePath
            // 
            executablePath.Dock = DockStyle.Top;
            executablePath.Location = new Point(2, 35);
            executablePath.Margin = new Padding(2, 1, 2, 1);
            executablePath.Multiline = false;
            executablePath.Name = "executablePath";
            executablePath.PathSelectionFilter = "";
            executablePath.PathSelectMode = PathSelectMode.File;
            executablePath.ShowPathSelector = true;
            executablePath.Size = new Size(447, 34);
            executablePath.TabIndex = 5;
            executablePath.TextInput = "";
            executablePath.TextLabel = "Path to executable *";
            executablePath.Vertical = true;
            // 
            // serviceNameInput
            // 
            serviceNameInput.Dock = DockStyle.Top;
            serviceNameInput.Location = new Point(2, 2);
            serviceNameInput.Margin = new Padding(2, 1, 2, 1);
            serviceNameInput.Multiline = false;
            serviceNameInput.Name = "serviceNameInput";
            serviceNameInput.PathSelectionFilter = "";
            serviceNameInput.PathSelectMode = PathSelectMode.Folder;
            serviceNameInput.ShowPathSelector = false;
            serviceNameInput.Size = new Size(447, 33);
            serviceNameInput.TabIndex = 4;
            serviceNameInput.TextInput = "";
            serviceNameInput.TextLabel = "Service Name *";
            serviceNameInput.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(451, 349);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(2, 2);
            taskEditor1.Margin = new Padding(2, 1, 2, 1);
            taskEditor1.MinimumSize = new Size(39, 33);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(447, 345);
            taskEditor1.TabIndex = 0;
            // 
            // CreateServiceTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CreateServiceTask";
            Size = new Size(459, 377);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox serviceNameInput;
        private LabeledTextbox displayNameInput;
        private LabeledTextbox serviceDescription;
        private ComboBox serviceType;
        private Label label1;
        private LabeledTextbox executableParameters;
        private LabeledTextbox executablePath;
    }
}
