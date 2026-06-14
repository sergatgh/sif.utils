namespace SIF.Utils.Logic.JsonParser.ParseFile;

using AutoPipe;
using System.Text.Json;

public class ReadJsonObject : AutoProcessor
{
    public object ValidateFilePath([Required(Halt = true)] string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
        {
            return ErrorHalt("File path cannot be empty.");
        }

        if (!File.Exists(filePath))
        {
            return ErrorHalt($"The file '{filePath}' does not exist.");
        }

        return Info("File path is valid.");
    }

    [After(nameof(ValidateFilePath))]
    public string GetFolder([Required(Halt = true)] string filePath)
    {
        return Path.GetDirectoryName(filePath) ?? string.Empty;
    }

    [After(nameof(GetFolder))]
    public async Task<object> GetJsonDocument([Required(Halt = true)] string filePath)
    {
        try
        {
            using var reader = new StreamReader(filePath);
            var result = await JsonDocument.ParseAsync(reader.BaseStream);
            if (result.RootElement.ValueKind != JsonValueKind.Object)
            {
                return ErrorHalt("The root element of the JSON must be an object.");
            }
            return result.RootElement;
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

}