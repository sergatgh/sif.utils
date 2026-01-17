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
    public partial class WebRequestTask : AdvancedTask
    {
        public WebRequestTask()
        {
            InitializeComponent();
        }

        public override TaskEditor TaskEditor => taskEditor1;

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                ["Uri"] = addressTextBox.TextInput,
                ["RetryCount"] = retryCount.Value,
                ["RetryDelay"] = retryDelay.Value,
                ["RequestTimeout"] = requestTimeout.Value
            };

            return dict;
        }
    }
}
