using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using SIF.Utils.Helpers;

public partial class TaskEditor : UserControl
{
    private bool _enableSectionEditButton;

    public event EventHandler<ParameterSectionEditEventArgs>? SectionEditRequested;

    public TaskEditor()
    {
        InitializeComponent();
        AddSection();
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool EnableSectionEditButton
    {
        get => _enableSectionEditButton;
        set
        {
            _enableSectionEditButton = value;
            foreach (var section in parameterSectionsPanel.Controls.OfType<ParameterSectionControl>())
            {
                section.ShowEditButton = value;
            }
        }
    }

    public void SetDefaultParameters(IReadOnlyDictionary<string, string> defaults)
    {
        var firstSection = parameterSectionsPanel.Controls.OfType<ParameterSectionControl>().FirstOrDefault();
        if (firstSection == null || defaults.Count == 0) return;

        firstSection.LoadParameters(defaults.Select(kv => new TaskParameterModel { Name = kv.Key, Value = kv.Value }));
    }

    public void LoadFromModel(SifJsonTaskModel model)
    {
        nameInput.TextInput = model.Name;
        descriptionInput.TextInput = model.Description ?? string.Empty;
        skipInput.TextInput = model.Skip ?? string.Empty;
        requiresInput.TextInput = model.Requires ?? string.Empty;

        ClearSections();
        if (model.ParamsList.Any())
        {
            foreach (var paramSet in model.ParamsList)
            {
                AddSection(paramSet.Select(p => new TaskParameterModel { Name = p.Name, Value = p.Value }));
            }
        }
        else
        {
            AddSection();
        }
    }

    private void addSectionButton_Click(object sender, EventArgs e) => AddSection();

    private void parameterSectionsPanel_Resize(object sender, EventArgs e)
    {
        foreach (var section in parameterSectionsPanel.Controls.OfType<ParameterSectionControl>())
        {
            SizeSectionToPanel(section);
        }
    }

    private void SizeSectionToPanel(ParameterSectionControl section)
    {
        var availableWidth = parameterSectionsPanel.ClientSize.Width - parameterSectionsPanel.Padding.Horizontal - section.Margin.Horizontal;
        if (availableWidth > 0)
        {
            section.Width = availableWidth;
        }
    }

    private void ClearSections()
    {
        foreach (var section in parameterSectionsPanel.Controls.OfType<ParameterSectionControl>().ToList())
        {
            section.RemoveRequested -= Section_RemoveRequested;
            section.EditRequested -= Section_EditRequested;
            parameterSectionsPanel.Controls.Remove(section);
            section.Dispose();
        }
    }

    private void AddSection(IEnumerable<TaskParameterModel>? parameters = null)
    {
        var section = new ParameterSectionControl();
        section.LoadParameters(parameters ?? Enumerable.Empty<TaskParameterModel>());
        section.ShowEditButton = _enableSectionEditButton;
        section.RemoveRequested += Section_RemoveRequested;
        section.EditRequested += Section_EditRequested;
        parameterSectionsPanel.Controls.Add(section);
        SizeSectionToPanel(section);
        UpdateSectionHeaders();
    }

    private void Section_RemoveRequested(object? sender, EventArgs e)
    {
        if (sender is not ParameterSectionControl section) return;
        if (parameterSectionsPanel.Controls.Count <= 1) return;

        section.RemoveRequested -= Section_RemoveRequested;
        section.EditRequested -= Section_EditRequested;
        parameterSectionsPanel.Controls.Remove(section);
        section.Dispose();
        UpdateSectionHeaders();
    }

    private void Section_EditRequested(object? sender, EventArgs e)
    {
        if (sender is not ParameterSectionControl section) return;
        SectionEditRequested?.Invoke(this, new ParameterSectionEditEventArgs(section));
    }

    private void UpdateSectionHeaders()
    {
        var sections = parameterSectionsPanel.Controls.OfType<ParameterSectionControl>().ToList();
        for (var i = 0; i < sections.Count; i++)
        {
            sections[i].SectionTitle = i == 0 ? "Params" : $"Params{i + 1}";
            sections[i].ShowRemoveButton = sections.Count > 1;
        }
    }

    public (string, JsonObject) GetJson(string? type = null)
    {
        var editor = this;
        var json = new JsonObject();

        if (!string.IsNullOrWhiteSpace(editor.descriptionInput.TextInput))
        {
            json["Description"] = editor.descriptionInput.TextInput;
        }

        if (type != null)
        {
            json["Type"] = type;
        }

        var sections = parameterSectionsPanel.Controls.OfType<ParameterSectionControl>()
            .Select(s => s.GetParameters())
            .ToList();

        if (sections.Count <= 1)
        {
            var parameters = new JsonObject();
            foreach (var param in sections.FirstOrDefault() ?? [])
            {
                parameters[param.Name] = param.Value.ParseConfigVariable();
            }
            json["Params"] = parameters;
        }
        else
        {
            var parametersArray = new JsonArray();
            foreach (var section in sections)
            {
                var parameters = new JsonObject();
                foreach (var param in section)
                {
                    parameters[param.Name] = param.Value.ParseConfigVariable();
                }
                parametersArray.Add(parameters);
            }
            json["Params"] = parametersArray;
        }

        if (!string.IsNullOrWhiteSpace(editor.skipInput.TextInput))
        {
            json["Skip"] = editor.skipInput.TextInput;
        }

        if (!string.IsNullOrWhiteSpace(editor.requiresInput.TextInput))
        {
            json["Requires"] = editor.requiresInput.TextInput;
        }

        return (editor.nameInput.TextInput, json);
    }
}

public class TaskParameterModel
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}

public class ParameterSectionEditEventArgs(ParameterSectionControl section) : EventArgs
{
    public ParameterSectionControl Section { get; } = section;
}