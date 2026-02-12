namespace SIF.Utils.Forms.SelectFile
{
    partial class RecentFiles
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
            tableLayoutPanel1 = new TableLayoutPanel();
            headerLabel = new Label();
            clearAction = new LinkLabel();
            recentFileCard1 = new RecentFileCard();
            horizontalLine1 = new SIF.Utils.Forms.Common.HorizontalLine();
            filesPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            filesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(headerLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(clearAction, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(868, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(3, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(116, 28);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Recent files";
            // 
            // clearAction
            // 
            clearAction.AutoSize = true;
            clearAction.DisabledLinkColor = Color.FromArgb(37, 99, 235);
            clearAction.Dock = DockStyle.Right;
            clearAction.Font = new Font("Segoe UI", 12F);
            clearAction.LinkColor = Color.FromArgb(37, 99, 235);
            clearAction.Location = new Point(809, 0);
            clearAction.Name = "clearAction";
            clearAction.Size = new Size(56, 28);
            clearAction.TabIndex = 2;
            clearAction.TabStop = true;
            clearAction.Text = "Clear";
            clearAction.Visible = false;
            clearAction.VisitedLinkColor = Color.FromArgb(37, 99, 235);
            clearAction.LinkClicked += clearAction_LinkClicked;
            // 
            // recentFileCard1
            // 
            recentFileCard1.Dock = DockStyle.Top;
            recentFileCard1.Location = new Point(0, 0);
            recentFileCard1.Margin = new Padding(0);
            recentFileCard1.MaximumSize = new Size(0, 64);
            recentFileCard1.Name = "recentFileCard1";
            recentFileCard1.Padding = new Padding(12, 8, 12, 8);
            recentFileCard1.Size = new Size(868, 64);
            recentFileCard1.TabIndex = 2;
            // 
            // horizontalLine1
            // 
            horizontalLine1.BorderStyle = BorderStyle.Fixed3D;
            horizontalLine1.Dock = DockStyle.Top;
            horizontalLine1.Location = new Point(0, 40);
            horizontalLine1.MaximumSize = new Size(0, 2);
            horizontalLine1.Name = "horizontalLine1";
            horizontalLine1.Size = new Size(868, 2);
            horizontalLine1.TabIndex = 3;
            // 
            // filesPanel
            // 
            filesPanel.AutoSize = true;
            filesPanel.Controls.Add(recentFileCard1);
            filesPanel.Dock = DockStyle.Top;
            filesPanel.Location = new Point(0, 42);
            filesPanel.Name = "filesPanel";
            filesPanel.Size = new Size(868, 64);
            filesPanel.TabIndex = 4;
            // 
            // RecentFiles
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(filesPanel);
            Controls.Add(horizontalLine1);
            Controls.Add(tableLayoutPanel1);
            Name = "RecentFiles";
            Size = new Size(868, 645);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            filesPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel clearAction;
        private Label headerLabel;
        private RecentFileCard recentFileCard1;
        private Common.HorizontalLine horizontalLine1;
        private Panel filesPanel;
    }
}
