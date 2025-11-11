using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF.Utils
{
    public partial class LearnSIF : Form
    {
        public LearnSIF()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://developers.sitecore.com/api/download?file=Sitecore%20Installation%20Framework/2x/Sitecore%20Installation%20Framework%20240/Secure/Sitecore_Installation_Framework_Configuration_Guide-2.4.0.pdf");
        }

        private void StartUrl(string url)
        {
            try
            {
                var link = new ProcessStartInfo(url) { UseShellExecute = true };
                System.Diagnostics.Process.Start(link);
            }
            catch
            {
                // hack because of this:
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://developers.sitecore.com/api/download?file=Sitecore%20Installation%20Framework/2x/Sitecore%20Installation%20Framework%20230/Secure/Sitecore_Installation_Framework_Configuration_Guide-2.3.0.pdf");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://www.youtube.com/watch?v=x0FQhV4o_Ss");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://www.youtube.com/watch?v=-OqsrjlzwS0");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://www.youtube.com/watch?v=aA3V9ivixJ4");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://www.youtube.com/watch?v=nDCaAkpoF68");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://serg-at.medium.com/sif-a-clear-start-and-the-simplest-hello-world-60291374901d");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://medium.com/@serg-at/sif-writing-your-first-custom-task-89ef6e6a1a76");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://medium.com/@serg-at/sif-teaching-json-to-think-skip-requires-validate-and-configfunctions-magic-62700b8a124c");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://developers.sitecore.com/api/download?file=Sitecore%20Installation%20Framework/2x/Sitecore%20Installation%20Framework%20220/Secure/Sitecore_Installation_Framework_Configuration_Guid-2.2.0.pdf");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://medium.com/@serg-at/sif-uninstalltasks-and-includes-the-other-side-of-tasks-815e308f32a9");
        }
    }
}
