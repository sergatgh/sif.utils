namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class AppPoolListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            labelText = new Label();
            appPoolCombo = new ComboBox();
            adminRequiredPanel = new FlowLayoutPanel();
            adminMessageLabel = new Label();
            restartLink = new LinkLabel();
            adminRequiredPanel.SuspendLayout();
            SuspendLayout();
            //
            // labelText
            //
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Top;
            labelText.Location = new Point(0, 0);
            labelText.Margin = new Padding(2, 0, 2, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(46, 15);
            labelText.TabIndex = 0;
            labelText.Text = "Name *";
            //
            // appPoolCombo
            //
            appPoolCombo.Dock = DockStyle.Top;
            appPoolCombo.FormattingEnabled = true;
            appPoolCombo.Location = new Point(0, 15);
            appPoolCombo.Margin = new Padding(2, 2, 2, 2);
            appPoolCombo.Name = "appPoolCombo";
            appPoolCombo.Size = new Size(400, 23);
            appPoolCombo.TabIndex = 1;
            //
            // adminRequiredPanel
            //
            adminRequiredPanel.AutoSize = true;
            adminRequiredPanel.Controls.Add(adminMessageLabel);
            adminRequiredPanel.Controls.Add(restartLink);
            adminRequiredPanel.Dock = DockStyle.Top;
            adminRequiredPanel.FlowDirection = FlowDirection.TopDown;
            adminRequiredPanel.Location = new Point(0, 38);
            adminRequiredPanel.Margin = new Padding(2, 5, 2, 2);
            adminRequiredPanel.Name = "adminRequiredPanel";
            adminRequiredPanel.Size = new Size(400, 46);
            adminRequiredPanel.TabIndex = 2;
            adminRequiredPanel.Visible = false;
            adminRequiredPanel.WrapContents = false;
            //
            // adminMessageLabel
            //
            adminMessageLabel.AutoSize = true;
            adminMessageLabel.Location = new Point(2, 2);
            adminMessageLabel.Margin = new Padding(2, 2, 2, 3);
            adminMessageLabel.Name = "adminMessageLabel";
            adminMessageLabel.Size = new Size(340, 30);
            adminMessageLabel.TabIndex = 0;
            adminMessageLabel.Text = "Restart as administrator to see application pools on this PC.\r\nSave your progress first — restarting will close the app.";
            //
            // restartLink
            //
            restartLink.AutoSize = true;
            restartLink.Location = new Point(2, 37);
            restartLink.Margin = new Padding(2, 0, 2, 0);
            restartLink.Name = "restartLink";
            restartLink.Size = new Size(140, 15);
            restartLink.TabIndex = 1;
            restartLink.TabStop = true;
            restartLink.Text = "Restart as administrator";
            restartLink.LinkClicked += restartLink_LinkClicked;
            //
            // AppPoolListControl
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(adminRequiredPanel);
            Controls.Add(appPoolCombo);
            Controls.Add(labelText);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AppPoolListControl";
            Size = new Size(400, 38);
            adminRequiredPanel.ResumeLayout(false);
            adminRequiredPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private ComboBox appPoolCombo;
        private FlowLayoutPanel adminRequiredPanel;
        private Label adminMessageLabel;
        private LinkLabel restartLink;
    }
}
