using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

public interface IAdvancedTask
{
    TaskEditor TaskEditor { get; }
    Dictionary<string, JsonNode> GetAdditionalJsonProperties();
    string GetDefaultName();
    string GetDefaultDescription();
}