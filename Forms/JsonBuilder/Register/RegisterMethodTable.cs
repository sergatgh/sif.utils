namespace SIF.Utils.Forms.JsonBuilder.Register;

using SIF.Utils.Forms.Common;
using System.ComponentModel;
using System.Text.Json.Nodes;

public partial class RegisterMethodTable : UserControl
{
    [Browsable(true)]
    public event ResultEventHandler<string>? MethodAdded;

    [Browsable(true)]
    public event ResultEventHandler<string>? MethodRemoved;

    public List<RegisterMethodModel> RegisterMethods { get; } = [];

    public RegisterMethodTable()
    {
        InitializeComponent();
    }

    public bool HasRegisterMethods => RegisterMethods.Count > 0;

    public void Clear()
    {
        RegisterMethods.Clear();
        listView1.Items.Clear();
    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var addDialog = new RegisterMethodWindow();
        if (addDialog.ShowDialog() != DialogResult.OK) return;

        var model = addDialog.GetRegisterMethodModel();
        AddMethod(model);
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count > 0)
        {
            editToolStripMenuItem.Enabled = true;
            removeToolStripMenuItem.Enabled = true;
        }
        else
        {
            editToolStripMenuItem.Enabled = false;
            removeToolStripMenuItem.Enabled = false;
        }
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedIndices.Count != 1) return;

        var removedMethod = RegisterMethods[listView1.SelectedIndices[0]].RegisterAs;
        RegisterMethods.RemoveAt(listView1.SelectedIndices[0]);
        listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        MethodRemoved?.Invoke(this, removedMethod);
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedIndices.Count != 1) return;

        var selectedIndex = listView1.SelectedIndices[0];
        var model = RegisterMethods[selectedIndex];
        using var editDialog = new RegisterMethodWindow();
        editDialog.SetRegisterMethodModel(model);
        if (editDialog.ShowDialog() != DialogResult.OK) return;
        var updatedModel = editDialog.GetRegisterMethodModel();
        RegisterMethods[selectedIndex] = updatedModel;
        listView1.Items[selectedIndex].Text = updatedModel.RegisterAs;
    }

    public JsonObject GetJsonObject()
    {
        var registerTasksArray = new JsonObject();
        foreach (var method in RegisterMethods)
        {
            registerTasksArray[method.RegisterAs] = method.PowershellFunction;
        }
        return registerTasksArray;
    }

    public void AddMethod(RegisterMethodModel model)
    {
        listView1.Items.Add(model.RegisterAs);
        RegisterMethods.Add(model);
        MethodAdded?.Invoke(this, model.RegisterAs);
    }
}