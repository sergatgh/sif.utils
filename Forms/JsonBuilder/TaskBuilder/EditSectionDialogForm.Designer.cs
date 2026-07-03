namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder
{
    partial class EditSectionDialogForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            contentPanel = new Panel();
            pnlButtons = new FlowLayoutPanel();
            okButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(contentPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlButtons, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.TabIndex = 0;
            //
            // contentPanel
            //
            contentPanel.AutoScroll = true;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Name = "contentPanel";
            contentPanel.TabIndex = 0;
            //
            // pnlButtons
            //
            pnlButtons.Controls.Add(cancelButton);
            pnlButtons.Controls.Add(okButton);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(8);
            pnlButtons.TabIndex = 1;
            pnlButtons.WrapContents = false;
            //
            // okButton
            //
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            //
            // cancelButton
            //
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            //
            // EditSectionDialogForm
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AcceptButton = okButton;
            CancelButton = cancelButton;
            ClientSize = new Size(680, 560);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditSectionDialogForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit";
            tableLayoutPanel1.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel contentPanel;
        private FlowLayoutPanel pnlButtons;
        private Button okButton, cancelButton;
    }
}
