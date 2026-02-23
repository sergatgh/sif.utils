namespace SIF.Utils
{
    partial class ConfigFunctionViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("IISRootFolder");
            TreeNode treeNode2 = new TreeNode("parameter", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("pathExists", new TreeNode[] { treeNode2 });
            TreeNode treeNode4 = new TreeNode("not", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("IISRootPath");
            TreeNode treeNode6 = new TreeNode("createAndReturn", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("IISRootFolder");
            TreeNode treeNode8 = new TreeNode("getPath", new TreeNode[] { treeNode7 });
            TreeNode treeNode9 = new TreeNode("If", new TreeNode[] { treeNode4, treeNode6, treeNode8 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigFunctionViewer));
            configFunctionTree = new TreeView();
            errorParsingConfigFunctionLabel = new Label();
            SuspendLayout();
            // 
            // configFunctionTree
            // 
            configFunctionTree.Dock = DockStyle.Fill;
            configFunctionTree.Location = new Point(0, 0);
            configFunctionTree.Name = "configFunctionTree";
            treeNode1.Name = "Node4";
            treeNode1.Text = "IISRootFolder";
            treeNode2.Name = "Node3";
            treeNode2.Text = "parameter";
            treeNode3.Name = "Node2";
            treeNode3.Text = "pathExists";
            treeNode4.Name = "Node1";
            treeNode4.Text = "not";
            treeNode5.Name = "Node6";
            treeNode5.Text = "IISRootPath";
            treeNode6.Name = "Node5";
            treeNode6.Text = "createAndReturn";
            treeNode7.Name = "Node8";
            treeNode7.Text = "IISRootFolder";
            treeNode8.Name = "Node7";
            treeNode8.Text = "getPath";
            treeNode9.Name = "ifNode";
            treeNode9.Text = "If";
            configFunctionTree.Nodes.AddRange(new TreeNode[] { treeNode9 });
            configFunctionTree.Size = new Size(800, 450);
            configFunctionTree.TabIndex = 0;
            // 
            // errorParsingConfigFunctionLabel
            // 
            errorParsingConfigFunctionLabel.Dock = DockStyle.Fill;
            errorParsingConfigFunctionLabel.Font = new Font("Segoe UI", 16F);
            errorParsingConfigFunctionLabel.Location = new Point(0, 0);
            errorParsingConfigFunctionLabel.Name = "errorParsingConfigFunctionLabel";
            errorParsingConfigFunctionLabel.Size = new Size(800, 450);
            errorParsingConfigFunctionLabel.TabIndex = 1;
            errorParsingConfigFunctionLabel.Text = "There was an error parsing ConfigFunction";
            errorParsingConfigFunctionLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorParsingConfigFunctionLabel.Visible = false;
            // 
            // ConfigFunctionViewer
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(configFunctionTree);
            Controls.Add(errorParsingConfigFunctionLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConfigFunctionViewer";
            Text = "ConfigFunctionViewer";
            ResumeLayout(false);
        }

        #endregion

        private TreeView configFunctionTree;
        private Label errorParsingConfigFunctionLabel;
    }
}