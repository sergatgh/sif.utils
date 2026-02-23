namespace SIF.Utils.Forms.SecondaryNavigation
{
    partial class SecondaryNavigationCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondaryNavigationCategory));
            label1 = new Label();
            horizontalLine1 = new SIF.Utils.Forms.Common.HorizontalLine();
            flowLayoutPanel1 = new FlowLayoutPanel();
            secondaryNavigationMenuItem1 = new SecondaryNavigationMenuItem();
            secondaryNavigationMenuItem3 = new SecondaryNavigationMenuItem();
            secondaryNavigationMenuItem2 = new SecondaryNavigationMenuItem();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(47, 62, 78);
            label1.Location = new Point(12, 15);
            label1.Margin = new Padding(0, 15, 0, 5);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.Size = new Size(285, 30);
            label1.TabIndex = 0;
            label1.Text = "Official Sitecore Documentation";
            // 
            // horizontalLine1
            // 
            horizontalLine1.BorderStyle = BorderStyle.Fixed3D;
            horizontalLine1.Dock = DockStyle.Top;
            horizontalLine1.Location = new Point(12, 45);
            horizontalLine1.MaximumSize = new Size(0, 2);
            horizontalLine1.Name = "horizontalLine1";
            horizontalLine1.Size = new Size(256, 2);
            horizontalLine1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(secondaryNavigationMenuItem1);
            flowLayoutPanel1.Controls.Add(secondaryNavigationMenuItem3);
            flowLayoutPanel1.Controls.Add(secondaryNavigationMenuItem2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 8, 0, 0);
            flowLayoutPanel1.Size = new Size(256, 219);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // secondaryNavigationMenuItem1
            // 
            secondaryNavigationMenuItem1.Image = (Image)resources.GetObject("secondaryNavigationMenuItem1.Image");
            secondaryNavigationMenuItem1.Location = new Point(5, 8);
            secondaryNavigationMenuItem1.Margin = new Padding(0);
            secondaryNavigationMenuItem1.MaximumSize = new Size(200, 40);
            secondaryNavigationMenuItem1.Name = "secondaryNavigationMenuItem1";
            secondaryNavigationMenuItem1.Padding = new Padding(0, 0, 0, 8);
            secondaryNavigationMenuItem1.Selected = false;
            secondaryNavigationMenuItem1.Size = new Size(200, 40);
            secondaryNavigationMenuItem1.TabIndex = 0;
            secondaryNavigationMenuItem1.Text = "Navigation element";
            // 
            // secondaryNavigationMenuItem3
            // 
            secondaryNavigationMenuItem3.Image = (Image)resources.GetObject("secondaryNavigationMenuItem3.Image");
            secondaryNavigationMenuItem3.Location = new Point(5, 48);
            secondaryNavigationMenuItem3.Margin = new Padding(0);
            secondaryNavigationMenuItem3.MaximumSize = new Size(200, 40);
            secondaryNavigationMenuItem3.Name = "secondaryNavigationMenuItem3";
            secondaryNavigationMenuItem3.Padding = new Padding(0, 0, 0, 8);
            secondaryNavigationMenuItem3.Selected = false;
            secondaryNavigationMenuItem3.Size = new Size(200, 40);
            secondaryNavigationMenuItem3.TabIndex = 4;
            secondaryNavigationMenuItem3.Text = "Navigation element";
            // 
            // secondaryNavigationMenuItem2
            // 
            secondaryNavigationMenuItem2.Image = (Image)resources.GetObject("secondaryNavigationMenuItem2.Image");
            secondaryNavigationMenuItem2.Location = new Point(5, 88);
            secondaryNavigationMenuItem2.Margin = new Padding(0);
            secondaryNavigationMenuItem2.MaximumSize = new Size(200, 40);
            secondaryNavigationMenuItem2.Name = "secondaryNavigationMenuItem2";
            secondaryNavigationMenuItem2.Padding = new Padding(0, 0, 0, 8);
            secondaryNavigationMenuItem2.Selected = false;
            secondaryNavigationMenuItem2.Size = new Size(200, 40);
            secondaryNavigationMenuItem2.TabIndex = 3;
            secondaryNavigationMenuItem2.Text = "Navigation element";
            // 
            // SecondaryNavigationCategory
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(horizontalLine1);
            Controls.Add(label1);
            MaximumSize = new Size(280, 0);
            Name = "SecondaryNavigationCategory";
            Padding = new Padding(12, 15, 12, 5);
            Size = new Size(280, 271);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Common.HorizontalLine horizontalLine1;
        private FlowLayoutPanel flowLayoutPanel1;
        private SecondaryNavigationMenuItem secondaryNavigationMenuItem1;
        private SecondaryNavigationMenuItem secondaryNavigationMenuItem3;
        private SecondaryNavigationMenuItem secondaryNavigationMenuItem2;
    }
}
