namespace SIF.Utils.Forms.Error
{
    partial class ErrorForm
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
            navigationPanel1 = new SIF.Utils.Forms.Common.NavigationPanel();
            documentText = new TextBox();
            errorDescription = new Label();
            SuspendLayout();
            // 
            // navigationPanel1
            // 
            navigationPanel1.Dock = DockStyle.Top;
            navigationPanel1.Location = new Point(0, 0);
            navigationPanel1.Name = "navigationPanel1";
            navigationPanel1.Size = new Size(828, 79);
            navigationPanel1.TabIndex = 0;
            navigationPanel1.Title = "Error";
            // 
            // documentText
            // 
            documentText.Dock = DockStyle.Fill;
            documentText.Location = new Point(0, 182);
            documentText.Multiline = true;
            documentText.Name = "documentText";
            documentText.ReadOnly = true;
            documentText.ScrollBars = ScrollBars.Vertical;
            documentText.Size = new Size(828, 442);
            documentText.TabIndex = 6;
            // 
            // errorDescription
            // 
            errorDescription.AutoEllipsis = true;
            errorDescription.Dock = DockStyle.Top;
            errorDescription.Font = new Font("Segoe UI", 18F);
            errorDescription.Location = new Point(0, 79);
            errorDescription.Name = "errorDescription";
            errorDescription.Size = new Size(828, 103);
            errorDescription.TabIndex = 5;
            errorDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla accumsan nisl et sem pretium, nec ex.";
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(documentText);
            Controls.Add(errorDescription);
            Controls.Add(navigationPanel1);
            Name = "ErrorForm";
            Size = new Size(828, 624);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.NavigationPanel navigationPanel1;
        internal TextBox documentText;
        internal Label errorDescription;
    }
}
