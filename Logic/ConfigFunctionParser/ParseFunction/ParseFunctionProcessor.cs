using AutoPipe;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SIF.Utils.Logic.ConfigFunctionParser.ParseFunction
{
    public class ParseFunctionProcessor : AutoProcessor
    {
        public object GetRoot(string function)
        {
            try
            {
                var parsedFunction = ParseFunction(function.TrimConfigFunction());

                if (parsedFunction == null)
                {
                    return new ConfigFunctionModel { Name = function  };
                }

                return parsedFunction;
            }
            catch
            {
                return ErrorHalt("There is an error in the variable. Please review and fix:" + Environment.NewLine + function);
            }
        }

        protected ConfigFunctionModel? ParseFunction(string input)
        {
            var nameMatch = Expressions.FunctionNameRegex.Match(input);
            if (!nameMatch.Success)
            {
                return null;
            }

            string name = nameMatch.Groups[1].Value;
            int parenStart = nameMatch.Index + nameMatch.Length - 1;

            int parenEnd = FindMatchingParen(input, parenStart);
            if (parenEnd == -1)
            {
                return null;
            }

            string paramsStr = input.Substring(parenStart + 1, parenEnd - parenStart - 1);
            string afterParen = input[(parenEnd + 1)..].Trim();

            int? accessor = null;
            if (afterParen.Length >= 3 && afterParen.StartsWith('[') && afterParen.EndsWith(']'))
            {
                string accessorContent = afterParen[1..^1].Trim();
                if (int.TryParse(accessorContent, out int idx))
                {
                    accessor = idx;
                }
            }

            var model = new ConfigFunctionModel { Name = name, Accessor = accessor };

            if (!string.IsNullOrWhiteSpace(paramsStr))
            {
                foreach (var token in SplitTopLevelParameters(paramsStr))
                {
                    var trimmed = token.Trim();
                    if (!string.IsNullOrEmpty(trimmed))
                    {
                        model.Parameters.Add(ParseParameter(trimmed));
                    }
                }
            }

            return model;
        }

        private ConfigFunctionParameter ParseParameter(string token)
        {
            int colonIndex = FindTopLevelColon(token);
            if (colonIndex > 0)
            {
                string paramName = token.Substring(0, colonIndex).Trim();
                string paramValue = token.Substring(colonIndex + 1).Trim();

                if (Expressions.IdentifierRegex.IsMatch(paramName))
                {
                    var (value, type) = ParseValue(paramValue);
                    return new ConfigFunctionParameter { Name = paramName, Value = value, Type = type };
                }
            }

            var (val, t) = ParseValue(token);
            return new ConfigFunctionParameter { Value = val, Type = t };
        }

        private (object value, string type) ParseValue(string token)
        {
            if (token.StartsWith('\'') && token.EndsWith('\'') && token.Length >= 2)
            {
                return (token[1..^1], "string");
            }

            if (token.StartsWith('"') && token.EndsWith('"') && token.Length >= 2)
            {
                return (token[1..^1], "string");
            }

            if (int.TryParse(token, out int intVal))
            {
                return (intVal, "number");
            }

            if (decimal.TryParse(token, NumberStyles.Number, CultureInfo.InvariantCulture, out var dec))
            {
                return (dec, "number");
            }

            if (token.Equals("True", StringComparison.OrdinalIgnoreCase) ||
                token.Equals("False", StringComparison.OrdinalIgnoreCase))
            {
                return (bool.Parse(token), "boolean");
            }

            if (token.Contains('('))
            {
                var nested = ParseFunction(token);
                if (nested != null)
                {
                    return (nested, "function");
                }
            }

            return (token, "string");
        }

        private int FindMatchingParen(string input, int openIndex)
        {
            int depth = 0;
            bool inSingle = false;
            bool inDouble = false;

            for (int i = openIndex; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '\'' && !inDouble) { inSingle = !inSingle; continue; }
                if (c == '"' && !inSingle) { inDouble = !inDouble; continue; }
                if (inSingle || inDouble)
                {
                    continue;
                }

                if (c == '(')
                {
                    depth++;
                }
                else if (c == ')' && --depth == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private List<string> SplitTopLevelParameters(string paramsStr)
        {
            var result = new List<string>();
            int depth = 0;
            bool inSingle = false;
            bool inDouble = false;
            int start = 0;

            for (int i = 0; i < paramsStr.Length; i++)
            {
                char c = paramsStr[i];

                if (c == '\'' && !inDouble) { inSingle = !inSingle; continue; }
                if (c == '"' && !inSingle) { inDouble = !inDouble; continue; }
                if (inSingle || inDouble)
                {
                    continue;
                }

                if (c == '(' || c == '[')
                {
                    depth++;
                }
                else if (c == ')' || c == ']')
                {
                    depth--;
                }
                else if (c == ',' && depth == 0)
                {
                    result.Add(paramsStr.Substring(start, i - start));
                    start = i + 1;
                }
            }

            result.Add(paramsStr.Substring(start));
            return result;
        }

        private int FindTopLevelColon(string token)
        {
            bool inSingle = false;
            bool inDouble = false;
            int depth = 0;

            for (int i = 0; i < token.Length; i++)
            {
                char c = token[i];

                if (c == '\'' && !inDouble) { inSingle = !inSingle; continue; }
                if (c == '"' && !inSingle) { inDouble = !inDouble; continue; }
                if (inSingle || inDouble)
                {
                    continue;
                }

                if (c == '(' || c == '[')
                {
                    depth++;
                }
                else if (c == ')' || c == ']')
                {
                    depth--;
                }
                else if (c == ':' && depth == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
