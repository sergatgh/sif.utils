namespace SIF.Utils.Logic.ConfigFunctionParser
{
    public enum ConfigFunctionParamKind
    {
        Any,
        String,
        Number,
        Boolean,
    }

    public enum ConfigFunctionReferenceKind
    {
        None,
        VariableName,
        ParameterName,
    }

    public class ConfigFunctionParamDefinition
    {
        public required string Name { get; set; }

        public ConfigFunctionParamKind Kind { get; set; } = ConfigFunctionParamKind.Any;

        public bool IsMandatory { get; set; }

        /// <summary>Remaining/repeatable arguments collapse into this slot (e.g. concat, joinpath, and, or).</summary>
        public bool IsVariadic { get; set; }

        /// <summary>Special-cases the value editor for variable('Name')/parameter('Name') references.</summary>
        public ConfigFunctionReferenceKind ReferenceKind { get; set; } = ConfigFunctionReferenceKind.None;
    }

    public class ConfigFunctionDefinition
    {
        public required string Name { get; set; }

        public List<ConfigFunctionParamDefinition> Parameters { get; set; } = [];
    }
}
