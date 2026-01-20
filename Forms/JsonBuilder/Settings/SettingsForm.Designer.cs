namespace SIF.Utils.Forms.JsonBuilder.Settings
{
    partial class SettingsForm
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
            autoRegisterExtensionsSetting = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            informationActionComboBox = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            warningActionCombobox = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            errorActionComboBox = new ComboBox();
            button3 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // autoRegisterExtensionsSetting
            // 
            autoRegisterExtensionsSetting.Dock = DockStyle.Left;
            autoRegisterExtensionsSetting.Location = new Point(3, 3);
            autoRegisterExtensionsSetting.Name = "autoRegisterExtensionsSetting";
            autoRegisterExtensionsSetting.Size = new Size(220, 27);
            autoRegisterExtensionsSetting.TabIndex = 1;
            autoRegisterExtensionsSetting.Text = "Auto Register Extensions";
            autoRegisterExtensionsSetting.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(autoRegisterExtensionsSetting);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(706, 614);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 5;
            label1.Text = "Information Action";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(informationActionComboBox);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Location = new Point(3, 59);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(277, 37);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // informationActionComboBox
            // 
            informationActionComboBox.Dock = DockStyle.Top;
            informationActionComboBox.FormattingEnabled = true;
            informationActionComboBox.Items.AddRange(new object[] { "SilentlyContinue", "Stop", "Continue", "Inquire", "Ignore", "Suspend", "Break" });
            informationActionComboBox.Location = new Point(3, 3);
            informationActionComboBox.Name = "informationActionComboBox";
            informationActionComboBox.Size = new Size(220, 31);
            informationActionComboBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(229, 3);
            button1.Name = "button1";
            button1.Size = new Size(45, 29);
            button1.TabIndex = 3;
            button1.Text = "❌";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 99);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 6;
            label2.Text = "Warning Action";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(warningActionCombobox);
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Location = new Point(3, 125);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(277, 37);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // warningActionCombobox
            // 
            warningActionCombobox.Dock = DockStyle.Top;
            warningActionCombobox.FormattingEnabled = true;
            warningActionCombobox.Items.AddRange(new object[] { "SilentlyContinue", "Stop", "Continue", "Inquire", "Ignore", "Suspend", "Break" });
            warningActionCombobox.Location = new Point(3, 3);
            warningActionCombobox.Name = "warningActionCombobox";
            warningActionCombobox.Size = new Size(220, 31);
            warningActionCombobox.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(229, 3);
            button2.Name = "button2";
            button2.Size = new Size(45, 29);
            button2.TabIndex = 3;
            button2.Text = "❌";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 165);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 7;
            label3.Text = "Error Action";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(errorActionComboBox);
            flowLayoutPanel4.Controls.Add(button3);
            flowLayoutPanel4.Location = new Point(3, 191);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(277, 37);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // errorActionComboBox
            // 
            errorActionComboBox.Dock = DockStyle.Top;
            errorActionComboBox.FormattingEnabled = true;
            errorActionComboBox.Items.AddRange(new object[] { "SilentlyContinue", "Stop", "Continue", "Inquire", "Ignore", "Suspend", "Break" });
            errorActionComboBox.Location = new Point(3, 3);
            errorActionComboBox.Name = "errorActionComboBox";
            errorActionComboBox.Size = new Size(220, 31);
            errorActionComboBox.TabIndex = 2;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(229, 3);
            button3.Name = "button3";
            button3.Size = new Size(45, 29);
            button3.TabIndex = 3;
            button3.Text = "❌";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "SettingsForm";
            Size = new Size(706, 614);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox autoRegisterExtensionsSetting;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox informationActionComboBox;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel3;
        private ComboBox warningActionCombobox;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel4;
        private ComboBox errorActionComboBox;
        private Button button3;
    }
}
