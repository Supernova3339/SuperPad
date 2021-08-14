using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPad.Properties;

namespace SuperPad
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            label2.Text = "Version " + version;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void About_Load(object sender, EventArgs e)
        {
            if (SuperPad.Properties.Settings.Default.Update == "true")
            {
                checkUpdates.Checked = true;
            }
            else
            {
                checkUpdates.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Supernova3339/superpad");
        }

        private void checkUpdates_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkUpdates_Click(object sender, EventArgs e)
        {

        }

        private void checkUpdates_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkUpdates.Checked == true)
            {
                SuperPad.Properties.Settings.Default.Update = "true";
                Settings.Default.Save();

            }
            else
            {
                checkUpdates.Checked = false;
                SuperPad.Properties.Settings.Default.Update = "false";
                SuperPad.Properties.Settings.Default.Save();

            }
        }
    }
}
