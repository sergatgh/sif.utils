namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class CreateServiceTaskDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            serviceDescription = new LabeledTextbox();
            serviceType = new ComboBox();
            label1 = new Label();
            displayNameInput = new LabeledTextbox();
            executableParameters = new LabeledTextbox();
            executablePath = new LabeledTextbox();
            serviceNameInput = new LabeledTextbox();
            SuspendLayout();
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
            // CreateServiceTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(serviceDescription);
            Controls.Add(serviceType);
            Controls.Add(label1);
            Controls.Add(displayNameInput);
            Controls.Add(executableParameters);
            Controls.Add(executablePath);
            Controls.Add(serviceNameInput);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CreateServiceTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(451, 349);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public LabeledTextbox serviceNameInput;
        public LabeledTextbox displayNameInput;
        public LabeledTextbox serviceDescription;
        public ComboBox serviceType;
        private Label label1;
        public LabeledTextbox executableParameters;
        public LabeledTextbox executablePath;
    }
}
