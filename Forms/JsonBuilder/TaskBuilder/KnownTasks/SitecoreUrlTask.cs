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
    public partial class SitecoreUrlTask : AdvancedTask
    {
        public SitecoreUrlTask()
        {
            InitializeComponent();
        }
        public override TaskEditor TaskEditor => taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                { "SitecoreInstanceRoot", urlInput.TextInput },
                { "SitecoreActionPath", pathInput.TextInput },
                { "Username", usernameInput.TextInput },
                { "Password", passwordInput.TextInput },
            };


            // Add additional properties related to AppPoolTask here
            return dict;
        }
    }
}
