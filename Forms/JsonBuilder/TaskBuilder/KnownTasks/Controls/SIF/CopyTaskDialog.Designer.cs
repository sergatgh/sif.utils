namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class CopyTaskDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel2 = new Panel();
            destinationText = new TextBox();
            button2 = new Button();
            cleanLabel = new Label();
            panel1 = new Panel();
            sourcePathText = new TextBox();
            button1 = new Button();
            labelEnsure = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            //
            // panel2
            //
            panel2.Controls.Add(destinationText);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(2, 52);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 20);
            panel2.TabIndex = 6;
            //
            // destinationText
            //
            destinationText.Dock = DockStyle.Fill;
            destinationText.Location = new Point(0, 0);
            destinationText.Margin = new Padding(2, 2, 2, 2);
            destinationText.Name = "destinationText";
            destinationText.Size = new Size(503, 23);
            destinationText.TabIndex = 3;
            //
            // button2
            //
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(503, 0);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(25, 20);
            button2.TabIndex = 3;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            //
            // cleanLabel
            //
            cleanLabel.AutoSize = true;
            cleanLabel.Dock = DockStyle.Top;
            cleanLabel.Location = new Point(2, 37);
            cleanLabel.Margin = new Padding(2, 0, 2, 0);
            cleanLabel.Name = "cleanLabel";
            cleanLabel.Size = new Size(67, 15);
            cleanLabel.TabIndex = 1;
            cleanLabel.Text = "Destination";
            //
            // panel1
            //
            panel1.Controls.Add(sourcePathText);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(2, 17);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 20);
            panel1.TabIndex = 5;
            //
            // sourcePathText
            //
            sourcePathText.Dock = DockStyle.Fill;
            sourcePathText.Location = new Point(0, 0);
            sourcePathText.Margin = new Padding(2, 2, 2, 2);
            sourcePathText.Name = "sourcePathText";
            sourcePathText.Size = new Size(503, 23);
            sourcePathText.TabIndex = 2;
            sourcePathText.Text = "notepad";
            //
            // button1
            //
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(503, 0);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(25, 20);
            button1.TabIndex = 3;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // labelEnsure
            //
            labelEnsure.AutoSize = true;
            labelEnsure.Dock = DockStyle.Top;
            labelEnsure.Location = new Point(2, 2);
            labelEnsure.Margin = new Padding(2, 0, 2, 0);
            labelEnsure.Name = "labelEnsure";
            labelEnsure.Size = new Size(43, 15);
            labelEnsure.TabIndex = 0;
            labelEnsure.Text = "Source";
            //
            // CopyTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel2);
            Controls.Add(cleanLabel);
            Controls.Add(panel1);
            Controls.Add(labelEnsure);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CopyTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(532, 397);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        public TextBox destinationText;
        private Button button2;
        private Label cleanLabel;
        private Panel panel1;
        public TextBox sourcePathText;
        private Label labelEnsure;
        private Button button1;
    }
}
