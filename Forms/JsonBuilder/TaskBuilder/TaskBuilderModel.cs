using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

public class TaskBuilderModel
{
    public required TaskInfo Info { get; set; }

    public required Control EditorControl { get; set; }

    public (string, JsonObject) ToJson()
    {

        if (EditorControl is TaskEditor editor)
        {
            var name = !string.IsNullOrWhiteSpace(editor.nameInput.TextInput) ? editor.nameInput.TextInput : Info.Name;
            var jsonObject = editor.GetJson();
            jsonObject["Type"] = Info.Name;
            return (name, jsonObject);
        }

        if (EditorControl is AdvancedTask task)
        {
            var name = !string.IsNullOrWhiteSpace(task.TaskEditor.nameInput.TextInput) ? task.TaskEditor.nameInput.TextInput : task.GetDefaultName();

            var baseJson = task.GetJson();
            baseJson["Type"] = Info.Name;

            return (name, baseJson);
        }

        return ("", new JsonObject());
    }
}