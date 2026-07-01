using SIF.Utils.Forms.SelectFile;
using SIF.Utils.Logic.JsonParser;
using System.ComponentModel;
using System.Windows.Forms;

namespace SIF.Utils.Forms.JsonBuilder;

using JsonViewer = SIF.Utils.JsonViewer;

public partial class JsonBuilderForm : UserControl
{
    [Browsable(true)]
    public event EventHandler? BackClicked
    {
        add => navigationPanel.BackClicked += value;
        remove => navigationPanel.BackClicked -= value;
    }

    public JsonBuilderForm()
    {
        DoubleBuffered = true;
        InitializeComponent();

        toolTip1.SetToolTip(previewButton, "Preview JSON");
        toolTip1.SetToolTip(saveJsonToFileButton, "Save as a JSON");
        toolTip1.SetToolTip(importJsonButton, "Import existing JSON (alpha)");
        toolTip1.SetToolTip(newJsonButton, "Start over (clear all)");
    }

    public void LoadFromResult(SifJsonParsingResult result)
    {
        jsonBuilderPanel.LoadFromResult(result);
    }

    private void importJsonButton_Click(object sender, EventArgs e)
    {
        using var dialog = new SelectJsonFileDialog("Import JSON");
        dialog.ShowDialog(this);
        if (dialog.Result != null)
            LoadFromResult(dialog.Result);
    }

    private void saveJsonButton_Click(object sender, EventArgs e)
    {
        var result = saveSifJson.ShowDialog();
        if (result != DialogResult.OK) return;

        string json = jsonBuilderPanel.BuildJson(saveSifJson.FileName);
        File.WriteAllText(saveSifJson.FileName, json);
    }

    private void previewJsonButton_Click(object sender, EventArgs e)
    {
        string json = jsonBuilderPanel.BuildJson();
        new JsonViewer("SIF JSON Preview", json).ShowDialog();
    }

    private void newJsonButton_Click(object sender, EventArgs e)
    {
        if (jsonBuilderPanel.HasContent())
        {
            var answer = MessageBox.Show(
                "All current content will be lost. Do you want to save before starting over?",
                "Start Over",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button3);

            if (answer == DialogResult.Cancel) return;

            if (answer == DialogResult.Yes)
            {
                var saveResult = saveSifJson.ShowDialog();
                if (saveResult != DialogResult.OK) return;
                string json = jsonBuilderPanel.BuildJson(saveSifJson.FileName);
                File.WriteAllText(saveSifJson.FileName, json);
            }
        }

        jsonBuilderPanel.Clear();
    }
}