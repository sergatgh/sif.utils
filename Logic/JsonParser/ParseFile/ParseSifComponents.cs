using System.Text.Json;

namespace SIF.Utils.Logic.JsonParser.ParseFile;

using AutoPipe;
using SIF.Utils.Logic.ConfigFunctionParser;
using SIF.Utils.Logic.JsonParser;
using System.Diagnostics;
using System.Reflection.Metadata;

public class ParseSifComponents : AutoProcessor
{
    public object GetTasks([Required] JsonElement jsonDocument)
    {
        if (!jsonDocument.TryGetProperty("Tasks", out var tasksElement))
        {
            if (!jsonDocument.TryGetProperty("Includes", out _))
            {
                return ErrorHalt("The JSON does not contain neither 'Tasks' nor 'Includes' property.");
            }

            return Info("The JSON does not contain 'Tasks' property.");
        }

        if (tasksElement.ValueKind != JsonValueKind.Object)
        {
            return ErrorHalt("The 'Tasks' property is not an object.");
        }

        var tasksArray = tasksElement.EnumerateObject().ToArray();

        if (tasksArray.Length <= 0)
        {
            return ErrorHalt("The 'Tasks' object is empty.");
        }

        return tasksArray.Select(parameter =>
            new SifJsonTaskModel
            {
                Element = parameter,
                Name = parameter.Name,
                Description =
                    parameter.Get("Description"),
            }).ToList();
    }

    public object GetUninstallTasks([Required] JsonElement jsonDocument)
    {
        if (!jsonDocument.TryGetProperty("UninstallTasks", out var uninstallTasksElement))
        {
            return Info("The 'UninstallTasks' property is not added.");
        }

        if (uninstallTasksElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'UninstallTasks' property is not an object.");
        }

        return uninstallTasksElement.EnumerateObject().Select(parameter =>
            new SifJsonTaskModel
            {
                Element = parameter,
                Name = parameter.Name,
                Description =
                    parameter.Get("Description"),
            }).ToList();
    }

    public object GetParameters([Required] JsonElement jsonDocument)
    {
        if (!jsonDocument.TryGetProperty("Parameters", out var parametersElement))
        {
            return Info("The 'Parameters' property is not added.");
        }

        if (parametersElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Parameters' property is not an object.");
        }

        return parametersElement.EnumerateObject()
            .Select(parameter => new SifJsonParameterModel
            {
                Name = parameter.Name,
                Type = parameter.Get("Type"),
                Description = parameter.Get("Description"),
                DefaultValue = parameter.Get("DefaultValue"),
                Reference = parameter.Get("Reference"),
                Validate = parameter.Get("Validate"),
            }).ToList();
    }

    public async Task<object> GetVariables(Bag bag, [Required] JsonElement jsonDocument, IConfigFunctionApi configFunctionApi)
    {
        if (!jsonDocument.TryGetProperty("Variables", out var variablesElement))
        {
            return Info("The 'Variables' property is not added.");
        }
        if (variablesElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Variables' property is not an object.");
        }

        List<SifJsonVariableModel> list = [];
        foreach (var parameter in variablesElement.EnumerateObject())
        {
            var sifJsonVariableModel = new SifJsonVariableModel
            {
                Name = parameter.Name,
                Value = parameter.Value.GetRawText(),
            };

            if (parameter.Value.ValueKind == JsonValueKind.String)
            {
                var configFunction = configFunctionApi.IsConfigFunction(sifJsonVariableModel.Value);

                if (configFunction)
                {
                    var parsingResult = await configFunctionApi.Parse(sifJsonVariableModel.Value);
                    if (parsingResult.HasError)
                    {
                        bag.Warning($"The variable '{sifJsonVariableModel.Name}' is identified as a config function but failed to parse. Error: {parsingResult.Error}");
                    }
                    sifJsonVariableModel.ConfigFunction = parsingResult;
                }
            }

            list.Add(sifJsonVariableModel);
        }

        return list;
    }

    public void MapVariablesReferences([Required] List<SifJsonVariableModel> variables, [Required] List<SifJsonParameterModel> parameters)
    {
        foreach (var variable in variables)
        {
            var root = variable.ConfigFunction?.Root;
            if (root == null) continue;
            CollectReferences(root, variable, variables, parameters);
        }
    }

    private void CollectReferences(ConfigFunctionModel model, SifJsonVariableModel owner,
        List<SifJsonVariableModel> variables, List<SifJsonParameterModel> parameters)
    {
        var firstParamValue = model.Parameters.FirstOrDefault()?.Value?.ToString();

        if (string.Equals(model.Name, "variable", StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrEmpty(firstParamValue))
        {
            var referenced = variables.FirstOrDefault(v =>
                string.Equals(v.Name, firstParamValue, StringComparison.OrdinalIgnoreCase));
            if (referenced != null && !owner.ConfigFunction!.VariablesReferences.Contains(referenced))
            {
                owner.ConfigFunction!.VariablesReferences.Add(referenced);
                referenced.ReferencedVariables.Add(owner);
            }
        }
        else if (string.Equals(model.Name, "parameter", StringComparison.OrdinalIgnoreCase) &&
                 !string.IsNullOrEmpty(firstParamValue))
        {
            var referenced = parameters.FirstOrDefault(p =>
                string.Equals(p.Name, firstParamValue, StringComparison.OrdinalIgnoreCase));
            if (referenced != null && !owner.ConfigFunction!.ParametersReferences.Contains(referenced))
            {
                owner.ConfigFunction!.ParametersReferences.Add(referenced);
                referenced.ReferencedVariables.Add(owner);
            }
        }

        foreach (var fn in model.Functions)
            CollectReferences(fn, owner, variables, parameters);

        foreach (var param in model.Parameters)
        {
            if (param.Type == "function" && param.Value is ConfigFunctionModel nested)
                CollectReferences(nested, owner, variables, parameters);
        }
    }

    public async Task<object> GetIncludes(Bag bag, ISifJsonParser parser, [Required] JsonElement jsonDocument, [Required] string filePath, string folder, string[] visitedFiles)
    {
        if (!jsonDocument.TryGetProperty("Includes", out var includesElement))
        {
            return Info("The 'Includes' property is not added.");
        }
        if (includesElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Includes' property is not an object.");
        }

        var allVisits = visitedFiles.Append(filePath).ToArray();
        var result = new List<SifJsonIncludeModel>();
        foreach (var includeDeclaration in includesElement.EnumerateObject())
        {
            var source = includeDeclaration.Get("Source");
            var includeModel = new SifJsonIncludeModel
            {
                Name = includeDeclaration.Name,
                Description =
                    includeDeclaration.Get("Description"),
                OriginalValue = source,
            };
            result.Add(includeModel);

            if (string.IsNullOrWhiteSpace(source))
            {
                bag.Warning($"The Include [{includeDeclaration.Name}] in file [{filePath}] has empty source.");
                continue;
            }

            var fullIncludePath = Path.GetFullPath(source, folder);
            includeModel.FullPath = fullIncludePath;

            if (allVisits.Any(x => string.Compare(fullIncludePath, x, StringComparison.OrdinalIgnoreCase) == 0))
            {
                bag.Warning($"The included file [{includeDeclaration.Name}] in file [{filePath}] has already been referenced. Please fix a circular dependency.");
                continue;
            }

            var parsingResult = await parser.Parse(fullIncludePath, allVisits);
            if (parsingResult.HasError)
            {
                bag.Warning($"[{includeDeclaration.Name}] There was an error parsing included json: {parsingResult.Error}");
            }

            if (parsingResult.HasWarnings)
            {
                parsingResult.Warnings.ForEach(x => bag.Warning($"[{includeDeclaration.Name}] {x}"));
            }

            includeModel.ParseResult = parsingResult;
        }
        return result;
    }

    public object GetModules([Required] JsonElement jsonDocument)
    {
        if (!jsonDocument.TryGetProperty("Modules", out var modulesElement))
        {
            return Info("The 'Modules' property is not added.");
        }
        if (modulesElement.ValueKind != JsonValueKind.Array)
        {
            return Warning("The 'Modules' property is not an array.");
        }

        return modulesElement.EnumerateArray().Select(moduleElement =>
            new SifJsonModuleModel
            {
                Path = moduleElement.GetRawText().Trim('"'),
            }).ToList();
    }

    public object ObtainRegisteredTypes([Required] JsonElement jsonDocument)
    {
        if (!jsonDocument.TryGetProperty("Register", out var registerElement))
        {
            return Info("The 'Register' property is not added.");
        }

        if (registerElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Register' property is not an object.");
        }

        return new
        {
            RegisteredTasks = GetRegisteredTasks(registerElement),
            RegisteredConfigFunctions = GetRegisteredConfigFunctions(registerElement),
        };
    }

    private object GetRegisteredTasks([Required] JsonElement registerElement)
    {
        if (!registerElement.TryGetProperty("Tasks", out var tasksElement))
        {
            return Info("Custom tasks are not registered.");
        }

        if (tasksElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Tasks' property in 'Register' is not an object.");
        }

        return tasksElement.EnumerateObject().Select(parameter =>
            new RegisteredElementJsonModel
            {
                Name = parameter.Name,
                Command = parameter.Value.GetRawText().Trim('"'),
            }).ToList();
    }

    private object GetRegisteredConfigFunctions([Required] JsonElement registerElement)
    {
        if (!registerElement.TryGetProperty("ConfigFunctions", out var tasksElement))
        {
            return Info("Custom functions are not registered.");
        }

        if (tasksElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'ConfigFunctions' property in 'Register' is not an object.");
        }

        return tasksElement.EnumerateObject().Select(parameter =>
            new RegisteredElementJsonModel
            {
                Name = parameter.Name,
                Command = parameter.Value.GetRawText().Trim('"'),
            }).ToList();
    }

    public object GetSettings([Required] JsonElement jsonDocument)
    {
        if (!jsonDocument.TryGetProperty("Settings", out var settingsElement))
        {
            return Info("The 'Settings' property is not added.");
        }

        if (settingsElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Settings' property is not an object.");
        }

        var a = settingsElement.TryGetProperty("AutoRegisterExtensions", out var autoRegister);

        return new SifJsonSettings
        {
            AutoRegisterExtensions = a && autoRegister.GetBoolean(),
            ErrorAction = settingsElement.TryGetProperty("ErrorAction", out var errorAction) ? errorAction.GetString() : null,
            WarningAction = settingsElement.TryGetProperty("WarningAction", out var warningAction) ? warningAction.GetString() : null,
            InformationAction = settingsElement.TryGetProperty("InformationAction", out var infoAction) ? infoAction.GetString() : null,
        };
    }
}