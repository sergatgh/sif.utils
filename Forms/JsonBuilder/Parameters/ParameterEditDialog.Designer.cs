namespace SIF.Utils.Forms.JsonBuilder.Parameters
{
    partial class ParameterEditDialog
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

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlName = new Panel();
            lblName = new Label();
            nameTextBox = new TextBox();
            pnlType = new Panel();
            lblType = new Label();
            typeComboBox = new ComboBox();
            pnlDefaultValue = new Panel();
            lblDefaultValue = new Label();
            defaultValueTextBox = new TextBox();
            pnlReference = new Panel();
            lblReference = new Label();
            referenceTextBox = new TextBox();
            pnlValidate = new Panel();
            lblValidate = new Label();
            validateTextBox = new TextBox();
            pnlDescription = new Panel();
            lblDescription = new Label();
            descriptionTextBox = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            okButton = new Button();
            cancelButton = new Button();

            tableLayoutPanel1.SuspendLayout();
            pnlName.SuspendLayout();
            pnlType.SuspendLayout();
            pnlDefaultValue.SuspendLayout();
            pnlReference.SuspendLayout();
            pnlValidate.SuspendLayout();
            pnlDescription.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // tableLayoutPanel1
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlName, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlType, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlDefaultValue, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlReference, 2, 1);
            tableLayoutPanel1.Controls.Add(pnlValidate, 0, 2);
            tableLayoutPanel1.Controls.Add(pnlDescription, 0, 3);
            tableLayoutPanel1.Controls.Add(pnlButtons, 0, 4);
            tableLayoutPanel1.SetColumnSpan(pnlName, 3);
            tableLayoutPanel1.SetColumnSpan(pnlDefaultValue, 2);
            tableLayoutPanel1.SetColumnSpan(pnlReference, 2);
            tableLayoutPanel1.SetColumnSpan(pnlValidate, 4);
            tableLayoutPanel1.SetColumnSpan(pnlDescription, 4);
            tableLayoutPanel1.SetColumnSpan(pnlButtons, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.TabIndex = 0;

            // pnlName
            pnlName.Controls.Add(nameTextBox);
            pnlName.Controls.Add(lblName);
            pnlName.Dock = DockStyle.Fill;
            pnlName.Padding = new Padding(0, 0, 6, 0);
            pnlName.Name = "pnlName";

            // lblName
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Top;
            lblName.Name = "lblName";
            lblName.Text = "Name *";
            lblName.Padding = new Padding(0, 0, 0, 3);

            // nameTextBox
            nameTextBox.Dock = DockStyle.Fill;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.TabIndex = 0;

            // pnlType
            pnlType.Controls.Add(typeComboBox);
            pnlType.Controls.Add(lblType);
            pnlType.Dock = DockStyle.Fill;
            pnlType.Name = "pnlType";

            // lblType
            lblType.AutoSize = true;
            lblType.Dock = DockStyle.Top;
            lblType.Name = "lblType";
            lblType.Text = "Type *";
            lblType.Padding = new Padding(0, 0, 0, 3);

            // typeComboBox
            typeComboBox.Dock = DockStyle.Fill;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            typeComboBox.Name = "typeComboBox";
            typeComboBox.TabIndex = 1;

            // pnlDefaultValue
            pnlDefaultValue.Controls.Add(defaultValueTextBox);
            pnlDefaultValue.Controls.Add(lblDefaultValue);
            pnlDefaultValue.Dock = DockStyle.Fill;
            pnlDefaultValue.Padding = new Padding(0, 0, 6, 0);
            pnlDefaultValue.Name = "pnlDefaultValue";

            // lblDefaultValue
            lblDefaultValue.AutoSize = true;
            lblDefaultValue.Dock = DockStyle.Top;
            lblDefaultValue.Name = "lblDefaultValue";
            lblDefaultValue.Text = "Default value";
            lblDefaultValue.Padding = new Padding(0, 0, 0, 3);

            // defaultValueTextBox
            defaultValueTextBox.Dock = DockStyle.Fill;
            defaultValueTextBox.Name = "defaultValueTextBox";
            defaultValueTextBox.TabIndex = 2;

            // pnlReference
            pnlReference.Controls.Add(referenceTextBox);
            pnlReference.Controls.Add(lblReference);
            pnlReference.Dock = DockStyle.Fill;
            pnlReference.Name = "pnlReference";

            // lblReference
            lblReference.AutoSize = true;
            lblReference.Dock = DockStyle.Top;
            lblReference.Name = "lblReference";
            lblReference.Text = "Reference";
            lblReference.Padding = new Padding(0, 0, 0, 3);

            // referenceTextBox
            referenceTextBox.Dock = DockStyle.Fill;
            referenceTextBox.Name = "referenceTextBox";
            referenceTextBox.TabIndex = 3;

            // pnlValidate
            pnlValidate.Controls.Add(validateTextBox);
            pnlValidate.Controls.Add(lblValidate);
            pnlValidate.Dock = DockStyle.Fill;
            pnlValidate.Name = "pnlValidate";

            // lblValidate
            lblValidate.AutoSize = true;
            lblValidate.Dock = DockStyle.Top;
            lblValidate.Name = "lblValidate";
            lblValidate.Text = "Validate (config function)";
            lblValidate.Padding = new Padding(0, 0, 0, 3);

            // validateTextBox
            validateTextBox.Dock = DockStyle.Fill;
            validateTextBox.Name = "validateTextBox";
            validateTextBox.TabIndex = 4;

            // pnlDescription
            pnlDescription.Controls.Add(descriptionTextBox);
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Dock = DockStyle.Fill;
            pnlDescription.Name = "pnlDescription";

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Top;
            lblDescription.Name = "lblDescription";
            lblDescription.Text = "Description";
            lblDescription.Padding = new Padding(0, 0, 0, 3);

            // descriptionTextBox
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.TabIndex = 5;

            // pnlButtons
            pnlButtons.Controls.Add(cancelButton);
            pnlButtons.Controls.Add(okButton);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.WrapContents = false;
            pnlButtons.Name = "pnlButtons";

            // okButton
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;

            // cancelButton
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;

            // ParameterEditDialog
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AcceptButton = okButton;
            CancelButton = cancelButton;
            ClientSize = new Size(600, 440);
            MinimumSize = new Size(500, 400);
            Controls.Add(tableLayoutPanel1);
            Name = "ParameterEditDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parameter";

            tableLayoutPanel1.ResumeLayout(false);
            pnlName.ResumeLayout(false);
            pnlName.PerformLayout();
            pnlType.ResumeLayout(false);
            pnlType.PerformLayout();
            pnlDefaultValue.ResumeLayout(false);
            pnlDefaultValue.PerformLayout();
            pnlReference.ResumeLayout(false);
            pnlReference.PerformLayout();
            pnlValidate.ResumeLayout(false);
            pnlValidate.PerformLayout();
            pnlDescription.ResumeLayout(false);
            pnlDescription.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlName, pnlType, pnlDefaultValue, pnlReference, pnlValidate, pnlDescription;
        private Label lblName, lblType, lblDefaultValue, lblReference, lblValidate, lblDescription;
        private TextBox nameTextBox, defaultValueTextBox, referenceTextBox, validateTextBox, descriptionTextBox;
        private ComboBox typeComboBox;
        private FlowLayoutPanel pnlButtons;
        private Button okButton, cancelButton;
    }
}
