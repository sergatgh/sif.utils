using SIF.Utils.Logic.JsonParser;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.Parameters
{
    public partial class ParametersForm : UserControl
    {
        private readonly List<SifJsonParameterModel> _parameters = [];
        private List<SifJsonIncludeModel> _includes = [];

        public ParametersForm()
        {
            InitializeComponent();
        }

        public void SetIncludes(IEnumerable<SifJsonIncludeModel> includes)
        {
            _includes = includes.ToList();
        }

        public void Clear()
        {
            _parameters.Clear();
            listView1.Items.Clear();
        }

        public void LoadFromModels(IEnumerable<SifJsonParameterModel> models)
        {
            foreach (var model in models)
            {
                _parameters.Add(model);
                AddListItem(model);
            }
        }

        public bool HasParameters() => _parameters.Count > 0;

        public JsonObject GetJson()
        {
            var json = new JsonObject();
            foreach (var param in _parameters)
            {
                if (string.IsNullOrWhiteSpace(param.Name)) continue;
                var paramJson = new JsonObject
                {
                    ["Type"] = param.Type ?? "String"
                };
                if (!string.IsNullOrEmpty(param.DefaultValue)) paramJson["DefaultValue"] = param.DefaultValue;
                if (!string.IsNullOrEmpty(param.Reference)) paramJson["Reference"] = param.Reference;
                if (!string.IsNullOrEmpty(param.Validate)) paramJson["Validate"] = param.Validate;
                if (!string.IsNullOrEmpty(param.Description)) paramJson["Description"] = param.Description;
                json[param.Name] = paramJson;
            }
            return json;
        }

        private void AddListItem(SifJsonParameterModel model)
        {
            var item = new ListViewItem(model.Name);
            item.SubItems.Add(model.Type ?? "String");
            listView1.Items.Add(item);
        }

        private IEnumerable<string> GetParamNames(int excludeIndex = -1) =>
            _parameters.Where((_, i) => i != excludeIndex).Select(p => p.Name);

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new ParameterEditDialog(GetParamNames(), _includes);
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var model = dialog.GetModel();
            _parameters.Add(model);
            AddListItem(model);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 1) return;
            var index = listView1.SelectedIndices[0];
            using var dialog = new ParameterEditDialog(GetParamNames(index), _includes);
            dialog.SetModel(_parameters[index]);
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var updated = dialog.GetModel();
            _parameters[index] = updated;
            listView1.Items[index].Text = updated.Name;
            listView1.Items[index].SubItems[1].Text = updated.Type ?? "String";
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 1) return;
            var index = listView1.SelectedIndices[0];
            _parameters.RemoveAt(index);
            listView1.Items.RemoveAt(index);
            if (listView1.Items.Count > 0)
            {
                var newIndex = Math.Min(index, listView1.Items.Count - 1);
                listView1.Items[newIndex].Selected = true;
            }
            else
            {
                UpdateButtonStates(false);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates(listView1.SelectedItems.Count > 0);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                editToolStripMenuItem_Click(sender, e);
        }

        private void UpdateButtonStates(bool hasSelection)
        {
            editToolStripMenuItem.Enabled = hasSelection;
            removeToolStripMenuItem.Enabled = hasSelection;
        }
    }
}
