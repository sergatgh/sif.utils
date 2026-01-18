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
    public partial class ManageSolrSchemaTask : AdvancedTask
    {
        public override TaskEditor TaskEditor => taskEditor1;

        public ManageSolrSchemaTask()
        {
            InitializeComponent();
        }

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                ["Address"] = addressTextBox.TextInput,
                ["Core"] = coreTextBox.TextInput,
                ["ArgumentsFile"] = argumentsFileTextBox.TextInput,
                ["RetryCount"] = retryCount.Value,
                ["RetryDelay"] = retryDelay.Value,
                ["RequestTimeout"] = requestTimeout.Value
            };

            return dict;
        }
    }
}
