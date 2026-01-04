using Microsoft.VisualBasic;

namespace SIF.Utils.Forms.JsonBuilder.Modules
{
    public partial class ModulesControlPanel : UserControl
    {
        public ModulesControlPanel()
        {
            InitializeComponent();
        }

        public string[] ModulePaths => listBox1.Items.Cast<string>().ToArray();

        private void button1_Click(object sender, EventArgs e)
        {
            var result = moduleSelector.ShowDialog();

            if (result != DialogResult.OK) return;

            var modulePath = moduleSelector.FileName;
            listBox1.Items.Add(modulePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedItem != null;
        }

        private void addKnownModule_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter module name:", "Enter Known Powershell Module Name", "SitecoreInstallExtensions");

            if (!string.IsNullOrEmpty(input))
            {
                listBox1.Items.Add(input);
            }
        }
    }
}
