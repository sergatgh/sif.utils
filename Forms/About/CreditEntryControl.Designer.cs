namespace SIF.Utils.Forms.About
{
    partial class CreditEntryControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            flowLinks = new FlowLayoutPanel();
            SuspendLayout();
            //
            // lblName
            //
            lblName.AutoSize = false;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(31, 31, 31);
            lblName.Location = new Point(16, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(416, 34);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            //
            // flowLinks
            //
            flowLinks.AutoSize = true;
            flowLinks.Location = new Point(14, 50);
            flowLinks.Margin = new Padding(0);
            flowLinks.Name = "flowLinks";
            flowLinks.Padding = new Padding(0);
            flowLinks.Size = new Size(418, 32);
            flowLinks.TabIndex = 1;
            flowLinks.WrapContents = true;
            //
            // CreditEntryControl
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLinks);
            Controls.Add(lblName);
            Name = "CreditEntryControl";
            Size = new Size(448, 94);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private FlowLayoutPanel flowLinks;
    }
}
