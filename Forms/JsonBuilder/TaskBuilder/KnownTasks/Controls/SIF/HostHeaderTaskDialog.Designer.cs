namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class HostHeaderTaskDialog
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
            hostNameText = new LabeledTextbox();
            tableLayoutPanel1 = new TableLayoutPanel();
            addEntryButton = new RadioButton();
            removeEntryButton = new RadioButton();
            ipAddressText = new LabeledTextbox();
            tableLayoutPanel1.SuspendLayout();
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
            // HostHeaderTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ipAddressText);
            Controls.Add(hostNameText);
            Name = "HostHeaderTaskDialog";
            Padding = new Padding(3);
            Size = new Size(587, 635);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox hostNameText;
        private TableLayoutPanel tableLayoutPanel1;
        public RadioButton addEntryButton;
        public RadioButton removeEntryButton;
        public LabeledTextbox ipAddressText;
    }
}
