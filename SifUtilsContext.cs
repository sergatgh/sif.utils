namespace SIF.Utils;

public class SifUtilsContext
{
    public string? LastSelectedFile { get; set; }
    public SifJsonParsingResult? LastResult { get; set; }
    public FileChooseMode FileChooseMode { get; set; }
    public string[] TasksToExecute { get; set; }
    public bool ExecuteInUninstallMode { get; set; }
    public ParameterEditModel[] ParametersToEdit { get; set; }
    public ParameterEditModel? CurrentEditingParameter { get; set; }
}

public enum FileChooseMode
{
    View,
    Script,
}