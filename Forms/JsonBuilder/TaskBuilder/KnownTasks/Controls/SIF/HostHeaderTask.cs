using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

public partial class HostHeaderTask : AdvancedTask
{
    public override TaskEditor TaskEditor => taskEditor1;

    public HostHeaderTask()
    {
        InitializeComponent();
    }

    public override string GetDefaultName()
    {
        return "ManageHostHeader";
    }

    public override string GetDefaultDescription()
    {
        return "Sets the Host header for HTTP requests.";
    }

    public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
    {
        var dict = new Dictionary<string, JsonNode> {
            { "Hostname", hostNameText.TextInput }
        };

        if (ipAddressText.HasText)
        {
            dict.Add("IPAddress", ipAddressText.TextInput);
        }

        dict.Add("Action", addEntryButton.Checked ? "Add" : "Remove");

        return dict;
    }
}