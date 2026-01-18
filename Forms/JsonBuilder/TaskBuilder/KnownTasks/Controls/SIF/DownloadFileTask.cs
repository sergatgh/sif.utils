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
    public partial class DownloadFileTask : AdvancedTask
    {
        public override TaskEditor TaskEditor => taskEditor1;

        public DownloadFileTask()
        {
            InitializeComponent();
        }

        public override string GetDefaultName()
        {
            return "DownloadFromSource";
        }

        public override string GetDefaultDescription()
        {
            return "Downloads a file";
        }

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>();

            if (sourceTextInput.HasText)
            {
                dict["SourceUri"] = sourceTextInput.TextInput;
            }

            if (destinationPathInput.HasText)
            {
                dict["DestinationPath"] = destinationPathInput.TextInput;
            }

            if (hashInput.HasText)
            {
                dict["Hash"] = hashInput.TextInput;
            }

            if (hashComboBox.SelectedItem != null)
            {
                dict["Algorithm"] = hashComboBox.SelectedItem.ToString()!;
            }

            return dict;
        }
    }
}
