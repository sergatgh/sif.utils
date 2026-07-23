namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder
{
    partial class ParameterSectionControl
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
            taskParameterModelBindingSource = new BindingSource(components);
            headerPanel = new Panel();
            titleLabel = new Label();
            editButton = new Button();
            removeButton = new Button();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buildExpressionDataGridColumn = new DataGridViewButtonColumn();
            parametersDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).BeginInit();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // taskParameterModelBindingSource
            // 
            taskParameterModelBindingSource.DataSource = typeof(TaskParameterModel);
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(editButton);
            headerPanel.Controls.Add(removeButton);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(8, 4, 8, 4);
            headerPanel.Size = new Size(700, 38);
            headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Left;
            titleLabel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            titleLabel.Location = new Point(8, 4);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(71, 25);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Params";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Right;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            editButton.Location = new Point(616, 4);
            editButton.Margin = new Padding(0);
            editButton.Name = "editButton";
            editButton.Size = new Size(38, 30);
            editButton.TabIndex = 3;
            editButton.Text = "✎";
            editButton.UseVisualStyleBackColor = true;
            editButton.Visible = false;
            editButton.Click += editButton_Click;
            // 
            // removeButton
            // 
            removeButton.Dock = DockStyle.Right;
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            removeButton.Location = new Point(654, 4);
            removeButton.Margin = new Padding(0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(38, 30);
            removeButton.TabIndex = 1;
            removeButton.Text = "✕";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // buildExpressionDataGridColumn
            // 
            buildExpressionDataGridColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            buildExpressionDataGridColumn.HeaderText = "";
            buildExpressionDataGridColumn.MinimumWidth = 6;
            buildExpressionDataGridColumn.Name = "buildExpressionDataGridColumn";
            buildExpressionDataGridColumn.Text = "...";
            buildExpressionDataGridColumn.UseColumnTextForButtonValue = true;
            buildExpressionDataGridColumn.Width = 30;
            // 
            // parametersDataGrid
            // 
            parametersDataGrid.AutoGenerateColumns = false;
            parametersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parametersDataGrid.BackgroundColor = SystemColors.Control;
            parametersDataGrid.BorderStyle = BorderStyle.None;
            parametersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            parametersDataGrid.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn, buildExpressionDataGridColumn });
            parametersDataGrid.DataSource = taskParameterModelBindingSource;
            parametersDataGrid.Dock = DockStyle.Top;
            parametersDataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            parametersDataGrid.Location = new Point(0, 38);
            parametersDataGrid.Name = "parametersDataGrid";
            parametersDataGrid.RowHeadersWidth = 51;
            parametersDataGrid.Size = new Size(700, 58);
            parametersDataGrid.TabIndex = 1;
            parametersDataGrid.CellContentClick += parametersDataGrid_CellContentClick;
            parametersDataGrid.RowsAdded += parametersDataGrid_RowsAdded;
            parametersDataGrid.RowsRemoved += parametersDataGrid_RowsRemoved;
            // 
            // ParameterSectionControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(parametersDataGrid);
            Controls.Add(headerPanel);
            Margin = new Padding(0, 0, 0, 12);
            Name = "ParameterSectionControl";
            Padding = new Padding(0, 0, 0, 8);
            Size = new Size(700, 92);
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource taskParameterModelBindingSource;
        private Panel headerPanel;
        private Button removeButton;
        private Button editButton;
        private Label titleLabel;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn buildExpressionDataGridColumn;
        internal DataGridView parametersDataGrid;
    }
}
