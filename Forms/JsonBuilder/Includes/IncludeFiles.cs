using SIF.Utils.Helpers;
using SIF.Utils.Logic.JsonParser;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace SIF.Utils.Forms.JsonBuilder.Includes
{
    public partial class IncludeFiles : UserControl
    {
        public IncludeFiles()
        {
            InitializeComponent();
        }

        public void Clear() => listView1.Items.Clear();

        public void LoadFromModels(IEnumerable<SifJsonIncludeModel> models)
        {
            foreach (var model in models)
            {
                var path = model.FullPath ?? model.OriginalValue;
                if (!string.IsNullOrWhiteSpace(path))
                {
                    AddItem(path, model.Name);
                }
            }
        }

        public int Count => listView1.Items.Count;

        public JsonObject GetJson(string? jsonPath = null)
        {
            var jsonObject = new JsonObject();
            foreach (ListViewItem item in listView1.Items)
            {
                var path = item.Text;
                var relativePath = useRelativePathMenu.Checked && jsonPath != null
                    ? Path.GetRelativePath(Path.GetDirectoryName(jsonPath) ?? string.Empty, path)
                    : path;

                var alias = item.SubItems[1].Text;
                var baseName = !string.IsNullOrWhiteSpace(alias) ? alias : GetEasyNameNameFromFile(path);
                var name = baseName;
                int suffix = 1;
                while (jsonObject.ContainsKey(name))
                {
                    name = $"{baseName}_{suffix++}";
                }

                jsonObject.Add(name, new JsonObject { ["Source"] = relativePath });
            }
            return jsonObject;
        }

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "SIF JSON|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in dialog.FileNames)
                {
                    if (listView1.Items.Cast<ListViewItem>().Any(i => i.Text.Equals(file, StringComparison.OrdinalIgnoreCase)))
                    {
                        continue;
                    }

                    AddItem(file, string.Empty);
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lastSelectedIndex = listView1.SelectedIndices[0];
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }

            if (listView1.Items.Count > 0)
            {
                var newIndex = Math.Min(lastSelectedIndex, listView1.Items.Count - 1);
                listView1.Items[newIndex].Selected = true;
            }
        }

        private void editAliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1) return;
            var item = listView1.SelectedItems[0];
            using var dialog = new IncludeAliasDialog(item.Text, item.SubItems[1].Text);
            if (dialog.ShowDialog() != DialogResult.OK) return;

            item.Text = dialog.FilePath;
            item.SubItems[1].Text = dialog.Alias;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeToolStripMenuItem.Enabled = listView1.SelectedItems.Count > 0;
            editAliasToolStripMenuItem.Enabled = listView1.SelectedItems.Count == 1;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                editAliasToolStripMenuItem_Click(sender, e);
            }
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Move);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data?.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)) == true
                ? DragDropEffects.Move
                : DragDropEffects.None;
        }

        private void listView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.Data?.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)) == true
                ? DragDropEffects.Move
                : DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data?.GetData(typeof(ListView.SelectedListViewItemCollection)) is not ListView.SelectedListViewItemCollection selection)
            {
                return;
            }

            var draggedItems = selection.Cast<ListViewItem>().ToList();
            if (draggedItems.Count == 0) return;

            var clientPoint = listView1.PointToClient(new Point(e.X, e.Y));
            var targetItem = listView1.GetItemAt(clientPoint.X, clientPoint.Y);
            var insertAfter = targetItem == null || clientPoint.Y > targetItem.Bounds.Top + targetItem.Bounds.Height / 2;

            var anchorItem = targetItem != null && !draggedItems.Contains(targetItem) ? targetItem : null;

            foreach (var item in draggedItems)
            {
                listView1.Items.Remove(item);
            }

            var insertIndex = anchorItem != null ? anchorItem.Index + (insertAfter ? 1 : 0) : listView1.Items.Count;
            insertIndex = Math.Max(0, Math.Min(insertIndex, listView1.Items.Count));

            for (int i = 0; i < draggedItems.Count; i++)
            {
                listView1.Items.Insert(insertIndex + i, draggedItems[i]);
            }

            foreach (var item in draggedItems)
            {
                item.Selected = true;
            }
        }

        private void AddItem(string path, string alias)
        {
            var item = new ListViewItem(path);
            item.SubItems.Add(alias ?? string.Empty);
            listView1.Items.Add(item);
        }

        protected string GetEasyNameNameFromFile(string path)
        {
            var fileName = Path.GetFileNameWithoutExtension(path);
            var name = Regex.Replace(fileName, "[^a-zA-Z0-9]", "").Or(fileName);
            name = char.ToUpper(name[0]) + name[1..];
            return name;
        }
    }
}
