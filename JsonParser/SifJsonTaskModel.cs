namespace SIF.Utils.JsonParser;

public class SifJsonTaskModel : SifBaseProperties
{
    public string Type { get; set; } = string.Empty;

    public string Skip { get; set; } = string.Empty;

    public string Requires { get; set; } = string.Empty;

    public List<SifJsonTaskParameterModel> Params { get; } = [];
}