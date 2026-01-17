namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class HostHeaderTask
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
            hostNameText = new LabeledTextbox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            addEntryButton = new RadioButton();
            removeEntryButton = new RadioButton();
            ipAddressText = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // hostNameText
            // 
            hostNameText.Dock = DockStyle.Top;
            hostNameText.Location = new Point(3, 3);
            hostNameText.Multiline = false;
            hostNameText.Name = "hostNameText";
            hostNameText.PathSelectMode = PathSelectMode.Folder;
            hostNameText.ShowPathSelector = false;
            hostNameText.Size = new Size(581, 69);
            hostNameText.TabIndex = 0;
            hostNameText.TextInput = "sc1041.sc";
            hostNameText.TextLabel = "Hostname *";
            hostNameText.Vertical = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(595, 671);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(ipAddressText);
            tabPage1.Controls.Add(hostNameText);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(587, 635);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Host entry";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(addEntryButton, 0, 0);
            tableLayoutPanel1.Controls.Add(removeEntryButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 141);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(581, 33);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // addEntryButton
            // 
            addEntryButton.AutoSize = true;
            addEntryButton.Checked = true;
            addEntryButton.Location = new Point(3, 3);
            addEntryButton.Name = "addEntryButton";
            addEntryButton.Size = new Size(106, 27);
            addEntryButton.TabIndex = 0;
            addEntryButton.TabStop = true;
            addEntryButton.Text = "Add entry";
            addEntryButton.UseVisualStyleBackColor = true;
            // 
            // removeEntryButton
            // 
            removeEntryButton.AutoSize = true;
            removeEntryButton.Location = new Point(293, 3);
            removeEntryButton.Name = "removeEntryButton";
            removeEntryButton.Size = new Size(136, 27);
            removeEntryButton.TabIndex = 1;
            removeEntryButton.TabStop = true;
            removeEntryButton.Text = "Remove entry";
            removeEntryButton.UseVisualStyleBackColor = true;
            // 
            // ipAddressText
            // 
            ipAddressText.Dock = DockStyle.Top;
            ipAddressText.Location = new Point(3, 72);
            ipAddressText.Multiline = false;
            ipAddressText.Name = "ipAddressText";
            ipAddressText.PathSelectMode = PathSelectMode.Folder;
            ipAddressText.ShowPathSelector = false;
            ipAddressText.Size = new Size(581, 69);
            ipAddressText.TabIndex = 1;
            ipAddressText.TextInput = "127.0.0.1";
            ipAddressText.TextLabel = "IP Address";
            ipAddressText.Vertical = true;
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
            // HostHeaderTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "HostHeaderTask";
            Size = new Size(595, 671);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private LabeledTextbox hostNameText;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton addEntryButton;
        private RadioButton removeEntryButton;
        private LabeledTextbox ipAddressText;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
