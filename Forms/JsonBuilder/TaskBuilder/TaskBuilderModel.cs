using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls;
using SIF.Utils.Helpers;

public class TaskBuilderModel
{
    public required TaskInfo Info { get; set; }

    public required Control EditorControl { get; set; }

    public (string, JsonObject) ToJson()
    {
        if (EditorControl is CustomTask customTask)
        {
            return customTask.GetJson();
        }

        if (EditorControl is TaskEditor editor)
        {
            var jsonObject = editor.GetJson();
            jsonObject.Item2["Type"] = Info.Name;
            return (jsonObject.Item1.Or(Info.Name), jsonObject.Item2);
        }

        if (EditorControl is AdvancedTask task)
        {
            var baseJson = task.GetJson();
            baseJson.Item2["Type"] = Info.Name;

            return baseJson;
        }

        return ("", new JsonObject());
    }
}