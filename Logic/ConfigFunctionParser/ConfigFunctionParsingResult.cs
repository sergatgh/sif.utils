using SIF.Utils.Logic.JsonParser;

namespace SIF.Utils.Logic.ConfigFunctionParser
{
    public class ConfigFunctionParsingResult
    {
        public string? Error { get; set; }

        public bool HasError => !string.IsNullOrWhiteSpace(Error);

        public ConfigFunctionModel? Root { get; set; }

        public List<SifJsonParameterModel> ParametersReferences { get; } = [];
        public List<SifJsonVariableModel> VariablesReferences { get; } = [];
    }
}
