namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.Primitive
{
    partial class WriteHostTaskDialog
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
            backgroundColorInput = new ComboBox();
            label2 = new Label();
            colorSelector = new ComboBox();
            label1 = new Label();
            nameInput = new LabeledTextbox();
            SuspendLayout();
            // 
            // backgroundColorInput
            // 
            backgroundColorInput.Dock = DockStyle.Top;
            backgroundColorInput.FormattingEnabled = true;
            backgroundColorInput.Items.AddRange(new object[] { "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White" });
            backgroundColorInput.Location = new Point(0, 131);
            backgroundColorInput.Name = "backgroundColorInput";
            backgroundColorInput.Size = new Size(658, 31);
            backgroundColorInput.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 108);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 14;
            label2.Text = "Background Color:";
            // 
            // colorSelector
            // 
            colorSelector.Dock = DockStyle.Top;
            colorSelector.FormattingEnabled = true;
            colorSelector.Items.AddRange(new object[] { "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White" });
            colorSelector.Location = new Point(0, 77);
            colorSelector.Name = "colorSelector";
            colorSelector.Size = new Size(658, 31);
            colorSelector.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 54);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 12;
            label1.Text = "Text Color:";
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(0, 0);
            nameInput.Margin = new Padding(3, 2, 3, 2);
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.PathSelectionFilter = "";
            nameInput.PathSelectMode = PathSelectMode.Folder;
            nameInput.ShowPathSelector = false;
            nameInput.Size = new Size(658, 54);
            nameInput.TabIndex = 10;
            nameInput.TextInput = "Hello World!";
            nameInput.TextLabel = "Message *";
            nameInput.Vertical = true;
            // 
            // WriteHostTaskDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backgroundColorInput);
            Controls.Add(label2);
            Controls.Add(colorSelector);
            Controls.Add(label1);
            Controls.Add(nameInput);
            Name = "WriteHostTaskDialog";
            Size = new Size(658, 513);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        public ComboBox backgroundColorInput;
        public ComboBox colorSelector;
        public LabeledTextbox nameInput;
    }
}
