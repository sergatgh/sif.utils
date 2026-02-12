using SIF.Utils.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace SIF.Utils.Forms.JsonBuilder.Variables
{
    public partial class VariablesForm : UserControl
    {
        public VariablesForm()
        {
            InitializeComponent();
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
