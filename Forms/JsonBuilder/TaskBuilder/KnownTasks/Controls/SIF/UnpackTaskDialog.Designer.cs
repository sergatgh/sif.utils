namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class UnpackTaskDialog
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
            destinationInput = new LabeledTextbox();
            sourceInput = new LabeledTextbox();
            SuspendLayout();
            //
            // destinationInput
            //
            destinationInput.Dock = DockStyle.Top;
            destinationInput.Location = new Point(3, 59);
            destinationInput.Multiline = false;
            destinationInput.Name = "destinationInput";
            destinationInput.PathSelectionFilter = "";
            destinationInput.PathSelectMode = PathSelectMode.Folder;
            destinationInput.ShowPathSelector = false;
            destinationInput.Size = new Size(720, 57);
            destinationInput.TabIndex = 7;
            destinationInput.TextInput = "C:\\dist\\";
            destinationInput.TextLabel = "Destination *";
            destinationInput.Vertical = true;
            //
            // sourceInput
            //
            sourceInput.Dock = DockStyle.Top;
            sourceInput.Location = new Point(3, 3);
            sourceInput.Multiline = false;
            sourceInput.Name = "sourceInput";
            sourceInput.PathSelectionFilter = "";
            sourceInput.PathSelectMode = PathSelectMode.Folder;
            sourceInput.ShowPathSelector = false;
            sourceInput.Size = new Size(720, 56);
            sourceInput.TabIndex = 0;
            sourceInput.TextInput = "C:\\source.zip";
            sourceInput.TextLabel = "Source *";
            sourceInput.Vertical = true;
            //
            // UnpackTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(destinationInput);
            Controls.Add(sourceInput);
            Name = "UnpackTaskDialog";
            Padding = new Padding(3);
            Size = new Size(726, 661);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox destinationInput;
        public LabeledTextbox sourceInput;
    }
}
