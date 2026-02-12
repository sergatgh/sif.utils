namespace SIF.Utils.Forms.SelectFile
{
    public partial class RecentFileCard : UserControl
    {
        private bool _hovered;
        public event EventHandler? CardClick;

        public RecentFileCard()
        {
            InitializeComponent();
            subscribeToMouseEvents(this);
        }

        public RecentFileCard(string filePath, DateTime lastOpened) : this()
        {
            SetFilePath(filePath, lastOpened);
        }

        public void SetFilePath(string filePath, DateTime lastOpened)
        {
            filePathLabel.Text = Path.GetDirectoryName(filePath);
            fileNameLabel.Text = Path.GetFileName(filePath);
            lastOpenedLabel.Text = GetLastOpenedText(lastOpened);
        }

        public string GetLastOpenedText(DateTime lastOpened)
        {
            var timeSpan = DateTime.Now - lastOpened;
            if (timeSpan.TotalSeconds < 60)
                return "Last opened: Just now";

            if (timeSpan.TotalMinutes < 60)
                return $"Last opened: {Math.Floor(timeSpan.TotalMinutes)} minute(s) ago";

            if (timeSpan.TotalHours < 24)
                return $"Last opened: {Math.Floor(timeSpan.TotalHours)} hour(s) ago";

            if (timeSpan.TotalDays < 7)
                return $"Last opened: {Math.Floor(timeSpan.TotalDays)} day(s) ago";

            if (timeSpan.TotalDays < 30)
                return $"Last opened: {Math.Floor(timeSpan.TotalDays / 7)} week(s) ago";

            if (timeSpan.TotalDays < 365)
                return $"Last opened: {Math.Floor(timeSpan.TotalDays / 30)} month(s) ago";

            return $"Last opened: {Math.Floor(timeSpan.TotalDays / 365)} year(s) ago";
        }

        public void subscribeToMouseEvents(Control control)
        {
            control.MouseEnter += Card_MouseEnter;
            control.MouseLeave += Card_MouseLeave;
            control.MouseDown += Card_MouseDown;
            control.MouseUp += Card_MouseUp;
            control.Click += Control_Click;

            foreach (Control c in control.Controls)
            {
                subscribeToMouseEvents(c);
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
            BackColor = Color.FromArgb(241, 245, 249);
        }

        private void DrawDefaultState()
        {
            BackColor = Color.Transparent;
        }
    }
}
