namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class UnpackTask
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
            destinationInput = new LabeledTextbox();
            button1 = new Button();
            sourceInput = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabControl1.Size = new Size(734, 697);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(destinationInput);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(sourceInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(726, 661);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Unpack";
            tabPage1.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(3116, 112);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
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
            // UnpackTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UnpackTask";
            Size = new Size(734, 697);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox destinationInput;
        private Button button1;
        private LabeledTextbox sourceInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
