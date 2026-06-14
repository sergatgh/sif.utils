namespace SIF.Utils.Forms.SecondaryNavigation
{
    partial class SecondaryNavigationPanel
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
            secondaryNavigationCategory1 = new SecondaryNavigationCategory();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            secondaryNavigationCategory3 = new SecondaryNavigationCategory();
            secondaryNavigationCategory2 = new SecondaryNavigationCategory();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // secondaryNavigationCategory1
            // 
            secondaryNavigationCategory1.AutoSize = true;
            secondaryNavigationCategory1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            secondaryNavigationCategory1.BackColor = Color.Transparent;
            secondaryNavigationCategory1.Location = new Point(3, 306);
            secondaryNavigationCategory1.Margin = new Padding(3, 2, 3, 2);
            secondaryNavigationCategory1.MaximumSize = new Size(249, 0);
            secondaryNavigationCategory1.MinimumSize = new Size(10, 10);
            secondaryNavigationCategory1.Name = "secondaryNavigationCategory1";
            secondaryNavigationCategory1.Padding = new Padding(11, 12, 11, 4);
            secondaryNavigationCategory1.Size = new Size(204, 148);
            secondaryNavigationCategory1.TabIndex = 0;
            secondaryNavigationCategory1.Title = "Official Sitecore Documentation";
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 1;
            label1.Text = "Secondary menu title";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(secondaryNavigationCategory3);
            flowLayoutPanel1.Controls.Add(secondaryNavigationCategory2);
            flowLayoutPanel1.Controls.Add(secondaryNavigationCategory1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 456);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // secondaryNavigationCategory3
            // 
            secondaryNavigationCategory3.AutoSize = true;
            secondaryNavigationCategory3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            secondaryNavigationCategory3.BackColor = Color.Transparent;
            secondaryNavigationCategory3.Location = new Point(3, 2);
            secondaryNavigationCategory3.Margin = new Padding(3, 2, 3, 2);
            secondaryNavigationCategory3.MaximumSize = new Size(249, 0);
            secondaryNavigationCategory3.MinimumSize = new Size(10, 10);
            secondaryNavigationCategory3.Name = "secondaryNavigationCategory3";
            secondaryNavigationCategory3.Padding = new Padding(11, 12, 11, 4);
            secondaryNavigationCategory3.Size = new Size(204, 148);
            secondaryNavigationCategory3.TabIndex = 1;
            secondaryNavigationCategory3.Title = "Official Sitecore Documentation";
            // 
            // secondaryNavigationCategory2
            // 
            secondaryNavigationCategory2.AutoSize = true;
            secondaryNavigationCategory2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            secondaryNavigationCategory2.BackColor = Color.Transparent;
            secondaryNavigationCategory2.Location = new Point(3, 154);
            secondaryNavigationCategory2.Margin = new Padding(3, 2, 3, 2);
            secondaryNavigationCategory2.MaximumSize = new Size(249, 0);
            secondaryNavigationCategory2.MinimumSize = new Size(10, 10);
            secondaryNavigationCategory2.Name = "secondaryNavigationCategory2";
            secondaryNavigationCategory2.Padding = new Padding(11, 12, 11, 4);
            secondaryNavigationCategory2.Size = new Size(204, 148);
            secondaryNavigationCategory2.TabIndex = 0;
            secondaryNavigationCategory2.Title = "Official Sitecore Documentation";
            // 
            // SecondaryNavigationPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(234, 233, 238);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(47, 62, 78);
            Margin = new Padding(0);
            MinimumSize = new Size(10, 20);
            Name = "SecondaryNavigationPanel";
            Padding = new Padding(0, 10, 0, 10);
            Size = new Size(245, 291);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SecondaryNavigation.SecondaryNavigationCategory secondaryNavigationCategory1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private SecondaryNavigation.SecondaryNavigationCategory secondaryNavigationCategory2;
        private SecondaryNavigation.SecondaryNavigationCategory secondaryNavigationCategory3;
    }
}
