using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class IoXmlTask : AdvancedTask
    {
        public override TaskEditor TaskEditor => taskEditor1;

        public IoXmlTask()
        {
            InitializeComponent();
        }

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                { "RootDirectoryPath", folderPathInput.TextInput },
                { "IoXmlPath", xpathTextInput.TextInput },
            };

            return dict;
        }
    }
}
