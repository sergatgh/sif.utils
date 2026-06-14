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
            label1.Location = new Point(11, 12);
            label1.Margin = new Padding(0, 12, 0, 4);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 4);
            label1.Size = new Size(232, 24);
            label1.TabIndex = 0;
            label1.Text = "Official Sitecore Documentation";
            // 
            // horizontalLine1
            // 
            horizontalLine1.BorderStyle = BorderStyle.Fixed3D;
            horizontalLine1.Dock = DockStyle.Top;
            horizontalLine1.Location = new Point(11, 36);
            horizontalLine1.MaximumSize = new Size(0, 2);
            horizontalLine1.Name = "horizontalLine1";
            horizontalLine1.Size = new Size(227, 2);
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
            flowLayoutPanel1.Location = new Point(11, 38);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(4, 7, 0, 0);
            flowLayoutPanel1.Size = new Size(227, 106);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // secondaryNavigationMenuItem1
            // 
            secondaryNavigationMenuItem1.Image = (Image)resources.GetObject("secondaryNavigationMenuItem1.Image");
            secondaryNavigationMenuItem1.Location = new Point(4, 7);
            secondaryNavigationMenuItem1.Margin = new Padding(0);
            secondaryNavigationMenuItem1.MaximumSize = new Size(178, 33);
            secondaryNavigationMenuItem1.MinimumSize = new Size(10, 10);
            secondaryNavigationMenuItem1.Name = "secondaryNavigationMenuItem1";
            secondaryNavigationMenuItem1.Padding = new Padding(0, 0, 0, 7);
            secondaryNavigationMenuItem1.Selected = false;
            secondaryNavigationMenuItem1.Size = new Size(178, 33);
            secondaryNavigationMenuItem1.TabIndex = 0;
            secondaryNavigationMenuItem1.Text = "Navigation element";
            // 
            // secondaryNavigationMenuItem3
            // 
            secondaryNavigationMenuItem3.Image = (Image)resources.GetObject("secondaryNavigationMenuItem3.Image");
            secondaryNavigationMenuItem3.Location = new Point(4, 40);
            secondaryNavigationMenuItem3.Margin = new Padding(0);
            secondaryNavigationMenuItem3.MaximumSize = new Size(178, 33);
            secondaryNavigationMenuItem3.MinimumSize = new Size(10, 10);
            secondaryNavigationMenuItem3.Name = "secondaryNavigationMenuItem3";
            secondaryNavigationMenuItem3.Padding = new Padding(0, 0, 0, 7);
            secondaryNavigationMenuItem3.Selected = false;
            secondaryNavigationMenuItem3.Size = new Size(178, 33);
            secondaryNavigationMenuItem3.TabIndex = 4;
            secondaryNavigationMenuItem3.Text = "Navigation element";
            // 
            // secondaryNavigationMenuItem2
            // 
            secondaryNavigationMenuItem2.Image = (Image)resources.GetObject("secondaryNavigationMenuItem2.Image");
            secondaryNavigationMenuItem2.Location = new Point(4, 73);
            secondaryNavigationMenuItem2.Margin = new Padding(0);
            secondaryNavigationMenuItem2.MaximumSize = new Size(178, 33);
            secondaryNavigationMenuItem2.MinimumSize = new Size(10, 10);
            secondaryNavigationMenuItem2.Name = "secondaryNavigationMenuItem2";
            secondaryNavigationMenuItem2.Padding = new Padding(0, 0, 0, 7);
            secondaryNavigationMenuItem2.Selected = false;
            secondaryNavigationMenuItem2.Size = new Size(178, 33);
            secondaryNavigationMenuItem2.TabIndex = 3;
            secondaryNavigationMenuItem2.Text = "Navigation element";
            // 
            // SecondaryNavigationCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(horizontalLine1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(249, 0);
            MinimumSize = new Size(10, 10);
            Name = "SecondaryNavigationCategory";
            Padding = new Padding(11, 12, 11, 4);
            Size = new Size(249, 148);
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
