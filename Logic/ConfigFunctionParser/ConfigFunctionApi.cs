using AutoPipe;
using SIF.Utils.Logic.ConfigFunctionParser.ParseFunction;

namespace SIF.Utils.Logic.ConfigFunctionParser
{
    public interface IConfigFunctionApi
    {
        Task<ConfigFunctionParsingResult> Parse(string configFunction);
        bool IsConfigFunction(string value);
    }

    public class ConfigFunctionApi : IConfigFunctionApi
    {
        public async Task<ConfigFunctionParsingResult> Parse(string configFunction)
        {
            if (!HasCorrectStartAndEnd(configFunction))
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

        public bool IsConfigFunction(string value)
        {
            return HasCorrectStartAndEnd(value);
        }

        protected bool HasCorrectStartAndEnd(string configFunction)
        {
            return configFunction.StartsWith("\"[") && configFunction.EndsWith("]\"");
        }

        protected string PrepareFunction(string configFunction)
        {
            return configFunction.TrimStart('[', '"').TrimEnd(']', '"');
        }
    }
}
