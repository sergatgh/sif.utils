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
            components = new System.ComponentModel.Container();
            parametersDataGrid = new DataGridView();
            nameDataColumn = new DataGridViewTextBoxColumn();
            valueDataGridColumn = new DataGridViewTextBoxColumn();
            buildExpressionDataGridColumn = new DataGridViewButtonColumn();
            valueContextMenuStrip = new ContextMenuStrip(components);
            buildExpressionToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            valueContextMenuStrip.SuspendLayout();
            SuspendLayout();
            //
            // parametersDataGrid
            //
            parametersDataGrid.BackgroundColor = SystemColors.Control;
            parametersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametersDataGrid.Columns.AddRange(new DataGridViewColumn[] { nameDataColumn, valueDataGridColumn, buildExpressionDataGridColumn });
            parametersDataGrid.ContextMenuStrip = valueContextMenuStrip;
            parametersDataGrid.Dock = DockStyle.Fill;
            parametersDataGrid.Location = new Point(0, 0);
            parametersDataGrid.Name = "parametersDataGrid";
            parametersDataGrid.RowHeadersWidth = 51;
            parametersDataGrid.Size = new Size(662, 544);
            parametersDataGrid.TabIndex = 1;
            parametersDataGrid.CellContentClick += parametersDataGrid_CellContentClick;
            parametersDataGrid.CellMouseDown += parametersDataGrid_CellMouseDown;
            //
            // valueContextMenuStrip
            //
            valueContextMenuStrip.Items.AddRange(new ToolStripItem[] { buildExpressionToolStripMenuItem });
            valueContextMenuStrip.Name = "valueContextMenuStrip";
            valueContextMenuStrip.Size = new Size(181, 26);
            //
            // buildExpressionToolStripMenuItem
            //
            buildExpressionToolStripMenuItem.Name = "buildExpressionToolStripMenuItem";
            buildExpressionToolStripMenuItem.Size = new Size(180, 22);
            buildExpressionToolStripMenuItem.Text = "Build Expression...";
            buildExpressionToolStripMenuItem.Click += buildExpressionToolStripMenuItem_Click;
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
            // buildExpressionDataGridColumn
            //
            buildExpressionDataGridColumn.HeaderText = "";
            buildExpressionDataGridColumn.MinimumWidth = 6;
            buildExpressionDataGridColumn.Name = "buildExpressionDataGridColumn";
            buildExpressionDataGridColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            buildExpressionDataGridColumn.Text = "Build";
            buildExpressionDataGridColumn.UseColumnTextForButtonValue = true;
            buildExpressionDataGridColumn.Width = 80;
            //
            // VariablesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parametersDataGrid);
            Name = "VariablesForm";
            Size = new Size(662, 544);
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            valueContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView parametersDataGrid;
        private DataGridViewTextBoxColumn nameDataColumn;
        private DataGridViewTextBoxColumn valueDataGridColumn;
        private DataGridViewButtonColumn buildExpressionDataGridColumn;
        private ContextMenuStrip valueContextMenuStrip;
        private ToolStripMenuItem buildExpressionToolStripMenuItem;
    }
}
