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
            lblPath = new Label();
            pathTextBox = new TextBox();
            browseButton = new Button();
            lblAlias = new Label();
            aliasTextBox = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            cancelButton = new Button();
            okButton = new Button();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            //
            // lblPath
            //
            lblPath.AutoSize = true;
            lblPath.Location = new Point(12, 15);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(85, 20);
            lblPath.TabIndex = 0;
            lblPath.Text = "Include file:";
            //
            // pathTextBox
            //
            pathTextBox.Location = new Point(12, 38);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(306, 27);
            pathTextBox.TabIndex = 1;
            //
            // browseButton
            //
            browseButton.Location = new Point(324, 37);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(88, 29);
            browseButton.TabIndex = 2;
            browseButton.Text = "Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            //
            // lblAlias
            //
            lblAlias.AutoSize = true;
            lblAlias.Location = new Point(12, 78);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(275, 20);
            lblAlias.TabIndex = 3;
            lblAlias.Text = "Alias (leave empty to auto-generate from file name):";
            //
            // aliasTextBox
            //
            aliasTextBox.Location = new Point(12, 101);
            aliasTextBox.Name = "aliasTextBox";
            aliasTextBox.Size = new Size(400, 27);
            aliasTextBox.TabIndex = 4;
            //
            // pnlButtons
            //
            pnlButtons.Controls.Add(cancelButton);
            pnlButtons.Controls.Add(okButton);
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Location = new Point(12, 138);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(400, 35);
            pnlButtons.TabIndex = 5;
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
            ClientSize = new Size(424, 185);
            Controls.Add(pnlButtons);
            Controls.Add(aliasTextBox);
            Controls.Add(lblAlias);
            Controls.Add(browseButton);
            Controls.Add(pathTextBox);
            Controls.Add(lblPath);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IncludeAliasDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Include";
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPath;
        private TextBox pathTextBox;
        private Button browseButton;
        private Label lblAlias;
        private TextBox aliasTextBox;
        private FlowLayoutPanel pnlButtons;
        private Button cancelButton;
        private Button okButton;
    }
}
