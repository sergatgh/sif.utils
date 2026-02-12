using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace SIF.Utils.Forms.Home
{
    public partial class FeatureCardControl : UserControl
    {
        protected Color BorderColor { get; set; } = Color.FromArgb(229, 231, 235);

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Radius { get; set; } = 10;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title { get => this.titleLabel.Text; set => this.titleLabel.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Description { get => this.descriptionLabel.Text; set => this.descriptionLabel.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image? Image { get => this.imageBox.Image; set => this.imageBox.Image = value; }

        public event EventHandler? CardClick;

        private bool _hovered;

        public FeatureCardControl()
        {
            InitializeComponent();
            subscribeToMouseDown(this);
            SetStyle(ControlStyles.ResizeRedraw, true);
            UpdateRegion();
        }

        private void FeatureCardControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using var path = CreateRoundedRectPath(rect, Radius);
            using var pen = new Pen(BorderColor, 2);

            e.Graphics.DrawPath(pen, path);
        }

        private void FeatureCardControl_Resize(object sender, EventArgs e)
        {
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            var path = CreateRoundedRectPath(ClientRectangle, Radius);

            Region?.Dispose();
            Region = new Region(path);

            Invalidate();
        }

        private GraphicsPath CreateRoundedRectPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();

            path.AddArc(rect.Left, rect.Top, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Top, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();

            return path;
        }

        public void subscribeToMouseDown(Control control)
        {
            control.MouseEnter += Card_MouseEnter;
            control.MouseLeave += Card_MouseLeave;
            control.MouseDown += Card_MouseDown;
            control.MouseUp += Card_MouseUp;
            control.Click += Control_Click;

            foreach (Control c in control.Controls)
            {
                subscribeToMouseDown(c);
            }
        }

        private void Control_Click(object? sender, EventArgs e)
        {
            _hovered = false;
            CardClick?.Invoke(this, e);
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            if (_hovered) return;
            _hovered = true;

            DrawHoveredState();
            Cursor = Cursors.Hand;
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            if (!_hovered) return;

            var pos = PointToClient(MousePosition);
            var inArea = ClientRectangle.Contains(pos);

            if (inArea) return;
            _hovered = false;

            DrawDefaultState();
            Cursor = Cursors.Default;
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            BorderColor = Color.FromArgb(0, 120, 212);
            BackColor = Color.FromArgb(238, 246, 255);
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            if (_hovered)
            {
                DrawHoveredState();
            }
            else
            {
                DrawDefaultState();
            }
        }

        private void DrawHoveredState()
        {
            BorderColor = Color.FromArgb(0, 120, 212);
            BackColor = Color.FromArgb(249, 250, 251);
        }

        private void DrawDefaultState()
        {
            BorderColor = Color.FromArgb(229, 231, 235);
            BackColor = Color.White;
        }
    }
}
