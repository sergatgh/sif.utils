namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class RemoveXmlTask
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
            ignoreNoMatchesCheckbox = new CheckBox();
            xPathInput = new LabeledTextbox();
            button1 = new Button();
            filePathInput = new LabeledTextbox();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(735, 725);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(ignoreNoMatchesCheckbox);
            tabPage1.Controls.Add(xPathInput);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(filePathInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(727, 689);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "XML";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ignoreNoMatchesCheckbox
            // 
            ignoreNoMatchesCheckbox.AutoSize = true;
            ignoreNoMatchesCheckbox.Dock = DockStyle.Top;
            ignoreNoMatchesCheckbox.Location = new Point(3, 124);
            ignoreNoMatchesCheckbox.Name = "ignoreNoMatchesCheckbox";
            ignoreNoMatchesCheckbox.Size = new Size(721, 27);
            ignoreNoMatchesCheckbox.TabIndex = 8;
            ignoreNoMatchesCheckbox.Text = "Ignore No Matches";
            ignoreNoMatchesCheckbox.UseVisualStyleBackColor = true;
            // 
            // xPathInput
            // 
            xPathInput.Dock = DockStyle.Top;
            xPathInput.Location = new Point(3, 54);
            xPathInput.Multiline = false;
            xPathInput.Name = "xPathInput";
            xPathInput.PathSelectionFilter = "";
            xPathInput.PathSelectMode = PathSelectMode.Folder;
            xPathInput.ShowPathSelector = false;
            xPathInput.Size = new Size(721, 70);
            xPathInput.TabIndex = 7;
            xPathInput.TextInput = "";
            xPathInput.TextLabel = "XPath *";
            xPathInput.Vertical = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(2092, 106);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // filePathInput
            // 
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(3, 3);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectionFilter = "";
            filePathInput.PathSelectMode = PathSelectMode.File;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(721, 51);
            filePathInput.TabIndex = 0;
            filePathInput.TextInput = "";
            filePathInput.TextLabel = "File Path *";
            filePathInput.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 64);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(3, 3);
            taskEditor1.MinimumSize = new Size(50, 50);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(186, 58);
            taskEditor1.TabIndex = 0;
            // 
            // RemoveXmlTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "RemoveXmlTask";
            Size = new Size(735, 725);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox ignoreNoMatchesCheckbox;
        private LabeledTextbox xPathInput;
        private Button button1;
        private LabeledTextbox filePathInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
