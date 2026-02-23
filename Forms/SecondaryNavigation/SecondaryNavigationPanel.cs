namespace SIF.Utils.Forms.SecondaryNavigation;

using System.ComponentModel;

public partial class SecondaryNavigationPanel : UserControl
{
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Title { get => label1.Text; set => label1.Text = value; }

    public SecondaryNavigationPanel()
    {
        InitializeComponent();
    }

    public void LoadFrom(SecondaryNavigationModel secondaryNavigationModel)
    {
        this.flowLayoutPanel1.Controls.Clear();
        label1.Text = secondaryNavigationModel.Title;
        foreach (var item in secondaryNavigationModel.Categories)
        {
            AddCategory(item);
        }
    }

    public void AddCategory(CategoryModel categoryModel)
    {
        var category = new SecondaryNavigationCategory();

        foreach (var item in categoryModel.Links)
        {
            item.Click += delegate { UnselectAll(); };
        }

        category.LoadFrom(categoryModel);
        this.flowLayoutPanel1.Controls.Add(category);
    }

    public void UnselectAll()
    {
        foreach (var item in flowLayoutPanel1.Controls.OfType<SecondaryNavigationCategory>())
        {
            item.UnselectAll();
        }
    }

    public void Select(int categoryIndex, int linkIndex)
    {
        flowLayoutPanel1.Controls.OfType<SecondaryNavigationCategory>().ElementAt(categoryIndex).SelectIndex(linkIndex);
    }
}

public class SecondaryNavigationModel(string title)
{
    public string Title { get; } = title;
    public List<CategoryModel> Categories { get; init; } = [];
}