using SIF.Utils.Forms.JsonBuilder.Register;
using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using SIF.Utils.Logic.JsonParser;
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

        public void LoadFromResult(SifJsonParsingResult result)
        {
            ClearAll();
            foreach (var task in result.Tasks)
                taskBuilderPanel1.AddTaskFromModel(task);
            foreach (var task in result.UninstallTasks)
                uninstallTaskBuilderPanel.AddTaskFromModel(task);
            parametersForm1.LoadFromModels(result.Parameters);
            variablesForm1.LoadFromModels(result.Variables);
            includeFiles1.LoadFromModels(result.Includes);
            modulesControlPanel1.LoadFromModels(result.Modules);
            foreach (var rt in result.RegisteredTasks)
                registerTasks.AddMethod(new RegisterMethodModel { PowershellFunction = rt.Command, RegisterAs = rt.Name });
            foreach (var cf in result.RegisteredConfigFunctions)
                registerFunctions.AddMethod(new RegisterMethodModel { PowershellFunction = cf.Command, RegisterAs = cf.Name });
            if (result.Settings != null)
                settingsForm1.LoadFromModel(result.Settings);
        }

        private void ClearAll()
        {
            taskBuilderPanel1.Clear();
            uninstallTaskBuilderPanel.Clear();
            parametersForm1.Clear();
            variablesForm1.Clear();
            includeFiles1.Clear();
            modulesControlPanel1.Clear();
            registerTasks.Clear();
            registerFunctions.Clear();
            settingsForm1.Clear();
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
