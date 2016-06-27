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
using System.IO;
using System.Diagnostics;

namespace TidalDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickDownload(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();

            if(folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            {
                output.AppendText("Error: no path selected\n");
                return;
            }

            if(URI.Text == null | URI.Text == "")
            {
                output.AppendText("Error: no partial Tidal URI\n");
                return;
            }

            String loc = folderBrowserDialog.SelectedPath;

            for (int i = (int)startNo.Value; i < (int)endNo.Value + 1; i++)
            {
                output.AppendText("Downloading section #" + i.ToString() + "\n");

                try
                {
                    wc.DownloadFile(URI.Text + i.ToString() + ".ts" + suffix.Text, loc + "\\" + i.ToString() + ".ts");
                }
                catch
                {
                    output.AppendText("Error downloading section #" + i.ToString() + "\n");
                    break;
                }
            }
        }

        private void pickFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
        }

        private void stitchButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            {
                output.AppendText("Error: no path selected\n");
                return;
            }

            if (outfile.Text == null | outfile.Text == "")
            {
                output.AppendText("Error: no output filename\n");
                return;
            }

            String command = " -i \"concat:";

            for (int i = (int)startNo.Value; i < (int)endNo.Value + 1; i++)
            {
                command += folderBrowserDialog.SelectedPath + "\\" + i.ToString() + ".ts";

                if (i != (int)endNo.Value)
                {
                    command += "|";
                }
            }

            command += "\" -c copy -bsf aac_adtstoasc \"" + folderBrowserDialog.SelectedPath + "\\" + outfile.Text + ".mp4\"";

            Console.WriteLine(command);

            var proc1 = new ProcessStartInfo();
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = folderBrowserDialog.SelectedPath;

            proc1.FileName = @"C:\Program Files\ImageMagick-6.9.3-Q16\ffmpeg.exe";
            proc1.Verb = "runas";
            proc1.Arguments = command;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);

            //Process.Start("ffmpeg", command);
        }
    }
}
