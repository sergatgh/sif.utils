using System.ComponentModel;

namespace SIF.Utils.Forms.SecondaryNavigation
{
    public partial class SecondaryNavigationMenuItem : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get => label1.Text; set => label1.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image? Image { get => this.pictureBox1.Image; set => this.pictureBox1.Image = value; }

        public event EventHandler? CardClick;

        private bool _hovered;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Selected { get; set; }

        public SecondaryNavigationMenuItem()
        {
            InitializeComponent();

            subscribeToMouseDown(this);
        }

        public void LoadFrom(LinkModel linkModel)
        {
            Image = linkModel.Image;
            Text = linkModel.Text;
            this.CardClick += linkModel.Click;
        }

        public void Unselect()
        {
            Selected = false;
            DrawDefaultState();
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

        public void Control_Click(object? sender, EventArgs e)
        {
            CardClick?.Invoke(this, e);
            _hovered = false;
            Selected = true;
            BackColor = Color.FromArgb(217, 230, 242);
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
            BackColor = Color.FromArgb(217, 230, 242);
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
            if (Selected) return;
            label1.ForeColor = Color.FromArgb(47, 62, 78);
            BackColor = Color.FromArgb(230, 230, 230);
        }

        private void DrawDefaultState()
        {
            if (Selected) return;
            ForeColor = Color.FromArgb(59, 74, 89);
            BackColor = Color.Transparent;
        }
    }
}
