namespace SIF.Utils.Forms.Error;

public partial class ErrorForm : UserControl
{
    public event EventHandler OnBack
    {
        add => this.navigationPanel1.BackClicked += value;
        remove => this.navigationPanel1.BackClicked -= value;
    }

    public ErrorForm()
    {
        DoubleBuffered = true;
        InitializeComponent();
    }

    public void SetData(string error, string context)
    {
        this.errorDescription.Text = error;
        this.documentText.Text = context;
    }
}