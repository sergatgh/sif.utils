using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class RemoveXmlTask : AdvancedTask
    {
        public RemoveXmlTask()
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

            if (ignoreNoMatchesCheckbox.Checked)
            {
                dict.Add("IgnoreNoMatches", ignoreNoMatchesCheckbox.Checked);
            }

            // Add additional properties related to AppPoolTask here
            return dict;
        }
    }
}
