using SIF.Utils.Properties;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

using Controls.Primitive;

public static class PowershellTasks
{
    public static List<TaskInfo> Tasks { get; } =
    [
        new TaskInfo { Name = "WriteHost", Image = Resources.DefaultPowerShellTaskIcon, Source = "PS", ControlFactory = CreateWriteHostEditor },
    ];

    private static TaskEditor CreateWriteHostEditor()
    {
        var editor = new TaskEditor();
        editor.SetDefaultParameters(new Dictionary<string, string> { ["Object"] = "Hello World!" });
        editor.EnableSectionEditButton = true;
        editor.SectionEditRequested += (_, e) => EditWriteHostSection(e.Section);
        return editor;
    }

    private static void EditWriteHostSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new WriteHostTaskDialog
        {
            nameInput = { TextInput = parameters.FirstOrDefault(p => p.Name == "Object")?.Value ?? string.Empty },
            colorSelector = { Text = parameters.FirstOrDefault(p => p.Name == "ForegroundColor")?.Value ?? string.Empty },
            backgroundColorInput = { Text = parameters.FirstOrDefault(p => p.Name == "BackgroundColor")?.Value ?? string.Empty },
        };

        using var form = new EditSectionDialogForm(dialog, "Edit Write Host Message");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "Object", Value = dialog.nameInput.TextInput },
        };
        if (!string.IsNullOrEmpty(dialog.backgroundColorInput.Text))
        {
            updated.Add(new TaskParameterModel { Name = "BackgroundColor", Value = dialog.backgroundColorInput.Text });
        }
        if (!string.IsNullOrEmpty(dialog.colorSelector.Text))
        {
            updated.Add(new TaskParameterModel { Name = "ForegroundColor", Value = dialog.colorSelector.Text });
        }

        section.LoadParameters(updated);
    }
}
