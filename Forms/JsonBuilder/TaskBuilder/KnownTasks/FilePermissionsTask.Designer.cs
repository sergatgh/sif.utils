namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class FilePermissionsTask
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
            filePathInput = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            listView1 = new ListView();
            menuStrip1 = new MenuStrip();
            addAccessRightToolStripMenuItem = new ToolStripMenuItem();
            removeAccessRightToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            tabControl1.Size = new Size(581, 454);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(filePathInput);
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(573, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "File Permissions";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // filePathInput
            // 
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(3, 3);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectMode = PathSelectMode.File;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(567, 58);
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
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(567, 323);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addAccessRightToolStripMenuItem, removeAccessRightToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(3, 384);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(567, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addAccessRightToolStripMenuItem
            // 
            addAccessRightToolStripMenuItem.Name = "addAccessRightToolStripMenuItem";
            addAccessRightToolStripMenuItem.Size = new Size(55, 27);
            addAccessRightToolStripMenuItem.Text = "Add";
            // 
            // removeAccessRightToolStripMenuItem
            // 
            removeAccessRightToolStripMenuItem.Name = "removeAccessRightToolStripMenuItem";
            removeAccessRightToolStripMenuItem.Size = new Size(85, 27);
            removeAccessRightToolStripMenuItem.Text = "Remove";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(53, 27);
            editToolStripMenuItem.Text = "Edit";
            // 
            // FilePermissionsTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "FilePermissionsTask";
            Size = new Size(581, 454);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox filePathInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private ListView listView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addAccessRightToolStripMenuItem;
        private ToolStripMenuItem removeAccessRightToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}
