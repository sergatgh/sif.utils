namespace SIF.Utils.Logic.JsonParser;

public class SifJsonParsingResult
{
    public static SifJsonParsingResult Empty = new SifJsonParsingResult()
    {
        Error = "Empty"
    };

    public string Folder { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string? Error { get; set; }

    public bool HasError => !string.IsNullOrWhiteSpace(Error);

    public List<string> Warnings { get; } = [];

    public bool HasWarnings => Warnings.Any(x => !string.IsNullOrWhiteSpace(x));

    public List<SifJsonTaskModel> Tasks { get; set; } = [];

    public List<SifJsonTaskModel> UninstallTasks { get; set; } = [];

    public List<SifJsonParameterModel> Parameters { get; set; } = [];

    public List<SifJsonVariableModel> Variables { get; set; } = [];

    public List<SifJsonIncludeModel> Includes { get; set; } = [];

    public List<SifJsonModuleModel> Modules { get; set; } = [];

    public List<RegisteredElementJsonModel> RegisteredTasks { get; set; } = [];

    public List<RegisteredElementJsonModel> RegisteredConfigFunctions { get; set; } = [];
}