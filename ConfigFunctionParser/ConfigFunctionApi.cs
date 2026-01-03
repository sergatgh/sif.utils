using AutoPipe;
using SIF.Utils.ConfigFunctionParser.ParseFunction;

namespace SIF.Utils.ConfigFunctionParser
{
    public class ConfigFunctionApi
    {
        public async Task<ConfigFunctionParsingResult> Parse(string configFunction)
        {
            if (!configFunction.StartsWith("\"[") || !configFunction.EndsWith("]\""))
            {
                return new ConfigFunctionParsingResult { Error = "ConfigFunction should start with [ and end with ]" };
            }

            var bag = await Pipeline.From<ParseFunctionProcessor>().Run(new { function = PrepareFunction(configFunction) });

            if (bag.HasErrors())
            {
                return new ConfigFunctionParsingResult { Error = bag.Summary(filter: MessageFilter.Error) };
            }

            return bag.As<ConfigFunctionParsingResult>();
        }

        protected string PrepareFunction(string configFunction)
        {
            return configFunction.TrimStart('[', '"').TrimEnd(']', '"');
        }
    }

    public class ConfigFunctionParsingResult
    {
        public string? Error { get; set; }

        public bool HasError => !string.IsNullOrWhiteSpace(Error);

        public ConfigFunctionModel? Root { get; set; }
    }

    public class ConfigFunctionParameter
    {
        public object? Value { get; set; }

        public string? Type { get; set; }
    }

    public class ConfigFunctionModel
    {
        public List<ConfigFunctionModel> Functions { get; set; } = [];

        public bool HasInnerFunctions => Functions.Any();

        public string Name { get; set; } = string.Empty;

        public List<ConfigFunctionParameter> Parameters { get; set; } = [];

        public bool HasParameters => Parameters.Any();
    }
}
