namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    partial class WebDeployTask
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
            argsJson = new LabeledTextbox();
            checkBox1 = new CheckBox();
            pathToDeploy = new LabeledTextbox();
            actionText = new ComboBox();
            label1 = new Label();
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
            tabControl1.Size = new Size(761, 708);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(argsJson);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(pathToDeploy);
            tabPage1.Controls.Add(actionText);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(753, 672);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MS Deploy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // argsJson
            // 
            argsJson.Dock = DockStyle.Fill;
            argsJson.Location = new Point(3, 114);
            argsJson.Multiline = true;
            argsJson.Name = "argsJson";
            argsJson.PathSelectionFilter = "";
            argsJson.PathSelectMode = PathSelectMode.Folder;
            argsJson.ShowPathSelector = false;
            argsJson.Size = new Size(747, 555);
            argsJson.TabIndex = 13;
            argsJson.TextInput = "{ }";
            argsJson.TextLabel = "Arguments object JSON";
            argsJson.Vertical = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1095, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 27);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Check Status";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pathToDeploy
            // 
            pathToDeploy.Dock = DockStyle.Top;
            pathToDeploy.Location = new Point(3, 57);
            pathToDeploy.Multiline = false;
            pathToDeploy.Name = "pathToDeploy";
            pathToDeploy.PathSelectionFilter = "MS Deploy|*.exe";
            pathToDeploy.PathSelectMode = PathSelectMode.File;
            pathToDeploy.ShowPathSelector = true;
            pathToDeploy.Size = new Size(747, 57);
            pathToDeploy.TabIndex = 5;
            pathToDeploy.TextInput = "";
            pathToDeploy.TextLabel = "Path to msdeploy.exe";
            pathToDeploy.Vertical = true;
            // 
            // actionText
            // 
            actionText.Dock = DockStyle.Top;
            actionText.FormattingEnabled = true;
            actionText.Items.AddRange(new object[] { "sync", "delete", "dump", "getDependencies", "getSystemInfo" });
            actionText.Location = new Point(3, 26);
            actionText.Name = "actionText";
            actionText.Size = new Size(747, 31);
            actionText.TabIndex = 4;
            actionText.Text = "sync";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 3;
            label1.Text = "Verb *";
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
            // WebDeployTask
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "WebDeployTask";
            Size = new Size(761, 708);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox checkBox1;
        private LabeledTextbox pathToDeploy;
        private ComboBox actionText;
        private Label label1;
        private TabPage tabPage2;
        internal TaskEditor taskEditor1;
        private LabeledTextbox argsJson;
    }
}
