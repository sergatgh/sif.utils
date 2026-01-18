namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class UpdateBindingRedirectsTask
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
            configsFolder = new LabeledTextbox();
            binFolder = new LabeledTextbox();
            button1 = new Button();
            siteFolder = new LabeledTextbox();
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
            tabControl1.Size = new Size(746, 707);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(configsFolder);
            tabPage1.Controls.Add(binFolder);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(siteFolder);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(738, 671);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // configsFolder
            // 
            configsFolder.Dock = DockStyle.Fill;
            configsFolder.Location = new Point(3, 115);
            configsFolder.Multiline = true;
            configsFolder.Name = "configsFolder";
            configsFolder.PathSelectionFilter = "";
            configsFolder.PathSelectMode = PathSelectMode.Folder;
            configsFolder.ShowPathSelector = false;
            configsFolder.Size = new Size(732, 553);
            configsFolder.TabIndex = 7;
            configsFolder.TextInput = "";
            configsFolder.TextLabel = "Config Files To Patch (one per line)";
            configsFolder.Vertical = true;
            // 
            // binFolder
            // 
            binFolder.Dock = DockStyle.Top;
            binFolder.Location = new Point(3, 59);
            binFolder.Multiline = false;
            binFolder.Name = "binFolder";
            binFolder.PathSelectionFilter = "";
            binFolder.PathSelectMode = PathSelectMode.Folder;
            binFolder.ShowPathSelector = true;
            binFolder.Size = new Size(732, 56);
            binFolder.TabIndex = 8;
            binFolder.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Data\\jobs\\continuous\\ProcessingEngine";
            binFolder.TextLabel = "Binaries Folder";
            binFolder.Vertical = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(3651, 115);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // siteFolder
            // 
            siteFolder.Dock = DockStyle.Top;
            siteFolder.Location = new Point(3, 3);
            siteFolder.Multiline = false;
            siteFolder.Name = "siteFolder";
            siteFolder.PathSelectionFilter = "";
            siteFolder.PathSelectMode = PathSelectMode.Folder;
            siteFolder.ShowPathSelector = true;
            siteFolder.Size = new Size(732, 56);
            siteFolder.TabIndex = 0;
            siteFolder.TextInput = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Data\\jobs\\continuous\\ProcessingEngine";
            siteFolder.TextLabel = "Site Path *";
            siteFolder.Vertical = true;
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
            // UpdateBindingRedirectsTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UpdateBindingRedirectsTask";
            Size = new Size(746, 707);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox configsFolder;
        private Button button1;
        private LabeledTextbox siteFolder;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox binFolder;
    }
}
