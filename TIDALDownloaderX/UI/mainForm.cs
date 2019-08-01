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
using TidalDownloader;
using TIDALDownloaderX.Properties;
using System.Reflection;

namespace TIDALDownloaderX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickDownload(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void pickFolder_Click(object sender, EventArgs e)
        {
            // Open Folder Browser to select path
            folderBrowserDialog.ShowDialog();

            // Save the value from the folderBrowserDialog into the settings.
            //Settings.Default.savedFolder = folderBrowserDialog.SelectedPath;
            //Settings.Default.Save();
            //Settings.Default.Reload();
            //Settings.Default.Upgrade();
        }

        private void stitchButton_Click(object sender, EventArgs e)
        {
            backgroundWorker3.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Net.WebRequest wr = System.Net.HttpWebRequest.Create("http://aiir.xyz/TIDALDownloaderX/TDX-Version.txt");
            System.Net.WebResponse ws = wr.GetResponse();
            StreamReader sr = new StreamReader(ws.GetResponseStream());

            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string newVersion = sr.ReadToEnd();

            if (currentVersion.Contains(newVersion))
            {
                // Do nothing.
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("The version you're using is outdated. Would you like to update now?", "New Version Available", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://aiir.xyz/TIDALDownloaderX/");
                    System.Windows.Forms.Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Do nothing.
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void endNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle TIDAL 0.ts URL
            if (zeroURL.Text == null | zeroURL.Text == "")
            {
                output.Text = String.Empty;
                output.AppendText("Umm... There's no URL?\n");
                return;
            }
            else
            {
                string splitting = zeroURL.Text;
                string[] url = splitting.Split(new string[] { "0.ts" }, StringSplitOptions.None);

                URI.Text = url[0];
                suffix.Text = url[1];
                output.Text = String.Empty;
                output.AppendText("URL Set!\n");
            }
        }

        private void zeroURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void URI_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void outfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void jamstaOpen_Click_1(object sender, EventArgs e)
        {
            // Open JAMSTA
            if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
                {
                    MessageBox.Show("No path selected!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //output.AppendText("Error: No path selected\n");
                    return;
                }

            if (!File.Exists(folderBrowserDialog.SelectedPath + "/ffmpeg.exe"))
            {
                MessageBox.Show("ffmpeg.exe is not present in the selected path! Be sure to click MOVE FILES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //System.Diagnostics.Process proc = new System.Diagnostics.Process();
                //proc.StartInfo.FileName = "JAMSTA.bat";
                //proc.StartInfo.WorkingDirectory = folderBrowserDialog.SelectedPath;
                //proc.Start();
            }

            if (!File.Exists(folderBrowserDialog.SelectedPath + "/JAMSTA.bat"))
                {
                    MessageBox.Show("JAMSTA.bat is not present in the selected path! Be sure to click MOVE FILES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = "JAMSTA.bat";
                    proc.StartInfo.WorkingDirectory = folderBrowserDialog.SelectedPath;
                    proc.Start();
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new aboutForm().ShowDialog(this);
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            // Open selcted folder
            if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            {
                MessageBox.Show("No path selected!", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //output.AppendText("Error: No path selected\n");
                return;
            }
            else
            {
                Process.Start(@folderBrowserDialog.SelectedPath);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient wc = new WebClient();

            if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            {
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("ERROR: No path selected\n")));
                return;
            }

            if (URI.Text == null | URI.Text == "")
            {
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("ERROR: No URL set / Incorrect link (not 0.ts)\n")));
                return;
            }

            String loc = folderBrowserDialog.SelectedPath;

            for (int i = (int)startNo.Value; i < (int)endNo.Value + 1; i++)
            {
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("Downloading section #" + i.ToString() + "\n")));

                try
                {
                    wc.DownloadFile(URI.Text + i.ToString() + ".ts" + suffix.Text, loc + "\\" + i.ToString() + ".ts");
                }
                catch
                {
                    output.Invoke(new Action(() => output.AppendText(" \n")));
                    output.Invoke(new Action(() => output.AppendText("Job Completed!\n")));
                    output.Invoke(new Action(() => output.AppendText("If not, your session expired. Refresh the TIDAL page, get a new link, & try again!\n")));
                    break;
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryInfo di = Directory.CreateDirectory("Req");

            output.Invoke(new Action(() => output.Text = String.Empty));
            //output.AppendText("JAMSTA & FFmpeg Downloading! Please wait until downloading is finished. Freezing is normal....\n");

            if (File.Exists("Req/JAMSTA.bat"))
            {
                output.Invoke(new Action(() => output.AppendText("JAMSTA already downloaded!\n")));
            }
            else
            {
                using (var client = new WebClient())
                {
                    output.Invoke(new Action(() => output.AppendText("JAMSTA Downloading....\n")));
                    client.DownloadFile("http://aiir.xyz/JAMSTA.bat", "Req/JAMSTA.bat");
                    output.Invoke(new Action(() => output.AppendText("JAMSTA Downloaded!\n")));
                }
            }

            if (File.Exists("Req/ffmpeg.exe"))
            {
                output.Invoke(new Action(() => output.AppendText("FFmpeg already downloaded!\n")));
                output.Invoke(new Action(() => output.AppendText("Downloads completed!\n")));
            }
            else
            {
                using (var client = new WebClient())
                {
                    output.Invoke(new Action(() => output.AppendText("FFmpeg Downloading....\n")));
                    client.DownloadFile("http://aiir.xyz/ffmpeg.exe", "Req/ffmpeg.exe");
                    output.Invoke(new Action(() => output.AppendText("FFmpeg Downloaded!\n")));
                    output.Invoke(new Action(() => output.AppendText("Downloads completed!\n")));
                }
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            output.Invoke(new Action(() => output.Text = String.Empty));
            if (!File.Exists("Req/JAMSTA.bat"))
            {
                MessageBox.Show("JAMSTA.bat is not present in the 'Req' folder! Make sure you've clicked on the 'Download Needed Files' button!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
                {
                    MessageBox.Show("You haven't slected a folder!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (File.Exists(folderBrowserDialog.SelectedPath + "/JAMSTA.bat"))
                    {
                        output.Invoke(new Action(() => output.AppendText("JAMSTA already in folder!\n")));
                    }
                    else
                    {
                        File.Copy("Req/JAMSTA.bat", folderBrowserDialog.SelectedPath + "/JAMSTA.bat");
                        output.Invoke(new Action(() => output.AppendText("JAMSTA moved!\n")));
                    }
                }
            }

            if (!File.Exists("Req/ffmpeg.exe"))
            {
                MessageBox.Show("ffmpeg.exe is not present in the 'Req' folder! Make sure you've clicked on the 'Download Needed Files' button!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
                {
                    MessageBox.Show("You haven't chosen a folder!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (File.Exists(folderBrowserDialog.SelectedPath + "/ffmpeg.exe"))
                    {
                        output.Invoke(new Action(() => output.AppendText("FFmpeg already in folder!\n")));
                    }
                    else
                    {
                        File.Copy("Req/ffmpeg.exe", folderBrowserDialog.SelectedPath + "/ffmpeg.exe");
                        output.Invoke(new Action(() => output.AppendText("FFmpeg moved!\n")));
                    }
                }
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
        }
    }
}
