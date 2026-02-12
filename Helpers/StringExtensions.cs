using System.Text.Json.Nodes;

namespace SIF.Utils.Helpers;

public static class StringExtensions
{
    public static string Or(this string a, string b)
    {
        return string.IsNullOrWhiteSpace(a) ? b : a;
    }
}

public static class JsonHelper
{
    public static T ParseJson<T>(this string? json, T defaultValue)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return defaultValue;
        }

        try
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(json) ?? defaultValue;
        }
        catch
        {
            return defaultValue;
        }
    }

    public static List<T> ParseJsonList<T>(this string? json)
    {
        return json.ParseJson<List<T>>([]);
    }

    public static JsonNode ParseConfigVariable(this string value)
    {

        if (value.StartsWith("\"") && value.EndsWith("\""))
        {
            return JsonValue.Create(value.Trim('"'));
        }

        if (value.Equals("true", StringComparison.OrdinalIgnoreCase))
        {
            return JsonValue.Create(true);
        }

        if (value.Equals("false", StringComparison.OrdinalIgnoreCase))
        {
            return JsonValue.Create(false);
        }

        if (int.TryParse(value, out var intValue))
        {
            return JsonValue.Create(intValue);
        }

        if (double.TryParse(value, out var doubleValue))
        {
            return JsonValue.Create(doubleValue);
        }

        if (value.StartsWith("[") && value.EndsWith("]"))
        {
            try
            {
                if (JsonNode.Parse(value) is JsonArray jsonArray)
                {
                    return jsonArray;
                }
            }
            catch
            {
                // Ignore parsing errors and treat as string
            }
        }
        else if (value.StartsWith("{") && value.EndsWith("}"))
        {
            try
            {
                if (JsonNode.Parse(value) is JsonObject jsonObject)
                {
                    return jsonObject;
                }
            }
            catch
            {
                // Ignore parsing errors and treat as string
            }
        }

        return JsonValue.Create(value);
    }
}