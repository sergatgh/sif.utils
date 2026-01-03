using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder
{
    public partial class JsonBuilderPanel : UserControl
    {
        public JsonBuilderPanel()
        {
            InitializeComponent();
        }

        public string BuildJson()
        {
            var settingsJson = new JsonObject();

            if (autoRegisterExtensionsSetting.Checked)
            {
                settingsJson["AutoRegisterExtensions"] = autoRegisterExtensionsSetting.Checked;
            }

            var taskObjects = taskBuilderPanel1.SelectedTasks;
            var tasksJson = new JsonObject();
            foreach (var task in taskObjects)
            {
                var (taskName, taskJson) = task.ToJson();
                tasksJson[taskName] = taskJson;
            }

            var resultJson = new JsonObject() { ["Settings"] = settingsJson, ["Tasks"] = tasksJson };

            return resultJson.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
        }

        private void taskBuilderPanel1_TaskAdded(object sender, EventArgs e)
        {
            if (sender is TaskInfo taskInfo)
            {
                if (taskInfo.Source == "PS")
                {
                    autoRegisterExtensionsSetting.Checked = true;
                }
            }
        }
    }
}
