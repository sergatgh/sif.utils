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
            nameInput = new AppPoolListControl();
            SuspendLayout();
            //
            // nameInput
            //
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(3, 3);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(674, 38);
            nameInput.TabIndex = 0;
            nameInput.TextInput = "sc10.local";
            nameInput.TextLabel = "Name *";
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

        public AppPoolListControl nameInput;
    }
}
