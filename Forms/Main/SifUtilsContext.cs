namespace SIF.Utils.Forms.Main;

using SIF.Utils.Forms.Common;
using SIF.Utils.Logic.JsonParser;

public class SifUtilsContext
{
    public SifJsonParsingResult? LastResult { get; set; }
    public string[] TasksToExecute { get; set; } = [];
    public bool ExecuteInUninstallMode { get; set; }
    public ParameterEditModel[] ParametersToEdit { get; set; } = [];
}
