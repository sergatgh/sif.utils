using SIF.Utils.Logic.JsonParser;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.Parameters
{
    public partial class ParametersForm : UserControl
    {
        public ParametersForm()
        {
            InitializeComponent();
        }

        public void Clear() => parametersDataGrid.Rows.Clear();

        public void LoadFromModels(IEnumerable<SifJsonParameterModel> models)
        {
            foreach (var model in models)
                parametersDataGrid.Rows.Add(model.Name);
        }

        public bool HasParameters()
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

                json[prop] = new JsonObject 
                {
                    ["Type"] = "string",
                };
            }
            return json;
        }
    }
}
