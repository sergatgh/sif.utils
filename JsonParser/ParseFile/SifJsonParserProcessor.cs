namespace SIF.Utils.JsonParser.ParseFile;

using AutoPipe;
using System.Text.Json;

public class SifJsonParserProcessor : AutoProcessor
{
    public string GetFolder([Required(Halt = true)] string filePath)
    {
        return Path.GetDirectoryName(filePath) ?? string.Empty;
    }

    public async Task<object> GetJsonDocument([Required(Halt = true)] string filePath)
    {
        try
        {
            using var reader = new StreamReader(filePath);
            return await JsonDocument.ParseAsync(reader.BaseStream);
        }
        catch (JsonException jsonEx)
        {
            return ErrorHalt($"JSON parsing error: {jsonEx.Message}");
        }
        catch (Exception ex)
        {
            return ErrorHalt($"Unexpected error: {ex.Message}");
        }
    }

    public object GetTasks([Required] JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("Tasks", out var tasksElement))
        {
            if (!jsonDocument.RootElement.TryGetProperty("Includes", out _))
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

    public object GetUninstallTasks(JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("UninstallTasks", out var uninstallTasksElement))
        {
            return Warning("The 'UninstallTasks' property is not added.");
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

    public object GetParameters([Required] JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("Parameters", out var parametersElement))
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

    public object GetVariables([Required] JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("Variables", out var variablesElement))
        {
            return Info("The 'Variables' property is not added.");
        }
        if (variablesElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Variables' property is not an object.");
        }

        return variablesElement.EnumerateObject()
            .Select(parameter => new SifJsonVariableModel
            {
                Name = parameter.Name,
                Value = parameter.Value.GetRawText(),
            }).ToList();
    }

    public object GetIncludes([Required] JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("Includes", out var includesElement))
        {
            return Info("The 'Includes' property is not added.");
        }
        if (includesElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Includes' property is not an object.");
        }

        return includesElement.EnumerateObject().Select(parameter =>
            new SifJsonIncludeModel
            {
                Name = parameter.Name,
                Description =
                    parameter.Get("Description"),
                Source = parameter.Get("Source"),
            }).ToList();
    }

    public object GetModules([Required] JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("Modules", out var modulesElement))
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

    public object GetRegisterElement([Required] JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("Register", out var registerElement))
        {
            return Info("The 'Register' property is not added.");
        }

        if (registerElement.ValueKind != JsonValueKind.Object)
        {
            return Warning("The 'Register' property is not an object.");
        }

        return registerElement;
    }

    public object GetRegisteredTasks([Required] JsonElement registerElement)
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

    public object GetRegisteredConfigFunctions([Required] JsonElement registerElement)
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
}