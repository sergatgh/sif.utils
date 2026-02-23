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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // secondaryNavigationPanel1
            // 
            secondaryNavigationPanel1.AutoScroll = true;
            secondaryNavigationPanel1.BackColor = Color.FromArgb(234, 233, 238);
            secondaryNavigationPanel1.BorderStyle = BorderStyle.FixedSingle;
            secondaryNavigationPanel1.Dock = DockStyle.Left;
            secondaryNavigationPanel1.ForeColor = Color.FromArgb(47, 62, 78);
            secondaryNavigationPanel1.Location = new Point(0, 0);
            secondaryNavigationPanel1.Margin = new Padding(0);
            secondaryNavigationPanel1.MaximumSize = new Size(280, 0);
            secondaryNavigationPanel1.Name = "secondaryNavigationPanel1";
            secondaryNavigationPanel1.Padding = new Padding(0, 12, 0, 12);
            secondaryNavigationPanel1.Size = new Size(241, 466);
            secondaryNavigationPanel1.TabIndex = 1;
            secondaryNavigationPanel1.Title = "Study guides";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(245, 247, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.CausesValidation = false;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(5, 5);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(536, 456);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(241, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(546, 466);
            panel1.TabIndex = 3;
            // 
            // LearnSIF
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(787, 466);
            Controls.Add(panel1);
            Controls.Add(secondaryNavigationPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LearnSIF";
            Text = "Resources";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SecondaryNavigationPanel secondaryNavigationPanel1;
        private RichTextBox richTextBox1;
        private Panel panel1;
    }
}