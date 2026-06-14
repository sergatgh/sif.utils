namespace SIF.Utils.Forms.Learn
{
    using SIF.Utils.Forms.SecondaryNavigation;

    partial class LearnSIF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnSIF));
            secondaryNavigationPanel1 = new SecondaryNavigationPanel();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // secondaryNavigationPanel1
            // 
            secondaryNavigationPanel1.AutoScroll = true;
            secondaryNavigationPanel1.BackColor = Color.FromArgb(234, 233, 238);
            secondaryNavigationPanel1.BorderStyle = BorderStyle.FixedSingle;
            secondaryNavigationPanel1.Dock = DockStyle.Fill;
            secondaryNavigationPanel1.ForeColor = Color.FromArgb(47, 62, 78);
            secondaryNavigationPanel1.Location = new Point(0, 0);
            secondaryNavigationPanel1.Margin = new Padding(0);
            secondaryNavigationPanel1.MinimumSize = new Size(10, 20);
            secondaryNavigationPanel1.Name = "secondaryNavigationPanel1";
            secondaryNavigationPanel1.Padding = new Padding(0, 10, 0, 10);
            secondaryNavigationPanel1.Size = new Size(214, 385);
            secondaryNavigationPanel1.TabIndex = 1;
            secondaryNavigationPanel1.Title = "Study guides";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(245, 247, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.CausesValidation = false;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(4, 4);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(478, 377);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(214, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(486, 385);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(secondaryNavigationPanel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 385);
            panel2.TabIndex = 4;
            // 
            // LearnSIF
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(700, 385);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LearnSIF";
            Text = "Resources";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SecondaryNavigationPanel secondaryNavigationPanel1;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Panel panel2;
    }
}