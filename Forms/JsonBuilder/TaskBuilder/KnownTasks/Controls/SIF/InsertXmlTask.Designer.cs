namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class InsertXmlTask
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
            xmlInput = new LabeledTextbox();
            xpathTextInput = new LabeledTextbox();
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
            tabControl1.Size = new Size(640, 562);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(xmlInput);
            tabPage1.Controls.Add(xpathTextInput);
            tabPage1.Controls.Add(filePathInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(632, 526);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Insert XML";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // xmlInput
            // 
            xmlInput.Dock = DockStyle.Fill;
            xmlInput.Location = new Point(3, 119);
            xmlInput.Multiline = true;
            xmlInput.Name = "xmlInput";
            xmlInput.PathSelectMode = PathSelectMode.Folder;
            xmlInput.ShowPathSelector = false;
            xmlInput.Size = new Size(626, 404);
            xmlInput.TabIndex = 2;
            xmlInput.TextInput = "<add name=\"core\" connectionString=\"Data Source=.;Initial Catalog=sc1041_Core;User ID=coreuser;Password=b\" />";
            xmlInput.TextLabel = "XML *";
            xmlInput.Vertical = true;
            // 
            // xpathTextInput
            // 
            xpathTextInput.Dock = DockStyle.Top;
            xpathTextInput.Location = new Point(3, 61);
            xpathTextInput.Multiline = false;
            xpathTextInput.Name = "xpathTextInput";
            xpathTextInput.PathSelectMode = PathSelectMode.Folder;
            xpathTextInput.ShowPathSelector = false;
            xpathTextInput.Size = new Size(626, 58);
            xpathTextInput.TabIndex = 1;
            xpathTextInput.TextInput = "//connectionStrings";
            xpathTextInput.TextLabel = "XPath *";
            xpathTextInput.Vertical = true;
            // 
            // filePathInput
            // 
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(3, 3);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectMode = PathSelectMode.File;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(626, 58);
            filePathInput.TabIndex = 0;
            filePathInput.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config\\ConnectionStrings.config";
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
            // InsertXmlTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "InsertXmlTask";
            Size = new Size(640, 562);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox xpathTextInput;
        private LabeledTextbox filePathInput;
        private LabeledTextbox xmlInput;
    }
}
