namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class WriteHostTask
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
            backgroundColorInput = new ComboBox();
            label2 = new Label();
            colorSelector = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            nameInput = new LabeledTextbox();
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
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(511, 329);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(backgroundColorInput);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(colorSelector);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(nameInput);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(503, 301);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Write";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // backgroundColorInput
            // 
            backgroundColorInput.Dock = DockStyle.Top;
            backgroundColorInput.FormattingEnabled = true;
            backgroundColorInput.Items.AddRange(new object[] { "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White" });
            backgroundColorInput.Location = new Point(2, 90);
            backgroundColorInput.Margin = new Padding(2, 2, 2, 2);
            backgroundColorInput.Name = "backgroundColorInput";
            backgroundColorInput.Size = new Size(499, 23);
            backgroundColorInput.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(2, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 9;
            label2.Text = "Background Color:";
            // 
            // colorSelector
            // 
            colorSelector.Dock = DockStyle.Top;
            colorSelector.FormattingEnabled = true;
            colorSelector.Items.AddRange(new object[] { "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White" });
            colorSelector.Location = new Point(2, 52);
            colorSelector.Margin = new Padding(2, 2, 2, 2);
            colorSelector.Name = "colorSelector";
            colorSelector.Size = new Size(499, 23);
            colorSelector.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Text Color:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(791, 65);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(26, 19);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(2, 2);
            nameInput.Margin = new Padding(2, 1, 2, 1);
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.PathSelectionFilter = "";
            nameInput.PathSelectMode = PathSelectMode.Folder;
            nameInput.ShowPathSelector = false;
            nameInput.Size = new Size(499, 35);
            nameInput.TabIndex = 0;
            nameInput.TextInput = "Hello World!";
            nameInput.TextLabel = "Message *";
            nameInput.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(503, 301);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(2, 2);
            taskEditor1.Margin = new Padding(2, 1, 2, 1);
            taskEditor1.MinimumSize = new Size(39, 33);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(499, 297);
            taskEditor1.TabIndex = 0;
            // 
            // WriteHostTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WriteHostTask";
            Size = new Size(511, 329);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private LabeledTextbox nameInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private ComboBox colorSelector;
        private Label label1;
        private ComboBox backgroundColorInput;
        private Label label2;
    }
}
