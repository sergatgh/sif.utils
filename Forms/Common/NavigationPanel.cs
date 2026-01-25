using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace SIF.Utils.Forms.Common;

[ComVisible(true)]
public partial class NavigationPanel : UserControl
{
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Title { get => titleLabel.Text; set => titleLabel.Text = value; }

    [Browsable(true)]
    public event EventHandler? BackClicked
    {
        add => backButton.Click += value;
        remove => backButton.Click -= value;
    }

    public NavigationPanel()
    {
        InitializeComponent();
    }
}