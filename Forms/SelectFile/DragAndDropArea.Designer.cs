namespace SIF.Utils.Forms.SelectFile
{
    partial class DragAndDropArea
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
            labelInstruction = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            browseFileButton = new Button();
            label3 = new Label();
            openFileForViewerDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Dock = DockStyle.Top;
            labelInstruction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInstruction.Location = new Point(0, 98);
            labelInstruction.Margin = new Padding(0);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(660, 28);
            labelInstruction.TabIndex = 0;
            labelInstruction.Text = "Drag && Drop SIF JSON file here";
            labelInstruction.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.choose_file_64;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(660, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(labelInstruction, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 5);
            tableLayoutPanel1.Controls.Add(browseFileButton, 0, 7);
            tableLayoutPanel1.Controls.Add(label3, 0, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.Size = new Size(660, 259);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.ForeColor = Color.FromArgb(156, 163, 175);
            label2.Location = new Point(0, 134);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(660, 21);
            label2.TabIndex = 2;
            label2.Text = "OR";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // browseFileButton
            // 
            browseFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            browseFileButton.Location = new Point(270, 167);
            browseFileButton.Margin = new Padding(0);
            browseFileButton.MaximumSize = new Size(120, 36);
            browseFileButton.Name = "browseFileButton";
            browseFileButton.Size = new Size(120, 36);
            browseFileButton.TabIndex = 3;
            browseFileButton.Text = "Browse file";
            browseFileButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(156, 163, 175);
            label3.Location = new Point(0, 215);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(660, 20);
            label3.TabIndex = 4;
            label3.Text = "Supported: *.json";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // openFileForViewerDialog
            // 
            openFileForViewerDialog.AddToRecent = false;
            openFileForViewerDialog.DefaultExt = "json";
            openFileForViewerDialog.Filter = "SIF JSON|*.json";
            openFileForViewerDialog.ReadOnlyChecked = true;
            openFileForViewerDialog.RestoreDirectory = true;
            // 
            // DragAndDropArea
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(2);
            Name = "DragAndDropArea";
            Size = new Size(660, 259);
            Paint += DragAndDropArea_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelInstruction;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button browseFileButton;
        private Label label3;
        private OpenFileDialog openFileForViewerDialog;
    }
}
