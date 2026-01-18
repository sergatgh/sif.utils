namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
    using System.Text.Json.Nodes;

    public partial class UnpackTask : AdvancedTask
    {
        public UnpackTask()
        {
            InitializeComponent();
        }
        public override TaskEditor TaskEditor => taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                {"Source", sourceInput.TextInput },
                { "Destination", destinationInput.TextInput },
            };
            // Add additional properties related to AppPoolTask here
            return dict;
        }
    }
}
