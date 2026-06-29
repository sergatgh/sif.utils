using System;
using System.Collections.Generic;
using System.Text;

namespace SIF.Utils.Logic.ConfigFunctionParser
{
    public static class StringExtensions
    {
        public static string TrimConfigFunction(this string configFunction)
        {
            var s = configFunction.Trim();
            if (s.StartsWith('"'))
            {
                s = s[1..];
            }

            if (s.EndsWith('"'))
            {
                s = s[..^1];
            }

            if (s.StartsWith('['))
            {
                s = s[1..];
            }

            if (s.EndsWith(']'))
            {
                s = s[..^1];
            }

            return s;
        }
    }
}
