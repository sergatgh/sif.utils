using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using System.ComponentModel;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

public partial class TaskBuilderPanel : UserControl
{
    public List<TaskBuilderModel> SelectedTasks { get; } = [];

    [Browsable(true)]
    public event EventHandler? TaskAdded;

    public TaskBuilderPanel()
    {
        InitializeComponent();
    }

    public void TaskBuilderPanel_Load(object sender, EventArgs e)
    {
        listView1.Items.Clear();
        defaultToolStripMenuItem.DropDownItems.Clear();
        powerShellToolStripMenuItem.DropDownItems.Clear();
        imageList1.Images.Clear();

        SifFrameworkTasks.Tasks.ForEach(task =>
        {
            defaultToolStripMenuItem.DropDownItems.Add(task.DisplayName, task.Image, (_, _) => TaskClicked(task));

            if (imageList1.Images.ContainsKey(task.DisplayName))
                return;

            imageList1.Images.Add(task.DisplayName, task.Image);
        });

        PowerShellTasks.Tasks.ForEach(task =>
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
        if (listView1.SelectedItems.Count > 0)
        {
            SelectedTasks.RemoveAt(listView1.SelectedItems[0].Index);
            listView1.Items.Remove(listView1.SelectedItems[0]);
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
}