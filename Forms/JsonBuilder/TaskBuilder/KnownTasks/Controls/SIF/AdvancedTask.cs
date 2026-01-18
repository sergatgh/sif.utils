using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;

public interface IAdvancedTask
{
    public JsonObject GetJson();
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

    public JsonObject GetJson()
    {
        var baseJson = TaskEditor.GetJson();
        var parametersNode = baseJson["Params"]!.AsObject();
        foreach (var (key, value) in GetAdditionalJsonProperties())
        {
            parametersNode[key] = value;
        }

        if (baseJson["Description"] == null || string.IsNullOrWhiteSpace(baseJson["Description"]!.GetValue<string>()))
        {
            baseJson["Description"] = GetDefaultDescription();
        }

        return baseJson;
    }

    public virtual string GetDefaultName() { return GetType().Name; }

    public virtual string GetDefaultDescription() { return ""; }

    public virtual Dictionary<string, JsonNode> GetAdditionalJsonProperties() { return new Dictionary<string, JsonNode>(); }
}