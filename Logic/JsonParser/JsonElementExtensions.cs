namespace SIF.Utils.Logic.JsonParser;

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

    public static string GetWithFallback(this JsonProperty element, string propertyName, string defaultValue = "")
    {
        if (element.Value.TryGetProperty(propertyName, out var prop))
        {
            return prop.GetRawText().Trim('"');
        }
        return defaultValue;
    }
}