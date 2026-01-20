namespace SIF.Utils.Forms.JsonBuilder.Includes
{
    partial class IncludeFiles
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
            listView1 = new ListView();
            pathToInclude = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            addFilesToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            useRelativePathMenu = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { pathToInclude });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(833, 503);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // pathToInclude
            // 
            pathToInclude.Text = "Path";
            pathToInclude.Width = 800;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addFilesToolStripMenuItem, removeToolStripMenuItem, useRelativePathMenu });
            menuStrip1.Location = new Point(0, 503);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(833, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addFilesToolStripMenuItem
            // 
            addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            addFilesToolStripMenuItem.Size = new Size(89, 27);
            addFilesToolStripMenuItem.Text = "Add files";
            addFilesToolStripMenuItem.Click += addFilesToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Enabled = false;
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(85, 27);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // useRelativePathMenu
            // 
            useRelativePathMenu.CheckOnClick = true;
            useRelativePathMenu.Name = "useRelativePathMenu";
            useRelativePathMenu.Size = new Size(215, 27);
            useRelativePathMenu.Text = "Use relative path on save";
            // 
            // IncludeFiles
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Name = "IncludeFiles";
            Size = new Size(833, 534);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader pathToInclude;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addFilesToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem useRelativePathMenu;
    }
}
