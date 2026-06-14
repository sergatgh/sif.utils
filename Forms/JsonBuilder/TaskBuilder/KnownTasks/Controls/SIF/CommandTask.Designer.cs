namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class CommandTask
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
            propertiesText = new TextBox();
            cleanLabel = new Label();
            commandPathText = new TextBox();
            labelEnsure = new Label();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabControl1.Size = new Size(388, 262);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(propertiesText);
            tabPage1.Controls.Add(cleanLabel);
            tabPage1.Controls.Add(commandPathText);
            tabPage1.Controls.Add(labelEnsure);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(380, 234);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Command";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // propertiesText
            // 
            propertiesText.Dock = DockStyle.Fill;
            propertiesText.Location = new Point(2, 55);
            propertiesText.Margin = new Padding(2, 2, 2, 2);
            propertiesText.Multiline = true;
            propertiesText.Name = "propertiesText";
            propertiesText.Size = new Size(376, 177);
            propertiesText.TabIndex = 3;
            propertiesText.Text = "/W\r\nC:\\certificates\\README";
            // 
            // cleanLabel
            // 
            cleanLabel.AutoSize = true;
            cleanLabel.Dock = DockStyle.Top;
            cleanLabel.Location = new Point(2, 40);
            cleanLabel.Margin = new Padding(2, 0, 2, 0);
            cleanLabel.Name = "cleanLabel";
            cleanLabel.Size = new Size(251, 15);
            cleanLabel.TabIndex = 1;
            cleanLabel.Text = "Parameters passed to executable (one per line)";
            // 
            // commandPathText
            // 
            commandPathText.Dock = DockStyle.Top;
            commandPathText.Location = new Point(2, 17);
            commandPathText.Margin = new Padding(2, 2, 2, 2);
            commandPathText.Name = "commandPathText";
            commandPathText.Size = new Size(376, 23);
            commandPathText.TabIndex = 2;
            commandPathText.Text = "notepad";
            // 
            // labelEnsure
            // 
            labelEnsure.AutoSize = true;
            labelEnsure.Dock = DockStyle.Top;
            labelEnsure.Location = new Point(2, 2);
            labelEnsure.Margin = new Padding(2, 0, 2, 0);
            labelEnsure.Name = "labelEnsure";
            labelEnsure.Size = new Size(104, 15);
            labelEnsure.TabIndex = 0;
            labelEnsure.Text = "Path to executable";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(380, 234);
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
            taskEditor1.Size = new Size(376, 230);
            taskEditor1.TabIndex = 0;
            // 
            // CommandTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CommandTask";
            Size = new Size(388, 262);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox propertiesText;
        private Label cleanLabel;
        private TextBox commandPathText;
        private Label labelEnsure;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
