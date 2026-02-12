using SIF.Utils.Forms.Common;

namespace SIF.Utils.Forms.Home
{
    public partial class HomeComponents : UserControl
    {
        public event EventHandler? OpenViewFileDialog;
        public event EventHandler? OpenExecuteFileDialog;
        public event EventHandler? OpenJsonBuilder;

        public HomeComponents()
        {
            InitializeComponent();
        }

        private void openForViewFileDialog_Click(object sender, EventArgs e)
        {
            OpenViewFileDialog?.Invoke(this, e);
        }

        private void executeFileDialog_Click(object sender, EventArgs e)
        {
            OpenExecuteFileDialog?.Invoke(this, e);
        }

        private void aboutWindowButton_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void learnSifButton_Click(object sender, EventArgs e)
        {
            new LearnSIF().ShowDialog();
        }

        private void sifBuilderFlow_Click(object sender, EventArgs e)
        {
            OpenJsonBuilder?.Invoke(this, EventArgs.Empty);
        }
    }
}
