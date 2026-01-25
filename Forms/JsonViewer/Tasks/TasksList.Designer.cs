namespace SIF.Utils.Forms.JsonViewer.Tasks
{
    partial class TasksList
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
            components = new System.ComponentModel.Container();
            filterText = new TextBox();
            tasksViewer = new ListView();
            nameColumnHeader = new ColumnHeader();
            descriptionColumnHeader = new ColumnHeader();
            TasksContextMenu = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            copyTaskName = new ToolStripMenuItem();
            copyTaskDescription = new ToolStripMenuItem();
            executeToolStripMenuItem = new ToolStripMenuItem();
            TasksContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // filterText
            // 
            filterText.Dock = DockStyle.Top;
            filterText.Location = new Point(0, 0);
            filterText.Name = "filterText";
            filterText.PlaceholderText = "Filter";
            filterText.Size = new Size(873, 30);
            filterText.TabIndex = 1;
            filterText.TextChanged += filterText_TextChanged;
            filterText.KeyDown += this.filterText_KeyDown;
            // 
            // tasksViewer
            // 
            tasksViewer.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, descriptionColumnHeader });
            tasksViewer.ContextMenuStrip = TasksContextMenu;
            tasksViewer.Dock = DockStyle.Fill;
            tasksViewer.FullRowSelect = true;
            tasksViewer.GridLines = true;
            tasksViewer.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tasksViewer.Location = new Point(0, 30);
            tasksViewer.Name = "tasksViewer";
            tasksViewer.ShowGroups = false;
            tasksViewer.ShowItemToolTips = true;
            tasksViewer.Size = new Size(873, 525);
            tasksViewer.TabIndex = 2;
            tasksViewer.Tag = "Tasks";
            tasksViewer.UseCompatibleStateImageBehavior = false;
            tasksViewer.View = View.Details;
            tasksViewer.DoubleClick += tasksViewer_DoubleClick;
            tasksViewer.KeyDown += tasksViewer_KeyDown;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 400;
            // 
            // descriptionColumnHeader
            // 
            descriptionColumnHeader.Text = "Description";
            descriptionColumnHeader.Width = 600;
            // 
            // TasksContextMenu
            // 
            TasksContextMenu.ImageScalingSize = new Size(20, 20);
            TasksContextMenu.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, copyToolStripMenuItem, executeToolStripMenuItem });
            TasksContextMenu.Name = "contextMenuStrip1";
            TasksContextMenu.Size = new Size(140, 88);
            TasksContextMenu.Opening += TasksContextMenu_Opening;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(139, 28);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyTaskName, copyTaskDescription });
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(139, 28);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // copyTaskName
            // 
            copyTaskName.Name = "copyTaskName";
            copyTaskName.Size = new Size(180, 28);
            copyTaskName.Text = "Name";
            copyTaskName.Click += copyTaskName_Click;
            // 
            // copyTaskDescription
            // 
            copyTaskDescription.Name = "copyTaskDescription";
            copyTaskDescription.Size = new Size(180, 28);
            copyTaskDescription.Text = "Description";
            copyTaskDescription.Click += copyTaskDescription_Click;
            // 
            // executeToolStripMenuItem
            // 
            executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            executeToolStripMenuItem.Size = new Size(139, 28);
            executeToolStripMenuItem.Text = "Execute";
            executeToolStripMenuItem.Click += executeToolStripMenuItem_Click;
            // 
            // TasksList
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tasksViewer);
            Controls.Add(filterText);
            Name = "TasksList";
            Size = new Size(873, 555);
            TasksContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox filterText;
        internal ListView tasksViewer;
        private ContextMenuStrip TasksContextMenu;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyTaskName;
        private ToolStripMenuItem copyTaskDescription;
        private ToolStripMenuItem executeToolStripMenuItem;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader descriptionColumnHeader;
    }
}
