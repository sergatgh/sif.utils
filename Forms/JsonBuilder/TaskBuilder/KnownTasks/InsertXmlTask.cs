using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using System.Text.Json.Nodes;

    public partial class InsertXmlTask : AdvancedTask
    {
        public InsertXmlTask()
        {
            InitializeComponent();
        }

        public override TaskEditor TaskEditor => taskEditor1;
        public override string GetDefaultName()
        {
            return "Insert_XML";
        }

        public override string GetDefaultDescription()
        {
            return "Inserts XML data into a specified location.";
        }

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var nodes = new Dictionary<string, JsonNode>();

            if (filePathInput.HasText)
            {
                nodes["FilePath"] = filePathInput.TextInput;
            }

            if (xpathTextInput.HasText)
            {
                nodes["XPath"] = xpathTextInput.TextInput;
            }

            if (xmlInput.HasText)
            {
                nodes["Xml"] = xmlInput.TextInput;
            }

            return nodes;
        }
    }
}
