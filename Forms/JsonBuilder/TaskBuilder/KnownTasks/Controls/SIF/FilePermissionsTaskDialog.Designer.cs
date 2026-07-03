namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class FilePermissionsTaskDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            accessRightsList = new ListView();
            columnHeader1 = new ColumnHeader();
            filePathInput = new LabeledTextbox();
            menuStrip1 = new MenuStrip();
            addAccessRightToolStripMenuItem = new ToolStripMenuItem();
            removeAccessRightToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            //
            // accessRightsList
            //
            accessRightsList.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            accessRightsList.Dock = DockStyle.Fill;
            accessRightsList.Location = new Point(3, 61);
            accessRightsList.MultiSelect = false;
            accessRightsList.Name = "accessRightsList";
            accessRightsList.Size = new Size(567, 323);
            accessRightsList.TabIndex = 1;
            accessRightsList.UseCompatibleStateImageBehavior = false;
            accessRightsList.View = View.Details;
            accessRightsList.SelectedIndexChanged += accessRightsList_SelectedIndexChanged;
            //
            // columnHeader1
            //
            columnHeader1.Text = "Name";
            columnHeader1.Width = 300;
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
            filePathInput.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config";
            filePathInput.TextLabel = "File Path *";
            filePathInput.Vertical = true;
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
            addAccessRightToolStripMenuItem.Click += addAccessRightToolStripMenuItem_Click;
            //
            // removeAccessRightToolStripMenuItem
            //
            removeAccessRightToolStripMenuItem.Enabled = false;
            removeAccessRightToolStripMenuItem.Name = "removeAccessRightToolStripMenuItem";
            removeAccessRightToolStripMenuItem.Size = new Size(85, 27);
            removeAccessRightToolStripMenuItem.Text = "Remove";
            removeAccessRightToolStripMenuItem.Click += removeAccessRightToolStripMenuItem_Click;
            //
            // editToolStripMenuItem
            //
            editToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(53, 27);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            //
            // FilePermissionsTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(accessRightsList);
            Controls.Add(filePathInput);
            Controls.Add(menuStrip1);
            Name = "FilePermissionsTaskDialog";
            Padding = new Padding(3);
            Size = new Size(573, 418);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public LabeledTextbox filePathInput;
        public ListView accessRightsList;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addAccessRightToolStripMenuItem;
        private ToolStripMenuItem removeAccessRightToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ColumnHeader columnHeader1;
    }
}
