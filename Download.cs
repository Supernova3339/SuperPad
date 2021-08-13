using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SuperPad
{
    public partial class Download : Form
    {
        WebClient wc = new WebClient();
        public Download()
        {
            InitializeComponent();
        }

       private void Download_Load(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted);
                    Uri url = new Uri("http://dl.supers0ft.us/superpad/superpadsetup.exe");
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted);
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    wc.DownloadFileAsync(url, "superpadsetup.exe");
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Close();
            Process.Start("superpadsetup.exe");
        }

    }
}






