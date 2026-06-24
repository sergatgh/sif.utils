namespace SIF.Utils.Logic.JsonParser.ParseFile;

using AutoPipe;
using System.Text.Json;

public class ReadJsonText : AutoProcessor
{
    public object GetJsonDocument([Required(Halt = true)] string jsonContent)
    {
        try
        {
            var result = JsonDocument.Parse(jsonContent);
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

    public object GetIsRawJson() => true;
}