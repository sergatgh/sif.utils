namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class RemoveSqlDatabaseTask
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
            passwordInput = new LabeledTextbox();
            userNameInput = new LabeledTextbox();
            databasesInput = new LabeledTextbox();
            button1 = new Button();
            nameInput = new LabeledTextbox();
            tabPage2 = new TabPage();
            taskEditor1 = new TaskEditor();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(731, 739);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(passwordInput);
            tabPage1.Controls.Add(userNameInput);
            tabPage1.Controls.Add(databasesInput);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(nameInput);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(723, 703);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Database";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // passwordInput
            // 
            passwordInput.Dock = DockStyle.Top;
            passwordInput.Location = new Point(3, 311);
            passwordInput.Multiline = false;
            passwordInput.Name = "passwordInput";
            passwordInput.PathSelectionFilter = "";
            passwordInput.PathSelectMode = PathSelectMode.Folder;
            passwordInput.ShowPathSelector = false;
            passwordInput.Size = new Size(717, 70);
            passwordInput.TabIndex = 8;
            passwordInput.TextInput = "b";
            passwordInput.TextLabel = "Password *";
            passwordInput.Vertical = true;
            // 
            // userNameInput
            // 
            userNameInput.Dock = DockStyle.Top;
            userNameInput.Location = new Point(3, 241);
            userNameInput.Multiline = false;
            userNameInput.Name = "userNameInput";
            userNameInput.PathSelectionFilter = "";
            userNameInput.PathSelectMode = PathSelectMode.Folder;
            userNameInput.ShowPathSelector = false;
            userNameInput.Size = new Size(717, 70);
            userNameInput.TabIndex = 7;
            userNameInput.TextInput = "sa";
            userNameInput.TextLabel = "User Name *";
            userNameInput.Vertical = true;
            // 
            // databasesInput
            // 
            databasesInput.Dock = DockStyle.Top;
            databasesInput.Location = new Point(3, 73);
            databasesInput.Multiline = true;
            databasesInput.Name = "databasesInput";
            databasesInput.PathSelectionFilter = "";
            databasesInput.PathSelectMode = PathSelectMode.Folder;
            databasesInput.ShowPathSelector = false;
            databasesInput.Size = new Size(717, 168);
            databasesInput.TabIndex = 6;
            databasesInput.TextInput = "sc1041_Master";
            databasesInput.TextLabel = "Database Names * (one per line)";
            databasesInput.Vertical = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1568, 103);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(3, 3);
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.PathSelectionFilter = "";
            nameInput.PathSelectMode = PathSelectMode.Folder;
            nameInput.ShowPathSelector = false;
            nameInput.Size = new Size(717, 70);
            nameInput.TabIndex = 0;
            nameInput.TextInput = "(local)";
            nameInput.TextLabel = "Server Name *";
            nameInput.Vertical = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(taskEditor1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 64);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Properties";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskEditor1
            // 
            taskEditor1.AutoScroll = true;
            taskEditor1.Dock = DockStyle.Fill;
            taskEditor1.Location = new Point(3, 3);
            taskEditor1.MinimumSize = new Size(50, 50);
            taskEditor1.Name = "taskEditor1";
            taskEditor1.Size = new Size(186, 58);
            taskEditor1.TabIndex = 0;
            // 
            // RemoveSqlDatabaseTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "RemoveSqlDatabaseTask";
            Size = new Size(731, 739);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LabeledTextbox passwordInput;
        private LabeledTextbox userNameInput;
        private LabeledTextbox databasesInput;
        private Button button1;
        private LabeledTextbox nameInput;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
    }
}
