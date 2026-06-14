using System.Diagnostics;

namespace SIF.Utils.Forms.About
{
    public partial class CreditEntryControl : UserControl
    {
        public CreditEntryControl()
        {
            InitializeComponent();
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string PersonName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public void AddLink(string label, string url)
        {
            var btn = new Button
            {
                Text = label,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(0, 120, 212),
                Font = new Font("Segoe UI", 11F),
                AutoSize = true,
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 8, 0),
                Padding = new Padding(2, 0, 2, 0),
                UseVisualStyleBackColor = false,
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            btn.Click += (_, _) => StartUrl(url);
            flowLinks.Controls.Add(btn);
        }

        private static void StartUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Could not open the link.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
