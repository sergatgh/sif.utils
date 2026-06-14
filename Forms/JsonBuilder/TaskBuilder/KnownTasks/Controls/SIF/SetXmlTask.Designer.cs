namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class SetXmlTask
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            parametersDataGrid = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            valueColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            valueInput = new LabeledTextbox();
            elementText = new LabeledTextbox();
            xPathInput = new LabeledTextbox();
            button1 = new Button();
            filePathInput = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(549, 416);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(parametersDataGrid);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(valueInput);
            tabPage1.Controls.Add(elementText);
            tabPage1.Controls.Add(xPathInput);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(filePathInput);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(541, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "XML";
            tabPage1.UseVisualStyleBackColor = true;
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
            parametersDataGrid.Location = new Point(2, 166);
            parametersDataGrid.Margin = new Padding(2, 2, 2, 2);
            parametersDataGrid.Name = "parametersDataGrid";
            parametersDataGrid.RowHeadersWidth = 51;
            parametersDataGrid.Size = new Size(537, 220);
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
            label1.Location = new Point(2, 151);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 10;
            label1.Text = "Parameters";
            // 
            // valueInput
            // 
            valueInput.Dock = DockStyle.Top;
            valueInput.Location = new Point(2, 116);
            valueInput.Margin = new Padding(2, 1, 2, 1);
            valueInput.Multiline = false;
            valueInput.Name = "valueInput";
            valueInput.PathSelectionFilter = "";
            valueInput.PathSelectMode = PathSelectMode.Folder;
            valueInput.ShowPathSelector = false;
            valueInput.Size = new Size(537, 35);
            valueInput.TabIndex = 8;
            valueInput.TextInput = "";
            valueInput.TextLabel = "Value";
            valueInput.Vertical = true;
            // 
            // elementText
            // 
            elementText.Dock = DockStyle.Top;
            elementText.Location = new Point(2, 81);
            elementText.Margin = new Padding(2, 1, 2, 1);
            elementText.Multiline = false;
            elementText.Name = "elementText";
            elementText.PathSelectionFilter = "";
            elementText.PathSelectMode = PathSelectMode.Folder;
            elementText.ShowPathSelector = false;
            elementText.Size = new Size(537, 35);
            elementText.TabIndex = 11;
            elementText.TextInput = "";
            elementText.TextLabel = "Element (set this field to create a new element)";
            elementText.Vertical = true;
            // 
            // xPathInput
            // 
            xPathInput.Dock = DockStyle.Top;
            xPathInput.Location = new Point(2, 35);
            xPathInput.Margin = new Padding(2, 1, 2, 1);
            xPathInput.Multiline = false;
            xPathInput.Name = "xPathInput";
            xPathInput.PathSelectionFilter = "";
            xPathInput.PathSelectMode = PathSelectMode.Folder;
            xPathInput.ShowPathSelector = false;
            xPathInput.Size = new Size(537, 46);
            xPathInput.TabIndex = 7;
            xPathInput.TextInput = "";
            xPathInput.TextLabel = "XPath *";
            xPathInput.Vertical = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(2012, 71);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(26, 19);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // filePathInput
            // 
            filePathInput.Dock = DockStyle.Top;
            filePathInput.Location = new Point(2, 2);
            filePathInput.Margin = new Padding(2, 1, 2, 1);
            filePathInput.Multiline = false;
            filePathInput.Name = "filePathInput";
            filePathInput.PathSelectionFilter = "";
            filePathInput.PathSelectMode = PathSelectMode.File;
            filePathInput.ShowPathSelector = true;
            filePathInput.Size = new Size(537, 33);
            filePathInput.TabIndex = 0;
            filePathInput.TextInput = "";
            filePathInput.TextLabel = "File Path *";
            filePathInput.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(541, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(2, 2);
            taskEditor1.Margin = new Padding(2, 1, 2, 1);
            taskEditor1.MinimumSize = new Size(39, 33);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(537, 384);
            taskEditor1.TabIndex = 0;
            // 
            // SetXmlTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SetXmlTask";
            Size = new Size(549, 416);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox xPathInput;
        private Button button1;
        private LabeledTextbox filePathInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox valueInput;
        internal DataGridView parametersDataGrid;
        private Label label1;
        private LabeledTextbox elementText;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn valueColumn;
    }
}
