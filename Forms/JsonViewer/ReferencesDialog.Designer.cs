namespace SIF.Utils.Forms.JsonViewer
{
    partial class ReferencesDialog
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
            referencesList = new ListView();
            kindColumn = new ColumnHeader();
            nameColumn = new ColumnHeader();
            bottomPanel = new Panel();
            closeButton = new Button();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            //
            // referencesList
            //
            referencesList.Columns.AddRange(new ColumnHeader[] { kindColumn, nameColumn });
            referencesList.Dock = DockStyle.Fill;
            referencesList.FullRowSelect = true;
            referencesList.GridLines = true;
            referencesList.Location = new Point(0, 0);
            referencesList.MultiSelect = false;
            referencesList.Name = "referencesList";
            referencesList.Size = new Size(500, 300);
            referencesList.TabIndex = 0;
            referencesList.UseCompatibleStateImageBehavior = false;
            referencesList.View = View.Details;
            referencesList.DoubleClick += referencesList_DoubleClick;
            referencesList.KeyDown += referencesList_KeyDown;
            //
            // kindColumn
            //
            kindColumn.Text = "Kind";
            kindColumn.Width = 100;
            //
            // nameColumn
            //
            nameColumn.Text = "Name";
            nameColumn.Width = 380;
            //
            // bottomPanel
            //
            bottomPanel.Controls.Add(closeButton);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 300);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(500, 44);
            bottomPanel.TabIndex = 1;
            //
            // closeButton
            //
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.Location = new Point(413, 9);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 27);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            //
            // ReferencesDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 344);
            Controls.Add(referencesList);
            Controls.Add(bottomPanel);
            MinimumSize = new Size(400, 250);
            Name = "ReferencesDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "References";
            bottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ListView referencesList;
        private ColumnHeader kindColumn;
        private ColumnHeader nameColumn;
        private Panel bottomPanel;
        private Button closeButton;
    }
}
