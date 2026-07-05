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
            variablesForm1.GetAvailableParameterNames = () => parametersForm1.GetParameterNames();
            variablesForm1.GetRegisteredConfigFunctions = () => registerFunctions.RegisterMethods;
        }

        public void LoadFromResult(SifJsonParsingResult result)
        {
            ClearAll();
            foreach (var task in result.Tasks)
            {
                taskBuilderPanel1.AddTaskFromModel(task);
            }

            foreach (var task in result.UninstallTasks)
            {
                uninstallTaskBuilderPanel.AddTaskFromModel(task);
            }

            parametersForm1.LoadFromModels(result.Parameters);
            parametersForm1.SetIncludes(result.Includes);
            variablesForm1.LoadFromModels(result.Variables);
            includeFiles1.LoadFromModels(result.Includes);
            modulesControlPanel1.LoadFromModels(result.Modules);
            foreach (var rt in result.RegisteredTasks)
            {
                registerTasks.AddMethod(new RegisterMethodModel { PowershellFunction = rt.Command, RegisterAs = rt.Name });
            }

            foreach (var cf in result.RegisteredConfigFunctions)
            {
                registerFunctions.AddMethod(new RegisterMethodModel { PowershellFunction = cf.Command, RegisterAs = cf.Name });
            }

            if (result.Settings != null)
            {
                settingsForm1.LoadFromModel(result.Settings);
            }

            if (result.SectionOrder.Count > 0)
            {
                sectionOrderPanel1.ApplySectionOrder(result.SectionOrder);
            }
        }

        public bool HasContent()
        {
            return taskBuilderPanel1.SelectedTasks.Count > 0
                || uninstallTaskBuilderPanel.SelectedTasks.Count > 0
                || parametersForm1.HasParameters()
                || variablesForm1.HasVariables()
                || includeFiles1.Count > 0
                || modulesControlPanel1.ModulePaths.Length > 0
                || registerTasks.HasRegisterMethods
                || registerFunctions.HasRegisterMethods
                || settingsForm1.GetJson().Count > 0;
        }

        public void Clear() => ClearAll();

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
            var sections = BuildSections(filePath);
            var resultJson = new JsonObject();

            foreach (var key in sectionOrderPanel1.GetSectionOrder())
            {
                if (sections.TryGetValue(key, out var node))
                {
                    resultJson[key] = node;
                }
            }

            return resultJson.ToJsonString(new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        }

        private Dictionary<string, JsonNode> BuildSections(string? filePath)
        {
            var sections = new Dictionary<string, JsonNode>();

            var tasksJson = new JsonObject();
            foreach (var task in taskBuilderPanel1.SelectedTasks)
            {
                var (taskName, taskJson) = task.ToJson();
                tasksJson[taskName] = taskJson;
            }
            sections["Tasks"] = tasksJson;

            if (parametersForm1.HasParameters())
            {
                sections["Parameters"] = parametersForm1.GetJson();
            }

            if (variablesForm1.HasVariables())
            {
                sections["Variables"] = variablesForm1.GetJson();
            }

            if (uninstallTaskBuilderPanel.SelectedTasks.Count > 0)
            {
                var uninstallTasksJson = new JsonObject();
                foreach (var task in uninstallTaskBuilderPanel.SelectedTasks)
                {
                    var (taskName, taskJson) = task.ToJson();
                    uninstallTasksJson[taskName] = taskJson;
                }
                sections["UninstallTasks"] = uninstallTasksJson;
            }

            var modulePaths = new JsonArray(modulesControlPanel1.ModulePaths.Select<string, JsonNode>(x => x).ToArray());
            if (modulePaths.Count > 0)
            {
                sections["Modules"] = modulePaths;
            }

            if (includeFiles1.Count > 0)
            {
                sections["Includes"] = includeFiles1.GetJson(filePath);
            }

            if (registerTasks.HasRegisterMethods || registerFunctions.HasRegisterMethods)
            {
                var registerJson = new JsonObject();
                if (registerTasks.HasRegisterMethods)
                {
                    registerJson["Tasks"] = registerTasks.GetJsonObject();
                }

                if (registerFunctions.HasRegisterMethods)
                {
                    registerJson["ConfigFunction"] = registerFunctions.GetJsonObject();
                }

                sections["Register"] = registerJson;
            }

            var settingsJson = settingsForm1.GetJson();
            if (settingsJson.Count > 0)
            {
                sections["Settings"] = settingsJson;
            }

            return sections;
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
