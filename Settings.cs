using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
    }
}
