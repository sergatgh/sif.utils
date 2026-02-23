using AutoPipe;
using System.Text.RegularExpressions;

namespace SIF.Utils.Logic.ConfigFunctionParser.ParseFunction
{
    public class ParseFunctionProcessor : AutoProcessor
    {
        private readonly Regex _functionRegex = new Regex(@"^\s*([A-Za-z_]\w*)\s*\(\s*(.*?)\s*\)\s*$");
        private readonly Regex _parametersRegex = new Regex(@"(?:([A-Za-z_]\w*):)?('(?:[^'\\]|\\.)*'|[^,\s][^,]*)");

        public object GetRoot(string function)
        {
            try
            {
                var parsedFunction = ParseFunction(function);

                if (parsedFunction == null)
                {
                    return ErrorHalt("Cannot parse function: " + function);
                }

                return parsedFunction;
            }
            catch
            {
                return ErrorHalt("There is an error in the variable. Please review and fix:" + Environment.NewLine + function);
            }
        }

        protected ConfigFunctionModel? ParseFunction(string function)
        {
            var model = new ConfigFunctionModel();

            var matches = _functionRegex.Matches(function);
            var nameMatch = matches.FirstOrDefault();
            if (nameMatch == null)
            {
                return null;
            }
                
            var name = nameMatch.Groups[1].Value;
            var parameters = matches.First().Groups[2].Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            model.Name = name;

            if (string.IsNullOrWhiteSpace(parameters))
            {
                return model;
            }

            var parameterMatches = _parametersRegex.Matches(parameters);
            foreach (Match parameterMatch in parameterMatches)
            {
                var match = parameterMatch.Groups[2].ToString()!;
                if (match.StartsWith("'") && match.EndsWith("'"))
                {
                    model.Parameters.Add(new ConfigFunctionParameter
                    {
                        Value = match.Substring(1, match.Length - 2),
                        Type = "string",
                    });
                    continue;
                }

                if (decimal.TryParse(match, out var decimalValue))
                {
                    model.Parameters.Add(new ConfigFunctionParameter
                    {
                        Value = decimalValue,
                        Type = "number",
                    });
                    continue;
                }

                if (!match.Contains("(") && !match.Contains(")"))
                {
                    model.Parameters.Add(new ConfigFunctionParameter
                    {
                        Value = match,
                        Type = "string",
                    });
                    continue;
                }

                var configFunctionModel = ParseFunction(match);
                if (configFunctionModel != null)
                {
                    model.Parameters.Add(new ConfigFunctionParameter
                    {
                        Value = configFunctionModel,
                        Type = "function",
                    });
                    continue;
                }

                model.Parameters.Add(new ConfigFunctionParameter
                {
                    Value = match,
                    Type = "unknown",
                });
            }

            return model;
        }
    }
}
