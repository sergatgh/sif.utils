using SIF.Utils.Forms.SecondaryNavigation;
using System.ComponentModel;

namespace SIF.Utils.Forms.SecondaryNavigation;

public partial class SecondaryNavigationCategory : UserControl
{
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Title { get => label1.Text; set => label1.Text = value; }

    public SecondaryNavigationCategory()
    {
        InitializeComponent();
    }

    public void LoadFrom(CategoryModel categoryModel)
    {
        this.flowLayoutPanel1.Controls.Clear();
        label1.Text = categoryModel.Name;
        foreach (var item in categoryModel.Links)
        {
            AddLink(item);
        }
    }

    public void AddLink(LinkModel linkModel)
    {
        var secondaryNavigationMenuItem = new SecondaryNavigationMenuItem();

        secondaryNavigationMenuItem.CardClick += linkModel.Click;

        secondaryNavigationMenuItem.LoadFrom(linkModel);

        flowLayoutPanel1.Controls.Add(secondaryNavigationMenuItem);
    }

    public void UnselectAll()
    {
        foreach (var item in flowLayoutPanel1.Controls.OfType<SecondaryNavigationMenuItem>())
        {
            item.Unselect();
        }
    }

    public void SelectIndex(int index)
    {
        var control = flowLayoutPanel1.Controls.OfType<SecondaryNavigationMenuItem>().ElementAt(index);
        control.Control_Click(control, EventArgs.Empty);
    }
}