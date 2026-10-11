using BloatynosyAI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class SettingsPageView : UserControl
    {
        public SettingsPageView()
        {
            InitializeComponent();
        }

        private void SettingsPageView_Load(object sender, EventArgs e)
        {
            linkFollow.Text = "\uE8E1 GitHub";
            lblVersion.Text = "Version " + Program.GetCurrentVersionTostring() + " Caleb";
        }

        private void linkAppInfos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start("https://github.com/builtbybel/BloatynosyAI");

        private void linkFollow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://github.com/builtbybel/BloatynosyAI");

        private void linkCreditsAppIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start("https://www.flaticon.com/free-icon/maintenance_8794698");
    }
}