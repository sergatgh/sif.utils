using SIF.Utils.Logic.JsonParser;
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

        public void FocusTypeInput() => typeText.Focus();

        public (string, JsonObject) GetJson()
        {
            var json = this.taskEditor1.GetJson(this.typeText.Text);

            return (json.Item1.Or("CustomTask"), json.Item2);
        }

        public void LoadFromModel(SifJsonTaskModel model)
        {
            this.typeText.Text = model.Type;
            this.taskEditor1.LoadFromModel(model);
        }

        public void RemoveSuggestions(string type)
        {
            this.typeText.AutoCompleteCustomSource.Remove(type);
        }
    }
}
