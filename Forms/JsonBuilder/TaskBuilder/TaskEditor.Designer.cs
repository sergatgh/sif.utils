namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder
{
    partial class TaskEditor
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
            components = new System.ComponentModel.Container();
            descriptionInput = new LabeledTextbox();
            skipInput = new LabeledTextbox();
            nameInput = new LabeledTextbox();
            requiresInput = new LabeledTextbox();
            taskParameterModelBindingSource = new BindingSource(components);
            label1 = new Label();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametersDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // descriptionInput
            // 
            descriptionInput.Dock = DockStyle.Top;
            descriptionInput.Location = new Point(0, 38);
            descriptionInput.Margin = new Padding(0, 0, 0, 7);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.PathSelectionFilter = "";
            descriptionInput.PathSelectMode = PathSelectMode.Folder;
            descriptionInput.ShowPathSelector = false;
            descriptionInput.Size = new Size(549, 62);
            descriptionInput.TabIndex = 4;
            descriptionInput.TextInput = "";
            descriptionInput.TextLabel = "Description";
            descriptionInput.Vertical = true;
            // 
            // skipInput
            // 
            skipInput.Dock = DockStyle.Top;
            skipInput.Location = new Point(0, 153);
            skipInput.Margin = new Padding(2, 1, 2, 1);
            skipInput.Multiline = false;
            skipInput.Name = "skipInput";
            skipInput.PathSelectionFilter = "";
            skipInput.PathSelectMode = PathSelectMode.Folder;
            skipInput.ShowPathSelector = false;
            skipInput.Size = new Size(549, 38);
            skipInput.TabIndex = 5;
            skipInput.TextInput = "";
            skipInput.TextLabel = "Skip";
            skipInput.Vertical = true;
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(0, 0);
            nameInput.Margin = new Padding(2, 1, 2, 1);
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.PathSelectionFilter = "";
            nameInput.PathSelectMode = PathSelectMode.Folder;
            nameInput.ShowPathSelector = false;
            nameInput.Size = new Size(549, 38);
            nameInput.TabIndex = 3;
            nameInput.TextInput = "";
            nameInput.TextLabel = "Name        ";
            nameInput.Vertical = true;
            // 
            // requiresInput
            // 
            requiresInput.Dock = DockStyle.Top;
            requiresInput.Location = new Point(0, 191);
            requiresInput.Margin = new Padding(2, 1, 2, 1);
            requiresInput.Multiline = false;
            requiresInput.Name = "requiresInput";
            requiresInput.PathSelectionFilter = "";
            requiresInput.PathSelectMode = PathSelectMode.Folder;
            requiresInput.ShowPathSelector = false;
            requiresInput.Size = new Size(549, 38);
            requiresInput.TabIndex = 6;
            requiresInput.TextInput = "";
            requiresInput.TextLabel = "Requires";
            requiresInput.Vertical = true;
            // 
            // taskParameterModelBindingSource
            // 
            taskParameterModelBindingSource.DataSource = typeof(TaskParameterModel);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 8;
            label1.Text = "Parameters";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // parametersDataGrid
            // 
            parametersDataGrid.AutoGenerateColumns = false;
            parametersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parametersDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            parametersDataGrid.BackgroundColor = SystemColors.Control;
            parametersDataGrid.BorderStyle = BorderStyle.None;
            parametersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametersDataGrid.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn });
            parametersDataGrid.DataSource = taskParameterModelBindingSource;
            parametersDataGrid.Dock = DockStyle.Top;
            parametersDataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            parametersDataGrid.Location = new Point(0, 115);
            parametersDataGrid.Margin = new Padding(2, 2, 2, 2);
            parametersDataGrid.Name = "parametersDataGrid";
            parametersDataGrid.RowHeadersWidth = 51;
            parametersDataGrid.Size = new Size(549, 38);
            parametersDataGrid.TabIndex = 7;
            parametersDataGrid.RowsAdded += dataGridView1_RowsAdded;
            parametersDataGrid.RowsRemoved += dataGridView1_RowsRemoved;
            // 
            // TaskEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(requiresInput);
            Controls.Add(skipInput);
            Controls.Add(parametersDataGrid);
            Controls.Add(label1);
            Controls.Add(descriptionInput);
            Controls.Add(nameInput);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(39, 33);
            Name = "TaskEditor";
            Size = new Size(549, 331);
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        internal BindingSource taskParameterModelBindingSource;
        internal DataGridView parametersDataGrid;
        internal LabeledTextbox descriptionInput;
        internal LabeledTextbox skipInput;
        internal LabeledTextbox nameInput;
        internal LabeledTextbox requiresInput;
    }
}
