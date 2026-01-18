using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class EnsurePathTask : AdvancedTask
    {
        public EnsurePathTask()
        {
            InitializeComponent();
            InitializeBase();
        }

        public override TaskEditor TaskEditor => taskEditor1;
        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            var dict = new Dictionary<string, JsonNode>();
            if (this.cleanText.Lines.Length > 0)
            {
                dict.Add("Clean", new JsonArray(this.cleanText.Lines.Select<string, JsonNode>(x => x).ToArray()));
            }

            if (this.ensureText.Lines.Length > 0)
            {
                dict.Add("Exists", new JsonArray(this.ensureText.Lines.Select<string, JsonNode>(x => x).ToArray()));
            }

            return dict;
        }

        public override string GetDefaultName()
        {
            return "EnsurePath";
        }

        public override string GetDefaultDescription()
        {
            if (this.ensureText.Lines.Length <= 0 && this.cleanText.Lines.Length <= 0)
            {
                return "Ensure the path";
            }

            if (this.ensureText.Lines.Length > 0)
            {
                return $"Ensure the existence of paths: {string.Join(", ", this.ensureText.Lines)}";
            }

            return $"Clean the paths: {string.Join(", ", this.cleanText.Lines)}";
        }
    }
}
