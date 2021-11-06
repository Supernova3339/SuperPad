using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperPad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var Form1 = new Form1();

            var CommandLine = Environment.CommandLine.Trim();

            var Filename = (string)null;

            if (CommandLine.StartsWith("\""))
            {
                var ClosingQuoteIndex = CommandLine.IndexOf('\"', 1);

                if (ClosingQuoteIndex < (CommandLine.Length - 1))
                {
                    Filename = CommandLine.Substring(ClosingQuoteIndex + 1).Trim();
                }
            }
            else
            {
                var FirstSpaceIndex = CommandLine.IndexOf(' ', 1);

                if (FirstSpaceIndex != -1)
                {
                    Filename = CommandLine.Substring(FirstSpaceIndex + 1).Trim();
                }
            }

            if (Filename != null)
            {
                Form1.Open(Filename);
            }

            Application.Run(new Form1());
        }
    }
}
