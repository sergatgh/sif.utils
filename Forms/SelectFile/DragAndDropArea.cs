using SIF.Utils.Forms.Common;

namespace SIF.Utils.Forms.SelectFile;

using System.ComponentModel;
using System.Diagnostics;

public partial class DragAndDropArea : UserControl
{
    private bool _isDragging = false;
    private DragDropEffects _effect = DragDropEffects.Copy;

    protected Color BorderColor { get; set; } = Color.FromArgb(203, 213, 225);
    public event ResultEventHandler<string>? FileSelected;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AllowRawJson { get; set; } = true;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AllowUrl { get; set; } = true;

    public DragAndDropArea()
    {
        InitializeComponent();
        subscribeToMouseDown(this);
    }

    private void browseFileButton_Click(object? sender, EventArgs e)
    {
        var result = openFileForViewerDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            var filePath = openFileForViewerDialog.FileName;
            FileSelected?.Invoke(this, filePath);
        }
    }

    public void UpdateInstructionLabel()
    {
        if (AllowRawJson && AllowUrl)
            labelInstruction.Text = "Drag and Drop SIF JSON file, URL, or raw JSON here";
        else if (AllowRawJson)
            labelInstruction.Text = "Drag and Drop SIF JSON file or raw JSON here";
        else if (AllowUrl)
            labelInstruction.Text = "Drag and Drop SIF JSON file or URL here";
        else
            labelInstruction.Text = "Drag and Drop SIF JSON file or path here";
    }

    private void DragAndDropArea_Paint(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, ClientRectangle, BorderColor, ButtonBorderStyle.Dashed);
    }

    public void subscribeToMouseDown(Control control)
    {
        control.DragEnter += Area_DragEnter;
        control.DragLeave += Area_DragLeave;
        control.DragDrop += Area_DragDrop;
        control.Click += browseFileButton_Click;
        control.AllowDrop = true;

        foreach (Control c in control.Controls)
        {
            subscribeToMouseDown(c);
        }
    }

    private void Area_DragLeave(object? sender, EventArgs e)
    {
        if (!_isDragging) return;

        var pos = PointToClient(MousePosition);
        var inArea = ClientRectangle.Contains(pos);

        if (inArea) return;
        _isDragging = false;

        BorderColor = Color.FromArgb(203, 213, 225);
        BackColor = Color.FromArgb(248, 250, 252);

        Trace.WriteLine("Leave");
    }

    private void Area_DragDrop(object? sender, DragEventArgs e)
    {
        _isDragging = false;
        BorderColor = Color.FromArgb(203, 213, 225);
        BackColor = Color.FromArgb(248, 250, 252);

        if (e.Data == null) return;

        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data == null) return;
            var files = (string[])data;
            var file = files.FirstOrDefault(x => x.EndsWith(".json"));
            if (file != null)
                FileSelected?.Invoke(this, file);
            return;
        }

        if (e.Data.GetDataPresent(DataFormats.UnicodeText) || e.Data.GetDataPresent(DataFormats.Text))
        {
            var text = (e.Data.GetData(DataFormats.UnicodeText) ?? e.Data.GetData(DataFormats.Text)) as string;
            var trimmed = text?.Trim();
            if (!string.IsNullOrWhiteSpace(trimmed) && IsTextDropAllowed(trimmed))
                FileSelected?.Invoke(this, trimmed);
        }
    }

    private void Area_DragEnter(object? sender, DragEventArgs e)
    {
        // Prevent multiple computation on mouse hover events over child controls
        if (_isDragging)
        {
            e.Effect = _effect;
            return;
        }

        _isDragging = true;

        if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var files = (string[])data;
                var file = files.FirstOrDefault(x => x.EndsWith(".json"));
                if (file != null)
                {
                    BorderColor = Color.FromArgb(59, 130, 246);
                    BackColor = Color.FromArgb(238, 246, 255);
                    e.Effect = _effect = DragDropEffects.Copy;
                    return;
                }
            }
        }

        if (e.Data != null && (e.Data.GetDataPresent(DataFormats.UnicodeText) || e.Data.GetDataPresent(DataFormats.Text)))
        {
            var text = (e.Data.GetData(DataFormats.UnicodeText) ?? e.Data.GetData(DataFormats.Text)) as string;
            var trimmed = text?.Trim() ?? string.Empty;
            if (IsTextDropAllowed(trimmed))
            {
                BorderColor = Color.FromArgb(59, 130, 246);
                BackColor = Color.FromArgb(238, 246, 255);
                e.Effect = _effect = DragDropEffects.Copy;
                return;
            }
        }

        e.Effect = _effect = DragDropEffects.None;
    }

    private bool IsTextDropAllowed(string trimmed)
    {
        var isUrl = trimmed.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                    trimmed.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
        var isRawJson = trimmed.StartsWith("{");
        var isFilePath = trimmed.EndsWith(".json", StringComparison.OrdinalIgnoreCase);

        if (isUrl) return AllowUrl;
        if (isRawJson) return AllowRawJson;
        if (isFilePath) return true;
        return false;
    }
}