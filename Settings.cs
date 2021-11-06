using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperPad
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void checkUpdates_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkUpdates_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkUpdates.Checked == true)
            {
                SuperPad.Properties.Settings.Default.Update = "true";
                Properties.Settings.Default.Save();

            }
            else
            {
                checkUpdates.Checked = false;
                SuperPad.Properties.Settings.Default.Update = "false";
                SuperPad.Properties.Settings.Default.Save();

            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            darkMode1.Visible = false;
            if (SuperPad.Properties.Settings.Default.Update == "true")
            {
                checkUpdates.Checked = true;
            }
            if (SuperPad.Properties.Settings.Default.Update == "false")
            {
                checkUpdates.Checked = false;
            }
            if (SuperPad.Properties.Settings.Default.darkMode == "true")
            {
                SuperPad.Properties.Settings.Default.rac = "false";
                SuperPad.Properties.Settings.Default.Save();
                darkMode1.Checked = true;
            }
            if (SuperPad.Properties.Settings.Default.darkMode == "false")
            {
                SuperPad.Properties.Settings.Default.rac = "false";
                SuperPad.Properties.Settings.Default.Save();
                darkMode1.Checked = false;
            }
            if (SuperPad.Properties.Settings.Default.allowsharing == "true")
            {
                allowSharing.Checked = true;
            }
            else
            {
                allowSharing.Checked = false;
            }
        }

        private void darkMode1_CheckStateChanged(object sender, EventArgs e)
        {
            if (darkMode1.Checked == true)
            {
                SuperPad.Properties.Settings.Default.darkMode = "true";
                SuperPad.Properties.Settings.Default.Save();
                
                SuperPad.Properties.Settings.Default.rac = "true";
                

            }
            if(darkMode1.Checked == false)
            {
                SuperPad.Properties.Settings.Default.darkMode = "false";
                SuperPad.Properties.Settings.Default.Save();
                SuperPad.Properties.Settings.Default.rac = "false";
            }
}

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (SuperPad.Properties.Settings.Default.rac == "true")
            {
                SuperPad.Properties.Settings.Default.rac = "false";
                SuperPad.Properties.Settings.Default.Save();
                {
                    var restartToApplyChanges = MessageBox.Show("Restart SuperPad to apply changes?", "Appearance Changer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
                    if (restartToApplyChanges == DialogResult.Yes)
                    {
                        SuperPad.Properties.Settings.Default.darkMode = "true";
                        SuperPad.Properties.Settings.Default.rac = "false";
                        SuperPad.Properties.Settings.Default.Save();
                        Thread.Sleep(100);
                        System.Diagnostics.Process.Start("superpad.exe");
                        Environment.Exit(0);

                    }
                    if (restartToApplyChanges == DialogResult.No)
                    {
                        SuperPad.Properties.Settings.Default.darkMode = "false";
                        SuperPad.Properties.Settings.Default.rac = "false";
                        SuperPad.Properties.Settings.Default.Save();
                    }
                }
            }
            if(SuperPad.Properties.Settings.Default.rac == "false")
            {
                SuperPad.Properties.Settings.Default.rac = "false";
                SuperPad.Properties.Settings.Default.Save();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (allowSharing.Checked == true)
            {
                SuperPad.Properties.Settings.Default.allowsharing = "true";
                SuperPad.Properties.Settings.Default.Save();
            }
            if (allowSharing.Checked == false)
            {
                SuperPad.Properties.Settings.Default.allowsharing = "false";
                SuperPad.Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WebClient updatecheck = new WebClient();
            if (!updatecheck.DownloadString("http://dl.supers0ft.us/superpad").Contains(Properties.Settings.Default.version))
            {
                // outdated
                timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("Update Found!\n\nInstall?", "Update Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Download updateinit = new Download();
                    updateinit.Show();
                    updateinit.Activate();
                }
                else if (dialogResult == DialogResult.No)
                {
                    timer1.Stop();
                }
            }
            else
            {
                // up to date
                timer1.Stop();
                MessageBox.Show("No Updates Found", "Update Checker", MessageBoxButtons.OK);

            }
        }
    }
}
