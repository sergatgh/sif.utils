namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class ManageSolrSchemaTaskDialog
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
            argumentsFileTextBox = new LabeledTextbox();
            coreTextBox = new LabeledTextbox();
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
            requestTimeout.Location = new Point(2, 198);
            requestTimeout.Margin = new Padding(2, 2, 2, 2);
            requestTimeout.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            requestTimeout.Name = "requestTimeout";
            requestTimeout.Size = new Size(556, 23);
            requestTimeout.TabIndex = 8;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(2, 183);
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
            retryDelay.Location = new Point(2, 160);
            retryDelay.Margin = new Padding(2, 2, 2, 2);
            retryDelay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            retryDelay.Name = "retryDelay";
            retryDelay.Size = new Size(556, 23);
            retryDelay.TabIndex = 7;
            retryDelay.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(2, 145);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Retry Delay (ms)";
            //
            // retryCount
            //
            retryCount.Dock = DockStyle.Top;
            retryCount.Location = new Point(2, 122);
            retryCount.Margin = new Padding(2, 2, 2, 2);
            retryCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            retryCount.Name = "retryCount";
            retryCount.Size = new Size(556, 23);
            retryCount.TabIndex = 6;
            retryCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 107);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Retry Count";
            //
            // argumentsFileTextBox
            //
            argumentsFileTextBox.Dock = DockStyle.Top;
            argumentsFileTextBox.Location = new Point(2, 72);
            argumentsFileTextBox.Margin = new Padding(2, 1, 2, 1);
            argumentsFileTextBox.Multiline = false;
            argumentsFileTextBox.Name = "argumentsFileTextBox";
            argumentsFileTextBox.PathSelectionFilter = "JSON Schema|*.json";
            argumentsFileTextBox.PathSelectMode = PathSelectMode.File;
            argumentsFileTextBox.ShowPathSelector = true;
            argumentsFileTextBox.Size = new Size(556, 35);
            argumentsFileTextBox.TabIndex = 2;
            argumentsFileTextBox.TextInput = "C:\\schema.json";
            argumentsFileTextBox.TextLabel = "Arguments File *";
            argumentsFileTextBox.Vertical = true;
            //
            // coreTextBox
            //
            coreTextBox.Dock = DockStyle.Top;
            coreTextBox.Location = new Point(2, 37);
            coreTextBox.Margin = new Padding(2, 1, 2, 1);
            coreTextBox.Multiline = false;
            coreTextBox.Name = "coreTextBox";
            coreTextBox.PathSelectionFilter = "";
            coreTextBox.PathSelectMode = PathSelectMode.Folder;
            coreTextBox.ShowPathSelector = false;
            coreTextBox.Size = new Size(556, 35);
            coreTextBox.TabIndex = 1;
            coreTextBox.TextInput = "sitecore_master_index";
            coreTextBox.TextLabel = "Core *";
            coreTextBox.Vertical = true;
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
            addressTextBox.Size = new Size(556, 35);
            addressTextBox.TabIndex = 0;
            addressTextBox.TextInput = "https://localhost:8983/solr";
            addressTextBox.TextLabel = "Address *";
            addressTextBox.Vertical = true;
            //
            // ManageSolrSchemaTaskDialog
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
            Controls.Add(argumentsFileTextBox);
            Controls.Add(coreTextBox);
            Controls.Add(addressTextBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ManageSolrSchemaTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(560, 428);
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
        public LabeledTextbox argumentsFileTextBox;
        public LabeledTextbox coreTextBox;
        public LabeledTextbox addressTextBox;
    }
}
