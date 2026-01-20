using SIF.Utils.Helpers;
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
                jsonObject.Add(GetName(path), new JsonObject { ["Source"] = relativePath });
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

                    listView1.Items.Add(file);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeToolStripMenuItem.Enabled = listView1.SelectedItems.Count > 0;
        }

        protected string GetName(string path)
        {
            var fileName = Path.GetFileNameWithoutExtension(path);
            var name = Regex.Replace(fileName, "[^a-zA-Z0-9]", "").Or(fileName);
            name = char.ToUpper(name[0]) + name[1..];
            return name;
        }
    }
}
