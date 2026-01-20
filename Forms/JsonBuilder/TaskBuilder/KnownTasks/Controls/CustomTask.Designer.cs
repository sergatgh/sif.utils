namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls
{
    partial class CustomTask
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
            taskEditor1 = new TaskEditor();
            typeLabel = new Label();
            typeText = new TextBox();
            SuspendLayout();
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.AutoSize = true;
            taskEditor1.Dock = DockStyle.Top;
            taskEditor1.Location = new Point(0, 53);
            taskEditor1.MinimumSize = new Size(50, 50);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(581, 362);
            taskEditor1.TabIndex = 0;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Dock = DockStyle.Top;
            typeLabel.Location = new Point(0, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(45, 23);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type";
            // 
            // typeText
            // 
            typeText.AutoCompleteMode = AutoCompleteMode.Suggest;
            typeText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            typeText.Dock = DockStyle.Top;
            typeText.Location = new Point(0, 23);
            typeText.Name = "typeText";
            typeText.Size = new Size(581, 30);
            typeText.TabIndex = 2;
            typeText.Text = "Command";
            // 
            // CustomTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(taskEditor1);
            Controls.Add(typeText);
            Controls.Add(typeLabel);
            Name = "CustomTask";
            Size = new Size(581, 519);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TaskEditor taskEditor1;
        private Label typeLabel;
        private TextBox typeText;
    }
}
