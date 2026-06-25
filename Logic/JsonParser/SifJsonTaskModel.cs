namespace SIF.Utils.Logic.JsonParser;

public class SifJsonTaskModel : SifBaseProperties
{
    public string Type { get; set; } = string.Empty;

    public string? Skip { get; set; }

    public string? Requires { get; set; }

    public List<List<SifJsonTaskParameterModel>> ParamsList { get; } = [];

    public bool ExecutedMultipleTimes => ParamsList.Count > 1;
}