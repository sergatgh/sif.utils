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
    public partial class WebDeployTask : AdvancedTask
    {
        public WebDeployTask()
        {
            InitializeComponent();
        }

        public override TaskEditor TaskEditor => taskEditor1;

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                { "Verb", actionText.Text }
            };

            if (!string.IsNullOrWhiteSpace(pathToDeploy.TextInput))
            {
                dict.Add("Path", pathToDeploy.TextInput);
            }

            if (!string.IsNullOrWhiteSpace(argsJson.TextInput))
            {
                try
                {
                    dict.Add("Arguments", JsonNode.Parse(argsJson.TextInput)!);
                }
                catch (Exception e)
                {
                    dict.Add("Arguments", e.Message);
                }
            }

            return dict;
        }
    }
}
