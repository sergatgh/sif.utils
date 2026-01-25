namespace SIF.Utils
{
    using SIF.Utils.JsonParser;

    partial class SifJsonParsingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SifJsonParsingResult sifJsonParsingResult1 = new SifJsonParsingResult();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifJsonParsingForm));
            openFileForViewerDialog = new OpenFileDialog();
            MainSelectFilePanel = new Panel();
            label1 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            createPsScriptLabel = new Label();
            viewJsonLabel = new Label();
            welcomeWhatDoWeDo = new Label();
            welcomeLabel = new Label();
            sifJsonParameterModelBindingSource = new BindingSource(components);
            MainJsonBuilder = new SIF.Utils.Forms.JsonBuilder.JsonBuilderForm();
            MainJsonViewer = new SIF.Utils.Forms.JsonViewer.SifJsonViewerForm();
            MainScriptRunnerForm = new SIF.Utils.Forms.ScriptRunner.ScriptRunnerForm();
            MainFileParsingError = new SIF.Utils.Forms.Error.ErrorForm();
            MainChooseExportFormat = new SIF.Utils.Forms.ExportRunner.ExportRunnerForm();
            MainSelectFilePanel.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // openFileForViewerDialog
            // 
            openFileForViewerDialog.AddToRecent = false;
            openFileForViewerDialog.DefaultExt = "json";
            openFileForViewerDialog.Filter = "SIF JSON|*.json";
            openFileForViewerDialog.ReadOnlyChecked = true;
            openFileForViewerDialog.RestoreDirectory = true;
            // 
            // MainSelectFilePanel
            // 
            MainSelectFilePanel.Controls.Add(label1);
            MainSelectFilePanel.Controls.Add(flowLayoutPanel7);
            MainSelectFilePanel.Controls.Add(createPsScriptLabel);
            MainSelectFilePanel.Controls.Add(viewJsonLabel);
            MainSelectFilePanel.Controls.Add(welcomeWhatDoWeDo);
            MainSelectFilePanel.Controls.Add(welcomeLabel);
            MainSelectFilePanel.Dock = DockStyle.Fill;
            MainSelectFilePanel.Location = new Point(0, 0);
            MainSelectFilePanel.Name = "MainSelectFilePanel";
            MainSelectFilePanel.Size = new Size(800, 450);
            MainSelectFilePanel.TabIndex = 1;
            MainSelectFilePanel.Visible = false;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(0, 290);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(800, 75);
            label1.TabIndex = 8;
            label1.Text = "👉 SIF Builder";
            label1.Click += label1_Click;
            label1.MouseLeave += labelButton_MouseLeave;
            label1.MouseHover += labelButton_MouseHover;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(button3);
            flowLayoutPanel7.Controls.Add(button4);
            flowLayoutPanel7.Dock = DockStyle.Bottom;
            flowLayoutPanel7.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel7.Location = new Point(0, 382);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(800, 68);
            flowLayoutPanel7.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(643, 3);
            button3.Name = "button3";
            button3.Size = new Size(154, 57);
            button3.TabIndex = 6;
            button3.Text = "🕵️ Credits";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(459, 3);
            button4.Name = "button4";
            button4.Size = new Size(178, 57);
            button4.TabIndex = 7;
            button4.Text = "📖 Learn SIF";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // createPsScriptLabel
            // 
            createPsScriptLabel.Cursor = Cursors.Hand;
            createPsScriptLabel.Dock = DockStyle.Top;
            createPsScriptLabel.Font = new Font("Segoe UI", 15F);
            createPsScriptLabel.Location = new Point(0, 215);
            createPsScriptLabel.Name = "createPsScriptLabel";
            createPsScriptLabel.Padding = new Padding(20);
            createPsScriptLabel.Size = new Size(800, 75);
            createPsScriptLabel.TabIndex = 5;
            createPsScriptLabel.Text = "👉 Run SIF Script";
            createPsScriptLabel.Click += customFileOpenDialog_Click;
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
            viewJsonLabel.Size = new Size(800, 75);
            viewJsonLabel.TabIndex = 4;
            viewJsonLabel.Text = "👉 View JSON File";
            viewJsonLabel.Click += openFileDialog_Click;
            viewJsonLabel.MouseLeave += labelButton_MouseLeave;
            viewJsonLabel.MouseHover += labelButton_MouseHover;
            // 
            // welcomeWhatDoWeDo
            // 
            welcomeWhatDoWeDo.Dock = DockStyle.Top;
            welcomeWhatDoWeDo.Font = new Font("Segoe UI", 18F);
            welcomeWhatDoWeDo.Location = new Point(0, 94);
            welcomeWhatDoWeDo.Name = "welcomeWhatDoWeDo";
            welcomeWhatDoWeDo.Size = new Size(800, 46);
            welcomeWhatDoWeDo.TabIndex = 1;
            welcomeWhatDoWeDo.Text = "What would you like to do?";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Dock = DockStyle.Top;
            welcomeLabel.Font = new Font("Open Sans", 32F, FontStyle.Bold);
            welcomeLabel.Location = new Point(0, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(800, 94);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to SIF Utils";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sifJsonParameterModelBindingSource
            // 
            sifJsonParameterModelBindingSource.DataSource = typeof(SifJsonParameterModel);
            // 
            // MainJsonBuilder
            // 
            MainJsonBuilder.Dock = DockStyle.Fill;
            MainJsonBuilder.Location = new Point(0, 0);
            MainJsonBuilder.Name = "MainJsonBuilder";
            MainJsonBuilder.Size = new Size(800, 450);
            MainJsonBuilder.TabIndex = 5;
            MainJsonBuilder.BackClicked += back_Click;
            // 
            // MainJsonViewer
            // 
            MainJsonViewer.Dock = DockStyle.Fill;
            MainJsonViewer.Location = new Point(0, 0);
            MainJsonViewer.Name = "MainJsonViewer";
            MainJsonViewer.Size = new Size(800, 450);
            MainJsonViewer.TabIndex = 4;
            MainJsonViewer.OnPlay += MainJsonViewer_OnPlay;
            MainJsonViewer.OnExecuteTasks += executeToolStripMenuItem_Click;
            MainJsonViewer.BackClicked += back_Click;
            // 
            // MainScriptRunnerForm
            // 
            sifJsonParsingResult1.Error = "Empty";
            sifJsonParsingResult1.FilePath = null;
            sifJsonParsingResult1.Folder = null;
            MainScriptRunnerForm.Dock = DockStyle.Fill;
            MainScriptRunnerForm.Location = new Point(0, 0);
            MainScriptRunnerForm.Name = "MainScriptRunnerForm";
            MainScriptRunnerForm.Size = new Size(800, 450);
            MainScriptRunnerForm.TabIndex = 9;
            MainScriptRunnerForm.ExecuteClicked += MainScriptRunnerForm_ExecuteClicked;
            MainScriptRunnerForm.RefreshClicked += MainScriptRunnerForm_RefreshClicked;
            MainScriptRunnerForm.BackClicked += back_Click;
            // 
            // MainFileParsingError
            // 
            MainFileParsingError.Dock = DockStyle.Fill;
            MainFileParsingError.Location = new Point(0, 0);
            MainFileParsingError.Name = "MainFileParsingError";
            MainFileParsingError.Size = new Size(800, 450);
            MainFileParsingError.TabIndex = 5;
            MainFileParsingError.OnBack += back_Click;
            // 
            // MainChooseExportFormat
            // 
            MainChooseExportFormat.Dock = DockStyle.Fill;
            MainChooseExportFormat.Location = new Point(0, 0);
            MainChooseExportFormat.Name = "MainChooseExportFormat";
            MainChooseExportFormat.Size = new Size(800, 450);
            MainChooseExportFormat.TabIndex = 10;
            MainChooseExportFormat.OnHome += MainChooseExportFormat_OnHome;
            MainChooseExportFormat.OnBack += back_Click;
            // 
            // SifJsonParsingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainChooseExportFormat);
            Controls.Add(MainFileParsingError);
            Controls.Add(MainScriptRunnerForm);
            Controls.Add(MainJsonViewer);
            Controls.Add(MainJsonBuilder);
            Controls.Add(MainSelectFilePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "SifJsonParsingForm";
            Text = "SIF Utils";
            Load += SifJsonParsingForm_Load;
            KeyDown += Form1_KeyDown;
            MainSelectFilePanel.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileForViewerDialog;
        internal Panel MainSelectFilePanel;
        private Label welcomeLabel;
        private Label welcomeWhatDoWeDo;
        private Label viewJsonLabel;
        private Label createPsScriptLabel;
        private BindingSource sifJsonParameterModelBindingSource;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button button3;
        private Button button4;
        private Label label1;
        internal Forms.JsonBuilder.JsonBuilderForm MainJsonBuilder;
        internal Forms.JsonViewer.SifJsonViewerForm MainJsonViewer;
        internal Forms.ScriptRunner.ScriptRunnerForm MainScriptRunnerForm;
        public Forms.Error.ErrorForm MainFileParsingError;
        public Forms.ExportRunner.ExportRunnerForm MainChooseExportFormat;
    }
}
