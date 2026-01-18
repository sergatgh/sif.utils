namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
    using System.Text.Json.Nodes;

    public partial class CommandTask : AdvancedTask
    {
        public CommandTask()
        {
            InitializeComponent();
            InitializeBase();
        }

        public override TaskEditor TaskEditor => this.taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>();
            dict["Path"] = JsonValue.Create(this.commandPathText.Text);
            dict["Arguments"] = new JsonArray(this.propertiesText.Lines.Select<string, JsonNode>(x => x).ToArray());
            return dict;
        }

        public override string GetDefaultName()
        {
            return "CommandTask";
        }

        public override string GetDefaultDescription()
        {
            return "Executes a command line command.";
        }
    }
}
