namespace SIF.Utils.Logic.ConfigFunctionParser
{
    public class ConfigFunctionModel
    {
        public List<ConfigFunctionModel> Functions { get; set; } = [];

        public bool HasInnerFunctions => Functions.Any();

        public string Name { get; set; } = string.Empty;

        public List<ConfigFunctionParameter> Parameters { get; set; } = [];

        public bool HasParameters => Parameters.Any();
    }
}
