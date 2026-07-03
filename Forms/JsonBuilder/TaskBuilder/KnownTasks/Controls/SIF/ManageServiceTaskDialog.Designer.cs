namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class ManageServiceTaskDialog
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
            postDelayNumber = new MaskedTextBox();
            label1 = new Label();
            displayNameText = new LabeledTextbox();
            descriptionText = new LabeledTextbox();
            serviceType = new ComboBox();
            label2 = new Label();
            statusText = new ComboBox();
            label3 = new Label();
            nameText = new LabeledTextbox();
            SuspendLayout();
            //
            // postDelayNumber
            //
            postDelayNumber.Dock = DockStyle.Top;
            postDelayNumber.Location = new Point(2, 228);
            postDelayNumber.Margin = new Padding(2, 2, 2, 2);
            postDelayNumber.Mask = "0000000";
            postDelayNumber.Name = "postDelayNumber";
            postDelayNumber.Size = new Size(501, 23);
            postDelayNumber.TabIndex = 8;
            postDelayNumber.ValidatingType = typeof(int);
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 213);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 5;
            label1.Text = "Post Delay (milliseconds)";
            //
            // displayNameText
            //
            displayNameText.Dock = DockStyle.Top;
            displayNameText.Location = new Point(2, 168);
            displayNameText.Margin = new Padding(2, 1, 2, 1);
            displayNameText.Multiline = false;
            displayNameText.Name = "displayNameText";
            displayNameText.PathSelectionFilter = "";
            displayNameText.PathSelectMode = PathSelectMode.Folder;
            displayNameText.ShowPathSelector = false;
            displayNameText.Size = new Size(501, 45);
            displayNameText.TabIndex = 4;
            displayNameText.TextInput = "";
            displayNameText.TextLabel = "Display Name";
            displayNameText.Vertical = true;
            //
            // descriptionText
            //
            descriptionText.Dock = DockStyle.Top;
            descriptionText.Location = new Point(2, 123);
            descriptionText.Margin = new Padding(2, 1, 2, 1);
            descriptionText.Multiline = false;
            descriptionText.Name = "descriptionText";
            descriptionText.PathSelectionFilter = "";
            descriptionText.PathSelectMode = PathSelectMode.Folder;
            descriptionText.ShowPathSelector = false;
            descriptionText.Size = new Size(501, 45);
            descriptionText.TabIndex = 3;
            descriptionText.TextInput = "";
            descriptionText.TextLabel = "Description";
            descriptionText.Vertical = true;
            //
            // serviceType
            //
            serviceType.Dock = DockStyle.Top;
            serviceType.FormattingEnabled = true;
            serviceType.Items.AddRange(new object[] { "Automatic", "Boot", "Disabled", "Manual", "System" });
            serviceType.Location = new Point(2, 100);
            serviceType.Margin = new Padding(2, 2, 2, 2);
            serviceType.Name = "serviceType";
            serviceType.Size = new Size(501, 23);
            serviceType.TabIndex = 10;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(2, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 9;
            label2.Text = "Service Startup Type";
            //
            // statusText
            //
            statusText.Dock = DockStyle.Top;
            statusText.FormattingEnabled = true;
            statusText.Items.AddRange(new object[] { "Running", "Stopped", "Paused" });
            statusText.Location = new Point(2, 62);
            statusText.Margin = new Padding(2, 2, 2, 2);
            statusText.Name = "statusText";
            statusText.Size = new Size(501, 23);
            statusText.TabIndex = 12;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(2, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Status";
            //
            // nameText
            //
            nameText.Dock = DockStyle.Top;
            nameText.Location = new Point(2, 2);
            nameText.Margin = new Padding(2, 1, 2, 1);
            nameText.Multiline = false;
            nameText.Name = "nameText";
            nameText.PathSelectionFilter = "";
            nameText.PathSelectMode = PathSelectMode.Folder;
            nameText.ShowPathSelector = false;
            nameText.Size = new Size(501, 45);
            nameText.TabIndex = 0;
            nameText.TextInput = "";
            nameText.TextLabel = "Name *";
            nameText.Vertical = true;
            //
            // ManageServiceTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(postDelayNumber);
            Controls.Add(label1);
            Controls.Add(displayNameText);
            Controls.Add(descriptionText);
            Controls.Add(serviceType);
            Controls.Add(label2);
            Controls.Add(statusText);
            Controls.Add(label3);
            Controls.Add(nameText);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ManageServiceTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(505, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public LabeledTextbox displayNameText;
        public LabeledTextbox descriptionText;
        public LabeledTextbox nameText;
        public MaskedTextBox postDelayNumber;
        private Label label1;
        public ComboBox statusText;
        private Label label3;
        public ComboBox serviceType;
        private Label label2;
    }
}
