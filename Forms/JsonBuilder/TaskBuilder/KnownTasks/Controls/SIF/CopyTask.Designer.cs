namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class CopyTask
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            destinationText = new TextBox();
            button2 = new Button();
            cleanLabel = new Label();
            panel1 = new Panel();
            sourcePathText = new TextBox();
            button1 = new Button();
            labelEnsure = new Label();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(540, 425);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(cleanLabel);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(labelEnsure);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(532, 397);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Copy";
            tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(532, 397);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(2, 2);
            taskEditor1.Margin = new Padding(2, 1, 2, 1);
            taskEditor1.MinimumSize = new Size(39, 33);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(528, 393);
            taskEditor1.TabIndex = 0;
            // 
            // CopyTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CopyTask";
            Size = new Size(540, 425);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox destinationText;
        private Label cleanLabel;
        private TextBox sourcePathText;
        private Label labelEnsure;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
    }
}
