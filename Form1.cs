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
                    richTextBox1.Text = ft;
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
            richTextBox1.Font = fontDialog1.Font;
            
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = richTextBox1.SelectionLength;
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, a);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = richTextBox1.SelectionLength;
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, a);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WebClient updatecheck = new WebClient();
            if (!updatecheck.DownloadString("http://dl.supers0ft.us/superpad").Contains("1.2"))
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
    }
}
