namespace SIF.Utils.Forms.Common.ConfigFunctionBuilder
{
    partial class ConfigFunctionArgumentEditor
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
        /// <remarks>
        /// Only the outer shell is designer-managed here: which sub-editor is shown (literal /
        /// boolean / variable / parameter / function-call / raw) depends on runtime state, so those
        /// panels and their controls are built procedurally in ConfigFunctionArgumentEditor.cs
        /// (see BuildLayout) rather than declared here.
        /// </remarks>
        private void InitializeComponent()
        {
            kindComboBox = new ComboBox();
            kindLabel = new Label();
            valueContainerPanel = new Panel();
            SuspendLayout();
            //
            // valueContainerPanel
            //
            valueContainerPanel.Dock = DockStyle.Fill;
            valueContainerPanel.Location = new Point(0, 46);
            valueContainerPanel.Name = "valueContainerPanel";
            valueContainerPanel.Size = new Size(420, 254);
            valueContainerPanel.TabIndex = 2;
            //
            // kindComboBox
            //
            kindComboBox.Dock = DockStyle.Top;
            kindComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kindComboBox.Location = new Point(0, 23);
            kindComboBox.Name = "kindComboBox";
            kindComboBox.Size = new Size(420, 23);
            kindComboBox.TabIndex = 1;
            //
            // kindLabel
            //
            kindLabel.AutoSize = true;
            kindLabel.Dock = DockStyle.Top;
            kindLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            kindLabel.Location = new Point(0, 0);
            kindLabel.Name = "kindLabel";
            kindLabel.Padding = new Padding(0, 8, 0, 8);
            kindLabel.Size = new Size(420, 34);
            kindLabel.TabIndex = 0;
            kindLabel.Text = "Value kind";
            //
            // ConfigFunctionArgumentEditor
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(valueContainerPanel);
            Controls.Add(kindComboBox);
            Controls.Add(kindLabel);
            Name = "ConfigFunctionArgumentEditor";
            Size = new Size(420, 300);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox kindComboBox;
        private Label kindLabel;
        private Panel valueContainerPanel;
    }
}
