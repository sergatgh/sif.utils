namespace SIF.Utils.Forms.JsonViewer.Tasks
{
    using SIF.Utils.Forms.Common;
    using SIF.Utils.JsonParser;
    using System.ComponentModel;
    using JsonViewer = SIF.Utils.JsonViewer;

    public partial class TasksList : UserControl
    {
        private IList<SifJsonTaskModel> _tasks = [];

        [Browsable(true)]
        public event ResultEventHandler<SifJsonTaskModel[]>? OnExecuteTasks;

        public TasksList()
        {
            InitializeComponent();
        }

        public void LoadTasks(IList<SifJsonTaskModel> tasks)
        {
            this.Clear();
            this._tasks = tasks;
            tasksViewer.Items.AddRange(GetGroupItems(_tasks).ToArray());

            AutoResizeColumns();
        }

        public void AutoResizeColumns()
        {
            tasksViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            if (_tasks.Any(x => x.Name.Length > 4))
            {
                tasksViewer.AutoResizeColumn(tasksViewer.Columns["Name"]?.Index ?? 0, ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            if (_tasks.Any(x => x.Description?.Length > 11))
            {
                tasksViewer.AutoResizeColumn(tasksViewer.Columns["Description"]?.Index ?? 0, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        public void Clear()
        {
            this._tasks = [];
            this.filterText.Text = string.Empty;
            this.tasksViewer.Items.Clear();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var menu = menuItem?.Owner as ContextMenuStrip;

            if (menu?.SourceControl is not ListView list || list.SelectedItems.Count != 1) return;

            var item = list.SelectedItems[0];
            var taskName = item.Text;

            var task = _tasks.FirstOrDefault(t => t.Name == taskName);

            if (task == null) return;

            using var detailsForm = new JsonViewer(task.Name, task.Element.Value);
            detailsForm.ShowDialog();
        }

        private void copyTaskName_Click(object sender, EventArgs e)
        {
            var menuItem = (sender as ToolStripMenuItem)?.Owner as ToolStripDropDownMenu;
            var menu = menuItem?.OwnerItem?.Owner as ContextMenuStrip;

            if (menu?.SourceControl is not ListView list || list.SelectedItems.Count != 1) return;

            var item = list.SelectedItems[0];
            var taskName = item.Text;
            Clipboard.SetText(taskName);
        }

        private void tasksViewer_DoubleClick(object sender, EventArgs e)
        {
            var list = sender as ListView;
            if (list?.SelectedIndices.Count != 1) return;

            var task = _tasks[list.SelectedIndices[0]];

            using var detailsForm = new JsonViewer(task.Name, task.Element.Value);
            detailsForm.ShowDialog();
        }

        private void copyTaskDescription_Click(object sender, EventArgs e)
        {
            var menuItem = (sender as ToolStripMenuItem)?.Owner as ToolStripDropDownMenu;
            var menu = (menuItem?.OwnerItem)?.Owner as ContextMenuStrip;

            if (menu?.SourceControl is not ListView list || list.SelectedItems.Count != 1) return;

            var item = list.SelectedItems[0];
            var description = item.SubItems[1];
            Clipboard.SetText(description.Text);
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var menu = menuItem?.Owner as ContextMenuStrip;

            if (menu?.SourceControl is not ListView list) return;

            OnExecuteTasks?.Invoke(this, list.SelectedIndices.Cast<int>().Select(x => _tasks[x]).ToArray());
        }

        private void TasksContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (sender is not ContextMenuStrip menu)
            {
                e.Cancel = true;
                return;
            }

            if (menu.SourceControl is not ListView list)
            {
                e.Cancel = true;
                return;
            }

            if (list.SelectedItems.Count == 1)
            {
                viewToolStripMenuItem.Visible = true;
                copyToolStripMenuItem.Visible = true;
            }
            else
            {
                viewToolStripMenuItem.Visible = false;
                copyToolStripMenuItem.Visible = false;
            }
        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            var text = this.filterText.Text.Trim().ToLower();

            tasksViewer.Items.Clear();
            var tasks = string.IsNullOrWhiteSpace(text)
                ? _tasks
                : _tasks.Where(x =>
                    x.Name.ToLower().Contains(text) ||
                    (x.Description?.ToLower().Contains(text) ?? false));

            var listItems = GetGroupItems(
                tasks
            );

            tasksViewer.Items.AddRange(listItems);
        }

        public ListViewItem[] GetGroupItems(IEnumerable<SifJsonTaskModel> props)
        {
            return props.Select(task => new ListViewItem([
                    task.Name,
                    task.Description ?? string.Empty]))
                .ToArray();
        }

        private void tasksViewer_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Handled) return;

            if (e is { KeyCode: Keys.C, Control: true })
            {
                if (sender is not ListView list) return;

                var data = string.Join(Environment.NewLine, list.SelectedIndices.Cast<int>().Select(i => _tasks[i].Name + "\t" + _tasks[i].Description));

                Clipboard.SetText(data);
                return;
            }

            if (e.KeyCode is >= Keys.A and <= Keys.Z)
            {
                filterText.Text = e.KeyCode.ToString();
                filterText.Focus();
                filterText.SelectionStart = filterText.Text.Length;
                filterText.SelectionLength = 0;
            }

            if (e.KeyCode is Keys.Enter or Keys.F3)
            {
                if (sender is not ListView list || list.SelectedIndices.Count != 1) return;

                var task = _tasks[list.SelectedIndices[0]];

                using var detailsForm = new JsonViewer(task.Name, task.Element.Value);
                detailsForm.ShowDialog();
            }
        }

        private void filterText_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (tasksViewer.Items.Count > 0)
                {
                    tasksViewer.SelectedIndices.Clear();
                    tasksViewer.AutoScrollOffset = new Point(0, 0);
                    tasksViewer.Items[0].Selected = true;
                    tasksViewer.Focus();
                }
            }
        }
    }
}
