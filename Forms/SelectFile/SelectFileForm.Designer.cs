namespace SIF.Utils.Forms.SelectFile
{
    partial class SelectFileForm
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            loadingImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            dragAndDropArea1 = new DragAndDropArea();
            recentFiles1 = new RecentFiles();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingImage).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1101, 1076);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(loadingImage, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dragAndDropArea1, 0, 4);
            tableLayoutPanel1.Controls.Add(recentFiles1, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(32, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1037, 684);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // loadingImage
            // 
            loadingImage.Dock = DockStyle.Fill;
            loadingImage.Image = Properties.Resources.placidplace_loading_16066_512;
            loadingImage.Location = new Point(0, 363);
            loadingImage.Margin = new Padding(0);
            loadingImage.Name = "loadingImage";
            loadingImage.Size = new Size(1037, 183);
            loadingImage.SizeMode = PictureBoxSizeMode.CenterImage;
            loadingImage.TabIndex = 3;
            loadingImage.TabStop = false;
            loadingImage.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(31, 41, 55);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(442, 46);
            label1.TabIndex = 0;
            label1.Text = "Select SIF configuration file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 107, 107);
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(394, 25);
            label2.TabIndex = 1;
            label2.Text = "Inspect, validate or run a SIF JSON configuration";
            // 
            // dragAndDropArea1
            // 
            dragAndDropArea1.AllowDrop = true;
            dragAndDropArea1.BackColor = Color.FromArgb(248, 250, 252);
            dragAndDropArea1.Dock = DockStyle.Fill;
            dragAndDropArea1.Location = new Point(0, 103);
            dragAndDropArea1.Margin = new Padding(0);
            dragAndDropArea1.MaximumSize = new Size(0, 260);
            dragAndDropArea1.Name = "dragAndDropArea1";
            dragAndDropArea1.Padding = new Padding(24);
            dragAndDropArea1.Size = new Size(1037, 260);
            dragAndDropArea1.TabIndex = 2;
            dragAndDropArea1.FileSelected += dragAndDropArea1_FileSelected;
            // 
            // recentFiles1
            // 
            recentFiles1.AutoSize = true;
            recentFiles1.BackColor = Color.Transparent;
            recentFiles1.Dock = DockStyle.Top;
            recentFiles1.Location = new Point(0, 578);
            recentFiles1.Margin = new Padding(0);
            recentFiles1.Name = "recentFiles1";
            recentFiles1.Size = new Size(1037, 106);
            recentFiles1.TabIndex = 4;
            recentFiles1.FileSelected += recentFiles1_FileSelected;
            // 
            // SelectFileForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SelectFileForm";
            Size = new Size(1101, 1076);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loadingImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private DragAndDropArea dragAndDropArea1;
        private PictureBox loadingImage;
        private RecentFiles recentFiles1;
    }
}
