namespace SIF.Utils.Forms.Learn
{
    using System.Diagnostics;
    using SIF.Utils.Forms.SecondaryNavigation;

    public partial class LearnSIF : Form
    {
        public LearnSIF()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            secondaryNavigationPanel1.LoadFrom(GetNavigationModel(LearnStructureModel.Menu));
            secondaryNavigationPanel1.Select(0,0);
        }

        public virtual SecondaryNavigationModel GetNavigationModel(Dictionary<string, List<LearnPageMenuModel>> menu)
        {
            return new SecondaryNavigationModel("Content")
            {
                Categories = menu.Select(x => new CategoryModel(x.Key)
                {
                    Links = x.Value.Select(y => new LinkModel(y.Image, y.Name) { Click = (_,_) => LoadFile(y) }).ToList(),
                }).ToList()
            };
        }

        public virtual void LoadFile(LearnPageMenuModel learnPageMenu)
        {
            if (learnPageMenu.FileFactory == null)
            {
                richTextBox1.Text = "No content";
                return;
            }

            using var unmanagedMemoryStream = new MemoryStream(learnPageMenu.FileFactory());
            richTextBox1.LoadFile(
                unmanagedMemoryStream, RichTextBoxStreamType.RichText
            );
            richTextBox1.SelectionStart = 0;
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.LinkText)) return;

            StartUrl(e.LinkText);
        }

        private void StartUrl(string url)
        {
            try
            {
                var link = new ProcessStartInfo(url) { UseShellExecute = true };
                Process.Start(link);
            }
            catch
            {
                // hack because of this:
            }
        }

    }
}
