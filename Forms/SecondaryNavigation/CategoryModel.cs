namespace SIF.Utils.Forms.SecondaryNavigation;

public class CategoryModel(string name)
{
    public string Name { get; } = name;
    public List<LinkModel> Links { get; init; } = [];
}