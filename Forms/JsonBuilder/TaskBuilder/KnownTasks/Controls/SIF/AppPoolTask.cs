namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
    using System.Text.Json.Nodes;

    public partial class AppPoolTask : AdvancedTask
    {
        public AppPoolTask()
        {
            InitializeComponent();
            InitializeBase();
        }

        public override TaskEditor TaskEditor => taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>();

            dict["Name"] = nameInput.TextInput;

            // Add additional properties related to AppPoolTask here
            return dict;
        }

        public override string GetDefaultName()
        {
            if (!string.IsNullOrWhiteSpace(nameInput.TextInput))
            {
                return $"Create_{nameInput.TextInput}_AppPool";
            }
            return "CreateAppPool";
        }

        public override string GetDefaultDescription()
        {
            if (!string.IsNullOrWhiteSpace(nameInput.TextInput))
            {
                return $"Create an Application Pool named {nameInput.TextInput}.";
            }
            return "Create an Application Pool.";
        }
    }
}
