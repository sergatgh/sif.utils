namespace SIF.Utils.JsonParser;

public class SifJsonParameterModel : SifBaseProperties
{
    public string? Type { get; set; }

    public string? DefaultValue { get; set; }

    public string? Reference { get; set; }

    public string? Validate { get; set; }
}