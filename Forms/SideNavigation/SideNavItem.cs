using System.ComponentModel;

namespace SIF.Utils.Forms.SideNavigation;


public delegate void NavEventHandler(SideNavItem sender, EventArgs e);

public class SideNavItem : UserControl
{
    private static readonly Color NormalColor   = Color.FromArgb(30, 40, 51);
    private static readonly Color HoverColor    = Color.FromArgb(50, 60, 75);
    private static readonly Color SelectedColor = Color.FromArgb(0, 120, 212);

    private readonly Label _iconLabel;
    private readonly string _text;
    private readonly Font _textFont = new Font("Segoe UI", 10f);
    private bool _hovered;
    private bool _selected;

    public event NavEventHandler NavItemClicked;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsSelected
    {
        get => _selected;
        set { _selected = value; UpdateBackColor(); }
    }

    public SideNavItem(string iconChar, string text)
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        Height = 48;
        BackColor = NormalColor;
        Cursor = Cursors.Hand;
        _text = text;

        _iconLabel = new Label
        {
            Text = iconChar,
            Dock = DockStyle.Left,
            Width = 50,
            Font = new Font("Segoe MDL2 Assets", 14f),
            ForeColor = Color.White,
            BackColor = Color.Transparent,
            TextAlign = ContentAlignment.MiddleCenter,
        };

        Controls.Add(_iconLabel);
        SubscribeHover(this);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        const int textX = 54;
        int textW = Width - textX - 2;
        if (textW <= 0) return;

        using var brush = new SolidBrush(Color.White);
        using var fmt = new StringFormat
        {
            LineAlignment = StringAlignment.Center,
            Alignment = StringAlignment.Near,
            FormatFlags = StringFormatFlags.NoWrap,
            Trimming = StringTrimming.None,
        };
        e.Graphics.DrawString(_text, _textFont, brush, new RectangleF(textX, 0, textW, Height), fmt);
    }

    private void SubscribeHover(Control control)
    {
        control.MouseEnter += OnAnyMouseEnter;
        control.MouseLeave += OnAnyMouseLeave;
        control.Click      += OnAnyClick;

        foreach (Control c in control.Controls)
            SubscribeHover(c);
    }

    private void OnAnyMouseEnter(object? sender, EventArgs e)
    {
        if (_hovered) return;
        _hovered = true;
        UpdateBackColor();
    }

    private void OnAnyMouseLeave(object? sender, EventArgs e)
    {
        if (!_hovered) return;
        if (ClientRectangle.Contains(PointToClient(MousePosition))) return;
        _hovered = false;
        UpdateBackColor();
    }

    private void OnAnyClick(object? sender, EventArgs e)
    {
        NavItemClicked?.Invoke(this, EventArgs.Empty);
    }

    private void UpdateBackColor()
    {
        if (_hovered)
        {
            BackColor = _selected ? SelectedColor : HoverColor;
        }
        else
        {
            BackColor = _selected ? SelectedColor : NormalColor;
        }
    }
}
