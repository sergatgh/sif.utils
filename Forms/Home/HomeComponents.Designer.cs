namespace SIF.Utils.Forms.Home
{
    partial class HomeComponents
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
            MainSelectFilePanel = new Panel();
            sifBuilderFlow = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            creditsButton = new Button();
            learnSifButton = new Button();
            createPsScriptLabel = new Label();
            viewJsonLabel = new Label();
            welcomeWhatDoWeDo = new Label();
            welcomeLabel = new Label();
            openFileForViewerDialog = new OpenFileDialog();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // MainSelectFilePanel
            // 
            MainSelectFilePanel.Dock = DockStyle.Fill;
            MainSelectFilePanel.Location = new Point(0, 0);
            MainSelectFilePanel.Name = "MainSelectFilePanel";
            MainSelectFilePanel.Size = new Size(1130, 770);
            MainSelectFilePanel.TabIndex = 2;
            MainSelectFilePanel.Visible = false;
            // 
            // sifBuilderFlow
            // 
            sifBuilderFlow.Cursor = Cursors.Hand;
            sifBuilderFlow.Dock = DockStyle.Top;
            sifBuilderFlow.Font = new Font("Segoe UI", 15F);
            sifBuilderFlow.Location = new Point(0, 290);
            sifBuilderFlow.Name = "sifBuilderFlow";
            sifBuilderFlow.Padding = new Padding(20);
            sifBuilderFlow.Size = new Size(1130, 75);
            sifBuilderFlow.TabIndex = 8;
            sifBuilderFlow.Text = "👉 SIF Builder";
            sifBuilderFlow.Click += sifBuilderFlow_Click;
            sifBuilderFlow.MouseLeave += labelButton_MouseLeave;
            sifBuilderFlow.MouseHover += labelButton_MouseHover;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(creditsButton);
            flowLayoutPanel7.Controls.Add(learnSifButton);
            flowLayoutPanel7.Dock = DockStyle.Bottom;
            flowLayoutPanel7.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel7.Location = new Point(0, 702);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(1130, 68);
            flowLayoutPanel7.TabIndex = 7;
            // 
            // creditsButton
            // 
            creditsButton.Font = new Font("Segoe UI", 14F);
            creditsButton.Location = new Point(973, 3);
            creditsButton.Name = "creditsButton";
            creditsButton.Size = new Size(154, 57);
            creditsButton.TabIndex = 6;
            creditsButton.Text = "🕵️ Credits";
            creditsButton.UseVisualStyleBackColor = true;
            creditsButton.Click += aboutWindowButton_Click;
            // 
            // learnSifButton
            // 
            learnSifButton.Font = new Font("Segoe UI", 14F);
            learnSifButton.Location = new Point(789, 3);
            learnSifButton.Name = "learnSifButton";
            learnSifButton.Size = new Size(178, 57);
            learnSifButton.TabIndex = 7;
            learnSifButton.Text = "📖 Learn SIF";
            learnSifButton.UseVisualStyleBackColor = true;
            learnSifButton.Click += learnSifButton_Click;
            // 
            // createPsScriptLabel
            // 
            createPsScriptLabel.Cursor = Cursors.Hand;
            createPsScriptLabel.Dock = DockStyle.Top;
            createPsScriptLabel.Font = new Font("Segoe UI", 15F);
            createPsScriptLabel.Location = new Point(0, 215);
            createPsScriptLabel.Name = "createPsScriptLabel";
            createPsScriptLabel.Padding = new Padding(20);
            createPsScriptLabel.Size = new Size(1130, 75);
            createPsScriptLabel.TabIndex = 5;
            createPsScriptLabel.Text = "👉 Run SIF Script";
            createPsScriptLabel.Click += executeFileDialog_Click;
            createPsScriptLabel.MouseLeave += labelButton_MouseLeave;
            createPsScriptLabel.MouseHover += labelButton_MouseHover;
            // 
            // viewJsonLabel
            // 
            viewJsonLabel.Cursor = Cursors.Hand;
            viewJsonLabel.Dock = DockStyle.Top;
            viewJsonLabel.Font = new Font("Segoe UI", 15F);
            viewJsonLabel.Location = new Point(0, 140);
            viewJsonLabel.Name = "viewJsonLabel";
            viewJsonLabel.Padding = new Padding(20);
            viewJsonLabel.Size = new Size(1130, 75);
            viewJsonLabel.TabIndex = 4;
            viewJsonLabel.Text = "👉 View JSON File";
            viewJsonLabel.Click += openForViewFileDialog_Click;
            viewJsonLabel.MouseLeave += labelButton_MouseLeave;
            viewJsonLabel.MouseHover += labelButton_MouseHover;
            // 
            // welcomeWhatDoWeDo
            // 
            welcomeWhatDoWeDo.Dock = DockStyle.Top;
            welcomeWhatDoWeDo.Font = new Font("Segoe UI", 18F);
            welcomeWhatDoWeDo.Location = new Point(0, 94);
            welcomeWhatDoWeDo.Name = "welcomeWhatDoWeDo";
            welcomeWhatDoWeDo.Size = new Size(1130, 46);
            welcomeWhatDoWeDo.TabIndex = 1;
            welcomeWhatDoWeDo.Text = "What would you like to do?";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Dock = DockStyle.Top;
            welcomeLabel.Font = new Font("Open Sans", 32F, FontStyle.Bold);
            welcomeLabel.Location = new Point(0, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(1130, 94);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to SIF Utils";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileForViewerDialog
            // 
            openFileForViewerDialog.AddToRecent = false;
            openFileForViewerDialog.DefaultExt = "json";
            openFileForViewerDialog.Filter = "SIF JSON|*.json";
            openFileForViewerDialog.ReadOnlyChecked = true;
            openFileForViewerDialog.RestoreDirectory = true;
            // 
            // HomeComponents
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sifBuilderFlow);
            Controls.Add(createPsScriptLabel);
            Controls.Add(viewJsonLabel);
            Controls.Add(welcomeWhatDoWeDo);
            Controls.Add(welcomeLabel);
            Controls.Add(flowLayoutPanel7);
            Controls.Add(MainSelectFilePanel);
            Name = "HomeComponents";
            Size = new Size(1130, 770);
            flowLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal Panel MainSelectFilePanel;
        private Label sifBuilderFlow;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button creditsButton;
        private Button learnSifButton;
        private Label createPsScriptLabel;
        private Label viewJsonLabel;
        private Label welcomeWhatDoWeDo;
        private Label welcomeLabel;
        private OpenFileDialog openFileForViewerDialog;
    }
}
