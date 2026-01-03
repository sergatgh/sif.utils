using System.ComponentModel;

namespace SIF.Utils.Forms.Common
{
    public partial class NavigationPanel : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title { get => titleLabel.Text; set => titleLabel.Text = value; }

        [Browsable(true)]
        public event EventHandler? OnBackClicked
        {
            add => backButton.Click += value;
            remove => backButton.Click -= value;
        }

        public NavigationPanel()
        {
            InitializeComponent();
        }
    }
}
