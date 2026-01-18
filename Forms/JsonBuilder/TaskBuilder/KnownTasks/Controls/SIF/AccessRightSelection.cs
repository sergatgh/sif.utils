namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;

public class AccessRightSelection
{
    public string User { get; set; }

    public string[] AccessRights { get; set; }

    public string AccessControlType { get; set; }

    public string[]? InheritanceFlags { get; set; }

    public string[]? PropagationFlags { get; set; }
}