using SIF.Utils.Helpers;
using SIF.Utils.Logic.JsonParser;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.Variables
{
    public partial class VariablesForm : UserControl
    {
        public VariablesForm()
        {
            InitializeComponent();
        }

        public void Clear() => parametersDataGrid.Rows.Clear();

        public void LoadFromModels(IEnumerable<SifJsonVariableModel> models)
        {
            foreach (var model in models)
                parametersDataGrid.Rows.Add(model.Name, model.Value);
        }

        public bool HasVariables()
        {
            return this.parametersDataGrid.Rows.Count > 1;
        }

        public JsonObject GetJson()
        {
            JsonObject json = new JsonObject();
            foreach (DataGridViewRow parameter in this.parametersDataGrid.Rows)
            {
                var prop = parameter.Cells[0].Value?.ToString() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(prop))
                {
                    continue;
                }

                json[prop] = (parameter.Cells[1].Value?.ToString() ?? string.Empty).ParseConfigVariable();
            }
            return json;
        }
    }
}
