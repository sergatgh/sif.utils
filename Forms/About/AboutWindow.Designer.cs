namespace SIF.Utils
{
    partial class AboutWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            pnlHeader = new Panel();
            lblVersion = new Label();
            lblTitle = new Label();
            horizontalLine1 = new SIF.Utils.Forms.Common.HorizontalLine();
            pnlCredits = new Panel();
            creditEntry = new SIF.Utils.Forms.About.CreditEntryControl();
            lblCreditsHeader = new Label();
            horizontalLine2 = new SIF.Utils.Forms.Common.HorizontalLine();
            pnlProject = new Panel();
            btnGithubProject = new Button();
            lblProjectHeader = new Label();
            pnlHeader.SuspendLayout();
            pnlCredits.SuspendLayout();
            pnlProject.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblVersion);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(427, 91);
            pnlHeader.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.ForeColor = Color.FromArgb(107, 107, 107);
            lblVersion.Location = new Point(0, 63);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(427, 21);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "v1.5";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(31, 31, 31);
            lblTitle.Location = new Point(0, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(427, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SIF UTILS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // horizontalLine1
            // 
            horizontalLine1.BorderStyle = BorderStyle.Fixed3D;
            horizontalLine1.Dock = DockStyle.Top;
            horizontalLine1.Location = new Point(0, 91);
            horizontalLine1.MaximumSize = new Size(0, 2);
            horizontalLine1.Name = "horizontalLine1";
            horizontalLine1.Size = new Size(427, 2);
            horizontalLine1.TabIndex = 1;
            // 
            // pnlCredits
            // 
            pnlCredits.BackColor = Color.White;
            pnlCredits.Controls.Add(creditEntry);
            pnlCredits.Controls.Add(lblCreditsHeader);
            pnlCredits.Dock = DockStyle.Top;
            pnlCredits.Location = new Point(0, 93);
            pnlCredits.Margin = new Padding(3, 2, 3, 2);
            pnlCredits.Name = "pnlCredits";
            pnlCredits.Size = new Size(427, 127);
            pnlCredits.TabIndex = 2;
            // 
            // creditEntry
            // 
            creditEntry.BackColor = Color.White;
            creditEntry.Location = new Point(14, 35);
            creditEntry.Margin = new Padding(3, 2, 3, 2);
            creditEntry.Name = "creditEntry";
            creditEntry.Size = new Size(398, 78);
            creditEntry.TabIndex = 1;
            // 
            // lblCreditsHeader
            // 
            lblCreditsHeader.AutoSize = true;
            lblCreditsHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreditsHeader.ForeColor = Color.FromArgb(107, 107, 107);
            lblCreditsHeader.Location = new Point(21, 13);
            lblCreditsHeader.Name = "lblCreditsHeader";
            lblCreditsHeader.Size = new Size(75, 15);
            lblCreditsHeader.TabIndex = 0;
            lblCreditsHeader.Text = "CREATED BY";
            // 
            // horizontalLine2
            // 
            horizontalLine2.BorderStyle = BorderStyle.Fixed3D;
            horizontalLine2.Dock = DockStyle.Top;
            horizontalLine2.Location = new Point(0, 220);
            horizontalLine2.MaximumSize = new Size(0, 2);
            horizontalLine2.Name = "horizontalLine2";
            horizontalLine2.Size = new Size(427, 2);
            horizontalLine2.TabIndex = 3;
            // 
            // pnlProject
            // 
            pnlProject.BackColor = Color.White;
            pnlProject.Controls.Add(btnGithubProject);
            pnlProject.Controls.Add(lblProjectHeader);
            pnlProject.Dock = DockStyle.Fill;
            pnlProject.Location = new Point(0, 222);
            pnlProject.Margin = new Padding(3, 2, 3, 2);
            pnlProject.Name = "pnlProject";
            pnlProject.Size = new Size(427, 125);
            pnlProject.TabIndex = 4;
            // 
            // btnGithubProject
            // 
            btnGithubProject.AutoSize = true;
            btnGithubProject.BackColor = Color.Transparent;
            btnGithubProject.Cursor = Cursors.Hand;
            btnGithubProject.FlatAppearance.BorderSize = 0;
            btnGithubProject.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            btnGithubProject.FlatStyle = FlatStyle.Flat;
            btnGithubProject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGithubProject.ForeColor = Color.FromArgb(0, 120, 212);
            btnGithubProject.Location = new Point(18, 33);
            btnGithubProject.Margin = new Padding(3, 2, 3, 2);
            btnGithubProject.Name = "btnGithubProject";
            btnGithubProject.Padding = new Padding(4, 0, 4, 0);
            btnGithubProject.Size = new Size(93, 31);
            btnGithubProject.TabIndex = 1;
            btnGithubProject.Text = "GitHub ↗";
            btnGithubProject.UseVisualStyleBackColor = false;
            btnGithubProject.Click += btnGithubProject_Click;
            // 
            // lblProjectHeader
            // 
            lblProjectHeader.AutoSize = true;
            lblProjectHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProjectHeader.ForeColor = Color.FromArgb(107, 107, 107);
            lblProjectHeader.Location = new Point(21, 13);
            lblProjectHeader.Name = "lblProjectHeader";
            lblProjectHeader.Size = new Size(56, 15);
            lblProjectHeader.TabIndex = 0;
            lblProjectHeader.Text = "PROJECT";
            // 
            // AboutWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(427, 347);
            Controls.Add(pnlProject);
            Controls.Add(horizontalLine2);
            Controls.Add(pnlCredits);
            Controls.Add(horizontalLine1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            pnlHeader.ResumeLayout(false);
            pnlCredits.ResumeLayout(false);
            pnlCredits.PerformLayout();
            pnlProject.ResumeLayout(false);
            pnlProject.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblVersion;
        private Forms.Common.HorizontalLine horizontalLine1;
        private Panel pnlCredits;
        private Label lblCreditsHeader;
        private Forms.About.CreditEntryControl creditEntry;
        private Forms.Common.HorizontalLine horizontalLine2;
        private Panel pnlProject;
        private Label lblProjectHeader;
        private Button btnGithubProject;
    }
}
