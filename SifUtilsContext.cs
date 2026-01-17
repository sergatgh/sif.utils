namespace SIF.Utils;

using SIF.Utils.JsonParser;

public class SifUtilsContext
{
    public SifJsonParsingResult? LastResult { get; set; }
    public string[] TasksToExecute { get; set; }
    public bool ExecuteInUninstallMode { get; set; }
    public ParameterEditModel[] ParametersToEdit { get; set; }
    public ParameterEditModel? CurrentEditingParameter { get; set; }
}
