using System.Text.Json;

namespace SIF.Utils;

public class SifBaseProperties
{
    public string Name { get; set; } = string.Empty;
    public JsonProperty Element { get; set; }
    public string? Description { get; set; }
}

public class SifJsonTaskParameterModel
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}

public class SifJsonTaskModel : SifBaseProperties
{
    public string Type { get; set; } = string.Empty;

    public string Skip { get; set; } = string.Empty;

    public string Requires { get; set; } = string.Empty;

    public List<SifJsonTaskParameterModel> Params { get; } = [];
}

public class SifJsonParameterModel : SifBaseProperties
{
    public string? Type { get; set; }

    public string? DefaultValue { get; set; }

    public string? Reference { get; set; }

    public string? Validate { get; set; }
}

public class SifJsonVariableModel
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}

public class SifJsonIncludeModel : SifBaseProperties
{
    public string? Source { get; set; }
}

public class SifJsonModuleModel
{
    public string Path { get; set; } = string.Empty;
}

public class SifJsonParsingResult
{
    public string? Error { get; set; }

    public bool HasError => !string.IsNullOrWhiteSpace(Error);

    public List<string> Warnings { get; } = [];

    public bool HasWarnings => Warnings.Any(x => !string.IsNullOrWhiteSpace(x));

    public List<SifJsonTaskModel> Tasks { get; } = [];

    public List<SifJsonTaskModel> UninstallTasks { get; } = [];

    public List<SifJsonParameterModel> Parameters { get; } = [];

    public List<SifJsonVariableModel> Variables { get; } = [];

    public List<SifJsonIncludeModel> Includes { get; } = [];

    public List<SifJsonModuleModel> Modules { get; } = [];
}

public class SifJsonParser
{
    public async Task<SifJsonParsingResult> Parse(string filePath)
    {
        try
        {
            JsonDocument? jsonDocument;
            using(var reader = new StreamReader(filePath))
            {
                jsonDocument = await JsonDocument.ParseAsync(reader.BaseStream);
            }
            return ParseInternal(jsonDocument);
        }
        catch (JsonException jsonEx)
        {
            return new SifJsonParsingResult
            {
                Error = $"JSON parsing error: {jsonEx.Message}",
            };
        }
        catch (Exception ex)
        {
            return new SifJsonParsingResult
            {
                Error = $"Unexpected error: {ex.Message}",
            };
        }
    }

    protected SifJsonParsingResult ParseInternal(JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty("Tasks", out var tasksElement))
        {
            return new SifJsonParsingResult
            {
                Error = "The JSON does not contain a 'Tasks' property.",
            };
        }

        if (tasksElement.ValueKind != JsonValueKind.Object)
        {
            return new SifJsonParsingResult
            {
                Error = "The 'Tasks' property is not an object.",
            };
        }

        var enumerable = tasksElement.EnumerateObject();
        if (!enumerable.Any())
        {
            return new SifJsonParsingResult
            {
                Error = "The 'Tasks' object is empty.",
            };
        }

        var result = new SifJsonParsingResult();
        result.Tasks.AddRange(ParseTasks(tasksElement));

        if (jsonDocument.RootElement.TryGetProperty("UninstallTasks", out var uninstallTasksElement))
        {
            if (uninstallTasksElement.ValueKind != JsonValueKind.Object)
            {
                result.Warnings.Add("The 'UninstallTasks' property is not an object.");
            }
            else
            {
                result.UninstallTasks.AddRange(ParseTasks(uninstallTasksElement));
            }
        }

        if (jsonDocument.RootElement.TryGetProperty("Parameters", out var parametersElement))
        {
            if (parametersElement.ValueKind != JsonValueKind.Object)
            {
                result.Warnings.Add("The 'Parameters' property is not an object.");
            }
            else
            {
                result.Parameters.AddRange(ParseTaskParameters(parametersElement));
            }
        }

        if (jsonDocument.RootElement.TryGetProperty("Variables", out var variablesElement))
        {
            if (variablesElement.ValueKind != JsonValueKind.Object)
            {
                result.Warnings.Add("The 'Variables' property is not an object.");
            }
            else
            {
                result.Variables.AddRange(ParseVariables(variablesElement));
            }
        }

        if (jsonDocument.RootElement.TryGetProperty("Includes", out var includesElement))
        {
            if (includesElement.ValueKind != JsonValueKind.Object)
            {
                result.Warnings.Add("The 'Includes' property is not an object.");
            }
            else
            {
                result.Includes.AddRange(ParseIncludes(includesElement));
            }
        }

        if (jsonDocument.RootElement.TryGetProperty("Modules", out var modulesElement))
        {
            if (modulesElement.ValueKind != JsonValueKind.Array)
            {
                result.Warnings.Add("The 'Modules' property is not an array.");
            }
            else
            {
                result.Modules.AddRange(ParseModules(modulesElement));
            }
        }

        return result;
    }

    private IEnumerable<SifJsonModuleModel> ParseModules(JsonElement modulesElement)
    {
        return modulesElement.EnumerateArray().Select(moduleElement =>
            new SifJsonModuleModel
            {
                Path = moduleElement.GetRawText().Trim('"'),
            }).ToList();
    }

    private IEnumerable<SifJsonIncludeModel> ParseIncludes(JsonElement includesElement)
    {
        return includesElement.EnumerateObject().Select(parameter =>
            new SifJsonIncludeModel
            {
                Name = parameter.Name,
                Description =
                    parameter.Get("Description"),
                Source = parameter.Get("Source"),
            }).ToList();
    }

    public List<SifJsonTaskModel> ParseTasks(JsonElement tasksElement)
    {
        return tasksElement.EnumerateObject().Select(parameter =>
        new SifJsonTaskModel
        {
            Element = parameter,
            Name = parameter.Name,
            Description =
                parameter.Get("Description"),
        }).ToList();
    }

    public List<SifJsonParameterModel> ParseTaskParameters(JsonElement parametersElement)
    {
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

    public List<SifJsonVariableModel> ParseVariables(JsonElement parametersElement)
    {
        return parametersElement.EnumerateObject()
            .Select(parameter => new SifJsonVariableModel
            {
                Name = parameter.Name,
                Value = parameter.Value.GetRawText(),
            }).ToList();
    }
}

public static class JsonElementExtensions
{
    public static string? Get(this JsonProperty element, string propertyName)
    {
        if (element.Value.TryGetProperty(propertyName, out var prop))
        {
            return prop.GetRawText().Trim('"');
        }
        return null;
    }
}