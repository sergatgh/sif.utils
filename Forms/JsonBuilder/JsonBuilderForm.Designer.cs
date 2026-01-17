namespace SIF.Utils.Forms.JsonBuilder
{
    partial class JsonBuilderForm
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
            MainJsonBuilder = new Panel();
            previewButton = new Button();
            saveJsonToFileButton = new Button();
            jsonBuilderPanel = new JsonBuilderPanel();
            navigationPanel = new SIF.Utils.Forms.Common.NavigationPanel();
            saveSifJson = new SaveFileDialog();
            MainJsonBuilder.SuspendLayout();
            SuspendLayout();
            // 
            // MainJsonBuilder
            // 
            MainJsonBuilder.Controls.Add(previewButton);
            MainJsonBuilder.Controls.Add(saveJsonToFileButton);
            MainJsonBuilder.Controls.Add(jsonBuilderPanel);
            MainJsonBuilder.Controls.Add(navigationPanel);
            MainJsonBuilder.Dock = DockStyle.Fill;
            MainJsonBuilder.Location = new Point(0, 0);
            MainJsonBuilder.Name = "MainJsonBuilder";
            MainJsonBuilder.Size = new Size(936, 685);
            MainJsonBuilder.TabIndex = 2;
            // 
            // previewButton
            // 
            previewButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            previewButton.BackColor = Color.Transparent;
            previewButton.Font = new Font("Segoe UI", 22F);
            previewButton.Location = new Point(752, 8);
            previewButton.Margin = new Padding(0);
            previewButton.Name = "previewButton";
            previewButton.Size = new Size(73, 56);
            previewButton.TabIndex = 5;
            previewButton.Text = "📄";
            previewButton.UseVisualStyleBackColor = false;
            previewButton.Click += previewJsonButton_Click;
            // 
            // saveJsonToFileButton
            // 
            saveJsonToFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveJsonToFileButton.BackColor = Color.Transparent;
            saveJsonToFileButton.Font = new Font("Segoe UI", 22F);
            saveJsonToFileButton.Location = new Point(835, 8);
            saveJsonToFileButton.Margin = new Padding(0);
            saveJsonToFileButton.Name = "saveJsonToFileButton";
            saveJsonToFileButton.Size = new Size(73, 56);
            saveJsonToFileButton.TabIndex = 3;
            saveJsonToFileButton.Text = "💾";
            saveJsonToFileButton.UseVisualStyleBackColor = false;
            saveJsonToFileButton.Click += saveJsonButton_Click;
            // 
            // jsonBuilderPanel
            // 
            jsonBuilderPanel.Dock = DockStyle.Fill;
            jsonBuilderPanel.Location = new Point(0, 76);
            jsonBuilderPanel.Name = "jsonBuilderPanel";
            jsonBuilderPanel.Size = new Size(936, 609);
            jsonBuilderPanel.TabIndex = 0;
            // 
            // navigationPanel
            // 
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(936, 76);
            navigationPanel.TabIndex = 2;
            navigationPanel.Title = "JSON Builder";
            // 
            // saveSifJson
            // 
            saveSifJson.AddToRecent = false;
            saveSifJson.DefaultExt = "json";
            saveSifJson.FileName = "my-flow";
            saveSifJson.Filter = "SIF JSON|*.json";
            saveSifJson.RestoreDirectory = true;
            // 
            // JsonBuilderForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainJsonBuilder);
            Name = "JsonBuilderForm";
            Size = new Size(936, 685);
            MainJsonBuilder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal Panel MainJsonBuilder;
        private JsonBuilderPanel jsonBuilderPanel;
        private Common.NavigationPanel navigationPanel;
        internal Button previewButton;
        internal Button saveJsonToFileButton;
        private SaveFileDialog saveSifJson;
    }
}
