using SIF.Utils.Forms.Common;

namespace SIF.Utils.Forms.SelectFile;

using System.Diagnostics;

public partial class DragAndDropArea : UserControl
{
    private bool _isDragging = false;
    private DragDropEffects _effect = DragDropEffects.Copy;

    protected Color BorderColor { get; set; } = Color.FromArgb(203, 213, 225);
    public event ResultEventHandler<string>? FileSelected;

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

        if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

        var data = e.Data.GetData(DataFormats.FileDrop);
        if (data == null) return;

        var files = (string[])data;
        var file = files.FirstOrDefault(x => x.EndsWith(".json"));
        if (file != null)
        {
            FileSelected?.Invoke(this, file);
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

        // Check if the dragged data contains json files
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

        e.Effect = _effect = DragDropEffects.None;
    }
}