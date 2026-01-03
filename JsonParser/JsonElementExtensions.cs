namespace SIF.Utils.JsonParser;

using System.Text.Json;

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