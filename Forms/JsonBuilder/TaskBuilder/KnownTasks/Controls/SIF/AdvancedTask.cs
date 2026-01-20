using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;

using global::SIF.Utils.Helpers;

public interface IAdvancedTask
{
    public (string, JsonObject) GetJson();
    string GetDefaultName();
    string GetDefaultDescription();
}

public class AdvancedTask : UserControl, IAdvancedTask
{
    protected void InitializeBase()
    {
        TaskEditor.nameInput.TextInput = GetDefaultName();
        TaskEditor.descriptionInput.TextInput = GetDefaultDescription();
    }

    public virtual TaskEditor TaskEditor { get; }

    public (string, JsonObject) GetJson()
    {
        var result = TaskEditor.GetJson();
        var baseJson = result.Item2;

        var parametersNode = baseJson["Params"]!.AsObject();
        foreach (var (key, value) in GetAdditionalJsonProperties())
        {
            parametersNode[key] = value;
        }

        if (baseJson["Description"] == null || string.IsNullOrWhiteSpace(baseJson["Description"]!.GetValue<string>()))
        {
            baseJson["Description"] = GetDefaultDescription();
        }

        return (result.Item1.Or(GetDefaultName()), baseJson);
    }

    public virtual string GetDefaultName() { return GetType().Name; }

    public virtual string GetDefaultDescription() { return ""; }

    public virtual Dictionary<string, JsonNode> GetAdditionalJsonProperties() { return new Dictionary<string, JsonNode>(); }
}