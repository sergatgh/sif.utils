using System.Text.Json;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;

public partial class FilePermissionsTask : AdvancedTask
{
    public override TaskEditor TaskEditor => taskEditor1;

    public List<AccessRightSelection> AccessRights { get; } = [];

    public FilePermissionsTask()
    {
        InitializeComponent();
    }

    private void addAccessRightToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var window = new AccessRightBuilderWindow();
        var result = window.ShowDialog();

        if (result == DialogResult.OK)
        {
            var accessRight = window.GetAccessRightSelection();
            AccessRights.Add(accessRight);
            accessRightsList.Items.Add(accessRight.User);
        }
    }

    private void removeAccessRightToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (var item in accessRightsList.SelectedIndices)
        {
            var index = (int)item;
            AccessRights.RemoveAt(index);
            accessRightsList.Items.RemoveAt(index);
        }
    }

    private void accessRightsList_SelectedIndexChanged(object sender, EventArgs e)
    {
        removeAccessRightToolStripMenuItem.Enabled = accessRightsList.SelectedItems.Count > 0;
        editToolStripMenuItem.Enabled = accessRightsList.SelectedItems.Count == 1;
    }

    public override string GetDefaultName()
    {
        return "FilePermissions";
    }

    public override string GetDefaultDescription()
    {
        return "Set file permissions";
    }

    public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
    {
        var dict = new Dictionary<string, JsonNode>();

        dict["Path"] = filePathInput.TextInput;
        dict["Rights"] = JsonSerializer.SerializeToNode(AccessRights)!;

        return dict;
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (accessRightsList.SelectedItems.Count != 1) return;

        var index = accessRightsList.SelectedIndices[0];
        var accessRight = AccessRights[index];
        using var window = new AccessRightBuilderWindow();
        window.LoadAccessRight(accessRight);
        var result = window.ShowDialog();
        if (result == DialogResult.OK)
        {
            var updatedAccessRight = window.GetAccessRightSelection();
            AccessRights[index] = updatedAccessRight;
            accessRightsList.Items[index].Text = updatedAccessRight.User;
        }
    }
}