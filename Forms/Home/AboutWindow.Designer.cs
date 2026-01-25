namespace SIF.Utils
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label2 = new Label();
            linkLabel4 = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 72);
            label1.TabIndex = 0;
            label1.Text = "SIF UTILS";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 18F);
            linkLabel1.Location = new Point(12, 189);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 41);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LinkedIn";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 18F);
            linkLabel2.Location = new Point(148, 189);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(108, 41);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Github";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 18F);
            linkLabel3.Location = new Point(262, 189);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(129, 41);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Medium";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(12, 284);
            label2.Name = "label2";
            label2.Size = new Size(310, 41);
            label2.TabIndex = 4;
            label2.Text = "Project is available on:";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Segoe UI", 18F);
            linkLabel4.Location = new Point(12, 332);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(108, 41);
            linkLabel4.TabIndex = 5;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Github";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(288, 82);
            label3.TabIndex = 6;
            label3.Text = "created by:\r\nSergey Solomentsev";
            // 
            // AboutWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 486);
            Controls.Add(label3);
            Controls.Add(linkLabel4);
            Controls.Add(label2);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutWindow";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label2;
        private LinkLabel linkLabel4;
        private Label label3;
    }
}