namespace SIF.Utils.JsonParser;

using System.Text.Json;

public class SifBaseProperties
{
    public string Name { get; set; } = string.Empty;
    public JsonProperty Element { get; set; }
    public string? Description { get; set; }
}