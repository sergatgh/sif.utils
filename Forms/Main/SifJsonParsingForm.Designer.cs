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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifJsonParsingForm));
            sifJsonParameterModelBindingSource = new BindingSource(components);
            MainJsonBuilder = new SIF.Utils.Forms.JsonBuilder.JsonBuilderForm();
            MainJsonViewer = new SIF.Utils.Forms.JsonViewer.SifJsonViewerForm();
            MainScriptRunnerForm = new SIF.Utils.Forms.ScriptRunner.ScriptRunnerForm();
            MainFileParsingError = new SIF.Utils.Forms.Error.ErrorForm();
            MainChooseExportFormat = new SIF.Utils.Forms.ExportRunner.ExportRunnerForm();
            MainSelectFilePanel = new SIF.Utils.Forms.Home.HomeComponents();
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).BeginInit();
            SuspendLayout();
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
            // MainSelectFilePanel
            // 
            MainSelectFilePanel.Dock = DockStyle.Fill;
            MainSelectFilePanel.Location = new Point(0, 0);
            MainSelectFilePanel.Name = "MainSelectFilePanel";
            MainSelectFilePanel.Size = new Size(800, 450);
            MainSelectFilePanel.TabIndex = 9;
            MainSelectFilePanel.OpenViewFileDialog += MainSelectFilePanel_OpenViewFileDialog;
            MainSelectFilePanel.OpenExecuteFileDialog += MainSelectFilePanel_OpenExecuteFileDialog;
            MainSelectFilePanel.OpenJsonBuilder += MainSelectFilePanel_OpenJsonBuilder;
            // 
            // SifJsonParsingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainSelectFilePanel);
            Controls.Add(MainChooseExportFormat);
            Controls.Add(MainFileParsingError);
            Controls.Add(MainScriptRunnerForm);
            Controls.Add(MainJsonViewer);
            Controls.Add(MainJsonBuilder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "SifJsonParsingForm";
            Text = "SIF Utils";
            Load += SifJsonParsingForm_Load;
            ((System.ComponentModel.ISupportInitialize)sifJsonParameterModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource sifJsonParameterModelBindingSource;
        internal Forms.JsonBuilder.JsonBuilderForm MainJsonBuilder;
        internal Forms.JsonViewer.SifJsonViewerForm MainJsonViewer;
        internal Forms.ScriptRunner.ScriptRunnerForm MainScriptRunnerForm;
        public Forms.Error.ErrorForm MainFileParsingError;
        public Forms.ExportRunner.ExportRunnerForm MainChooseExportFormat;
        internal Forms.Home.HomeComponents MainSelectFilePanel;
    }
}
