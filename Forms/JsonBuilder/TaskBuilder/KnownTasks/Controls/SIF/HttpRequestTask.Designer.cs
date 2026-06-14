namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class HttpRequestTask
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusNumber).BeginInit();
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
            tabControl1.Size = new Size(532, 449);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(parametersDataGrid);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(contentTypeText);
            tabPage1.Controls.Add(actionText);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(statusNumber);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(hostNameText);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(524, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Request";
            tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(524, 421);
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
            taskEditor1.Size = new Size(520, 417);
            taskEditor1.TabIndex = 0;
            // 
            // HttpRequestTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HttpRequestTask";
            Size = new Size(532, 449);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parametersDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskParameterModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusNumber).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox hostNameText;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox contentTypeText;
        private ComboBox actionText;
        private Label label1;
        internal DataGridView parametersDataGrid;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        internal BindingSource taskParameterModelBindingSource;
        private Label label2;
        private CheckBox checkBox1;
        private NumericUpDown statusNumber;
        private Label label3;
    }
}
