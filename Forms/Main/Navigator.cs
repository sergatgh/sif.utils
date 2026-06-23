namespace SIF.Utils.Forms.Main;

public sealed class Navigator
{
    private readonly Stack<Control> _history = new();
    private readonly List<Control> _allPages;

    public event EventHandler<Control>? PageChanged;

    public Navigator(IEnumerable<Control> pages) => _allPages = [..pages];

    public void Navigate(Control page, Action? onShow = null)
    {
        if (_history.TryPeek(out var current) && current == page) return;
        HideAll();
        page.Visible = true;
        onShow?.Invoke();
        _history.Push(page);
        PageChanged?.Invoke(this, page);
    }

    public void GoBack()
    {
        if (_history.Count <= 1) return;
        _history.Pop();
        HideAll();
        _history.Peek().Visible = true;
        PageChanged?.Invoke(this, _history.Peek());
    }

    public void GoHome(Control homePage)
    {
        _history.Clear();
        Navigate(homePage);
    }

    // Silently resets the history to homePage without showing it or firing PageChanged.
    // Use before sidebar navigations so Back can never cross flow boundaries.
    public void RestartFrom(Control homePage)
    {
        _history.Clear();
        _history.Push(homePage);
    }

    // Removes the current page from history without changing the UI or firing PageChanged.
    // Use when an intermediate page (e.g. file picker) hands off to the real destination —
    // the next Navigate call will show the destination directly, skipping the intermediate.
    public void DropCurrent()
    {
        if (_history.Count > 1)
            _history.Pop();
    }

    private void HideAll()
    {
        foreach (var p in _allPages) p.Visible = false;
    }
}
