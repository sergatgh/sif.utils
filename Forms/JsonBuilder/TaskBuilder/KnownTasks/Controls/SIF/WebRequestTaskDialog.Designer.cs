namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class WebRequestTaskDialog
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
            requestTimeout = new NumericUpDown();
            label3 = new Label();
            retryDelay = new NumericUpDown();
            label2 = new Label();
            retryCount = new NumericUpDown();
            label1 = new Label();
            addressTextBox = new LabeledTextbox();
            ((System.ComponentModel.ISupportInitialize)requestTimeout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)retryDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)retryCount).BeginInit();
            SuspendLayout();
            //
            // requestTimeout
            //
            requestTimeout.Dock = DockStyle.Top;
            requestTimeout.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            requestTimeout.Location = new Point(2, 128);
            requestTimeout.Margin = new Padding(2, 2, 2, 2);
            requestTimeout.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            requestTimeout.Name = "requestTimeout";
            requestTimeout.Size = new Size(537, 23);
            requestTimeout.TabIndex = 8;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(2, 113);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 15);
            label3.TabIndex = 5;
            label3.Text = "Request Timeout (ms) (0 - is infinity)";
            //
            // retryDelay
            //
            retryDelay.Dock = DockStyle.Top;
            retryDelay.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            retryDelay.Location = new Point(2, 90);
            retryDelay.Margin = new Padding(2, 2, 2, 2);
            retryDelay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            retryDelay.Name = "retryDelay";
            retryDelay.Size = new Size(537, 23);
            retryDelay.TabIndex = 7;
            retryDelay.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(2, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Retry Delay (ms)";
            //
            // retryCount
            //
            retryCount.Dock = DockStyle.Top;
            retryCount.Location = new Point(2, 52);
            retryCount.Margin = new Padding(2, 2, 2, 2);
            retryCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            retryCount.Name = "retryCount";
            retryCount.Size = new Size(537, 23);
            retryCount.TabIndex = 6;
            retryCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Retry Count";
            //
            // addressTextBox
            //
            addressTextBox.Dock = DockStyle.Top;
            addressTextBox.Location = new Point(2, 2);
            addressTextBox.Margin = new Padding(2, 1, 2, 1);
            addressTextBox.Multiline = false;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.PathSelectionFilter = "";
            addressTextBox.PathSelectMode = PathSelectMode.Folder;
            addressTextBox.ShowPathSelector = false;
            addressTextBox.Size = new Size(537, 35);
            addressTextBox.TabIndex = 0;
            addressTextBox.TextInput = "https://sc1041.sc";
            addressTextBox.TextLabel = "URI *";
            addressTextBox.Vertical = true;
            //
            // WebRequestTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(requestTimeout);
            Controls.Add(label3);
            Controls.Add(retryDelay);
            Controls.Add(label2);
            Controls.Add(retryCount);
            Controls.Add(label1);
            Controls.Add(addressTextBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WebRequestTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(541, 412);
            ((System.ComponentModel.ISupportInitialize)requestTimeout).EndInit();
            ((System.ComponentModel.ISupportInitialize)retryDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)retryCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public NumericUpDown requestTimeout;
        private Label label3;
        public NumericUpDown retryDelay;
        private Label label2;
        public NumericUpDown retryCount;
        private Label label1;
        public LabeledTextbox addressTextBox;
    }
}
