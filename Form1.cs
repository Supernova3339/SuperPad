using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Net;
using SuperPad.Properties;
using System.Threading;

namespace SuperPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.ShowIcon = false;
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial" ,12 ,FontStyle.Regular) , Brushes.Black , new Point(10,100)   );
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newwindow = new Form1();
            newwindow.Show();
            newwindow.Activate();
        }

        private void backroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream streamy;
            if (openFileDialog1.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
            {
                if ((streamy = openFileDialog1.OpenFile()) != null)
                {
                    String fn = openFileDialog1.FileName;
                    String ft = File.ReadAllText(fn);
                    fn = System.IO.Path.GetFileName(fn);
                    TabPage tp = new TabPage( fn + "      "); //creates a new tab page
                    RichTextBox rtb = new RichTextBox(); //creates a new richtext box object
                    rtb.Dock = DockStyle.Fill; //docks rich text box
                    rtb.BorderStyle = BorderStyle.None;//borderstyle none for cleaner design
                    tp.Controls.Add(rtb); // adds rich text box to the tab page
                    tabControl1.TabPages.Add(tp); //adds the tab pages to tab control
                    rtb.Text = ft;
                }
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream str = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter strwr = new StreamWriter(str))
                {
                    String fn1 = saveFileDialog1.FileName;
                    strwr.Write(fn1);
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            GetRichTextBox().Font = fontDialog1.Font;
            
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            GetRichTextBox().ForeColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("New Document   "); //creates a new tab page
            RichTextBox rtb = new RichTextBox(); //creates a new richtext box object
            rtb.Dock = DockStyle.Fill;
            rtb.BorderStyle = BorderStyle.None;//docks rich text box
            tp.Controls.Add(rtb); // adds rich text box to the tab page
            tabControl1.TabPages.Add(tp); //adds the tab pages to tab contro
        }
        private RichTextBox GetRichTextBox()
        {
            RichTextBox rtb = null; //making it initially null
            TabPage tp = tabControl1.SelectedTab; // saves the tab selection status in a tabpage type variable
            if (tp != null)
            {
                rtb = tp.Controls[0] as RichTextBox; //sets the selected rich text box index as primary
            }
            return rtb;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = GetRichTextBox().SelectionLength;
            GetRichTextBox().Text = GetRichTextBox().Text.Remove(GetRichTextBox().SelectionStart, a);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = GetRichTextBox().SelectionLength;
            GetRichTextBox().Text = GetRichTextBox().Text.Remove(GetRichTextBox().SelectionStart, a);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) // load settings
        {
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            Bitmap CloseImage = SuperPad.Properties.Resources.closeR;
            tabControl1.Padding = new Point(10, 3);
            if (SuperPad.Properties.Settings.Default.Update == "true")
            {
                WebClient updatecheck = new WebClient();
                if (!updatecheck.DownloadString("http://dl.supers0ft.us/superpad").Contains("2.3"))
                {
                    //outdated
                    notifyIcon1.ShowBalloonTip(1000, "Automatic Updater", "Updates found\n\nClick this notification to install the update", ToolTipIcon.Info);
                }
                else
                {
                    // up to date
                    timer1.Stop();

                }
            }
            if (SuperPad.Properties.Settings.Default.onTop == "true")
            {
                this.TopMost = true;
                toolStripMenuItem6.Checked = true;
            }
            if (SuperPad.Properties.Settings.Default.onTop == "false")
            {
                this.TopMost = false;
                toolStripMenuItem6.Checked = false;
            }
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    richTextBox1.LoadFile(fileNames[0]);
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WebClient updatecheck = new WebClient();
            if (!updatecheck.DownloadString("http://dl.supers0ft.us/superpad").Contains("2.3"))
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutform = new About();
            aboutform.Show();
            aboutform.Activate();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 12, e.Bounds.Top + 6);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 9, e.Bounds.Top + 6);
            e.DrawFocusRectangle();
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (tabControl1.SelectedIndex >= 1)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                    else
                    {
                        // do nothing
                    }
                }
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Download updateinit = new Download();
            updateinit.Show();
            updateinit.Activate();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            Download updatecontext = new Download();
            updatecontext.Show();
            updatecontext.Activate();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutcontext = new About();
            aboutcontext.Show();
            aboutcontext.Activate();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Share sharefile = new Share();
            sharefile.Show();
            sharefile.Activate();
        }

        private static string ReadAllText(string pFilename, Encoding encoding)
        {
            using (var FileStream = new FileStream(pFilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (encoding == null)
                {
                    using (var StreamReader = new StreamReader(FileStream))
                    {
                        var text = StreamReader.ReadToEnd();
                        return text;
                    }
                }
                else
                {
                    using (var StreamReader = new StreamReader(FileStream, encoding, false))
                    {
                        var text = StreamReader.ReadToEnd();
                        return text;
                    }
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            tabControl1.Refresh();
            Thread.Sleep(100);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer2.Stop();
        }

        private void toolStripMenuItem6_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem6.Checked == true)
            {
                SuperPad.Properties.Settings.Default.onTop = "true";
                this.TopMost = true;
                Properties.Settings.Default.Save();
                toolStripMenuItem6.Checked = true;
            }
            else
            {
                SuperPad.Properties.Settings.Default.onTop = "false";
                this.TopMost = false;
                Properties.Settings.Default.Save();
                toolStripMenuItem6.Checked = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
