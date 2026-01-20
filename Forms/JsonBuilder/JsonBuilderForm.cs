using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
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
        InitializeComponent();
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
}