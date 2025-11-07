namespace SIF.Utils;

public class SifUtilsContext
{
    public string? LastSelectedFile { get; set; }
    public SifJsonParsingResult? LastResult { get; set; }
    public FileChooseMode FileChooseMode { get; set; }
}

public enum FileChooseMode
{
    View,
    Script,
}