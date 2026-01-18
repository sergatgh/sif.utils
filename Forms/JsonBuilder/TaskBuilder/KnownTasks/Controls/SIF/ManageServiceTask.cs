using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

public partial class ManageServiceTask : AdvancedTask
{
    public override TaskEditor TaskEditor => taskEditor1;

    public ManageServiceTask()
    {
        InitializeComponent();
    }

    public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
    {
        var dict = new Dictionary<string, JsonNode>
        {
            { "Name", nameText.TextInput },
        };

        if (!string.IsNullOrWhiteSpace(displayNameText.TextInput))
        {
            dict["DisplayName"] = displayNameText.TextInput;
        }

        if (!string.IsNullOrWhiteSpace(descriptionText.TextInput))
        {
            dict["Description"] = descriptionText.TextInput;
        }

        if (!string.IsNullOrEmpty(postDelayNumber.Text))
        {
            dict["PostDelay"] = int.Parse(postDelayNumber.Text);
        }

        if (!string.IsNullOrWhiteSpace(statusText.Text))
        {
            dict["Status"] = statusText.Text;
        }

        if (!string.IsNullOrWhiteSpace(serviceType.Text))
        {
            dict["StartupType"] = serviceType.Text;
        }

        return dict;
    }
}