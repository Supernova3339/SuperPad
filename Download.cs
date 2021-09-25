using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace SuperPad
{
    public partial class Download : Form
    {
        
        [DllImport("user32")]
        private static extern bool SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32")]
        private static extern bool ShowWindowAsync(IntPtr hwnd, int a);
        WebClient wc = new WebClient();

        public Download()
        {
            InitializeComponent();
        }

       private void Download_Load(object sender, EventArgs e)
        {
            spsLbl.Visible = false;
            md5Lbl.Visible = false;
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                lblStatus.Text = "Status: Downloading update from server";
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

        private  void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private async void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            string md5checkhash = SuperPad.Properties.Settings.Default.md5;
            md5Lbl.Text = "C64C1D0D2CC15C9A1E0B730295027FB8";
            cancelBtn.Visible = false;
            lblStatus.Text = "Status: Verifying package integrity";
            // Verify package integrity | check md5
            string fileName = spsLbl.Text;

            if (File.Exists("superpadsetup.exe"))
            {
                byte[] md5HashBytes = await Task.Run(() => ComputeMd5Hash(fileName));

                md5Lbl.Text = ToHexadecimal(md5HashBytes);
                if (!string.IsNullOrWhiteSpace(md5Lbl.Text))
                {


                    if (md5Lbl.Text.ToUpper().Equals(md5checkhash))
                    {
                        lblStatus.Text = "Status: Checking for multiple instances";
                        await Task.Delay(1000);
                        lblStatus.Text = "Status: Launching update package";
                        int count = Process.GetProcessesByName("superpadsetup").Count();
                        if (count < 1)
                            Process.Start("superpadsetup.exe");
                        else
                        {
                            var proc = Process.GetProcessesByName("superpadsetup").FirstOrDefault();
                            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
                            {
                                SetForegroundWindow(proc.MainWindowHandle);
                                ShowWindowAsync(proc.MainWindowHandle, 3);
                            }
                        }
                        await Task.Delay(200);
                        Application.Exit();
                    }
                    else
                    {
                        lblStatus.Text = "Status: Invalid MD5 Signature, Try Again Later";
                        cancelBtn.Text = "Close";
                        cancelBtn.Visible = true;
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private byte[] ComputeMd5Hash(string fileName)
        {
            byte[] result = null;

            using (MD5 md5 = MD5.Create())
            {
                int bufferSize = 10 * 1024 * 1024; //10MB
                using (var stream = new BufferedStream(File.OpenRead(fileName), bufferSize))
                {
                    result = md5.ComputeHash(stream);
                }
            }
            return result;
        }

        static string ToHexadecimal(byte[] source)
        {
            if (source == null) return string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (byte b in source)
            {
                sb.Append(b.ToString("X2")); // print byte as Hexadecimal string 
            }
            return sb.ToString();
        }


    }
}






