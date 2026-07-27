using SIF.Utils.Forms.JsonBuilder.Register;
using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using SIF.Utils.Helpers;
using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls;
using SIF.Utils.Properties;

public partial class TaskBuilderPanel : UserControl
{
    protected List<string> TaskSuggestions { get; } = [];

    public List<TaskBuilderModel> SelectedTasks { get; } = [];

    private bool _isImporting;

    // OLE drag-drop runs its own modal message loop, which swallows WM_MOUSEWHEEL before it
    // reaches the ListView. A low-level mouse hook is the only way to observe wheel input
    // while a drag is in progress, so we install one for the duration of each drag.
    private const int WhMouseLl = 14;
    private const int WmMousewheel = 0x020A;
    private const int LvmScroll = 0x1000 + 20;

    private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential)]
    private struct MsllHookStruct
    {
        public Point Pt;
        public uint MouseData;
        public uint Flags;
        public uint Time;
        public IntPtr DwExtraInfo;
    }

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string? lpModuleName);

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

    private LowLevelMouseProc? _dragWheelProc;
    private IntPtr _dragWheelHookId = IntPtr.Zero;

    [Browsable(true)]
    public event EventHandler? TaskAdded;

    /// <summary>Supplies variable names live from the sibling Variables tab, for the expression builder.</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<IEnumerable<string>>? GetAvailableVariableNames { get; set; }

    /// <summary>Supplies parameter names live from the sibling Parameters tab, for the expression builder.</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<IEnumerable<string>>? GetAvailableParameterNames { get; set; }

    /// <summary>Supplies registered config function names live from the sibling Register tab, for the expression builder.</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<IEnumerable<RegisterMethodModel>>? GetRegisteredConfigFunctions { get; set; }

    public TaskBuilderPanel()
    {
        InitializeComponent();
        InitializeTaskBuilder();
        splitContainer1.Panel2.Resize += (_, _) => CenterImportOverlay();
    }

    /// <summary>Shows a progress bar over the editor pane and suppresses per-item selection/flicker while a batch of tasks is added via <see cref="AddTaskFromModel"/>.</summary>
    public void BeginImport(int totalCount)
    {
        _isImporting = true;
        listView1.BeginUpdate();
        listView1.Enabled = false;

        importProgressBar.Minimum = 0;
        importProgressBar.Maximum = Math.Max(totalCount, 1);
        importProgressBar.Value = 0;
        importStatusLabel.Text = totalCount > 0 ? $"Importing tasks… 0/{totalCount}" : "Importing tasks…";

        splitContainer1.Panel2.Controls.Clear();
        splitContainer1.Panel2.Controls.Add(importOverlayPanel);
        CenterImportOverlay();
        importOverlayPanel.Visible = true;
        importOverlayPanel.BringToFront();
        Application.DoEvents();
    }

    public void EndImport()
    {
        _isImporting = false;
        listView1.Enabled = true;
        listView1.EndUpdate();

        importOverlayPanel.Visible = false;
        splitContainer1.Panel2.Controls.Remove(importOverlayPanel);

        if (listView1.Items.Count > 0)
        {
            listView1.Items[0].Selected = true;
            listView1.Items[0].Focused = true;
        }
    }

    private void CenterImportOverlay()
    {
        var bounds = splitContainer1.Panel2.ClientSize;
        importStatusLabel.Location = new Point((bounds.Width - importStatusLabel.Width) / 2, (bounds.Height / 2) - 24);
        importProgressBar.Location = new Point((bounds.Width - importProgressBar.Width) / 2, (bounds.Height / 2));
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

    public void AddTaskFromModel(SifJsonTaskModel model, int? insertIndex = null)
    {
        var taskInfo = SifFrameworkTasks.Tasks.FirstOrDefault(t => t.Name == model.Type)
                    ?? PowershellTasks.Tasks.FirstOrDefault(t => t.Name == model.Type);

        if (taskInfo != null)
        {
            var editorControl = taskInfo.ControlFactory();
            editorControl.Dock = DockStyle.Fill;
            if (editorControl is TaskEditor taskEditor)
            {
                ApplyExpressionBuilderSources(taskEditor);
                taskEditor.LoadFromModel(model);
            }
            var item = InsertTask(new TaskBuilderModel { Info = taskInfo, EditorControl = editorControl }, taskInfo.DisplayName, taskInfo.DisplayName, insertIndex);
            TaskAdded?.Invoke(taskInfo, EventArgs.Empty);
            if (!_isImporting)
            {
                item.Selected = true;
                ScrollToAndFocusTask(item, editorControl);
            }
        }
        else
        {
            var customTask = new CustomTask(TaskSuggestions.ToArray());
            customTask.Dock = DockStyle.Fill;
            customTask.LoadFromModel(model);
            var info = new TaskInfo { Name = model.Type, DisplayName = model.Name.Or(model.Type) };
            var item = InsertTask(new TaskBuilderModel { Info = info, EditorControl = customTask }, info.DisplayName, "Custom Task", insertIndex);
            TaskAdded?.Invoke(info, EventArgs.Empty);
            if (!_isImporting)
            {
                item.Selected = true;
                ScrollToAndFocusTask(item, customTask);
            }
        }

        if (_isImporting)
            ReportImportProgress();
    }

    private void ReportImportProgress()
    {
        importProgressBar.Value = Math.Min(importProgressBar.Value + 1, importProgressBar.Maximum);
        importStatusLabel.Text = $"Importing tasks… {importProgressBar.Value}/{importProgressBar.Maximum}";
        CenterImportOverlay();
        Application.DoEvents();
    }

    private ListViewItem InsertTask(TaskBuilderModel task, string text, string imageKey, int? insertIndex)
    {
        if (insertIndex is int index && index >= 0 && index <= SelectedTasks.Count)
        {
            SelectedTasks.Insert(index, task);
            return listView1.Items.Insert(index, text, imageKey);
        }

        SelectedTasks.Add(task);
        return listView1.Items.Add(text, imageKey);
    }

    private void InitializeTaskBuilder()
    {
        listView1.AllowDrop = true;
        listView1.ItemDrag += listView1_ItemDrag;
        listView1.DragEnter += listView1_DragEnter;
        listView1.DragOver += listView1_DragOver;
        listView1.DragDrop += listView1_DragDrop;
        listView1.Resize += listView1_Resize;

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
        if (editorControl is TaskEditor taskEditor)
            ApplyExpressionBuilderSources(taskEditor);

        var insertIndex = listView1.SelectedItems.Count > 0
            ? listView1.SelectedItems[0].Index + 1
            : (int?)null;

        var item = InsertTask(new TaskBuilderModel { Info = sender, EditorControl = editorControl }, sender.DisplayName, sender.DisplayName, insertIndex);
        TaskAdded?.Invoke(sender, EventArgs.Empty);
        item.Selected = true;
        ScrollToAndFocusTask(item, editorControl);
    }

    /// <summary>Scrolls the newly added item into view and focuses its first editable property, regardless of
    /// whether the task landed at the start, middle, or end of the list.</summary>
    private static void ScrollToAndFocusTask(ListViewItem item, Control editorControl)
    {
        item.EnsureVisible();

        switch (editorControl)
        {
            case TaskEditor taskEditor:
                taskEditor.FocusNameInput();
                break;
            case CustomTask customTask:
                customTask.FocusTypeInput();
                break;
        }
    }

    private void ApplyExpressionBuilderSources(TaskEditor taskEditor)
    {
        taskEditor.GetAvailableVariableNames = GetAvailableVariableNames;
        taskEditor.GetAvailableParameterNames = GetAvailableParameterNames;
        taskEditor.GetRegisteredConfigFunctions = GetRegisteredConfigFunctions;
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

    private void listView1_Resize(object sender, EventArgs e)
    {
        if (listView1.Columns.Count > 0)
            listView1.Columns[0].Width = listView1.ClientSize.Width;
    }

    private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
            return;

        _dragWheelProc = DragWheelHookCallback;
        _dragWheelHookId = SetWindowsHookEx(WhMouseLl, _dragWheelProc, GetModuleHandle(null), 0);
        try
        {
            listView1.DoDragDrop(e.Item!, DragDropEffects.Move);
        }
        finally
        {
            if (_dragWheelHookId != IntPtr.Zero)
                UnhookWindowsHookEx(_dragWheelHookId);

            _dragWheelHookId = IntPtr.Zero;
            _dragWheelProc = null;
        }
    }

    private IntPtr DragWheelHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        try
        {
            if (nCode >= 0 && wParam == (IntPtr)WmMousewheel)
            {
                var hookStruct = Marshal.PtrToStructure<MsllHookStruct>(lParam);
                var wheelDelta = unchecked((short)((hookStruct.MouseData >> 16) & 0xFFFF));
                ScrollTaskListDuringDrag(wheelDelta);
                return (IntPtr)1;
            }
        }
        catch
        {
            // Never let a hook callback fault take down the system-wide mouse hook.
        }

        return CallNextHookEx(_dragWheelHookId, nCode, wParam, lParam);
    }

    private void ScrollTaskListDuringDrag(int wheelDelta)
    {
        if (!listView1.IsHandleCreated || listView1.Items.Count == 0)
            return;

        var itemHeight = listView1.GetItemRect(0).Height;
        if (itemHeight <= 0)
            return;

        var lines = Math.Max(SystemInformation.MouseWheelScrollLines, 1);
        var pixels = -(wheelDelta / 120) * lines * itemHeight;

        SendMessage(listView1.Handle, LvmScroll, IntPtr.Zero, (IntPtr)pixels);
    }

    private void listView1_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = e.Data?.GetDataPresent(typeof(ListViewItem)) == true
            ? DragDropEffects.Move
            : DragDropEffects.None;
    }

    private void listView1_DragOver(object sender, DragEventArgs e)
    {
        e.Effect = e.Data?.GetDataPresent(typeof(ListViewItem)) == true
            ? DragDropEffects.Move
            : DragDropEffects.None;
    }

    private void listView1_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(typeof(ListViewItem)) != true)
            return;

        var draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem))!;
        var sourceIndex = draggedItem.Index;

        var targetPoint = listView1.PointToClient(new Point(e.X, e.Y));
        var targetItem = listView1.GetItemAt(targetPoint.X, targetPoint.Y);
        var targetIndex = targetItem?.Index ?? listView1.Items.Count - 1;

        if (sourceIndex == targetIndex)
            return;

        var task = SelectedTasks[sourceIndex];
        SelectedTasks.RemoveAt(sourceIndex);
        SelectedTasks.Insert(targetIndex, task);

        var text = draggedItem.Text;
        var imageKey = draggedItem.ImageKey;
        listView1.Items.RemoveAt(sourceIndex);
        var inserted = listView1.Items.Insert(targetIndex, text, imageKey);
        inserted.Selected = true;
    }

    private void listView1_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var item = listView1.GetItemAt(e.X, e.Y);
        if (item != null)
        {
            item.Selected = true;
            item.Focused = true;
        }
    }

    private void listViewContextMenuStrip_Opening(object sender, CancelEventArgs e)
    {
        var hasSelection = listView1.SelectedItems.Count > 0;
        duplicateToolStripMenuItem.Enabled = hasSelection;
        contextMenuRemoveToolStripMenuItem.Enabled = hasSelection;
    }

    private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count != 1)
            return;

        var index = listView1.SelectedItems[0].Index;
        var (name, json) = SelectedTasks[index].ToJson();
        var model = BuildModelFromJson(GetUniqueTaskName(name), json);
        AddTaskFromModel(model, index + 1);
    }

    private string GetUniqueTaskName(string baseName)
    {
        var existingNames = SelectedTasks.Select(t => t.ToJson().Item1).ToHashSet();
        if (!existingNames.Contains(baseName))
            return baseName;

        var counter = 2;
        string candidate;
        do
        {
            candidate = $"{baseName} ({counter})";
            counter++;
        } while (existingNames.Contains(candidate));

        return candidate;
    }

    private static SifJsonTaskModel BuildModelFromJson(string name, JsonObject json)
    {
        var model = new SifJsonTaskModel
        {
            Name = name,
            Description = json["Description"]?.GetValue<string>(),
            Type = json["Type"]?.GetValue<string>() ?? string.Empty,
            Skip = json["Skip"]?.GetValue<string>(),
            Requires = json["Requires"]?.GetValue<string>(),
        };

        switch (json["Params"])
        {
            case JsonObject singleRunParameters:
                model.ParamsList.Add(ToParameterList(singleRunParameters));
                break;
            case JsonArray multipleRunParameters:
                foreach (var runParameters in multipleRunParameters.OfType<JsonObject>())
                {
                    model.ParamsList.Add(ToParameterList(runParameters));
                }
                break;
        }

        return model;
    }

    private static List<SifJsonTaskParameterModel> ToParameterList(JsonObject parameters)
    {
        return parameters.Select(kv => new SifJsonTaskParameterModel
        {
            Name = kv.Key,
            Value = kv.Value?.ToJsonString() ?? string.Empty,
        }).ToList();
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