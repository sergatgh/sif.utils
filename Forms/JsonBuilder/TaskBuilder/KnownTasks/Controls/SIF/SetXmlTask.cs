using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class SetXmlTask : AdvancedTask
    {
        public SetXmlTask()
        {
            InitializeComponent();
        }
        public override TaskEditor TaskEditor => taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                {"FilePath", filePathInput.TextInput },
                { "XPath", xPathInput.TextInput },
            };

            if (!string.IsNullOrWhiteSpace(elementText.TextInput))
            {
                dict.Add("Element", elementText.TextInput);
            }

            if (!string.IsNullOrWhiteSpace(valueInput.TextInput))
            {
                dict.Add("Value", valueInput.TextInput);
            }

            if (parametersDataGrid.Rows.Count > 1)
            {
                var parameters = new JsonObject();
                foreach (DataGridViewRow row in parametersDataGrid.Rows)
                {
                    if (row.IsNewRow) continue;
                    var keyCell = row.Cells[0].Value?.ToString() ?? string.Empty;
                    var valueCell = row.Cells[1].Value?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(keyCell))
                    {
                        parameters[keyCell] = valueCell;
                    }
                }
                dict["Attributes"] = parameters;
            }

            // Add additional properties related to AppPoolTask here
            return dict;
        }
    }
}
