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
            {
                return "Last opened: Just now";
            }

            if (timeSpan.TotalMinutes < 60)
            {
                var floor = (int)Math.Floor(timeSpan.TotalMinutes);

                if (floor == 1)
                {
                    return "Last opened: 1 minute ago";
                }

                return $"Last opened: {floor} minute ago";
            }

            if (timeSpan.TotalHours < 24)
            {
                var floor = (int)Math.Floor(timeSpan.TotalHours);

                if (floor == 1)
                {
                    return "Last opened: 1 hour ago";
                }

                return $"Last opened: {floor} hours ago";
            }

            if (timeSpan.TotalDays < 7)
            {
                var floor = (int)Math.Floor(timeSpan.TotalDays);
                if (floor == 1)
                {
                    return "Last opened: 1 day ago";
                }
                return $"Last opened: {floor} days ago";
            }

            if (timeSpan.TotalDays < 30)
            {
                var floor = (int)Math.Floor(timeSpan.TotalDays / 7);
                if (floor == 1)
                {
                    return "Last opened: 1 week ago";
                }
                return $"Last opened: {floor} weeks ago";
            }

            if (timeSpan.TotalDays < 365)
            {
                var floor = (int)Math.Floor(timeSpan.TotalDays / 30);
                if (floor == 1)
                {
                    return "Last opened: 1 month ago";
                }
                return $"Last opened: {floor} months ago";
            }

            var years = (int)Math.Floor(timeSpan.TotalDays / 365);
            if (years == 1)
            {
                return "Last opened: 1 year ago";
            }

            return $"Last opened: {years} years ago";
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
