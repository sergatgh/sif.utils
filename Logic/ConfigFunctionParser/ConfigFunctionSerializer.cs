using System.Globalization;

namespace SIF.Utils.Logic.ConfigFunctionParser
{
    /// <summary>
    /// Inverse of ParseFunction.ParseFunctionProcessor: turns an (edited) ConfigFunctionModel tree
    /// back into SIF config function text.
    /// </summary>
    public static class ConfigFunctionSerializer
    {
        public static string ToBracketedConfigFunctionString(this ConfigFunctionModel model) =>
            "[" + model.ToConfigFunctionText() + "]";

        public static string ToConfigFunctionText(this ConfigFunctionModel model)
        {
            var args = string.Join(", ", model.Parameters.Select(p => p.ToConfigFunctionParameterText()));
            var accessorSuffix = model.Accessor.HasValue ? $"[{model.Accessor.Value}]" : string.Empty;
            return $"{model.Name}({args}){accessorSuffix}";
        }

        public static string ToConfigFunctionParameterText(this ConfigFunctionParameter parameter)
        {
            var namePrefix = string.IsNullOrEmpty(parameter.Name) ? string.Empty : $"{parameter.Name}: ";
            return namePrefix + parameter.ToConfigFunctionValueText();
        }

        /// <summary>Escapes an embedded single quote by doubling it, matching PowerShell/SIF single-quoted string literals.</summary>
        public static string EscapeSingleQuotedLiteral(string value) => value.Replace("'", "''");

        /// <summary>The value portion only, without any "Name: " prefix - used for tree/row previews.</summary>
        public static string ToConfigFunctionValueText(this ConfigFunctionParameter parameter)
        {
            switch (parameter.Type)
            {
                case "function":
                    return parameter.Value is ConfigFunctionModel nested ? nested.ToConfigFunctionText() : string.Empty;

                case "number":
                    return parameter.Value switch
                    {
                        IConvertible convertible => Convert.ToString(convertible, CultureInfo.InvariantCulture) ?? "0",
                        _ => "0",
                    };

                case "boolean":
                    return parameter.Value is true ? "true" : "false";

                // Editor-only escape hatch: inserted verbatim, no quoting/escaping applied.
                case "raw":
                    return parameter.Value?.ToString() ?? string.Empty;

                default: // "string" (or unset, defaults to a string literal)
                    return "'" + EscapeSingleQuotedLiteral(parameter.Value?.ToString() ?? string.Empty) + "'";
            }
        }
    }
}
