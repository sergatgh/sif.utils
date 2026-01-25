using SIF.Utils.Forms.Common;
using SIF.Utils.JsonParser;
using System.Diagnostics;

namespace SIF.Utils.Forms.ExportRunner;

public partial class ExportRunnerForm : UserControl
{
    private SifJsonParsingResult _currentResult = SifJsonParsingResult.Empty;
    private ParameterEditModel[] _parameters = [];

    public event EventHandler OnHome
    {
        add => homeNavigationButton.Click += value;
        remove => homeNavigationButton.Click -= value;
    }

    public event EventHandler OnBack
    {
        add => navigationPanel1.BackClicked += value;
        remove => navigationPanel1.BackClicked -= value;
    }

    public ExportRunnerForm()
    {
        InitializeComponent();

        this.OnBack += (_, _) => Clear();
        this.OnHome += (_, _) => Clear();

        toolTipText.SetToolTip(executeInShell, "Execute script in local PowerShell instance");
        toolTipText.SetToolTip(copyToClipboardProperties, "Copy script to clipboard");
        toolTipText.SetToolTip(homeNavigationButton, "Back to the home page");
        toolTipText.SetToolTip(exportToFileProperties, "Save script to the file");
    }

    public void SetUninstallChecked(bool check)
    {
        includeUninstallOption.Checked = check;
    }

    public void Clear()
    {
        this._currentResult = SifJsonParsingResult.Empty;
        this._parameters = [];

        scriptToExport.Text = string.Empty;
        includeUninstallOption.Checked = false;
        tasksToolStripMenuItem.DropDownItems.Clear();
        inlineParametersOption.Checked = true;
        includeVerboseOption.Checked = false;
        errorActionDropdown.Text = string.Empty;
    }

    private void copyToClipboardProperties_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(scriptToExport.Text);
    }

    public void SetCurrentSifResult(SifJsonParsingResult parsingResult)
    {
        _currentResult = parsingResult;
    }

    public void SetCurrentParameters(ParameterEditModel[] parameters)
    {
        _parameters = parameters;
    }

    private void exportToFileProperties_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllText(saveFileDialog1.FileName, scriptToExport.Text);
        }
    }

    private void executeInShell_Click(object sender, EventArgs e)
    {
        var text = scriptToExport.Text;
        if (string.IsNullOrWhiteSpace(text)) return;

        var cdCommand = $"cd \\\"{_currentResult?.Folder}\\\"";

        var argument = $" -NoExit -Command \"{cdCommand};{text.Replace("\"", "\\\"")}\"";
        Process.Start("powershell.exe", argument);
    }

    public void GenerateExportScript()
    {
        var options = new PsScriptSerializerOptions
        {
            Path = _currentResult?.FilePath ?? "",
            Uninstall = includeUninstallOption.Checked,
            Verbose = includeVerboseOption.Checked,
            ErrorAction = errorActionDropdown.SelectedItem?.ToString(),
            Inline = inlineParametersOption.Checked,
            IncludeTasks = tasksToolStripMenuItem.DropDownItems
                .Cast<ToolStripMenuItem>()
                .Where(item => item.Checked)
                .Select(item => item.Text)
                .ToArray()!,
        };

        var parameterEditModels = _parameters;

        var text = new PsScriptSerializer().SerializeToString(parameterEditModels, options);

        scriptToExport.Text = text;
    }

    public void ShowTasksForScript(string[] tasksToExecute)
    {
        tasksToolStripMenuItem.DropDownItems.Clear();

        var tasks =
            includeUninstallOption.Checked ?
                _currentResult?.UninstallTasks ?? [] :
                _currentResult?.Tasks ?? [];

        tasksToolStripMenuItem.DropDownItems.AddRange(
            tasks.Select(task =>
            {
                var item = new ToolStripMenuItem(task.Name);
                item.CheckOnClick = true;
                item.Checked = tasksToExecute.Contains(task.Name);
                item.CheckStateChanged += (_, _) =>
                {
                    GenerateExportScript();
                };
                return item;
            }).ToArray<ToolStripItem>()
        );
    }

    private void errorActionDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
        GenerateExportScript();
    }

    private void inlineParametersOption_CheckedChanged(object sender, EventArgs e)
    {
        GenerateExportScript();
    }

    private void includeUninstallOption_CheckedChanged(object sender, EventArgs e)
    {
        GenerateExportScript();
        ShowTasksForScript([]);
    }

    private void includeVerboseOption_CheckedChanged(object sender, EventArgs e)
    {
        executeInShell.Enabled = inlineParametersOption.Checked;
        GenerateExportScript();
    }
}