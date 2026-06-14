namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class EnsurePathTask
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
            labelEnsure = new Label();
            cleanLabel = new Label();
            ensureText = new TextBox();
            cleanText = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // labelEnsure
            // 
            labelEnsure.AutoSize = true;
            labelEnsure.Dock = DockStyle.Top;
            labelEnsure.Location = new Point(2, 2);
            labelEnsure.Margin = new Padding(2, 0, 2, 0);
            labelEnsure.Name = "labelEnsure";
            labelEnsure.Size = new Size(119, 15);
            labelEnsure.TabIndex = 0;
            labelEnsure.Text = "Ensure (path per line)";
            // 
            // cleanLabel
            // 
            cleanLabel.AutoSize = true;
            cleanLabel.Dock = DockStyle.Top;
            cleanLabel.Location = new Point(2, 109);
            cleanLabel.Margin = new Padding(2, 0, 2, 0);
            cleanLabel.Name = "cleanLabel";
            cleanLabel.Size = new Size(114, 15);
            cleanLabel.TabIndex = 1;
            cleanLabel.Text = "Clean (path per line)";
            // 
            // ensureText
            // 
            ensureText.Dock = DockStyle.Top;
            ensureText.Location = new Point(2, 17);
            ensureText.Margin = new Padding(2, 2, 2, 2);
            ensureText.Multiline = true;
            ensureText.Name = "ensureText";
            ensureText.Size = new Size(469, 92);
            ensureText.TabIndex = 2;
            // 
            // cleanText
            // 
            cleanText.Dock = DockStyle.Top;
            cleanText.Location = new Point(2, 124);
            cleanText.Margin = new Padding(2, 2, 2, 2);
            cleanText.Multiline = true;
            cleanText.Name = "cleanText";
            cleanText.Size = new Size(469, 91);
            cleanText.TabIndex = 3;
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
            tabControl1.Size = new Size(481, 256);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(cleanText);
            tabPage1.Controls.Add(cleanLabel);
            tabPage1.Controls.Add(ensureText);
            tabPage1.Controls.Add(labelEnsure);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(473, 228);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Paths";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(473, 228);
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
            taskEditor1.Size = new Size(469, 224);
            taskEditor1.TabIndex = 0;
            // 
            // EnsurePathTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EnsurePathTask";
            Size = new Size(481, 256);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelEnsure;
        private Label cleanLabel;
        private TextBox ensureText;
        private TextBox cleanText;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
