namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder
{
    partial class TaskEditor
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
            descriptionInput = new LabeledTextbox();
            skipInput = new LabeledTextbox();
            nameInput = new LabeledTextbox();
            requiresInput = new LabeledTextbox();
            parametersHeaderPanel = new Panel();
            addSectionButton = new Button();
            parametersLabel = new Label();
            parameterSectionsPanel = new FlowLayoutPanel();
            parametersHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // descriptionInput
            // 
            descriptionInput.Dock = DockStyle.Top;
            descriptionInput.Location = new Point(0, 58);
            descriptionInput.Margin = new Padding(0, 0, 0, 11);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.PathSelectionFilter = "";
            descriptionInput.PathSelectMode = PathSelectMode.Folder;
            descriptionInput.ShowPathSelector = false;
            descriptionInput.Size = new Size(706, 95);
            descriptionInput.TabIndex = 4;
            descriptionInput.TextInput = "";
            descriptionInput.TextLabel = "Description";
            descriptionInput.Vertical = true;
            // 
            // skipInput
            // 
            skipInput.Dock = DockStyle.Top;
            skipInput.Location = new Point(0, 234);
            skipInput.Margin = new Padding(3, 2, 3, 2);
            skipInput.Multiline = false;
            skipInput.Name = "skipInput";
            skipInput.PathSelectionFilter = "";
            skipInput.PathSelectMode = PathSelectMode.Folder;
            skipInput.ShowPathSelector = false;
            skipInput.Size = new Size(706, 58);
            skipInput.TabIndex = 5;
            skipInput.TextInput = "";
            skipInput.TextLabel = "Skip";
            skipInput.Vertical = true;
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Top;
            nameInput.Location = new Point(0, 0);
            nameInput.Margin = new Padding(3, 2, 3, 2);
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.PathSelectionFilter = "";
            nameInput.PathSelectMode = PathSelectMode.Folder;
            nameInput.ShowPathSelector = false;
            nameInput.Size = new Size(706, 58);
            nameInput.TabIndex = 3;
            nameInput.TextInput = "";
            nameInput.TextLabel = "Name        ";
            nameInput.Vertical = true;
            // 
            // requiresInput
            // 
            requiresInput.Dock = DockStyle.Top;
            requiresInput.Location = new Point(0, 292);
            requiresInput.Margin = new Padding(3, 2, 3, 2);
            requiresInput.Multiline = false;
            requiresInput.Name = "requiresInput";
            requiresInput.PathSelectionFilter = "";
            requiresInput.PathSelectMode = PathSelectMode.Folder;
            requiresInput.ShowPathSelector = false;
            requiresInput.Size = new Size(706, 58);
            requiresInput.TabIndex = 6;
            requiresInput.TextInput = "";
            requiresInput.TextLabel = "Requires";
            requiresInput.Vertical = true;
            // 
            // parametersHeaderPanel
            //
            parametersHeaderPanel.Controls.Add(parametersLabel);
            parametersHeaderPanel.Controls.Add(addSectionButton);
            parametersHeaderPanel.Dock = DockStyle.Top;
            parametersHeaderPanel.Location = new Point(0, 153);
            parametersHeaderPanel.Name = "parametersHeaderPanel";
            parametersHeaderPanel.Size = new Size(706, 30);
            parametersHeaderPanel.TabIndex = 8;
            //
            // addSectionButton
            //
            addSectionButton.Dock = DockStyle.Right;
            addSectionButton.FlatStyle = FlatStyle.Flat;
            addSectionButton.FlatAppearance.BorderSize = 0;
            addSectionButton.Name = "addSectionButton";
            addSectionButton.Size = new Size(140, 30);
            addSectionButton.TabIndex = 1;
            addSectionButton.Text = "+ Add section";
            addSectionButton.UseVisualStyleBackColor = true;
            addSectionButton.Click += addSectionButton_Click;
            //
            // parametersLabel
            //
            parametersLabel.AutoSize = true;
            parametersLabel.Dock = DockStyle.Left;
            parametersLabel.Location = new Point(0, 0);
            parametersLabel.Name = "parametersLabel";
            parametersLabel.Size = new Size(148, 23);
            parametersLabel.TabIndex = 0;
            parametersLabel.Text = "Parameter sections";
            //
            // parameterSectionsPanel
            //
            parameterSectionsPanel.AutoSize = true;
            parameterSectionsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            parameterSectionsPanel.Dock = DockStyle.Top;
            parameterSectionsPanel.FlowDirection = FlowDirection.TopDown;
            parameterSectionsPanel.Location = new Point(0, 183);
            parameterSectionsPanel.Name = "parameterSectionsPanel";
            parameterSectionsPanel.Size = new Size(706, 0);
            parameterSectionsPanel.TabIndex = 7;
            parameterSectionsPanel.WrapContents = false;
            parameterSectionsPanel.Resize += parameterSectionsPanel_Resize;
            //
            // TaskEditor
            //
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(requiresInput);
            Controls.Add(skipInput);
            Controls.Add(parameterSectionsPanel);
            Controls.Add(parametersHeaderPanel);
            Controls.Add(descriptionInput);
            Controls.Add(nameInput);
            MinimumSize = new Size(50, 51);
            Name = "TaskEditor";
            Size = new Size(706, 508);
            parametersHeaderPanel.ResumeLayout(false);
            parametersHeaderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel parametersHeaderPanel;
        private Label parametersLabel;
        private Button addSectionButton;
        internal FlowLayoutPanel parameterSectionsPanel;
        internal LabeledTextbox descriptionInput;
        internal LabeledTextbox skipInput;
        internal LabeledTextbox nameInput;
        internal LabeledTextbox requiresInput;
    }
}
