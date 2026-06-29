namespace SIF.Utils.Forms.JsonBuilder.SectionOrder
{
    public partial class SectionOrderPanel : UserControl
    {
        private static readonly string[] DefaultOrder =
            ["Tasks", "Parameters", "Variables", "UninstallTasks", "Modules", "Includes", "Register", "Settings"];

        private int _dragIndex = -1;

        public SectionOrderPanel()
        {
            InitializeComponent();
            ResetToDefault();
        }

        public List<string> GetSectionOrder() => listBox1.Items.Cast<string>().ToList();

        public void ApplySectionOrder(IEnumerable<string> order)
        {
            var knownSet = new HashSet<string>(DefaultOrder, StringComparer.OrdinalIgnoreCase);
            var ordered = order.Where(k => knownSet.Contains(k)).ToList();
            var remaining = DefaultOrder.Where(k => !ordered.Contains(k, StringComparer.OrdinalIgnoreCase));

            listBox1.Items.Clear();
            foreach (var key in ordered.Concat(remaining))
                listBox1.Items.Add(key);
        }

        private void ResetToDefault()
        {
            listBox1.Items.Clear();
            foreach (var key in DefaultOrder)
                listBox1.Items.Add(key);
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            int idx = listBox1.SelectedIndex;
            moveUpButton.Enabled = idx > 0;
            moveDownButton.Enabled = idx >= 0 && idx < listBox1.Items.Count - 1;
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            if (idx <= 0) return;
            var item = listBox1.Items[idx];
            listBox1.Items.RemoveAt(idx);
            listBox1.Items.Insert(idx - 1, item);
            listBox1.SelectedIndex = idx - 1;
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= listBox1.Items.Count - 1) return;
            var item = listBox1.Items[idx];
            listBox1.Items.RemoveAt(idx);
            listBox1.Items.Insert(idx + 1, item);
            listBox1.SelectedIndex = idx + 1;
        }

        private void resetButton_Click(object sender, EventArgs e) => ResetToDefault();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => UpdateButtons();

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragIndex = listBox1.IndexFromPoint(e.X, e.Y);
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || _dragIndex < 0) return;
            listBox1.DoDragDrop(listBox1.Items[_dragIndex], DragDropEffects.Move);
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e) => _dragIndex = -1;

        private void listBox1_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Move;

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            var pt = listBox1.PointToClient(new Point(e.X, e.Y));
            int dropIndex = listBox1.IndexFromPoint(pt);
            if (dropIndex < 0) dropIndex = listBox1.Items.Count - 1;

            if (_dragIndex >= 0 && dropIndex != _dragIndex)
            {
                var item = listBox1.Items[_dragIndex];
                listBox1.Items.RemoveAt(_dragIndex);
                listBox1.Items.Insert(dropIndex, item);
                listBox1.SelectedIndex = dropIndex;
            }
            _dragIndex = -1;
        }
    }
}
