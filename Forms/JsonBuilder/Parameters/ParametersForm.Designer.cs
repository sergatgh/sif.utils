namespace SIF.Utils.Forms.JsonBuilder.Parameters
{
    partial class ParametersForm
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

        private void InitializeComponent()
        {
            listView1 = new ListView();
            columnName = new ColumnHeader();
            columnType = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();

            menuStrip1.SuspendLayout();
            SuspendLayout();

            // listView1
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnType });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;

            // columnName
            columnName.Text = "Name";
            columnName.Width = 300;

            // columnType
            columnType.Text = "Type";
            columnType.Width = 120;

            // menuStrip1
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, removeToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 31);
            menuStrip1.Text = "menuStrip1";

            // addToolStripMenuItem
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(55, 27);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;

            // editToolStripMenuItem
            editToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(53, 27);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;

            // removeToolStripMenuItem
            removeToolStripMenuItem.Enabled = false;
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(85, 27);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;

            // ParametersForm
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Name = "ParametersForm";
            Size = new Size(584, 392);

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ListView listView1;
        private ColumnHeader columnName;
        private ColumnHeader columnType;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}
