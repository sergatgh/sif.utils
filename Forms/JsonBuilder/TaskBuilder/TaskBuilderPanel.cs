using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using SIF.Utils.Helpers;
using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls;
using SIF.Utils.Properties;

public partial class TaskBuilderPanel : UserControl
{
    protected List<string> TaskSuggestions { get; } = [];

    public List<TaskBuilderModel> SelectedTasks { get; } = [];

    [Browsable(true)]
    public event EventHandler? TaskAdded;

    public TaskBuilderPanel()
    {
        InitializeComponent();
    }

    public void AddTypeSuggestion(string type)
    {
        TaskSuggestions.Add(type);

        foreach (var task in SelectedTasks)
        {
            if (task.EditorControl is CustomTask customTask)
            {
                customTask.AddSuggestions(type);
            }
        }
    }

    public void RemoveTypeSuggestion(string type)
    {
        TaskSuggestions.Remove(type);

        foreach (var task in SelectedTasks)
        {
            if (task.EditorControl is CustomTask customTask)
            {
                customTask.RemoveSuggestions(type);
            }
        }
    }

    public void Clear()
    {
        SelectedTasks.Clear();
        listView1.Items.Clear();
        splitContainer1.Panel2.Controls.Clear();
    }

    public void AddTaskFromModel(SifJsonTaskModel model)
    {
        var taskInfo = SifFrameworkTasks.Tasks.FirstOrDefault(t => t.Name == model.Type)
                    ?? PowershellTasks.Tasks.FirstOrDefault(t => t.Name == model.Type);

        if (taskInfo != null)
        {
            var editorControl = taskInfo.ControlFactory();
            editorControl.Dock = DockStyle.Fill;
            if (editorControl is AdvancedTask advancedTask)
                advancedTask.LoadFromModel(model);
            SelectedTasks.Add(new TaskBuilderModel { Info = taskInfo, EditorControl = editorControl });
            var item = listView1.Items.Add(taskInfo.DisplayName, taskInfo.DisplayName);
            TaskAdded?.Invoke(taskInfo, EventArgs.Empty);
            item.Selected = true;
        }
        else
        {
            var customTask = new CustomTask(TaskSuggestions.ToArray());
            customTask.Dock = DockStyle.Fill;
            customTask.LoadFromModel(model);
            var info = new TaskInfo { Name = model.Type, DisplayName = model.Name.Or(model.Type) };
            SelectedTasks.Add(new TaskBuilderModel { Info = info, EditorControl = customTask });
            var item = listView1.Items.Add(info.DisplayName, "Custom Task");
            TaskAdded?.Invoke(info, EventArgs.Empty);
            item.Selected = true;
        }
    }

    public void TaskBuilderPanel_Load(object sender, EventArgs e)
    {
        listView1.Items.Clear();
        defaultToolStripMenuItem.DropDownItems.Clear();
        powerShellToolStripMenuItem.DropDownItems.Clear();
        imageList1.Images.Clear();
        imageList1.Images.Add("Custom Task", Resources.DefaultTaskIcon);

        SifFrameworkTasks.Tasks.ForEach(task =>
        {
            defaultToolStripMenuItem.DropDownItems.Add(task.DisplayName, task.Image, (_, _) => TaskClicked(task));

            if (imageList1.Images.ContainsKey(task.DisplayName))
                return;

            imageList1.Images.Add(task.DisplayName, task.Image);
        });

        PowershellTasks.Tasks.ForEach(task =>
        {
            powerShellToolStripMenuItem.DropDownItems.Add(task.DisplayName, task.Image, (_, _) => TaskClicked(task));

            if (imageList1.Images.ContainsKey(task.DisplayName))
                return;

            imageList1.Images.Add(task.DisplayName, task.Image);
        });
    }

    private void TaskClicked(TaskInfo sender)
    {
        var editorControl = sender.ControlFactory();
        editorControl.Dock = DockStyle.Fill;
        SelectedTasks.Add(new TaskBuilderModel { Info = sender, EditorControl = editorControl });
        var item = listView1.Items.Add(sender.DisplayName, sender.DisplayName);
        TaskAdded?.Invoke(sender, EventArgs.Empty);
        item.Selected = true;
    }

    private void splitContainer1_Panel2_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data == null)
        {
            e.Effect = DragDropEffects.None;
            return;
        }

        if (e.Data.GetDataPresent(DataFormats.Text)) // Check if the dragged data is text
        {
            e.Effect = DragDropEffects.Move; // Allow moving the data
        }
        else
        {
            e.Effect = DragDropEffects.None; // Disallow dropping
        }
    }

    private void splitContainer1_Panel2_DragDrop(object sender, DragEventArgs e)
    {
        string droppedData = e.Data?.GetData(DataFormats.Text)?.ToString() ?? string.Empty;
    }

    private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
            return;

        listView1.DoDragDrop(e.Item.ToString(), DragDropEffects.Move);
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 1)
        {
            var index = listView1.SelectedItems[0].Index;
            var nextIndex = index;
            if (nextIndex + 1 >= listView1.Items.Count)
                nextIndex = index - 1;

            SelectedTasks.RemoveAt(index);
            listView1.Items.Remove(listView1.SelectedItems[0]);

            if (nextIndex >= 0)
            {
                listView1.Items[nextIndex].Selected = true;
            }
        }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        removeToolStripMenuItem.Enabled = listView1.SelectedItems.Count > 0;
        splitContainer1.Panel2.Enabled = listView1.SelectedItems.Count > 0;

        if (listView1.SelectedItems.Count == 1)
        {
            var selectedIndex = listView1.SelectedItems[0].Index;
            var selectedTask = SelectedTasks[selectedIndex];
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(selectedTask.EditorControl);
        }

        if (listView1.SelectedItems.Count == 0)
        {
            splitContainer1.Panel2.Controls.Clear();
        }
    }

    private void customToolStripMenuItem_Click(object sender, EventArgs e)
    {
        TaskClicked(new TaskInfo
        {
            DisplayName = "Custom Task",
            ControlFactory = () => new KnownTasks.Controls.CustomTask(TaskSuggestions.ToArray()),
        });
    }
}