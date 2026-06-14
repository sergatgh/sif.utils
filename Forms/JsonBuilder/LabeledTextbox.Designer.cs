namespace SIF.Utils.Forms.JsonBuilder
{
    partial class LabeledTextbox
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
            labelText = new Label();
            textBox = new TextBox();
            panel1 = new Panel();
            pathSelectButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Top;
            labelText.Location = new Point(0, 0);
            labelText.Margin = new Padding(2, 0, 2, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(32, 15);
            labelText.TabIndex = 0;
            labelText.Text = "label";
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(0, 0);
            textBox.Margin = new Padding(2, 2, 2, 2);
            textBox.Name = "textBox";
            textBox.Size = new Size(200, 23);
            textBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox);
            panel1.Controls.Add(pathSelectButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 15);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 21);
            panel1.TabIndex = 2;
            // 
            // pathSelectButton
            // 
            pathSelectButton.Dock = DockStyle.Right;
            pathSelectButton.Location = new Point(200, 0);
            pathSelectButton.Margin = new Padding(2, 2, 2, 2);
            pathSelectButton.Name = "pathSelectButton";
            pathSelectButton.Size = new Size(28, 21);
            pathSelectButton.TabIndex = 2;
            pathSelectButton.Text = "...";
            pathSelectButton.UseVisualStyleBackColor = true;
            pathSelectButton.Visible = false;
            pathSelectButton.Click += pathSelectButton_Click;
            // 
            // LabeledTextbox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(labelText);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LabeledTextbox";
            Size = new Size(228, 36);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private TextBox textBox;
        private Panel panel1;
        private Button pathSelectButton;
    }
}
