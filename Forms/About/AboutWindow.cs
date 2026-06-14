using System.Diagnostics;

namespace SIF.Utils
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
            var v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (v != null)
            {
                lblVersion.Text = $"v{v.Major}.{v.Minor}";
            }
            creditEntry.PersonName = "Sergey Solomentsev";
            creditEntry.AddLink("LinkedIn", "https://www.linkedin.com/in/sergatln");
            creditEntry.AddLink("GitHub", "https://github.com/sergatgh");
            creditEntry.AddLink("Medium", "https://serg-at.medium.com/");
        }

        private void btnGithubProject_Click(object sender, EventArgs e)
        {
            StartUrl("https://github.com/sergatgh/sif.utils");
        }

        private static void StartUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch { }
        }
    }
}
