using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class TransformXmlDocTask : AdvancedTask
    {
        public TransformXmlDocTask()
        {
            InitializeComponent();
        }
        public override TaskEditor TaskEditor => taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                {"RootDirectoryPath", filePathInput.TextInput },
                { "XdtDirectory", xPathInput.TextInput },
            };

            // Add additional properties related to AppPoolTask here
            return dict;
        }
    }
}
