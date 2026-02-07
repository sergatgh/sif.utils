using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SIF.Utils.Forms.Home
{
    public partial class FeatureCardControl : UserControl
    {
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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public FeatureCardControl()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            subscribeToMouseDown(this);
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
            CardClick?.Invoke(this, e);
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(249, 250, 251);
            Cursor = Cursors.Hand;
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(238, 246, 255);
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.BackColor = tableLayoutPanel1.ClientRectangle.Contains(e.Location) ? Color.FromArgb(249, 250, 251) : Color.White;
        }
    }
}
