namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class SetXmlTaskDialog
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
            parametersDataGrid = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            valueColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            valueInput = new LabeledTextbox();
            elementText = new LabeledTextbox();
            xPathInput = new LabeledTextbox();
            filePathInput = new LabeledTextbox();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // parametersDataGrid
            // 
            parametersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parametersDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            parametersDataGrid.BackgroundColor = SystemColors.Control;
            parametersDataGrid.BorderStyle = BorderStyle.None;
            parametersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametersDataGrid.Columns.AddRange(new DataGridViewColumn[] { nameColumn, valueColumn });
            parametersDataGrid.Dock = DockStyle.Fill;
            parametersDataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            parametersDataGrid.Location = new Point(3, 256);
            parametersDataGrid.Name = "parametersDataGrid";
            parametersDataGrid.RowHeadersWidth = 51;
            parametersDataGrid.Size = new Size(690, 336);
            parametersDataGrid.TabIndex = 9;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Attribute";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            // 
            // valueColumn
            // 
            valueColumn.HeaderText = "Value";
            valueColumn.MinimumWidth = 6;
            valueColumn.Name = "valueColumn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 233);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 10;
            label1.Text = "Parameters";
            // 
            // valueInput
            // 
            valueInput.Dock = DockStyle.Top;
            valueInput.Location = new Point(3, 179);
            valueInput.Margin = new Padding(3, 2, 3, 2);
            valueInput.Multiline = false;
            valueInput.Name = "valueInput";
            valueInput.PathSelectionFilter = "";
            valueInput.PathSelectMode = PathSelectMode.Folder;
            valueInput.ShowPathSelector = false;
            valueInput.Size = new Size(690, 54);
            valueInput.TabIndex = 8;
            valueInput.TextInput = "";
            valueInput.TextLabel = "Value";
            valueInput.Vertical = true;
            // 
            // elementText
            // 
            elementText.Dock = DockStyle.Top;
            elementText.Location = new Point(3, 125);
            elementText.Margin = new Padding(3, 2, 3, 2);
            elementText.Multiline = false;
            elementText.Name = "elementText";
            elementText.PathSelectionFilter = "";
            elementText.PathSelectMode = PathSelectMode.Folder;
            elementText.ShowPathSelector = false;
            elementText.Size = new Size(690, 54);
            elementText.TabIndex = 11;
            elementText.TextInput = "";
            elementText.TextLabel = "Element (set this field to create a new element)";
            elementText.Vertical = true;
            // 
            // xPathInput
            // 
            xPathInput.Dock = DockStyle.Top;
            xPathInput.Location = new Point(3, 54);
            xPathInput.Margin = new Padding(3, 2, 3, 2);
            xPathInput.Multiline = false;
            xPathInput.Name = "xPathInput";
            xPathInput.PathSelectionFilter = "";
            xPathInput.PathSelectMode = PathSelectMode.Folder;
            xPathInput.ShowPathSelector = false;
            xPathInput.Size = new Size(690, 71);
            xPathInput.TabIndex = 7;
            xPathInput.TextInput = "";
            xPathInput.TextLabel = "XPath *";
            xPathInput.Vertical = true;
            // 
            // filePathInput
            // 
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(3, 3);
            filePathInput.Margin = new Padding(3, 2, 3, 2);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectionFilter = "";
            filePathInput.PathSelectMode = PathSelectMode.File;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(690, 51);
            filePathInput.TabIndex = 0;
            filePathInput.TextInput = "";
            filePathInput.TextLabel = "File Path *";
            filePathInput.Vertical = true;
            // 
            // SetXmlTaskDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(parametersDataGrid);
            Controls.Add(label1);
            Controls.Add(valueInput);
            Controls.Add(elementText);
            Controls.Add(xPathInput);
            Controls.Add(filePathInput);
            Name = "SetXmlTaskDialog";
            Padding = new Padding(3, 3, 3, 3);
            Size = new Size(696, 595);
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public LabeledTextbox xPathInput;
        public LabeledTextbox filePathInput;
        public LabeledTextbox valueInput;
        public DataGridView parametersDataGrid;
        private Label label1;
        public LabeledTextbox elementText;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn valueColumn;
    }
}
