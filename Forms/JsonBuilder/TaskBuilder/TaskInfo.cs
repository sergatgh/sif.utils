namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

using System.Text.RegularExpressions;
using SIF.Utils.Properties;


public class TaskInfo
{
    public string Name { get; set; } = string.Empty;

    public Image Image { get => field ?? Resources.DefaultTaskIcon; set => field = value; }

    public string Source { get; set; } = string.Empty;

    public Func<UserControl> ControlFactory { get; set; } = () => new TaskEditor();

    public string DisplayName
    {
        get => field ??= GetDisplayNameInternal();
        set => field = value;
    }

    protected virtual string GetDisplayNameInternal()
    {
        if (string.IsNullOrEmpty(Name))
        {
            return string.Empty;
        }

        // Use a regular expression to insert a space before each uppercase letter
        // that is not at the beginning of the string.
        var result = Regex.Replace(Name, "([A-Z])", " $1").Trim();

        // Capitalize the first letter of the entire string if it's not already.
        if (result.Length > 0 && char.IsLower(result[0]))
        {
            result = char.ToUpper(result[0]) + result[1..];
        }

        return result;
    }
}