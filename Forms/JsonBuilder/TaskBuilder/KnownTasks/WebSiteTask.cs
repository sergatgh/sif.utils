namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

public partial class WebSiteTask : UserControl, IAdvancedTask
{
    private bool pathIsDirty = false;
    private bool appPoolIsDirty = false;
    private bool hostNameIsDirty = false;
    private bool nameIsDirty = false;
    private bool descriptionIsDirty = false;

    public WebSiteTask()
    {
        InitializeComponent();
        taskEditor1.nameInput.KeyDown += (_, _) => nameIsDirty = true;
        taskEditor1.descriptionInput.KeyDown += (_, _) => descriptionIsDirty = true;
    }

    private void WebSiteTask_Load(object sender, EventArgs e)
    {
        var defaultSiteName = "sc10.local";
        nameInput.TextInput = defaultSiteName;
        pathInput.TextInput = $@"C:\inetpub\wwwroot\{defaultSiteName}";
        appPoolInput.TextInput = defaultSiteName;
        hostInput.TextInput = defaultSiteName;
        taskEditor1.nameInput.TextInput = GetDefaultName();
        taskEditor1.descriptionInput.TextInput = GetDefaultDescription();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var directorySelectResult = selectWebsiteFolder.ShowDialog();
        if (directorySelectResult != DialogResult.OK) return;

        pathInput.TextInput = selectWebsiteFolder.SelectedPath;
    }

    public TaskEditor TaskEditor => taskEditor1;

    public Dictionary<string, JsonNode> GetAdditionalJsonProperties()
    {
        var dict = new Dictionary<string, JsonNode>
        {
            { "Name", nameInput.TextInput },
            { "PhysicalPath", pathInput.TextInput },
            { "Port", portInput.TextInput },
            { "ApplicationPool", appPoolInput.TextInput }
        };

        if (!string.IsNullOrEmpty(hostInput.TextInput))
        {
            dict["HostName"] = hostInput.TextInput;
        }

        if (!string.IsNullOrEmpty(ipAddressInput.TextInput))
        {
            dict["IPAddress"] = ipAddressInput.TextInput;
        }

        return dict;
    }

    public virtual string GetDefaultName()
    {
        if (nameInput.TextInput.Length == 0) return "Create_Website";

        string name = Regex.Replace(nameInput.TextInput, "[^a-zA-Z0-9]", "");
        return $"Create_{name}_Website";
    }

    public virtual string GetDefaultDescription()
    {
        return nameInput.TextInput.Length == 0 ? "" : $"Create Web Site [{nameInput.TextInput}]";
    }

    private void nameInput_TextChanged(object sender, EventArgs e)
    {
        if (!pathIsDirty)
        {
            pathInput.TextInput = $@"C:\inetpub\wwwroot\{nameInput.TextInput}";
        }

        if (!appPoolIsDirty)
        {
            appPoolInput.TextInput = $"{nameInput.TextInput}";
        }

        if (!hostNameIsDirty)
        {
            hostInput.TextInput = $"{nameInput.TextInput}";
        }

        if (!nameIsDirty)
        {
            taskEditor1.nameInput.TextInput = GetDefaultName();
        }

        if (!descriptionIsDirty)
        {
            taskEditor1.descriptionInput.TextInput = GetDefaultDescription();
        }
    }

    private void pathInput_KeyDown(object sender, KeyEventArgs e)
    {
        pathIsDirty = true;
    }

    private void appPoolInput_KeyDown(object sender, KeyEventArgs e)
    {
        appPoolIsDirty = true;
    }

    private void hostInput_KeyDown(object sender, KeyEventArgs e)
    {
        hostNameIsDirty = true;
    }
}
