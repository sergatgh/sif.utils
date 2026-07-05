namespace SIF.Utils.Forms.Common.ConfigFunctionBuilder
{
    partial class ConfigFunctionBuilderDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            configFunctionTree = new TreeView();
            editorHostPanel = new Panel();
            buttonsPanel = new FlowLayoutPanel();
            cancelButton = new Button();
            okButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            //
            // splitContainer1
            //
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Panel1.Controls.Add(configFunctionTree);
            splitContainer1.Panel2.Controls.Add(editorHostPanel);
            splitContainer1.Size = new Size(760, 460);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 0;
            //
            // configFunctionTree
            //
            configFunctionTree.Dock = DockStyle.Fill;
            configFunctionTree.HideSelection = false;
            configFunctionTree.Location = new Point(0, 0);
            configFunctionTree.Name = "configFunctionTree";
            configFunctionTree.Size = new Size(260, 460);
            configFunctionTree.TabIndex = 0;
            //
            // editorHostPanel
            //
            editorHostPanel.Dock = DockStyle.Fill;
            editorHostPanel.Location = new Point(0, 0);
            editorHostPanel.Name = "editorHostPanel";
            editorHostPanel.Padding = new Padding(8);
            editorHostPanel.Size = new Size(496, 460);
            editorHostPanel.TabIndex = 0;
            //
            // buttonsPanel
            //
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(okButton);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonsPanel.Location = new Point(0, 460);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Padding = new Padding(8);
            buttonsPanel.Size = new Size(760, 45);
            buttonsPanel.TabIndex = 1;
            //
            // cancelButton
            //
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(663, 8);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            //
            // okButton
            //
            okButton.Location = new Point(563, 8);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            //
            // ConfigFunctionBuilderDialog
            //
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(760, 505);
            Controls.Add(splitContainer1);
            Controls.Add(buttonsPanel);
            MinimumSize = new Size(640, 420);
            Name = "ConfigFunctionBuilderDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Build Expression";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView configFunctionTree;
        private Panel editorHostPanel;
        private FlowLayoutPanel buttonsPanel;
        private Button cancelButton;
        private Button okButton;
    }
}
