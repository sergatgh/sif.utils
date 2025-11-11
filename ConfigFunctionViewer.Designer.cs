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
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
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
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode9 });
            treeView1.Size = new Size(800, 450);
            treeView1.TabIndex = 0;
            // 
            // ConfigFunctionViewer
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Name = "ConfigFunctionViewer";
            Text = "ConfigFunctionViewer";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}