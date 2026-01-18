using SIF.Utils.Properties;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

public static class PowershellTasks
{
    public static List<TaskInfo> Tasks { get; } =
    [
        new TaskInfo { Name = "WriteHost", Image = Resources.DefaultPowerShellTaskIcon, Source = "PS", ControlFactory = () => new WriteHostTask() },
    ];
}