namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class AccessRightBuilderWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userTextBox = new LabeledTextbox();
            accessRights = new CheckedListBox();
            allowAccessRadio = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            denyAccessRadio = new RadioButton();
            inheritanceFlagsBox = new CheckedListBox();
            propagationFlagsSelector = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // userTextBox
            // 
            userTextBox.Dock = DockStyle.Top;
            userTextBox.Location = new Point(0, 0);
            userTextBox.Multiline = false;
            userTextBox.Name = "userTextBox";
            userTextBox.PathSelectionFilter = "";
            userTextBox.PathSelectMode = PathSelectMode.Folder;
            userTextBox.ShowPathSelector = false;
            userTextBox.Size = new Size(559, 63);
            userTextBox.TabIndex = 0;
            userTextBox.TextInput = "IIS AppPool\\sc1041.sc";
            userTextBox.TextLabel = "User *";
            userTextBox.Vertical = true;
            // 
            // accessRights
            // 
            accessRights.CheckOnClick = true;
            accessRights.Dock = DockStyle.Top;
            accessRights.FormattingEnabled = true;
            accessRights.Items.AddRange(new object[] { "Full Control", "Read Data", "List Directory", "Write Data", "Create Files", "Append Data", "Create Directories", "Read Extended Attributes", "Write Extended Attributes", "Execute File", "Traverse", "Delete Subdirectories And Files", "Read Attributes", "Write Attributes", "Delete", "Read Permissions", "Change Permissions", "Take Ownership", "Synchronize", "Read", "Read And Execute", "Write", "Modify" });
            accessRights.Location = new Point(0, 63);
            accessRights.Name = "accessRights";
            accessRights.Size = new Size(559, 329);
            accessRights.TabIndex = 1;
            // 
            // allowAccessRadio
            // 
            allowAccessRadio.AutoSize = true;
            allowAccessRadio.Checked = true;
            allowAccessRadio.Location = new Point(3, 3);
            allowAccessRadio.Name = "allowAccessRadio";
            allowAccessRadio.Size = new Size(127, 27);
            allowAccessRadio.TabIndex = 0;
            allowAccessRadio.TabStop = true;
            allowAccessRadio.Text = "Allow Access";
            allowAccessRadio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(denyAccessRadio, 1, 0);
            tableLayoutPanel1.Controls.Add(allowAccessRadio, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 392);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(559, 33);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // denyAccessRadio
            // 
            denyAccessRadio.AutoSize = true;
            denyAccessRadio.Location = new Point(282, 3);
            denyAccessRadio.Name = "denyAccessRadio";
            denyAccessRadio.Size = new Size(125, 27);
            denyAccessRadio.TabIndex = 1;
            denyAccessRadio.TabStop = true;
            denyAccessRadio.Text = "Deny Access";
            denyAccessRadio.UseVisualStyleBackColor = true;
            // 
            // inheritanceFlagsBox
            // 
            inheritanceFlagsBox.CheckOnClick = true;
            inheritanceFlagsBox.Dock = DockStyle.Top;
            inheritanceFlagsBox.FormattingEnabled = true;
            inheritanceFlagsBox.Items.AddRange(new object[] { "Only current item (None)", "Current item and descendant files (ObjectInherit)", "Current item and subfolders (ContainerInherit)" });
            inheritanceFlagsBox.Location = new Point(0, 448);
            inheritanceFlagsBox.Margin = new Padding(3, 3, 3, 7);
            inheritanceFlagsBox.Name = "inheritanceFlagsBox";
            inheritanceFlagsBox.Size = new Size(559, 104);
            inheritanceFlagsBox.TabIndex = 3;
            inheritanceFlagsBox.ItemCheck += inheritanceFlagsBox_ItemCheck;
            // 
            // propagationFlagsSelector
            // 
            propagationFlagsSelector.CheckOnClick = true;
            propagationFlagsSelector.Dock = DockStyle.Top;
            propagationFlagsSelector.Enabled = false;
            propagationFlagsSelector.FormattingEnabled = true;
            propagationFlagsSelector.Items.AddRange(new object[] { "Current item and descendant (None)", "Do not include grandchildren (NoPropagateInherit)", "Descendants (InheritOnly)" });
            propagationFlagsSelector.Location = new Point(0, 575);
            propagationFlagsSelector.Name = "propagationFlagsSelector";
            propagationFlagsSelector.Size = new Size(559, 104);
            propagationFlagsSelector.TabIndex = 4;
            propagationFlagsSelector.ItemCheck += propagationFlagsSelector_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 552);
            label1.Margin = new Padding(3, 5, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 5;
            label1.Text = "Propagation Flags";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 425);
            label2.Margin = new Padding(3, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 6;
            label2.Text = "Inheritance Flags";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(462, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 679);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(559, 35);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(362, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // AccessRightBuilderWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 724);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(propagationFlagsSelector);
            Controls.Add(label1);
            Controls.Add(inheritanceFlagsBox);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(accessRights);
            Controls.Add(userTextBox);
            Name = "AccessRightBuilderWindow";
            Text = "AccessRightBuilderWindow";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabeledTextbox userTextBox;
        private CheckedListBox accessRights;
        private RadioButton allowAccessRadio;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton denyAccessRadio;
        private CheckedListBox inheritanceFlagsBox;
        private CheckedListBox propagationFlagsSelector;
        private Label label1;
        private Label label2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
    }
}