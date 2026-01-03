namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using System.Text.Json.Nodes;

    public partial class AppPoolTask : UserControl, IAdvancedTask
    {
        public AppPoolTask()
        {
            InitializeComponent();
            taskEditor1.nameInput.TextInput = GetDefaultName();
            taskEditor1.descriptionInput.TextInput = GetDefaultDescription();
        }

        public TaskEditor TaskEditor => taskEditor1;
        public Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>();

            dict["Name"] = nameInput.TextInput;

            // Add additional properties related to AppPoolTask here
            return dict;
        }

        public string GetDefaultName()
        {
            if (!string.IsNullOrWhiteSpace(nameInput.TextInput))
            {
                return $"Create_{nameInput.TextInput}_AppPool";
            }
            return "CreateAppPool";
        }

        public string GetDefaultDescription()
        {
            if (!string.IsNullOrWhiteSpace(nameInput.TextInput))
            {
                return $"Create an Application Pool named {nameInput.TextInput}.";
            }
            return "Create an Application Pool.";
        }
    }
}
