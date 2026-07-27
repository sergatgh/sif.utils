namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder
{
    partial class TaskBuilderPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskBuilderPanel));
            ListViewItem listViewItem1 = new ListViewItem("Write Host", "task.png");
            imageList1 = new ImageList(components);
            splitContainer1 = new SplitContainer();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            powerShellToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            customToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            listViewContextMenuStrip = new ContextMenuStrip(components);
            duplicateToolStripMenuItem = new ToolStripMenuItem();
            contextMenuRemoveToolStripMenuItem = new ToolStripMenuItem();
            importOverlayPanel = new Panel();
            importProgressBar = new ProgressBar();
            importStatusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            listViewContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "task.png");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listView1);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            //
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(importOverlayPanel);
            splitContainer1.Size = new Size(828, 393);
            splitContainer1.SplitterDistance = 276;
            splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(0, 0);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(276, 362);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ContextMenuStrip = listViewContextMenuStrip;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDown += listView1_MouseDown;
            //
            // columnHeader1
            //
            columnHeader1.Width = 272;
            //
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 362);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(276, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { powerShellToolStripMenuItem, defaultToolStripMenuItem, customToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(130, 27);
            addToolStripMenuItem.Text = "Insert New Task";
            // 
            // powerShellToolStripMenuItem
            // 
            powerShellToolStripMenuItem.Name = "powerShellToolStripMenuItem";
            powerShellToolStripMenuItem.Size = new Size(176, 28);
            powerShellToolStripMenuItem.Text = "PowerShell";
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(176, 28);
            defaultToolStripMenuItem.Text = "SIF Default";
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new Size(176, 28);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Enabled = false;
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(85, 27);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            //
            // listViewContextMenuStrip
            //
            listViewContextMenuStrip.Items.AddRange(new ToolStripItem[] { duplicateToolStripMenuItem, contextMenuRemoveToolStripMenuItem });
            listViewContextMenuStrip.Name = "listViewContextMenuStrip";
            listViewContextMenuStrip.Size = new Size(133, 52);
            listViewContextMenuStrip.Opening += listViewContextMenuStrip_Opening;
            //
            // duplicateToolStripMenuItem
            //
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new Size(132, 24);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += duplicateToolStripMenuItem_Click;
            //
            // contextMenuRemoveToolStripMenuItem
            //
            contextMenuRemoveToolStripMenuItem.Name = "contextMenuRemoveToolStripMenuItem";
            contextMenuRemoveToolStripMenuItem.Size = new Size(132, 24);
            contextMenuRemoveToolStripMenuItem.Text = "Remove";
            contextMenuRemoveToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            //
            // importOverlayPanel
            //
            importOverlayPanel.BackColor = SystemColors.Window;
            importOverlayPanel.Controls.Add(importProgressBar);
            importOverlayPanel.Controls.Add(importStatusLabel);
            importOverlayPanel.Dock = DockStyle.Fill;
            importOverlayPanel.Name = "importOverlayPanel";
            importOverlayPanel.Size = new Size(548, 393);
            importOverlayPanel.TabIndex = 0;
            importOverlayPanel.Visible = false;
            //
            // importProgressBar
            //
            importProgressBar.Anchor = AnchorStyles.None;
            importProgressBar.Location = new Point(174, 196);
            importProgressBar.MarqueeAnimationSpeed = 30;
            importProgressBar.Name = "importProgressBar";
            importProgressBar.Size = new Size(260, 20);
            importProgressBar.Style = ProgressBarStyle.Continuous;
            importProgressBar.TabIndex = 0;
            //
            // importStatusLabel
            //
            importStatusLabel.Anchor = AnchorStyles.None;
            importStatusLabel.AutoSize = true;
            importStatusLabel.Location = new Point(180, 172);
            importStatusLabel.Name = "importStatusLabel";
            importStatusLabel.Size = new Size(130, 20);
            importStatusLabel.TabIndex = 1;
            importStatusLabel.Text = "Importing tasks…";
            //
            // TaskBuilderPanel
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "TaskBuilderPanel";
            Size = new Size(828, 393);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            listViewContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private SplitContainer splitContainer1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem powerShellToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem customToolStripMenuItem;
        private ContextMenuStrip listViewContextMenuStrip;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripMenuItem contextMenuRemoveToolStripMenuItem;
        private Panel importOverlayPanel;
        private ProgressBar importProgressBar;
        private Label importStatusLabel;
    }
}
