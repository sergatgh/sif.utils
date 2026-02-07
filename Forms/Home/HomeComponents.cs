using SIF.Utils.Forms.Common;

namespace SIF.Utils.Forms.Home
{
    public partial class HomeComponents : UserControl
    {
        public event ResultEventHandler<string>? OpenViewFileDialog;
        public event ResultEventHandler<string>? OpenExecuteFileDialog;
        public event EventHandler? OpenJsonBuilder;

        public HomeComponents()
        {
            InitializeComponent();
        }

        private void openForViewFileDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            OpenViewFileDialog?.Invoke(this, openFileForViewerDialog.FileName);
        }

        private void executeFileDialog_Click(object sender, EventArgs e)
        {
            var result = openFileForViewerDialog.ShowDialog();

            if (result != DialogResult.OK) return;

            OpenExecuteFileDialog?.Invoke(this, openFileForViewerDialog.FileName);
        }


        private void labelButton_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label label) label.ForeColor = SystemColors.Highlight;
        }

        private void labelButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label) label.ForeColor = SystemColors.ControlText;
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
