namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class WebRequestTask
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            requestTimeout = new NumericUpDown();
            label3 = new Label();
            retryDelay = new NumericUpDown();
            label2 = new Label();
            retryCount = new NumericUpDown();
            label1 = new Label();
            addressTextBox = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestTimeout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)retryDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)retryCount).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(706, 675);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(requestTimeout);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(retryDelay);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(retryCount);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(addressTextBox);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(698, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Request";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // requestTimeout
            // 
            requestTimeout.Dock = DockStyle.Top;
            requestTimeout.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            requestTimeout.Location = new Point(3, 185);
            requestTimeout.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            requestTimeout.Name = "requestTimeout";
            requestTimeout.Size = new Size(692, 30);
            requestTimeout.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 162);
            label3.Name = "label3";
            label3.Size = new Size(284, 23);
            label3.TabIndex = 5;
            label3.Text = "Request Timeout (ms) (0 - is infinity)";
            // 
            // retryDelay
            // 
            retryDelay.Dock = DockStyle.Top;
            retryDelay.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            retryDelay.Location = new Point(3, 132);
            retryDelay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            retryDelay.Name = "retryDelay";
            retryDelay.Size = new Size(692, 30);
            retryDelay.TabIndex = 7;
            retryDelay.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 109);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 4;
            label2.Text = "Retry Delay (ms)";
            // 
            // retryCount
            // 
            retryCount.Dock = DockStyle.Top;
            retryCount.Location = new Point(3, 79);
            retryCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            retryCount.Name = "retryCount";
            retryCount.Size = new Size(692, 30);
            retryCount.TabIndex = 6;
            retryCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 56);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 3;
            label1.Text = "Retry Count";
            // 
            // addressTextBox
            // 
            addressTextBox.Dock = DockStyle.Top;
            addressTextBox.Location = new Point(3, 3);
            addressTextBox.Multiline = false;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.PathSelectionFilter = "";
            addressTextBox.PathSelectMode = PathSelectMode.Folder;
            addressTextBox.ShowPathSelector = false;
            addressTextBox.Size = new Size(692, 53);
            addressTextBox.TabIndex = 0;
            addressTextBox.TextInput = "https://sc1041.sc";
            addressTextBox.TextLabel = "URI *";
            addressTextBox.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 64);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(3, 3);
            taskEditor1.MinimumSize = new Size(50, 50);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(186, 58);
            taskEditor1.TabIndex = 0;
            // 
            // WebRequestTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "WebRequestTask";
            Size = new Size(706, 675);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)requestTimeout).EndInit();
            ((System.ComponentModel.ISupportInitialize)retryDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)retryCount).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown requestTimeout;
        private Label label3;
        private NumericUpDown retryDelay;
        private Label label2;
        private NumericUpDown retryCount;
        private Label label1;
        private LabeledTextbox addressTextBox;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
