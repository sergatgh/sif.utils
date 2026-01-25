using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF.Utils
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://github.com/sergatgh");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://serg-at.medium.com/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://github.com/sergatgh/sif.utils");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUrl("https://www.linkedin.com/in/sergatln");
        }
    }
}