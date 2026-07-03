namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class HttpRequestTaskDialog
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
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            parametersDataGrid = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taskParameterModelBindingSource = new BindingSource(components);
            label2 = new Label();
            contentTypeText = new LabeledTextbox();
            actionText = new ComboBox();
            label1 = new Label();
            statusNumber = new NumericUpDown();
            label3 = new Label();
            hostNameText = new LabeledTextbox();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusNumber).BeginInit();
            SuspendLayout();
            //
            // checkBox1
            //
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(430, 44);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Check Status";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            parametersDataGrid.Dock = DockStyle.Fill;
            parametersDataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            parametersDataGrid.Location = new Point(2, 183);
            parametersDataGrid.Margin = new Padding(2, 2, 2, 2);
            parametersDataGrid.Name = "parametersDataGrid";
            parametersDataGrid.RowHeadersWidth = 51;
            parametersDataGrid.Size = new Size(520, 236);
            parametersDataGrid.TabIndex = 8;
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
            // taskParameterModelBindingSource
            //
            taskParameterModelBindingSource.DataSource = typeof(TaskParameterModel);
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(2, 168);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Parameters";
            //
            // contentTypeText
            //
            contentTypeText.Dock = DockStyle.Top;
            contentTypeText.Location = new Point(2, 123);
            contentTypeText.Margin = new Padding(2, 1, 2, 1);
            contentTypeText.Multiline = false;
            contentTypeText.Name = "contentTypeText";
            contentTypeText.PathSelectionFilter = "";
            contentTypeText.PathSelectMode = PathSelectMode.Folder;
            contentTypeText.ShowPathSelector = false;
            contentTypeText.Size = new Size(520, 45);
            contentTypeText.TabIndex = 5;
            contentTypeText.TextInput = "";
            contentTypeText.TextLabel = "Content Type";
            contentTypeText.Vertical = true;
            //
            // actionText
            //
            actionText.Dock = DockStyle.Top;
            actionText.FormattingEnabled = true;
            actionText.Items.AddRange(new object[] { "GET", "POST" });
            actionText.Location = new Point(2, 100);
            actionText.Margin = new Padding(2, 2, 2, 2);
            actionText.Name = "actionText";
            actionText.Size = new Size(520, 23);
            actionText.TabIndex = 4;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(2, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Action";
            //
            // statusNumber
            //
            statusNumber.Dock = DockStyle.Top;
            statusNumber.Enabled = false;
            statusNumber.Location = new Point(2, 62);
            statusNumber.Margin = new Padding(2, 2, 2, 2);
            statusNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            statusNumber.Name = "statusNumber";
            statusNumber.Size = new Size(520, 23);
            statusNumber.TabIndex = 10;
            statusNumber.Value = new decimal(new int[] { 200, 0, 0, 0 });
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(2, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 11;
            label3.Text = "Expected Status Code";
            //
            // hostNameText
            //
            hostNameText.Dock = DockStyle.Top;
            hostNameText.Location = new Point(2, 2);
            hostNameText.Margin = new Padding(2, 1, 2, 1);
            hostNameText.Multiline = false;
            hostNameText.Name = "hostNameText";
            hostNameText.PathSelectionFilter = "";
            hostNameText.PathSelectMode = PathSelectMode.Folder;
            hostNameText.ShowPathSelector = false;
            hostNameText.Size = new Size(520, 45);
            hostNameText.TabIndex = 0;
            hostNameText.TextInput = "www.github.com";
            hostNameText.TextLabel = "URI *";
            hostNameText.Vertical = true;
            //
            // HttpRequestTaskDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(checkBox1);
            Controls.Add(parametersDataGrid);
            Controls.Add(label2);
            Controls.Add(contentTypeText);
            Controls.Add(actionText);
            Controls.Add(label1);
            Controls.Add(statusNumber);
            Controls.Add(label3);
            Controls.Add(hostNameText);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HttpRequestTaskDialog";
            Padding = new Padding(2, 2, 2, 2);
            Size = new Size(524, 421);
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public LabeledTextbox hostNameText;
        public LabeledTextbox contentTypeText;
        public ComboBox actionText;
        private Label label1;
        public DataGridView parametersDataGrid;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        public BindingSource taskParameterModelBindingSource;
        private Label label2;
        public CheckBox checkBox1;
        public NumericUpDown statusNumber;
        private Label label3;
    }
}
