namespace SIF.Utils.Logic.JsonParser;

using SIF.Utils.Logic.ConfigFunctionParser;

public class SifJsonVariableModel
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public ConfigFunctionParsingResult? ConfigFunction { get; set; }
    public List<SifJsonVariableModel> ReferencedVariables { get; } = [];
}