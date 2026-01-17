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
    public partial class UpdateBindingRedirectsTask : AdvancedTask
    {
        public UpdateBindingRedirectsTask()
        {
            InitializeComponent();
        }

        public override TaskEditor TaskEditor => taskEditor1;

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>()
            {
                ["SitePath"] = siteFolder.TextInput
            };

            if (!string.IsNullOrWhiteSpace(binFolder.TextInput))
            {
                dict["BinariesFolder"] = binFolder.TextInput;
            }

            if (!string.IsNullOrWhiteSpace(configsFolder.TextInput))
            {
                dict["ConfigFilesToPatch"] = string.Join(";", configsFolder.Lines);
            }

            return dict;
        }
    }
}
