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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlName = new Panel();
            nameTextBox = new TextBox();
            lblName = new Label();
            pnlType = new Panel();
            typeComboBox = new ComboBox();
            lblType = new Label();
            pnlDefaultValue = new Panel();
            defaultValueTextBox = new TextBox();
            hasDefaultValueCheckBox = new CheckBox();
            pnlReference = new Panel();
            referenceTextBox = new TextBox();
            lblReference = new Label();
            pnlValidate = new Panel();
            validateTextBox = new TextBox();
            lblValidate = new Label();
            pnlDescription = new Panel();
            descriptionTextBox = new TextBox();
            lblDescription = new Label();
            pnlButtons = new FlowLayoutPanel();
            cancelButton = new Button();
            okButton = new Button();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            pnlName.SuspendLayout();
            pnlType.SuspendLayout();
            pnlDefaultValue.SuspendLayout();
            pnlReference.SuspendLayout();
            pnlValidate.SuspendLayout();
            pnlDescription.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlName, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlType, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlDefaultValue, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlReference, 0, 2);
            tableLayoutPanel1.Controls.Add(pnlValidate, 0, 3);
            tableLayoutPanel1.Controls.Add(pnlDescription, 0, 4);
            tableLayoutPanel1.Controls.Add(pnlButtons, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(600, 505);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlName
            // 
            tableLayoutPanel1.SetColumnSpan(pnlName, 3);
            pnlName.Controls.Add(nameTextBox);
            pnlName.Controls.Add(lblName);
            pnlName.Dock = DockStyle.Fill;
            pnlName.Location = new Point(11, 11);
            pnlName.Name = "pnlName";
            pnlName.Padding = new Padding(0, 0, 6, 0);
            pnlName.Size = new Size(432, 59);
            pnlName.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Dock = DockStyle.Fill;
            nameTextBox.Location = new Point(0, 26);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(426, 30);
            nameTextBox.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Top;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 0, 0, 3);
            lblName.Size = new Size(68, 26);
            lblName.TabIndex = 1;
            lblName.Text = "Name *";
            // 
            // pnlType
            // 
            pnlType.Controls.Add(typeComboBox);
            pnlType.Controls.Add(lblType);
            pnlType.Dock = DockStyle.Fill;
            pnlType.Location = new Point(449, 11);
            pnlType.Name = "pnlType";
            pnlType.Size = new Size(140, 59);
            pnlType.TabIndex = 1;
            // 
            // typeComboBox
            // 
            typeComboBox.Dock = DockStyle.Fill;
            typeComboBox.Location = new Point(0, 26);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(140, 31);
            typeComboBox.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Dock = DockStyle.Top;
            lblType.Location = new Point(0, 0);
            lblType.Name = "lblType";
            lblType.Padding = new Padding(0, 0, 0, 3);
            lblType.Size = new Size(57, 26);
            lblType.TabIndex = 2;
            lblType.Text = "Type *";
            // 
            // pnlDefaultValue
            // 
            tableLayoutPanel1.SetColumnSpan(pnlDefaultValue, 4);
            pnlDefaultValue.Controls.Add(defaultValueTextBox);
            pnlDefaultValue.Controls.Add(hasDefaultValueCheckBox);
            pnlDefaultValue.Dock = DockStyle.Fill;
            pnlDefaultValue.Location = new Point(11, 76);
            pnlDefaultValue.Name = "pnlDefaultValue";
            pnlDefaultValue.Size = new Size(578, 59);
            pnlDefaultValue.TabIndex = 2;
            // 
            // defaultValueTextBox
            // 
            defaultValueTextBox.Dock = DockStyle.Fill;
            defaultValueTextBox.Location = new Point(0, 30);
            defaultValueTextBox.Name = "defaultValueTextBox";
            defaultValueTextBox.Size = new Size(578, 30);
            defaultValueTextBox.TabIndex = 3;
            // 
            // hasDefaultValueCheckBox
            // 
            hasDefaultValueCheckBox.AutoSize = true;
            hasDefaultValueCheckBox.Dock = DockStyle.Top;
            hasDefaultValueCheckBox.Location = new Point(0, 0);
            hasDefaultValueCheckBox.Name = "hasDefaultValueCheckBox";
            hasDefaultValueCheckBox.Padding = new Padding(0, 0, 0, 3);
            hasDefaultValueCheckBox.Size = new Size(578, 30);
            hasDefaultValueCheckBox.TabIndex = 2;
            hasDefaultValueCheckBox.Text = "Default value: provide a value";
            hasDefaultValueCheckBox.CheckedChanged += hasDefaultValueCheckBox_CheckedChanged;
            // 
            // pnlReference
            // 
            tableLayoutPanel1.SetColumnSpan(pnlReference, 4);
            pnlReference.Controls.Add(referenceTextBox);
            pnlReference.Controls.Add(lblReference);
            pnlReference.Dock = DockStyle.Fill;
            pnlReference.Location = new Point(11, 141);
            pnlReference.Name = "pnlReference";
            pnlReference.Size = new Size(578, 59);
            pnlReference.TabIndex = 3;
            // 
            // referenceTextBox
            // 
            referenceTextBox.Dock = DockStyle.Fill;
            referenceTextBox.Location = new Point(0, 26);
            referenceTextBox.Name = "referenceTextBox";
            referenceTextBox.Size = new Size(578, 30);
            referenceTextBox.TabIndex = 4;
            // 
            // lblReference
            // 
            lblReference.AutoSize = true;
            lblReference.Dock = DockStyle.Top;
            lblReference.Location = new Point(0, 0);
            lblReference.Name = "lblReference";
            lblReference.Padding = new Padding(0, 0, 0, 3);
            lblReference.Size = new Size(85, 26);
            lblReference.TabIndex = 5;
            lblReference.Text = "Reference";
            // 
            // pnlValidate
            // 
            tableLayoutPanel1.SetColumnSpan(pnlValidate, 4);
            pnlValidate.Controls.Add(validateTextBox);
            pnlValidate.Controls.Add(lblValidate);
            pnlValidate.Dock = DockStyle.Fill;
            pnlValidate.Location = new Point(11, 206);
            pnlValidate.Name = "pnlValidate";
            pnlValidate.Size = new Size(578, 59);
            pnlValidate.TabIndex = 4;
            // 
            // validateTextBox
            // 
            validateTextBox.Dock = DockStyle.Fill;
            validateTextBox.Location = new Point(0, 26);
            validateTextBox.Name = "validateTextBox";
            validateTextBox.Size = new Size(578, 30);
            validateTextBox.TabIndex = 5;
            // 
            // lblValidate
            // 
            lblValidate.AutoSize = true;
            lblValidate.Dock = DockStyle.Top;
            lblValidate.Location = new Point(0, 0);
            lblValidate.Name = "lblValidate";
            lblValidate.Padding = new Padding(0, 0, 0, 3);
            lblValidate.Size = new Size(201, 26);
            lblValidate.TabIndex = 6;
            lblValidate.Text = "Validate (config function)";
            // 
            // pnlDescription
            // 
            tableLayoutPanel1.SetColumnSpan(pnlDescription, 4);
            pnlDescription.Controls.Add(descriptionTextBox);
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Dock = DockStyle.Fill;
            pnlDescription.Location = new Point(11, 271);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Size = new Size(578, 183);
            pnlDescription.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Location = new Point(0, 26);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(578, 157);
            descriptionTextBox.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Top;
            lblDescription.Location = new Point(0, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(0, 0, 0, 3);
            lblDescription.Size = new Size(96, 26);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description";
            // 
            // pnlButtons
            // 
            tableLayoutPanel1.SetColumnSpan(pnlButtons, 4);
            pnlButtons.Controls.Add(cancelButton);
            pnlButtons.Controls.Add(okButton);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Location = new Point(11, 460);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(578, 34);
            pnlButtons.TabIndex = 6;
            pnlButtons.WrapContents = false;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(481, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Location = new Point(381, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 7;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // ParameterEditDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(600, 505);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(500, 465);
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
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlName, pnlType, pnlDefaultValue, pnlReference, pnlValidate, pnlDescription;
        private Label lblName, lblType, lblReference, lblValidate, lblDescription;
        private TextBox nameTextBox, defaultValueTextBox, referenceTextBox, validateTextBox, descriptionTextBox;
        private ComboBox typeComboBox;
        private CheckBox hasDefaultValueCheckBox;
        private FlowLayoutPanel pnlButtons;
        private Button okButton, cancelButton;
        private ToolTip toolTip1;
    }
}
