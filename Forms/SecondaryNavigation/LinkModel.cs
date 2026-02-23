namespace SIF.Utils.Forms.SecondaryNavigation;

public class LinkModel(Image? image, string text)
{
    public Image? Image { get; } = image;
    public string Text { get; } = text;
    public EventHandler Click { get; set; }
}