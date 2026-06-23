namespace SIF.Utils.Logic.JsonParser.ParseFile;

using AutoPipe;
using System.Text;
using System.Text.Json;

public class ReadUrlContent : AutoProcessor
{
    public async Task<object> GetJsonDocument([Required(Halt = true)] string url)
    {
        try
        {
            HttpClient httpClient = new();
            var stream = await httpClient.GetStreamAsync(url);
            var result = await JsonDocument.ParseAsync(stream);
            if (result.RootElement.ValueKind != JsonValueKind.Object)
            {
                return ErrorHalt("The root element of the JSON must be an object.");
            }
            return result.RootElement;
        }
        catch (HttpRequestException httpEx)
        {
            return ErrorHalt($"HTTP request error: {httpEx.Message}");
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
