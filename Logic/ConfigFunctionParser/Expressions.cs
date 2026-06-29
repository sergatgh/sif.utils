using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SIF.Utils.Logic.ConfigFunctionParser
{
    public static class Expressions
    {
        public static readonly Regex FunctionNameRegex = new(@"^([A-Za-z_]\w*)\s*\(", RegexOptions.Compiled);
        public static readonly Regex IdentifierRegex = new(@"^[A-Za-z_]\w*$", RegexOptions.Compiled);
        public static readonly Regex OpenCloseConfigFunctionSymbols = new(@"^\s*""\s*\[.*\]\s*""\s*$");
    }
}
