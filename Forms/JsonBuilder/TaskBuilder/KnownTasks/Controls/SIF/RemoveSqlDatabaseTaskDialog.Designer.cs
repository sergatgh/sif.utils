namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    partial class RemoveSqlDatabaseTaskDialog
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
            passwordInput = new LabeledTextbox();
            userNameInput = new LabeledTextbox();
            databasesInput = new LabeledTextbox();
            nameInput = new LabeledTextbox();
            SuspendLayout();
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
            // RemoveSqlDatabaseTaskDialog
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(passwordInput);
            Controls.Add(userNameInput);
            Controls.Add(databasesInput);
            Controls.Add(nameInput);
            Name = "RemoveSqlDatabaseTaskDialog";
            Padding = new Padding(3);
            Size = new Size(723, 703);
            ResumeLayout(false);
        }

        #endregion

        public LabeledTextbox passwordInput;
        public LabeledTextbox userNameInput;
        public LabeledTextbox databasesInput;
        public LabeledTextbox nameInput;
    }
}
