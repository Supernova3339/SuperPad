///;     SuperPad is licensed under the GNU GPL V3 License | Please refer to this license before modifying code
///;
///;     <https://gitub.com/Supernova3339/SuperPad>
///;







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // so you can see the form/use formcontrols | Ex: button
using System.Net.Mail; // for email
using SuperPad.Properties; // for ssl and saving email settings

namespace SuperPad
{
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
        }
        Point lastPoint; // varible to make form movable | also makes title move the form

        private void label1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Dispose();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // make form movable
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // make text movable so doenst look suspicous
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            // make text movable so doesnt look suspicous
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            // make form movable
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; 
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnAttach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblLocation.Text = openFileDialog1.FileName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string server = serverTextbox.Text;
            string numberStr = portTextbox.Text;
            int number;
            bool isParsable = Int32.TryParse(numberStr, out number);
            string activatessl = SuperPad.Properties.Settings.Default.shareSSL;
            bool sslactivated = bool.Parse(activatessl);

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient(server);
                mail.From = new MailAddress(fromTextbox.Text);
                mail.To.Add(toTextbox.Text);
                mail.Subject = titleLbl.Text;
                mail.Body = bodyLbl.Text;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(lblLocation.Text);
                mail.Attachments.Add(attachment);

                smtp.Port = (number); // set port for smtp server | relies on int converter so varible method works (basically so you can actually change the port and not be stuck on fucking gmail)
                smtp.EnableSsl = sslactivated; // activate ssl (relies on ssl checkbox)
                smtp.Credentials = new System.Net.NetworkCredential(fromTextbox.Text, passwordTextbox.Text); // login temporarily to smtp server to send users subject, body, and message to recipent
                smtp.Send(mail);
                Properties.Settings.Default["shareEmail"] = fromTextbox.Text; // save email 
                Properties.Settings.Default["sharePassword"] = passwordTextbox.Text; // save emails password
                Properties.Settings.Default["shareServer"] = serverTextbox.Text; // save smtp server
                Properties.Settings.Default["sharePort"] = portTextbox.Text; // save smtp port
                DialogResult dialogResult = MessageBox.Show("Note sent!\n\nWould you like to send another one?", "Email Sent", MessageBoxButtons.YesNo, MessageBoxIcon.None); // do confirmation instead of letting user spam button
                if (dialogResult == DialogResult.Yes) // if user wants to send another email do this then close messagebox
                {
                    toTextbox.Clear(); // clear to textbox
                    bodyTextbox.Clear(); // clear body textbox
                    lblLocation.ResetText(); // clear location 
                    openFileDialog1.Reset(); // reset file selected (just in case)
                }
                else if (dialogResult == DialogResult.No) // if user doesnt want to save email settings then close form 
                {
                    Properties.Settings.Default.Save();
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                // catch error and show to user
                MessageBox.Show(ex.Message);
            }
        }

        private void fromTextbox_TextChanged(object sender, EventArgs e)
        {
            // code shit here soon
        }

        private void Share_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save(); // save settings
            this.Dispose(); // close form
        }

        private void Share_Load(object sender, EventArgs e)
        {
            // load email user and pass from previous successful email
            if (fromTextbox.Text == String.Empty) // load only if nothing is in email textbox "From"
            {
                fromTextbox.Text = Properties.Settings.Default.shareEmail;
                passwordTextbox.Text = Properties.Settings.Default.sharePassword;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // ssl checked
                SuperPad.Properties.Settings.Default.shareSSL = "true";
                string activatessl = SuperPad.Properties.Settings.Default.shareSSL;
                Settings.Default.Save();

            }
            else
            {
                // ssl not checked
                checkBox1.Checked = false;
                SuperPad.Properties.Settings.Default.shareSSL = "false";
                string activatessl = SuperPad.Properties.Settings.Default.shareSSL;
                SuperPad.Properties.Settings.Default.Save();

            }
        }
    }
}
