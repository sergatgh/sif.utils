namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class ManageServiceTask
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
            postDelayNumber = new MaskedTextBox();
            label1 = new Label();
            displayNameText = new LabeledTextbox();
            descriptionText = new LabeledTextbox();
            serviceType = new ComboBox();
            label2 = new Label();
            statusText = new ComboBox();
            label3 = new Label();
            nameText = new LabeledTextbox();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(659, 733);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(postDelayNumber);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(displayNameText);
            tabPage1.Controls.Add(descriptionText);
            tabPage1.Controls.Add(serviceType);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(statusText);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(nameText);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(651, 697);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Service";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // postDelayNumber
            // 
            postDelayNumber.Dock = DockStyle.Top;
            postDelayNumber.Location = new Point(3, 341);
            postDelayNumber.Mask = "0000000";
            postDelayNumber.Name = "postDelayNumber";
            postDelayNumber.Size = new Size(645, 30);
            postDelayNumber.TabIndex = 8;
            postDelayNumber.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 318);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 5;
            label1.Text = "Post Delay (milliseconds)";
            // 
            // displayNameText
            // 
            displayNameText.Dock = DockStyle.Top;
            displayNameText.Location = new Point(3, 249);
            displayNameText.Multiline = false;
            displayNameText.Name = "displayNameText";
            displayNameText.PathSelectionFilter = "";
            displayNameText.PathSelectMode = PathSelectMode.Folder;
            displayNameText.ShowPathSelector = false;
            displayNameText.Size = new Size(645, 69);
            displayNameText.TabIndex = 4;
            displayNameText.TextInput = "";
            displayNameText.TextLabel = "Display Name";
            displayNameText.Vertical = true;
            // 
            // descriptionText
            // 
            descriptionText.Dock = DockStyle.Top;
            descriptionText.Location = new Point(3, 180);
            descriptionText.Multiline = false;
            descriptionText.Name = "descriptionText";
            descriptionText.PathSelectionFilter = "";
            descriptionText.PathSelectMode = PathSelectMode.Folder;
            descriptionText.ShowPathSelector = false;
            descriptionText.Size = new Size(645, 69);
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
            serviceType.Location = new Point(3, 149);
            serviceType.Name = "serviceType";
            serviceType.Size = new Size(645, 31);
            serviceType.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 126);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 9;
            label2.Text = "Service Startup Type";
            // 
            // statusText
            // 
            statusText.Dock = DockStyle.Top;
            statusText.FormattingEnabled = true;
            statusText.Items.AddRange(new object[] { "Running", "Stopped", "Paused" });
            statusText.Location = new Point(3, 95);
            statusText.Name = "statusText";
            statusText.Size = new Size(645, 31);
            statusText.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 11;
            label3.Text = "Status";
            // 
            // nameText
            // 
            nameText.Dock = DockStyle.Top;
            nameText.Location = new Point(3, 3);
            nameText.Multiline = false;
            nameText.Name = "nameText";
            nameText.PathSelectionFilter = "";
            nameText.PathSelectMode = PathSelectMode.Folder;
            nameText.ShowPathSelector = false;
            nameText.Size = new Size(645, 69);
            nameText.TabIndex = 0;
            nameText.TextInput = "";
            nameText.TextLabel = "Name *";
            nameText.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 64);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(3, 3);
            taskEditor1.MinimumSize = new Size(50, 50);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(186, 58);
            taskEditor1.TabIndex = 0;
            // 
            // ManageServiceTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "ManageServiceTask";
            Size = new Size(659, 733);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox xpathTextInput;
        private LabeledTextbox folderPathInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox displayNameText;
        private LabeledTextbox descriptionText;
        private LabeledTextbox nameText;
        private MaskedTextBox postDelayNumber;
        private Label label1;
        private ComboBox statusText;
        private Label label3;
        private ComboBox serviceType;
        private Label label2;
    }
}
