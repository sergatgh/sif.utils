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
            flowLayoutPanel7 = new FlowLayoutPanel();
            creditsButton = new Button();
            learnSifButton = new Button();
            openFileForViewerDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            welcomeDescriptionText = new Label();
            welcomeTitleText = new Label();
            welcomeText = new Label();
            actionControlsFlowPanel = new FlowLayoutPanel();
            viewJsonFileFeatureCard = new FeatureCardControl();
            featureCardControl1 = new FeatureCardControl();
            featureCardControl2 = new FeatureCardControl();
            panel1 = new Panel();
            flowLayoutPanel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            actionControlsFlowPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(creditsButton);
            flowLayoutPanel7.Controls.Add(learnSifButton);
            flowLayoutPanel7.Dock = DockStyle.Bottom;
            flowLayoutPanel7.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel7.Location = new Point(0, 702);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(1130, 68);
            flowLayoutPanel7.TabIndex = 7;
            // 
            // creditsButton
            // 
            creditsButton.Font = new Font("Segoe UI", 14F);
            creditsButton.Location = new Point(973, 3);
            creditsButton.Name = "creditsButton";
            creditsButton.Size = new Size(154, 57);
            creditsButton.TabIndex = 6;
            creditsButton.Text = "🕵️ Credits";
            creditsButton.UseVisualStyleBackColor = true;
            creditsButton.Click += aboutWindowButton_Click;
            // 
            // learnSifButton
            // 
            learnSifButton.Font = new Font("Segoe UI", 14F);
            learnSifButton.Location = new Point(789, 3);
            learnSifButton.Name = "learnSifButton";
            learnSifButton.Size = new Size(178, 57);
            learnSifButton.TabIndex = 7;
            learnSifButton.Text = "📖 Learn SIF";
            learnSifButton.UseVisualStyleBackColor = true;
            learnSifButton.Click += learnSifButton_Click;
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
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(welcomeDescriptionText, 0, 4);
            tableLayoutPanel1.Controls.Add(welcomeTitleText, 0, 2);
            tableLayoutPanel1.Controls.Add(welcomeText, 0, 0);
            tableLayoutPanel1.Controls.Add(actionControlsFlowPanel, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(32, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1066, 654);
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
            // actionControlsFlowPanel
            // 
            actionControlsFlowPanel.AutoSize = true;
            actionControlsFlowPanel.Controls.Add(viewJsonFileFeatureCard);
            actionControlsFlowPanel.Controls.Add(featureCardControl1);
            actionControlsFlowPanel.Controls.Add(featureCardControl2);
            actionControlsFlowPanel.Dock = DockStyle.Fill;
            actionControlsFlowPanel.Location = new Point(3, 143);
            actionControlsFlowPanel.Name = "actionControlsFlowPanel";
            actionControlsFlowPanel.Size = new Size(1060, 508);
            actionControlsFlowPanel.TabIndex = 11;
            // 
            // viewJsonFileFeatureCard
            // 
            viewJsonFileFeatureCard.AutoSize = true;
            viewJsonFileFeatureCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewJsonFileFeatureCard.Description = "Inspect configuration files in a clear format";
            viewJsonFileFeatureCard.Image = Properties.Resources.copy_icon;
            viewJsonFileFeatureCard.Location = new Point(0, 0);
            viewJsonFileFeatureCard.Margin = new Padding(0, 0, 20, 20);
            viewJsonFileFeatureCard.Name = "viewJsonFileFeatureCard";
            viewJsonFileFeatureCard.Size = new Size(358, 120);
            viewJsonFileFeatureCard.TabIndex = 0;
            viewJsonFileFeatureCard.Title = "View JSON File";
            viewJsonFileFeatureCard.CardClick += openForViewFileDialog_Click;
            // 
            // featureCardControl1
            // 
            featureCardControl1.AutoSize = true;
            featureCardControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            featureCardControl1.Description = "Execute SIF script with predefined parameters";
            featureCardControl1.Image = Properties.Resources.command_5515389;
            featureCardControl1.Location = new Point(378, 0);
            featureCardControl1.Margin = new Padding(0, 0, 20, 20);
            featureCardControl1.Name = "featureCardControl1";
            featureCardControl1.Size = new Size(358, 120);
            featureCardControl1.TabIndex = 1;
            featureCardControl1.Title = "Run SIF Script";
            featureCardControl1.CardClick += executeFileDialog_Click;
            // 
            // featureCardControl2
            // 
            featureCardControl2.AutoSize = true;
            featureCardControl2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            featureCardControl2.Description = "Visually create SIF configuration files";
            featureCardControl2.Image = Properties.Resources.service_8473597;
            featureCardControl2.Location = new Point(0, 140);
            featureCardControl2.Margin = new Padding(0, 0, 20, 20);
            featureCardControl2.Name = "featureCardControl2";
            featureCardControl2.Size = new Size(358, 120);
            featureCardControl2.TabIndex = 2;
            featureCardControl2.Title = "SIF Builder";
            featureCardControl2.CardClick += sifBuilderFlow_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(32, 24, 32, 24);
            panel1.Size = new Size(1130, 702);
            panel1.TabIndex = 11;
            // 
            // HomeComponents
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel7);
            Name = "HomeComponents";
            Size = new Size(1130, 770);
            flowLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            actionControlsFlowPanel.ResumeLayout(false);
            actionControlsFlowPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel7;
        private Button creditsButton;
        private Button learnSifButton;
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
    }
}
