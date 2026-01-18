using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class RemoveAppPoolTask : AdvancedTask
    {
        public override TaskEditor TaskEditor => taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                ["Name"] = nameInput.TextInput
            };

            // Add additional properties related to AppPoolTask here
            return dict;
        }

        public RemoveAppPoolTask()
        {
            InitializeComponent();
        }
    }
}
