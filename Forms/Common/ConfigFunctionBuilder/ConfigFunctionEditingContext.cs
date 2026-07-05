namespace SIF.Utils.Forms.Common.ConfigFunctionBuilder
{
    /// <summary>Autocomplete/suggestion sources handed to every argument editor in a builder session.</summary>
    public class ConfigFunctionEditingContext
    {
        public IReadOnlyList<string> AvailableVariables { get; init; } = [];

        public IReadOnlyList<string> AvailableParameters { get; init; } = [];

        /// <summary>Known catalog function names plus the user's registered config function names.</summary>
        public IReadOnlyList<string> AvailableFunctionNames { get; init; } = [];
    }
}
