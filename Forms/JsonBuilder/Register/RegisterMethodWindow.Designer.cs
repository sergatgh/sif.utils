namespace SIF.Utils.Forms.JsonBuilder.Register
{
    partial class RegisterMethodWindow
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
            txtPowershellFunction = new LabeledTextbox();
            txtRegisterAs = new LabeledTextbox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPowershellFunction
            // 
            txtPowershellFunction.Dock = DockStyle.Top;
            txtPowershellFunction.Location = new Point(0, 0);
            txtPowershellFunction.Multiline = false;
            txtPowershellFunction.Name = "txtPowershellFunction";
            txtPowershellFunction.PathSelectionFilter = "";
            txtPowershellFunction.PathSelectMode = PathSelectMode.Folder;
            txtPowershellFunction.ShowPathSelector = false;
            txtPowershellFunction.Size = new Size(456, 69);
            txtPowershellFunction.TabIndex = 0;
            txtPowershellFunction.TextInput = "";
            txtPowershellFunction.TextLabel = "Powershell Function";
            txtPowershellFunction.Vertical = true;
            // 
            // txtRegisterAs
            // 
            txtRegisterAs.Dock = DockStyle.Top;
            txtRegisterAs.Location = new Point(0, 69);
            txtRegisterAs.Multiline = false;
            txtRegisterAs.Name = "txtRegisterAs";
            txtRegisterAs.PathSelectionFilter = "";
            txtRegisterAs.PathSelectMode = PathSelectMode.Folder;
            txtRegisterAs.ShowPathSelector = false;
            txtRegisterAs.Size = new Size(456, 69);
            txtRegisterAs.TabIndex = 1;
            txtRegisterAs.TextInput = "";
            txtRegisterAs.TextLabel = "Register as";
            txtRegisterAs.Vertical = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 138);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(456, 35);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(359, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(259, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // RegisterMethodWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(456, 184);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtRegisterAs);
            Controls.Add(txtPowershellFunction);
            Name = "RegisterMethodWindow";
            Text = "Register Method";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabeledTextbox txtPowershellFunction;
        private LabeledTextbox txtRegisterAs;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button1;
    }
}