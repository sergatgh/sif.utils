namespace SIF.Utils.Forms.JsonBuilder.Includes
{
    partial class IncludeAliasDialog
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
            lblAlias = new Label();
            aliasTextBox = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            cancelButton = new Button();
            okButton = new Button();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            //
            // lblAlias
            //
            lblAlias.AutoSize = true;
            lblAlias.Location = new Point(12, 15);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(275, 20);
            lblAlias.TabIndex = 0;
            lblAlias.Text = "Alias (leave empty to auto-generate from file name):";
            //
            // aliasTextBox
            //
            aliasTextBox.Location = new Point(12, 38);
            aliasTextBox.Name = "aliasTextBox";
            aliasTextBox.Size = new Size(400, 27);
            aliasTextBox.TabIndex = 1;
            //
            // pnlButtons
            //
            pnlButtons.Controls.Add(cancelButton);
            pnlButtons.Controls.Add(okButton);
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Location = new Point(12, 75);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(400, 35);
            pnlButtons.TabIndex = 2;
            //
            // cancelButton
            //
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(306, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            //
            // okButton
            //
            okButton.Location = new Point(206, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            //
            // IncludeAliasDialog
            //
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(424, 122);
            Controls.Add(pnlButtons);
            Controls.Add(aliasTextBox);
            Controls.Add(lblAlias);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IncludeAliasDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Set Include Alias";
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAlias;
        private TextBox aliasTextBox;
        private FlowLayoutPanel pnlButtons;
        private Button cancelButton;
        private Button okButton;
    }
}
