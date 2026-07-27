using System.ComponentModel;

namespace SIF.Utils.Forms.JsonBuilder
{
    public partial class LabeledTextbox : UserControl
    {
        private bool _vertical = true;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextLabel { get => labelText.Text; set => labelText.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextInput { get => textBox.Text; set => textBox.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Vertical
        {
            get => _vertical;
            set
            {
                _vertical = value;
                labelText.Dock = value ? DockStyle.Top : DockStyle.Left;
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Multiline
        {
            get => textBox.Multiline;
            set
            {
                textBox.Multiline = value;
                if (value)
                {
                    textBox.Height = 60;
                }
            }
        }

        [Browsable(true)]
        public new event EventHandler? TextChanged
        {
            add => textBox.TextChanged += value;
            remove => textBox.TextChanged -= value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new event KeyEventHandler? KeyDown
        {
            add => textBox.KeyDown += value;
            remove => textBox.KeyDown -= value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowPathSelector
        {
            get => pathSelectButton.Visible;
            set => pathSelectButton.Visible = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public PathSelectMode PathSelectMode { get; set; } = PathSelectMode.Folder;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PathSelectionFilter { get; set; } = "";

        public string[] Lines => textBox.Lines;

        public bool HasText => !string.IsNullOrWhiteSpace(this.TextInput);

        public void FocusInput() => textBox.Focus();

        public LabeledTextbox()
        {
            InitializeComponent();
        }

        private void pathSelectButton_Click(object sender, EventArgs e)
        {
            if (PathSelectMode == PathSelectMode.File)
            {
                var openFileDialog1 = new OpenFileDialog();
                // Set initial directory (optional)
                openFileDialog1.InitialDirectory = @"C:\";

                openFileDialog1.Filter = PathSelectionFilter;
                openFileDialog1.FilterIndex = 1;

                // Show the dialog and check if the user clicked OK
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file
                    textBox.Text = openFileDialog1.FileName;
                }
                return;
            }

            if (PathSelectMode == PathSelectMode.Folder)
            {
                // Create an instance of the FolderBrowserDialog
                var folderBrowserDialog1 = new FolderBrowserDialog();

                // Set the initial directory (optional)
                folderBrowserDialog1.InitialDirectory = @"C:\";

                // Allow the user to create new folders (optional, default is true)
                folderBrowserDialog1.ShowNewFolderButton = true;

                // Show the dialog and check if the user clicked OK
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected folder
                    textBox.Text = folderBrowserDialog1.SelectedPath;
                }
                return;
            }

            if (PathSelectMode == PathSelectMode.All)
            {
                var openFileDialog1 = new OpenFileDialog
                {
                    ValidateNames = false,
                    CheckFileExists = false,
                    CheckPathExists = true,
                    FileName = "Select a file or folder"
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var selectedPath = openFileDialog1.FileName;
                    if (System.IO.Path.GetFileName(selectedPath) == "Select a file or folder")
                    {
                        selectedPath = System.IO.Path.GetDirectoryName(selectedPath) ?? selectedPath;
                    }
                    textBox.Text = selectedPath;
                }
            }
        }
    }
}

public enum PathSelectMode
{
    Folder,
    File,
    All,
}