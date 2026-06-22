namespace SIF.Utils.Forms.Main;

public sealed class Navigator
{
    private readonly Stack<Control> _history = new();
    private readonly List<Control> _allPages;

    public Navigator(IEnumerable<Control> pages) => _allPages = [..pages];

    public void Navigate(Control page, Action? onShow = null)
    {
        if (_history.TryPeek(out var current) && current == page) return;
        HideAll();
        page.Visible = true;
        onShow?.Invoke();
        _history.Push(page);
    }

    public void GoBack()
    {
        if (_history.Count <= 1) return;
        _history.Pop();
        HideAll();
        _history.Peek().Visible = true;
    }

    public void GoHome(Control homePage)
    {
        _history.Clear();
        Navigate(homePage);
    }

    private void HideAll()
    {
        foreach (var p in _allPages) p.Visible = false;
    }
}
