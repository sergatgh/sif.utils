namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    using System.Text.Json.Nodes;
    using System.Text.RegularExpressions;

    public partial class WriteHostTask : UserControl, IAdvancedTask
    {
        public WriteHostTask()
        {
            InitializeComponent();
        }

        public TaskEditor TaskEditor => taskEditor1;
        public Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>
            {
                { "Message", nameInput.TextInput },
            };

            if (!string.IsNullOrEmpty(backgroundColorInput.Text))
            {
                dict.Add("BackgroundColor", backgroundColorInput.Text);
            }

            if (!string.IsNullOrEmpty(colorSelector.Text))
            {
                dict.Add("ForegroundColor", colorSelector.Text);
            }

            return dict;
        }

        public string GetDefaultName()
        {
            string name = Regex.Replace(nameInput.TextInput, "[^a-zA-Z0-9]", "");
            if (!string.IsNullOrWhiteSpace(nameInput.TextInput))
            {
                return $"Write_{name}_To_Host";
            }

            return "WriteMessage";
        }

        public string GetDefaultDescription()
        {
            if (!string.IsNullOrWhiteSpace(nameInput.TextInput))
            {
                return $"Write the message: {nameInput.TextInput}";
            }
            return "Write a message to the host.";
        }
    }
}
