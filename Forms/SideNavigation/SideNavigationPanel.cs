namespace SIF.Utils.Forms.SideNavigation;

public class SideNavigationPanel : UserControl, IMessageFilter
{
    private const int CollapsedWidth = 50;
    private const int ExpandedWidth  = 210;
    private const int TimerInterval  = 10;
    private const int WM_SETREDRAW   = 11;

    private static readonly Color PanelBg     = Color.FromArgb(30, 40, 51);
    private static readonly Color HeaderBg    = Color.FromArgb(22, 32, 43);
    private static readonly Color BorderColor = Color.FromArgb(15, 25, 35);

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern System.IntPtr SendMessage(System.IntPtr hWnd, int msg, System.IntPtr wParam, System.IntPtr lParam);

    private sealed class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel() => DoubleBuffered = true;
    }

    private readonly System.Windows.Forms.Timer _timer;
    private readonly List<SideNavItem> _items = [];
    private readonly DoubleBufferedPanel _headerPanel;
    private readonly Font _headerFont = new("Segoe UI", 12f, FontStyle.Bold);
    private readonly DoubleBufferedPanel _itemsPanel;

    private int _targetWidth = ExpandedWidth;
    private bool _isOnHome   = true;
    private bool _isAnchored;

    public event EventHandler? HomeClicked;
    public event EventHandler? ViewJsonClicked;
    public event EventHandler? RunScriptClicked;
    public event EventHandler? SifBuilderClicked;
    public event EventHandler? LearnSifClicked;
    public event EventHandler? AboutClicked;

    public SideNavigationPanel()
    {
        SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        BackColor = PanelBg;
        Width = ExpandedWidth;
        Padding = Padding.Empty;

        _timer = new System.Windows.Forms.Timer { Interval = TimerInterval };
        _timer.Tick += OnTimerTick;

        _headerPanel = new DoubleBufferedPanel
        {
            Dock      = DockStyle.Top,
            Height    = 60,
            BackColor = HeaderBg,
        };
        _headerPanel.Paint  += OnHeaderPanelPaint;
        _headerPanel.Resize += (_, _) => _headerPanel.Invalidate();

        var headerIcon = new Label
        {
            Text      = "",
            Dock      = DockStyle.Left,
            Width     = 50,
            Font      = new Font("Segoe MDL2 Assets", 18f),
            ForeColor = Color.White,
            BackColor = Color.Transparent,
            TextAlign = ContentAlignment.MiddleCenter,
        };

        _headerPanel.Controls.Add(headerIcon);

        _itemsPanel = new DoubleBufferedPanel
        {
            Dock      = DockStyle.Fill,
            BackColor = PanelBg,
        };

        Controls.Add(_itemsPanel);
        Controls.Add(_headerPanel);

        BuildItems();
    }

    private void OnHeaderPanelPaint(object? sender, PaintEventArgs e)
    {
        const int textX = 54;
        int textW = _headerPanel.Width - textX - 4;
        if (textW <= 0) return;

        using var brush = new SolidBrush(Color.White);
        using var fmt = new StringFormat
        {
            LineAlignment = StringAlignment.Center,
            Alignment     = StringAlignment.Near,
            FormatFlags   = StringFormatFlags.NoWrap,
            Trimming      = StringTrimming.None,
        };
        e.Graphics.DrawString("SIF Utils", _headerFont, brush,
            new RectangleF(textX, 0, textW, _headerPanel.Height), fmt);
    }

    private void BuildItems()
    {
        (string Icon, string Text, Action Click)[] topItems =
        [
            ("", "Home",        () => HomeClicked?.Invoke(this, EventArgs.Empty)),
            ("", "View JSON",   () => ViewJsonClicked?.Invoke(this, EventArgs.Empty)),
            ("", "Run Script",  () => RunScriptClicked?.Invoke(this, EventArgs.Empty)),
            ("", "SIF Builder", () => SifBuilderClicked?.Invoke(this, EventArgs.Empty)),
        ];

        (string Icon, string Text, Action<SideNavItem, EventArgs> Click)[] bottomItems =
        [
            ("", "Keep open", (o,_) => OnAnchorItemClicked(o, EventArgs.Empty)),
            ("", "About",       (o,_) => { o.IsSelected = false; AboutClicked?.Invoke(this, EventArgs.Empty); }),
            ("", "Learn SIF",   (o,_) => { o.IsSelected = false; LearnSifClicked?.Invoke(this, EventArgs.Empty); }),
        ];

        foreach (var (icon, text, click) in topItems)
        {
            var item = new SideNavItem(icon, text) { Dock = DockStyle.Top };
            var capturedItem = item;
            item.NavItemClicked += (_, _) => { click(); SetSelectedItem(capturedItem); };
            _items.Add(item);
        }

        List<SideNavItem?> bottomItemsList = [];
        foreach (var (icon, text, click) in bottomItems)
        {
            var item = new SideNavItem(icon, text) { Dock = DockStyle.Bottom };
            item.NavItemClicked += (sender, args) => { click(sender, args); };
            bottomItemsList.Add(item);
        }

        foreach (var item in Enumerable.Reverse(_items.Concat(bottomItemsList)))
            _itemsPanel.Controls.Add(item);
    }

    public void SetHomePage(bool onHome)
    {
        _isOnHome = onHome;
        if (onHome)
        {
            _timer.Stop();
            Width        = ExpandedWidth;
            _targetWidth = ExpandedWidth;
        }
        else if (!_isAnchored)
        {
            AnimateTo(CollapsedWidth);
        }
    }

    public void SetSelectedIndex(int index)
    {
        for (int i = 0; i < _items.Count; i++)
            _items[i].IsSelected = i == index;
    }

    private void SetSelectedItem(SideNavItem item)
    {
        foreach (var i in _items) i.IsSelected = false;
        item.IsSelected = true;
    }

    private void AnimateTo(int targetWidth)
    {
        _targetWidth = targetWidth;
        _timer.Start();
    }

    private void OnTimerTick(object? sender, EventArgs e)
    {
        var parent = Parent;
        bool freeze = parent?.IsHandleCreated == true;

        if (freeze)
            SendMessage(parent!.Handle, WM_SETREDRAW, System.IntPtr.Zero, System.IntPtr.Zero);

        int diff = _targetWidth - Width;
        if (Math.Abs(diff) <= 2)
        {
            Width = _targetWidth;
            _timer.Stop();
        }
        else
        {
            Width += diff > 0 ? Math.Max(2, diff / 4) : Math.Min(-2, diff / 4);
        }

        if (freeze)
        {
            SendMessage(parent!.Handle, WM_SETREDRAW, new System.IntPtr(1), System.IntPtr.Zero);
            parent!.Invalidate(true);
        }
    }

    private void OnAnchorItemClicked(SideNavItem sender, EventArgs e)
    {
        _isAnchored = !_isAnchored;
        sender.IsSelected = _isAnchored;

        if (!_isAnchored && !_isOnHome)
        {
            var pt = PointToClient(Cursor.Position);
            if (!ClientRectangle.Contains(pt))
                AnimateTo(CollapsedWidth);
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        Application.AddMessageFilter(this);
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
        Application.RemoveMessageFilter(this);
        base.OnHandleDestroyed(e);
    }

    public bool PreFilterMessage(ref Message m)
    {
        if (m.Msg == 0x0200 /* WM_MOUSEMOVE */ && !_isOnHome && !_isAnchored && IsHandleCreated && !IsDisposed && Visible)
        {
            var pt = PointToClient(Cursor.Position);
            bool inside = ClientRectangle.Contains(pt);

            if (inside && _targetWidth != ExpandedWidth)
                AnimateTo(ExpandedWidth);
            else if (!inside && _targetWidth != CollapsedWidth)
                AnimateTo(CollapsedWidth);
        }
        return false;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using var pen = new Pen(BorderColor, 1);
        e.Graphics.DrawLine(pen, Width - 1, 0, Width - 1, Height);
    }
}