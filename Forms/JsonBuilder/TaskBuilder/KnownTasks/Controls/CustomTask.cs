using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls
{
    using global::SIF.Utils.Helpers;

    public partial class CustomTask : UserControl
    {
        public CustomTask()
        {
            InitializeComponent();

            this.typeText.AutoCompleteCustomSource = [];
            this.typeText.AutoCompleteCustomSource.AddRange(SifFrameworkTasks.Tasks.Select(x => x.Name).ToArray());

            this.taskEditor1.nameInput.TextInput = "MyCustomTask";
        }

        public CustomTask(params string[] suggestions) : this()
        {
            AddSuggestions(suggestions);
        }

        public void AddSuggestions(params string[] suggestions)
        {
            this.typeText.AutoCompleteCustomSource.AddRange(suggestions);
        }

        public (string, JsonObject) GetJson()
        {
            var json = this.taskEditor1.GetJson();
            json.Item2["Type"] = this.typeText.Text;

            return (json.Item1.Or("CustomTask"), json.Item2);
        }

        public void RemoveSuggestions(string type)
        {
            this.typeText.AutoCompleteCustomSource.Remove(type);
        }
    }
}
