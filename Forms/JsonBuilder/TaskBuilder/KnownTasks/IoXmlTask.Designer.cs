namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class IoXmlTask
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
            xpathTextInput = new LabeledTextbox();
            folderPathInput = new LabeledTextbox();
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
            tabControl1.Size = new Size(569, 601);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(xpathTextInput);
            tabPage1.Controls.Add(folderPathInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(561, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Insert XML";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // xpathTextInput
            // 
            xpathTextInput.Dock = DockStyle.Top;
            xpathTextInput.Location = new Point(3, 61);
            xpathTextInput.Multiline = false;
            xpathTextInput.Name = "xpathTextInput";
            xpathTextInput.PathSelectionFilter = "IOXML|*.ioxml";
            xpathTextInput.PathSelectMode = PathSelectMode.File;
            xpathTextInput.ShowPathSelector = true;
            xpathTextInput.Size = new Size(555, 58);
            xpathTextInput.TabIndex = 1;
            xpathTextInput.TextInput = "";
            xpathTextInput.TextLabel = "IO Xml Path *";
            xpathTextInput.Vertical = true;
            // 
            // folderPathInput
            // 
            folderPathInput.Dock = DockStyle.Top;
            folderPathInput.Location = new Point(3, 3);
            folderPathInput.Multiline = false;
            folderPathInput.Name = "folderPathInput";
            folderPathInput.PathSelectionFilter = "";
            folderPathInput.PathSelectMode = PathSelectMode.Folder;
            folderPathInput.ShowPathSelector = true;
            folderPathInput.Size = new Size(555, 58);
            folderPathInput.TabIndex = 0;
            folderPathInput.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config\\Include";
            folderPathInput.TextLabel = "Root Directory Path *";
            folderPathInput.Vertical = true;
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
            // IoXmlTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "IoXmlTask";
            Size = new Size(569, 601);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox xpathTextInput;
        private LabeledTextbox folderPathInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
