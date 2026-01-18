namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
    using System.Text.Json.Nodes;

    public partial class CreateServiceTask : AdvancedTask
    {
        public CreateServiceTask()
        {
            InitializeComponent();
        }

        public override TaskEditor TaskEditor => taskEditor1;
        public override string GetDefaultName()
        {
            return "CreateService";
        }

        public override string GetDefaultDescription()
        {
            return "Create a new Windows Service.";
        }

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>();

            if (serviceNameInput.TextInput.Length > 0)
            {
                dict.Add("Name", serviceNameInput.TextInput);
            }

            if (executablePath.TextInput.Length > 0)
            {
                dict.Add("Path", executablePath.TextInput);
            }

            if (!string.IsNullOrEmpty(executableParameters.TextInput))
            {
                var array = new JsonArray(executableParameters.Lines.Select<string, JsonNode>(x => x).ToArray());
                dict.Add("Arguments", array);
            }

            if (serviceType.Text.Length > 0)
            {
                dict.Add("StartupType", serviceType.Text);
            }

            if (serviceDescription.TextInput.Length > 0)
            {
                dict.Add("Description", serviceDescription.TextInput);
            }

            if (displayNameInput.TextInput.Length != 0)
            {
                dict.Add("DisplayName", displayNameInput.TextInput);
            }

            return dict;
        }
    }
}
