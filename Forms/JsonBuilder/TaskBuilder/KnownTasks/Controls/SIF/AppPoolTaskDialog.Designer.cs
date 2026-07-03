namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class AppPoolTaskDialog
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
            nameInput = new LabeledTextbox();
            SuspendLayout();
            //
            // nameInput
            //
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(3, 3);
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.PathSelectMode = PathSelectMode.Folder;
            nameInput.ShowPathSelector = false;
            nameInput.Size = new Size(674, 70);
            nameInput.TabIndex = 0;
            nameInput.TextInput = "sc10.local";
            nameInput.TextLabel = "Name *";
            nameInput.Vertical = true;
            //
            // AppPoolTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(nameInput);
            Name = "AppPoolTaskDialog";
            Padding = new Padding(3);
            Size = new Size(680, 434);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox nameInput;
    }
}
