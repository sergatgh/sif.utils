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
    public partial class HttpRequestTask : AdvancedTask
    {
        public override TaskEditor TaskEditor => taskEditor1;

        public HttpRequestTask()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            statusNumber.Enabled = checkBox1.Checked;
        }

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                { "Uri", hostNameText.TextInput },
            };

            if (contentTypeText.HasText)
            {
                dict.Add("ContentType", contentTypeText.TextInput);
            }

            if (actionText.Text.Length > 0)
            {
                dict.Add("Action", actionText.Text);
            }

            if (checkBox1.Checked)
            {
                dict.Add("ExpectedStatusCode", statusNumber.Value);
            }

            if (parametersDataGrid.Rows.Count > 0)
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
                dict.Add("Parameters", parameters);
            }

            return dict;
        }
    }
}
