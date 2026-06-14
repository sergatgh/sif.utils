namespace SIF.Utils.Forms.SelectFile
{
    partial class RecentFileCard
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
            fileNameLabel = new Label();
            filePathLabel = new Label();
            lastOpenedLabel = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanel1.Controls.Add(fileNameLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(filePathLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(lastOpenedLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(9, 5);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(522, 32);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Dock = DockStyle.Top;
            fileNameLabel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            fileNameLabel.ForeColor = Color.FromArgb(17, 24, 39);
            fileNameLabel.Location = new Point(49, 0);
            fileNameLabel.Margin = new Padding(2, 0, 2, 0);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(300, 16);
            fileNameLabel.TabIndex = 1;
            fileNameLabel.Text = "sif-file.json";
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Dock = DockStyle.Bottom;
            filePathLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filePathLabel.ForeColor = Color.FromArgb(107, 114, 128);
            filePathLabel.Location = new Point(49, 17);
            filePathLabel.Margin = new Padding(2, 0, 2, 0);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(300, 15);
            filePathLabel.TabIndex = 2;
            filePathLabel.Text = "C:\\wwwroot\\inetpub\\sc1041\\AppData\\path.json";
            // 
            // lastOpenedLabel
            // 
            lastOpenedLabel.AutoSize = true;
            lastOpenedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastOpenedLabel.ForeColor = Color.FromArgb(107, 114, 128);
            lastOpenedLabel.Location = new Point(353, 0);
            lastOpenedLabel.Margin = new Padding(2, 0, 2, 0);
            lastOpenedLabel.Name = "lastOpenedLabel";
            lastOpenedLabel.Size = new Size(98, 15);
            lastOpenedLabel.TabIndex = 3;
            lastOpenedLabel.Text = "Two minutes ago";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.url;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new Size(42, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // RecentFileCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            MaximumSize = new Size(0, 42);
            Name = "RecentFileCard";
            Padding = new Padding(9, 5, 9, 5);
            Size = new Size(540, 42);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label fileNameLabel;
        private Label filePathLabel;
        private Label lastOpenedLabel;
        private PictureBox pictureBox1;
        private Common.HorizontalLine horizontalLine1;
    }
}
