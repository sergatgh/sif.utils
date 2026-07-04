namespace SIF.Utils.Forms.JsonBuilder.Variables
{
    partial class VariablesForm
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
            parametersDataGrid = new DataGridView();
            nameDataColumn = new DataGridViewTextBoxColumn();
            valueDataGridColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // parametersDataGrid
            // 
            parametersDataGrid.BackgroundColor = SystemColors.Control;
            parametersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametersDataGrid.Columns.AddRange(new DataGridViewColumn[] { nameDataColumn, valueDataGridColumn });
            parametersDataGrid.Dock = DockStyle.Fill;
            parametersDataGrid.Location = new Point(0, 0);
            parametersDataGrid.Name = "parametersDataGrid";
            parametersDataGrid.RowHeadersWidth = 51;
            parametersDataGrid.Size = new Size(662, 544);
            parametersDataGrid.TabIndex = 1;
            // 
            // nameDataColumn
            // 
            nameDataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataColumn.HeaderText = "Name";
            nameDataColumn.MinimumWidth = 6;
            nameDataColumn.Name = "nameDataColumn";
            nameDataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // valueDataGridColumn
            // 
            valueDataGridColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            valueDataGridColumn.HeaderText = "Value";
            valueDataGridColumn.MinimumWidth = 6;
            valueDataGridColumn.Name = "valueDataGridColumn";
            valueDataGridColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // VariablesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parametersDataGrid);
            Name = "VariablesForm";
            Size = new Size(662, 544);
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView parametersDataGrid;
        private DataGridViewTextBoxColumn nameDataColumn;
        private DataGridViewTextBoxColumn valueDataGridColumn;
    }
}
