using SIF.Utils.Forms.Common;

namespace SIF.Utils.Forms.SelectFile
{
    public partial class RecentFiles : UserControl
    {
        public event ResultEventHandler<string>? FileSelected;

        public RecentFiles()
        {
            InitializeComponent();
        }

        public void UpdateRecentFiles(IList<RecentFileModel> recentFiles)
        {
            if (filesPanel.HasChildren)
            {
                filesPanel.Controls.Clear();
            }

            if (recentFiles.Count != 0)
            {
                clearAction.Visible = true;

                foreach (var file in recentFiles.Reverse())
                {
                    var recentFileCard = new RecentFileCard(file.FilePath, file.LastOpened)
                    {
                        Dock = DockStyle.Top
                    };
                    recentFileCard.CardClick += (_, _) => OnCardClicked(file.FilePath);
                    filesPanel.Controls.Add(recentFileCard);
                }
            }
        }

        private void OnCardClicked(string fileFilePath)
        {
            FileSelected?.Invoke(this, fileFilePath);
        }

        private void clearAction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.RecentFiles = string.Empty;
            Properties.Settings.Default.Save();
            filesPanel.Controls.Clear();
        }
    }
}
