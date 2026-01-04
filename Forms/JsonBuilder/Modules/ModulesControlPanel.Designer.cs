namespace SIF.Utils.Forms.JsonBuilder.Modules
{
    partial class ModulesControlPanel
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
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            addKnownModule = new Button();
            button2 = new Button();
            moduleSelector = new OpenFileDialog();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(694, 373);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(addKnownModule);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(694, 35);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 1;
            button1.Text = "Add psm1 module";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addKnownModule
            // 
            addKnownModule.Location = new Point(196, 3);
            addKnownModule.Name = "addKnownModule";
            addKnownModule.Size = new Size(187, 29);
            addKnownModule.TabIndex = 3;
            addKnownModule.Text = "Add known module";
            addKnownModule.UseVisualStyleBackColor = true;
            addKnownModule.Click += addKnownModule_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(389, 3);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 2;
            button2.Text = "Remove module";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // moduleSelector
            // 
            moduleSelector.Filter = "*.psm1|SIF Module";
            moduleSelector.Title = "Select SIF psm1 Module";
            // 
            // ModulesControlPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "ModulesControlPanel";
            Size = new Size(694, 408);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private OpenFileDialog moduleSelector;
        private Button addKnownModule;
    }
}
