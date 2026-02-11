namespace SIF.Utils.Forms.Home
{
    partial class FeatureCardControl
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
            descriptionLabel = new Label();
            imageBox = new PictureBox();
            titleLabel = new Label();
            shevron = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(descriptionLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(imageBox, 0, 0);
            tableLayoutPanel1.Controls.Add(titleLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(shevron, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MaximumSize = new Size(360, 120);
            tableLayoutPanel1.MinimumSize = new Size(320, 110);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(16);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(360, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Top;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.ForeColor = Color.FromArgb(107, 107, 107);
            descriptionLabel.Location = new Point(81, 47);
            descriptionLabel.Margin = new Padding(0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(229, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description goes here";
            // 
            // imageBox
            // 
            imageBox.Dock = DockStyle.Top;
            imageBox.Image = Properties.Resources.DefaultTaskIcon;
            imageBox.ImageLocation = "";
            imageBox.Location = new Point(16, 16);
            imageBox.Margin = new Padding(0, 0, 8, 12);
            imageBox.Name = "imageBox";
            tableLayoutPanel1.SetRowSpan(imageBox, 2);
            imageBox.Size = new Size(57, 64);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 0;
            imageBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(81, 16);
            titleLabel.Margin = new Padding(0, 0, 0, 6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(229, 25);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title goes here";
            // 
            // shevron
            // 
            shevron.AutoSize = true;
            shevron.Dock = DockStyle.Fill;
            shevron.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shevron.Location = new Point(313, 16);
            shevron.Name = "shevron";
            tableLayoutPanel1.SetRowSpan(shevron, 2);
            shevron.Size = new Size(28, 88);
            shevron.TabIndex = 3;
            shevron.Text = "→";
            shevron.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeatureCardControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(360, 120);
            Name = "FeatureCardControl";
            Size = new Size(360, 120);
            Paint += FeatureCardControl_Paint;
            Resize += FeatureCardControl_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox imageBox;
        private Label titleLabel;
        private Label descriptionLabel;
        private Label shevron;
    }
}
