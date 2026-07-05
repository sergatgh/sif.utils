namespace SIF.Utils.Logic.ConfigFunctionParser
{
    /// <summary>
    /// Declarative catalog of SIF config functions, sourced from the param() blocks in
    /// SitecoreInstallFramework's Public\ConfigFunctions\*.ps1 scripts, plus the two core
    /// reference functions (variable/parameter) that live outside that folder.
    /// </summary>
    public static class KnownConfigFunctions
    {
        public static readonly IReadOnlyList<ConfigFunctionDefinition> All = BuildCatalog();

        public static ConfigFunctionDefinition? Find(string name) =>
            All.FirstOrDefault(f => string.Equals(f.Name, name, StringComparison.OrdinalIgnoreCase));

        private static ConfigFunctionParamDefinition Param(string name, ConfigFunctionParamKind kind = ConfigFunctionParamKind.Any, bool mandatory = false, bool variadic = false, ConfigFunctionReferenceKind reference = ConfigFunctionReferenceKind.None) =>
            new() { Name = name, Kind = kind, IsMandatory = mandatory, IsVariadic = variadic, ReferenceKind = reference };

        private static List<ConfigFunctionDefinition> BuildCatalog()
        {
            const ConfigFunctionParamKind Str = ConfigFunctionParamKind.String;
            const ConfigFunctionParamKind Num = ConfigFunctionParamKind.Number;
            const ConfigFunctionParamKind Bool = ConfigFunctionParamKind.Boolean;

            return
            [
                // Core reference functions (not in ConfigFunctions folder)
                new() { Name = "variable", Parameters = [Param("Name", Str, mandatory: true, reference: ConfigFunctionReferenceKind.VariableName)] },
                new() { Name = "parameter", Parameters = [Param("Name", Str, mandatory: true, reference: ConfigFunctionReferenceKind.ParameterName)] },

                // Logic / string
                new() { Name = "and", Parameters = [Param("Values", mandatory: true, variadic: true)] },
                new() { Name = "or", Parameters = [Param("Values", mandatory: true, variadic: true)] },
                new() { Name = "not", Parameters = [Param("Value", mandatory: true)] },
                new() { Name = "equal", Parameters = [Param("LeftOperand", mandatory: true), Param("RightOperand", mandatory: true)] },
                new() { Name = "if", Parameters = [Param("Condition", mandatory: true), Param("WhenTrue", mandatory: true), Param("WhenFalse", mandatory: true)] },
                new() { Name = "concat", Parameters = [Param("Values", variadic: true)] },
                new() { Name = "join", Parameters = [Param("Values", mandatory: true, variadic: true), Param("Delimiter", Str)] },
                new() { Name = "joinpath", Parameters = [Param("Values", variadic: true)] },
                new() { Name = "split", Parameters = [Param("String", Str, mandatory: true), Param("Characters", Str), Param("ElementsToReturn", Num)] },
                new() { Name = "environment", Parameters = [Param("Name", Str, mandatory: true)] },

                // System / environment checks
                new() { Name = "module", Parameters = [Param("Name", Str, mandatory: true), Param("Version", Bool)] },
                new() { Name = "checkinstalledsoftware", Parameters = [Param("Name", Str, mandatory: true), Param("Version", Bool)] },
                new() { Name = "windowsfeature", Parameters = [Param("Name", Str, mandatory: true)] },

                // Certificates / credentials
                new() { Name = "getcertificate", Parameters = [Param("Id", Str, mandatory: true), Param("CertStorePath", Str)] },
                new() { Name = "getcertificatethumbprint", Parameters = [Param("Id", Str, mandatory: true), Param("CertStorePath", Str)] },
                new() { Name = "resolvecertificatepath", Parameters = [Param("CertificatePath", Str, mandatory: true)] },
                new() { Name = "newpscredential", Parameters = [Param("Username", Str, mandatory: true), Param("Password", Str, mandatory: true)] },
                new() { Name = "randomstring", Parameters =
                [
                    Param("Length", Num, mandatory: true),
                    Param("EnforceComplexity", Bool),
                    Param("DisallowSpecial", Bool),
                    Param("DisallowCaps", Bool),
                    Param("DisallowLower", Bool),
                    Param("DisallowNumbers", Bool),
                ] },

                // Files / paths / network
                new() { Name = "readjson", Parameters = [Param("Path", Str, mandatory: true)] },
                new() { Name = "resolvepath", Parameters = [Param("Path", Str, mandatory: true)] },
                new() { Name = "restauthentication", Parameters = [Param("LoginUri", Str, mandatory: true), Param("Username", Str, mandatory: true), Param("Password", Str, mandatory: true)] },
                new() { Name = "sqlconnectionstring", Parameters = [Param("Server", Str), Param("Database", Str), Param("UserName", Str), Param("Password", Str)] },

                // Validation
                new() { Name = "validatecount", Parameters = [Param("Param", mandatory: true), Param("MinLength", Num), Param("MaxLength", Num)] },
                new() { Name = "validatelength", Parameters = [Param("Param", Str, mandatory: true), Param("MinLength", Num), Param("MaxLength", Num)] },
                new() { Name = "validatenotnull", Parameters = [Param("Param", mandatory: true)] },
                new() { Name = "validatenotnullorempty", Parameters = [Param("Param", mandatory: true)] },
                new() { Name = "validatepattern", Parameters = [Param("Pattern", Str, mandatory: true), Param("Param", mandatory: true), Param("IgnoreCase", Bool)] },
                new() { Name = "validaterange", Parameters = [Param("Param", Num, mandatory: true), Param("Min", Num), Param("Max", Num)] },
                new() { Name = "validateset", Parameters = [Param("Values", Str, mandatory: true, variadic: true), Param("Param", mandatory: true), Param("IgnoreCase", Bool)] },
            ];
        }
    }
}
