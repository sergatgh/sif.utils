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

        public string BuildJson(string? filePath = null)
        {
            var taskObjects = taskBuilderPanel1.SelectedTasks;
            var tasksJson = new JsonObject();
            foreach (var task in taskObjects)
            {
                var (taskName, taskJson) = task.ToJson();
                tasksJson[taskName] = taskJson;
            }

            var modulePaths = new JsonArray(modulesControlPanel1.ModulePaths.Select<string, JsonNode>(x => x).ToArray());

            var resultJson = new JsonObject { ["Tasks"] = tasksJson };

            if (parametersForm1.HasParameters())
            {
                resultJson["Parameters"] = parametersForm1.GetJson();
            }

            if (variablesForm1.HasVariables())
            {
                resultJson["Variables"] = variablesForm1.GetJson();
            }

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

            if (includeFiles1.Count > 0)
            {
                resultJson["Includes"] = includeFiles1.GetJson(filePath);
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

            var settingsJson = settingsForm1.GetJson();

            if (settingsJson.Count > 0)
            {
                resultJson["Settings"] = settingsJson;
            }

            return resultJson.ToJsonString(new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        }

        private void taskBuilderPanel1_TaskAdded(object sender, EventArgs e)
        {
            if (sender is TaskInfo taskInfo)
            {
                if (taskInfo.Source == "PS")
                {
                    settingsForm1.SetAutoRegisterExtensions(true);
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

        private void registerTasks_MethodAdded(object sender, SIF.Utils.Forms.Common.ResultEventArgs<string> e)
        {
            this.taskBuilderPanel1.AddTypeSuggestion(e.Result);
            this.uninstallTaskBuilderPanel.AddTypeSuggestion(e.Result);
        }

        private void registerTasks_MethodRemoved(object sender, SIF.Utils.Forms.Common.ResultEventArgs<string> e)
        {
            this.taskBuilderPanel1.RemoveTypeSuggestion(e.Result);
            this.uninstallTaskBuilderPanel.RemoveTypeSuggestion(e.Result);
        }
    }
}
