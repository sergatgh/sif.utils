namespace SIF.Utils.Forms.JsonBuilder.SectionOrder
{
    partial class SectionOrderPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            moveUpButton = new Button();
            moveDownButton = new Button();
            resetButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            //
            // listBox1
            //
            listBox1.AllowDrop = true;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(0, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(694, 373);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDown += listBox1_MouseDown;
            listBox1.MouseMove += listBox1_MouseMove;
            listBox1.MouseUp += listBox1_MouseUp;
            listBox1.DragEnter += listBox1_DragEnter;
            listBox1.DragDrop += listBox1_DragDrop;
            //
            // flowLayoutPanel1
            //
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(moveUpButton);
            flowLayoutPanel1.Controls.Add(moveDownButton);
            flowLayoutPanel1.Controls.Add(resetButton);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(694, 35);
            flowLayoutPanel1.TabIndex = 1;
            //
            // moveUpButton
            //
            moveUpButton.Enabled = false;
            moveUpButton.Location = new Point(3, 3);
            moveUpButton.Name = "moveUpButton";
            moveUpButton.Size = new Size(120, 29);
            moveUpButton.TabIndex = 0;
            moveUpButton.Text = "Move Up";
            moveUpButton.UseVisualStyleBackColor = true;
            moveUpButton.Click += moveUpButton_Click;
            //
            // moveDownButton
            //
            moveDownButton.Enabled = false;
            moveDownButton.Location = new Point(129, 3);
            moveDownButton.Name = "moveDownButton";
            moveDownButton.Size = new Size(120, 29);
            moveDownButton.TabIndex = 1;
            moveDownButton.Text = "Move Down";
            moveDownButton.UseVisualStyleBackColor = true;
            moveDownButton.Click += moveDownButton_Click;
            //
            // resetButton
            //
            resetButton.Location = new Point(255, 3);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(150, 29);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset to Default";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            //
            // SectionOrderPanel
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "SectionOrderPanel";
            Size = new Size(694, 408);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button moveUpButton;
        private Button moveDownButton;
        private Button resetButton;
    }
}
