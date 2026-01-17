using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder
{
    using SIF.Utils.Forms.JsonBuilder.Register;

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

            var modulePaths = new JsonArray(modulesControlPanel1.ModulePaths.Select<string, JsonNode>(x => x).ToArray());

            var resultJson = new JsonObject { ["Tasks"] = tasksJson };

            if (uninstallTaskBuilderPanel.SelectedTasks.Count > 0)
            {
                var uninstallTasksJson = new JsonObject();
                foreach (var task in uninstallTaskBuilderPanel.SelectedTasks)
                {
                    var (taskName, taskJson) = task.ToJson();
                    uninstallTasksJson[taskName] = taskJson;
                }
                resultJson["UninstallTasks"] = uninstallTasksJson;
            }

            if (modulePaths.Count > 0)
            {
                resultJson["Modules"] = modulePaths;
            }

            if (settingsJson.Count > 0)
            {
                resultJson["Settings"] = settingsJson;
            }

            if (registerTasks.HasRegisterMethods || registerFunctions.HasRegisterMethods)
            {
                var registerJson = new JsonObject();
                resultJson["Register"] = registerJson;
                if (registerTasks.HasRegisterMethods)
                {
                    registerJson["Tasks"] = registerTasks.GetJsonObject();
                }
                if (registerFunctions.HasRegisterMethods)
                {
                    registerJson["ConfigFunction"] = registerFunctions.GetJsonObject();
                }
            }

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

                if (taskInfo.Name == "InstallPSModule")
                {
                    registerFunctions.AddMethod(new RegisterMethodModel
                    {
                        PowershellFunction = "Get-PSSession",
                        RegisterAs = "GetPSSession"
                    });
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
