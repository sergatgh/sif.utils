namespace SIF.Utils.Forms.Home
{
    partial class HomeComponents
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
            openFileForViewerDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            welcomeDescriptionText = new Label();
            welcomeTitleText = new Label();
            welcomeText = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            featureCardControl3 = new FeatureCardControl();
            featureCardControl4 = new FeatureCardControl();
            actionControlsFlowPanel = new FlowLayoutPanel();
            viewJsonFileFeatureCard = new FeatureCardControl();
            featureCardControl1 = new FeatureCardControl();
            featureCardControl2 = new FeatureCardControl();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            actionControlsFlowPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileForViewerDialog
            // 
            openFileForViewerDialog.AddToRecent = false;
            openFileForViewerDialog.DefaultExt = "json";
            openFileForViewerDialog.Filter = "SIF JSON|*.json";
            openFileForViewerDialog.ReadOnlyChecked = true;
            openFileForViewerDialog.RestoreDirectory = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(welcomeDescriptionText, 0, 4);
            tableLayoutPanel1.Controls.Add(welcomeTitleText, 0, 2);
            tableLayoutPanel1.Controls.Add(welcomeText, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 7);
            tableLayoutPanel1.Controls.Add(actionControlsFlowPanel, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(32, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1066, 572);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // welcomeDescriptionText
            // 
            welcomeDescriptionText.AutoSize = true;
            welcomeDescriptionText.BackColor = Color.Transparent;
            welcomeDescriptionText.Dock = DockStyle.Top;
            welcomeDescriptionText.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeDescriptionText.ForeColor = Color.FromArgb(107, 107, 107);
            welcomeDescriptionText.Location = new Point(0, 87);
            welcomeDescriptionText.Margin = new Padding(0);
            welcomeDescriptionText.Name = "welcomeDescriptionText";
            welcomeDescriptionText.Padding = new Padding(4, 0, 0, 0);
            welcomeDescriptionText.Size = new Size(1066, 25);
            welcomeDescriptionText.TabIndex = 10;
            welcomeDescriptionText.Text = "Inspect, build, and execute Sitecore Installation Framework configurations.";
            welcomeDescriptionText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // welcomeTitleText
            // 
            welcomeTitleText.AutoSize = true;
            welcomeTitleText.BackColor = Color.Transparent;
            welcomeTitleText.Dock = DockStyle.Top;
            welcomeTitleText.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeTitleText.ForeColor = Color.FromArgb(31, 31, 31);
            welcomeTitleText.Location = new Point(0, 28);
            welcomeTitleText.Margin = new Padding(0);
            welcomeTitleText.Name = "welcomeTitleText";
            welcomeTitleText.Size = new Size(1066, 47);
            welcomeTitleText.TabIndex = 2;
            welcomeTitleText.Text = "SIF Utils Dashboard";
            welcomeTitleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // welcomeText
            // 
            welcomeText.AutoSize = true;
            welcomeText.BackColor = Color.Transparent;
            welcomeText.Dock = DockStyle.Top;
            welcomeText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeText.ForeColor = Color.FromArgb(122, 122, 122);
            welcomeText.Location = new Point(0, 0);
            welcomeText.Margin = new Padding(0);
            welcomeText.Name = "welcomeText";
            welcomeText.Padding = new Padding(5, 0, 0, 0);
            welcomeText.Size = new Size(1066, 20);
            welcomeText.TabIndex = 1;
            welcomeText.Text = "Welcome back";
            welcomeText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(featureCardControl3);
            flowLayoutPanel1.Controls.Add(featureCardControl4);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 429);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1060, 140);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // featureCardControl3
            // 
            featureCardControl3.AutoSize = true;
            featureCardControl3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            featureCardControl3.BackColor = Color.White;
            featureCardControl3.Description = "Documentation and links to articles and sources";
            featureCardControl3.Image = Properties.Resources.website_logo_icon;
            featureCardControl3.Location = new Point(0, 0);
            featureCardControl3.Margin = new Padding(0, 0, 20, 20);
            featureCardControl3.MinimumSize = new Size(360, 120);
            featureCardControl3.Name = "featureCardControl3";
            featureCardControl3.Radius = 10;
            featureCardControl3.Size = new Size(360, 120);
            featureCardControl3.TabIndex = 0;
            featureCardControl3.Title = "Resources";
            featureCardControl3.CardClick += learnSifButton_Click;
            // 
            // featureCardControl4
            // 
            featureCardControl4.AutoSize = true;
            featureCardControl4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            featureCardControl4.BackColor = Color.White;
            featureCardControl4.Description = "About this program and credits to the author";
            featureCardControl4.Image = Properties.Resources.management_service;
            featureCardControl4.Location = new Point(380, 0);
            featureCardControl4.Margin = new Padding(0, 0, 20, 20);
            featureCardControl4.MinimumSize = new Size(360, 120);
            featureCardControl4.Name = "featureCardControl4";
            featureCardControl4.Radius = 10;
            featureCardControl4.Size = new Size(360, 120);
            featureCardControl4.TabIndex = 1;
            featureCardControl4.Title = "Credits and About";
            featureCardControl4.CardClick += aboutWindowButton_Click;
            // 
            // actionControlsFlowPanel
            // 
            actionControlsFlowPanel.AutoSize = true;
            actionControlsFlowPanel.Controls.Add(viewJsonFileFeatureCard);
            actionControlsFlowPanel.Controls.Add(featureCardControl1);
            actionControlsFlowPanel.Controls.Add(featureCardControl2);
            actionControlsFlowPanel.Dock = DockStyle.Top;
            actionControlsFlowPanel.Location = new Point(3, 143);
            actionControlsFlowPanel.Name = "actionControlsFlowPanel";
            actionControlsFlowPanel.Size = new Size(1060, 280);
            actionControlsFlowPanel.TabIndex = 11;
            // 
            // viewJsonFileFeatureCard
            // 
            viewJsonFileFeatureCard.AutoSize = true;
            viewJsonFileFeatureCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewJsonFileFeatureCard.BackColor = Color.White;
            viewJsonFileFeatureCard.Description = "Inspect configuration files in a clear format";
            viewJsonFileFeatureCard.Image = Properties.Resources.copy_icon;
            viewJsonFileFeatureCard.Location = new Point(0, 0);
            viewJsonFileFeatureCard.Margin = new Padding(0, 0, 20, 20);
            viewJsonFileFeatureCard.MinimumSize = new Size(360, 120);
            viewJsonFileFeatureCard.Name = "viewJsonFileFeatureCard";
            viewJsonFileFeatureCard.Radius = 10;
            viewJsonFileFeatureCard.Size = new Size(360, 120);
            viewJsonFileFeatureCard.TabIndex = 0;
            viewJsonFileFeatureCard.Title = "View JSON File";
            viewJsonFileFeatureCard.CardClick += openForViewFileDialog_Click;
            // 
            // featureCardControl1
            // 
            featureCardControl1.AutoSize = true;
            featureCardControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            featureCardControl1.BackColor = Color.White;
            featureCardControl1.Description = "Execute SIF script with predefined parameters";
            featureCardControl1.Image = Properties.Resources.command_5515389;
            featureCardControl1.Location = new Point(380, 0);
            featureCardControl1.Margin = new Padding(0, 0, 20, 20);
            featureCardControl1.MinimumSize = new Size(360, 120);
            featureCardControl1.Name = "featureCardControl1";
            featureCardControl1.Radius = 10;
            featureCardControl1.Size = new Size(360, 120);
            featureCardControl1.TabIndex = 1;
            featureCardControl1.Title = "Run SIF Script";
            featureCardControl1.CardClick += executeFileDialog_Click;
            // 
            // featureCardControl2
            // 
            featureCardControl2.AutoSize = true;
            featureCardControl2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            featureCardControl2.BackColor = Color.White;
            featureCardControl2.Description = "Visually create SIF configuration files";
            featureCardControl2.Image = Properties.Resources.service_8473597;
            featureCardControl2.Location = new Point(0, 140);
            featureCardControl2.Margin = new Padding(0, 0, 20, 20);
            featureCardControl2.MinimumSize = new Size(360, 120);
            featureCardControl2.Name = "featureCardControl2";
            featureCardControl2.Radius = 10;
            featureCardControl2.Size = new Size(360, 120);
            featureCardControl2.TabIndex = 2;
            featureCardControl2.Title = "SIF Builder";
            featureCardControl2.CardClick += sifBuilderFlow_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(32, 24, 32, 24);
            panel1.Size = new Size(1130, 680);
            panel1.TabIndex = 11;
            // 
            // HomeComponents
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HomeComponents";
            Size = new Size(1130, 680);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            actionControlsFlowPanel.ResumeLayout(false);
            actionControlsFlowPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileForViewerDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private Label welcomeText;
        private Label welcomeDescriptionText;
        private Label welcomeTitleText;
        private FlowLayoutPanel actionControlsFlowPanel;
        private FeatureCardControl viewJsonFileFeatureCard;
        private FeatureCardControl featureCardControl1;
        private Panel panel1;
        private FeatureCardControl featureCardControl2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FeatureCardControl featureCardControl3;
        private FeatureCardControl featureCardControl4;
    }
}
