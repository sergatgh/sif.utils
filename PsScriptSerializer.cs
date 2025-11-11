using System.Text;

namespace SIF.Utils;

public class PsScriptSerializerOptions
{
    public string Path { get; set; } = string.Empty;
    public bool Uninstall { get; set; } = false;
    public bool Verbose { get; set; } = false;
    public string? ErrorAction { get; set; } = null;
    public bool Inline { get; set; }
    public string[] IncludeTasks { get; set; } = [];
}

public class PsScriptSerializer
{
    public string SerializeToString(IList<ParameterEditModel> parameters, PsScriptSerializerOptions options)
    {
        var sb = new StringBuilder();
        var filteredParameters = parameters
            .Where(p => !p.HasDefaultValue || (p.HasDefaultValue && p.DefaultValue != p.Value))
            .Where(p => !p.IsReference || (p.IsReference && !string.IsNullOrWhiteSpace(p.Value)))
            .ToList();

        if (!options.Inline)
        {
            sb.AppendLine("$executionParams = @{");

            sb.AppendLine($"  Path = \"{options.Path}\"");

            foreach (var parameter in filteredParameters)
            {
                var line = $"  {parameter.Name} = \"{parameter.Value}\"";
                sb.AppendLine(line);
            }

            sb.AppendLine("}");
            sb.AppendLine();
        }

        sb.Append("Install-SitecoreConfiguration");

        if (options.Inline)
        {
            sb.Append($" -Path \"{options.Path}\"");
            foreach (var parameter in filteredParameters)
            {
                sb.Append($" -{parameter.Name} \"{parameter.Value}\"");
            }
        }
        else
        {
            sb.Append(" @executionParams");
        }

        if (options.IncludeTasks.Length > 0)
        {
            var tasks = string.Join(",", options.IncludeTasks.Select(x => $"\"{x}\""));
            sb.Append($" -Tasks {tasks}");
        }

        if (options.Uninstall)
        {
            sb.Append(" -Uninstall");
        }

        if (options.Verbose)
        {
            sb.Append(" -Verbose");
        }

        if (options.ErrorAction is not null)
        {
            sb.Append($" -ErrorAction {options.ErrorAction}");
        }

        return sb.ToString();
    }
}