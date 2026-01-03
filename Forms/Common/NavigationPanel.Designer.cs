namespace SIF.Utils.Forms.Common
{
    partial class NavigationPanel
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
            setPropsNavPanel = new Panel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            backButton = new Button();
            titleLabel = new Label();
            setPropsNavPanel.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // setPropsNavPanel
            // 
            setPropsNavPanel.Controls.Add(flowLayoutPanel6);
            setPropsNavPanel.Controls.Add(flowLayoutPanel5);
            setPropsNavPanel.Dock = DockStyle.Top;
            setPropsNavPanel.Location = new Point(0, 0);
            setPropsNavPanel.Margin = new Padding(0);
            setPropsNavPanel.Name = "setPropsNavPanel";
            setPropsNavPanel.Size = new Size(920, 76);
            setPropsNavPanel.TabIndex = 4;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(398, 0);
            flowLayoutPanel6.Margin = new Padding(0);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10);
            flowLayoutPanel6.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel6.Size = new Size(522, 76);
            flowLayoutPanel6.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(backButton);
            flowLayoutPanel5.Controls.Add(titleLabel);
            flowLayoutPanel5.Dock = DockStyle.Left;
            flowLayoutPanel5.Location = new Point(0, 0);
            flowLayoutPanel5.Margin = new Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(398, 76);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.BackgroundImage = Properties.Resources.BackButtonIcon;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.Dock = DockStyle.Left;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 22F);
            backButton.Location = new Point(10, 10);
            backButton.Margin = new Padding(0, 0, 10, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(62, 54);
            backButton.TabIndex = 0;
            backButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Left;
            titleLabel.Font = new Font("Segoe UI", 24F);
            titleLabel.Location = new Point(85, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(128, 54);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Name";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NavigationPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(setPropsNavPanel);
            Name = "NavigationPanel";
            Size = new Size(920, 80);
            setPropsNavPanel.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel setPropsNavPanel;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button backButton;
        private Label titleLabel;
    }
}
