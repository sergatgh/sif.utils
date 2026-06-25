using SIF.Utils.Logic.JsonParser;

namespace SIF.Utils.Forms.SelectFile;

public partial class SelectJsonFileDialog : Form
{
    public SifJsonParsingResult? Result { get; private set; }

    public SelectJsonFileDialog(string title = "Select File")
    {
        InitializeComponent();
        Text = title;

        selectFileForm.FileSelected += (s, args) =>
        {
            if (!args.Result.HasError)
            {
                Result = args.Result;
                DialogResult = DialogResult.OK;
                Close();
            }
        };

        selectFileForm.UpdateRecentFiles();
    }
}
