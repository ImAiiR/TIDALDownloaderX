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
using System.Threading;

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
            // Open Folder Browser to select path & Save
            folderBrowserDialog.ShowDialog();
            Settings.Default.savedFolder = folderBrowserDialog.SelectedPath;
            Settings.Default.Save();
        }

        private void stitchButton_Click(object sender, EventArgs e)
        {
            backgroundWorker3.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest wr = WebRequest.Create("http://aiir.xyz/TIDALDownloaderX/TDX-Version.txt");
            WebResponse ws = wr.GetResponse();
            StreamReader sr = new StreamReader(ws.GetResponseStream());

            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string newVersion = sr.ReadToEnd();

            if (currentVersion.Contains(newVersion))
            {
                // Do what usually happens at startup
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("The version you're using is outdated. Would you like to update now?", "New Version Available", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("https://aiir.xyz/TIDALDownloaderX/");
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Do what usually happens at startup
                }
            }

            // Do what usually happens at startup

            // Set saved path as selected path.
            folderBrowserDialog.SelectedPath = Settings.Default.savedFolder.ToString();

            // Set saved checkbox value.
            mp4Checkbox.Checked = Properties.Settings.Default.mp4Chk;

            // Check if there's no selected path.
            if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            {
                // If there is NOT a saved path.
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("No default path has been set! Remember to Choose a Folder!\n")));
            }
            else
            {
                // If there is a saved path.
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("Using the last folder you've selected on TDX as your chosen folder!\n")));
                output.Invoke(new Action(() => output.AppendText("\n")));
                output.Invoke(new Action(() => output.AppendText("Default Folder:\n")));
                output.Invoke(new Action(() => output.AppendText(folderBrowserDialog.SelectedPath + "\n")));
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
            backgroundWorker4.RunWorkerAsync();
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
            // Check if there's no selected path.
            if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            {
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("ERROR: No path selected\n")));
                return;
            }

            // Check if the URI section is empty.
            if (URI.Text == null | URI.Text == "")
            {
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("ERROR: No URL set / Incorrect link (not 0.ts)\n")));
                return;
            }

            // Check if the first 0.ts file still exists in the directory before downloading anything.
            if (File.Exists(folderBrowserDialog.SelectedPath + "/00000000.ts"))
            {
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("ERROR: You already have .ts files for another video downloaded! Be sure to merge the files together before downloading a new video!\n")));
                return;
            }

            // Check if there are any .ts files still in the directory before downloading anything.
            DirectoryInfo dir = new DirectoryInfo(@folderBrowserDialog.SelectedPath);
            FileInfo[] TSFiles = dir.GetFiles("*.ts");
            if (TSFiles.Length >= 1)
            {
                // .ts files are in the directory. Tell the user, and DON'T download any files.
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.AppendText("ERROR: There are .ts files in the directory. Please move them to a new directory so they don't get merged together.\n");
                return;
            }

            WebClient wc = new WebClient();

            String loc = folderBrowserDialog.SelectedPath;

            for (int i = (int)startNo.Value; i < (int)endNo.Value + 1; i++)
            {
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("Downloading section #" + i.ToString() + "\n")));

                try
                {
                    wc.DownloadFile(URI.Text + i.ToString() + ".ts" + suffix.Text, loc + "\\" + i.ToString().PadLeft(8, '0') + ".ts");
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

            // Downloads JAMSTA (outdated). Leaving this here in case anyone is wondering what used to happen here.

            //if (File.Exists("Req/JAMSTA.bat"))
            //{
            //    output.Invoke(new Action(() => output.AppendText("JAMSTA already downloaded!\n")));
            //}
            //else
            //{
            //    using (var client = new WebClient())
            //    {
            //        output.Invoke(new Action(() => output.AppendText("JAMSTA Downloading....\n")));
            //        client.DownloadFile("http://aiir.xyz/JAMSTA.bat", "Req/JAMSTA.bat");
            //        output.Invoke(new Action(() => output.AppendText("JAMSTA Downloaded!\n")));
            //    }
            //}

            // Downloads FFMPEG to TDX location, in the "Req" folder.

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

            // Move JAMSTA into selected path (Outdated)

            //if (!File.Exists("Req/JAMSTA.bat"))
            //{
            //    MessageBox.Show("JAMSTA.bat is not present in the 'Req' folder! Make sure you've clicked on the 'Download Needed Files' button!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            //    {
            //        MessageBox.Show("You haven't slected a folder!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //    else
            //    {
            //        if (File.Exists(folderBrowserDialog.SelectedPath + "/JAMSTA.bat"))
            //        {
            //            output.Invoke(new Action(() => output.AppendText("JAMSTA already in folder!\n")));
            //        }
            //        else
            //        {
            //            File.Copy("Req/JAMSTA.bat", folderBrowserDialog.SelectedPath + "/JAMSTA.bat");
            //            output.Invoke(new Action(() => output.AppendText("JAMSTA moved!\n")));
            //        }
            //    }
            //}

            // Move FFMPEG into selected path

            if (!File.Exists("Req/ffmpeg.exe"))
            {
                MessageBox.Show("ffmpeg.exe is not present in the 'Req' folder! Make sure you've clicked on the 'Download Needed Files' button!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if there's no selected path.
                if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
                {
                    MessageBox.Show("You haven't chosen a folder!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (File.Exists(folderBrowserDialog.SelectedPath + "/ffmpeg.exe"))
                    {
                        output.Invoke(new Action(() => output.AppendText("FFMPEG already in folder!\n")));
                    }
                    else
                    {
                        File.Copy("Req/ffmpeg.exe", folderBrowserDialog.SelectedPath + "/ffmpeg.exe");
                        output.Invoke(new Action(() => output.AppendText("FFMPEG moved!\n")));
                    }
                }
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
        }

        private void devTestButton_Click(object sender, EventArgs e)
        {
            // Used for testing during development. Doesn't run anything on released versions.
        }

        private void renameText_Enter(object sender, EventArgs e)
        {
            if (renameText.Text == "Filename")
            {
                renameText.Text = "";

                renameText.ForeColor = Color.Black;
            }
        }

        private void renameText_Leave(object sender, EventArgs e)
        {
            if (renameText.Text == "")
            {
                renameText.Text = "Filename";

                renameText.ForeColor = Color.Gray;
            }

        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            // Check to see if a path has been set
            if (folderBrowserDialog.SelectedPath == null | folderBrowserDialog.SelectedPath == "")
            {
                MessageBox.Show("No path selected!", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //output.AppendText("Error: No path selected\n");
                return;
            }

            // Check if there is only a single .ts file. If so, don't merge.
            DirectoryInfo dir = new DirectoryInfo(@folderBrowserDialog.SelectedPath);
            FileInfo[] TSFiles = dir.GetFiles("*.ts");
            if (TSFiles.Length == 1)
            {
                // .ts files are in the directory. Tell the user, don't attempt to merge
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.AppendText("ERROR: There is only one .ts file in the directory. Did you forget to hit download?\n");
                return;
            }

            // Check if there is no .ts files. If so, don't attempt to merge.
            DirectoryInfo dir2 = new DirectoryInfo(@folderBrowserDialog.SelectedPath);
            FileInfo[] TSFiles0 = dir.GetFiles("*.ts");
            if (TSFiles0.Length == 0)
            {
                // There's no .ts files in the directory. Tell the user, don't attempt to merge
                output.Invoke(new Action(() => output.Text = String.Empty));
                output.AppendText("ERROR: There are no .ts files in the directory. Did you forget to hit download?\n");
                return;
            }

            // Check if "Convert to MP4" is checked.
            if (mp4Checkbox.Checked == true)
            {
                // Check to see if FFMPEG is in the selected path
                if (!File.Exists(folderBrowserDialog.SelectedPath + "/ffmpeg.exe"))
                {
                    MessageBox.Show("FFMPEG is not present in the selected path!" + "\n" + "FFMPEG is required for converting to MP4! Be sure to click MOVE FILES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Disable "Convert to MP4" checkbox.
                    mp4Checkbox.Enabled = false;

                    output.Invoke(new Action(() => output.Text = String.Empty));
                    output.Invoke(new Action(() => output.AppendText("Merging downloaded .ts files & Converting to MP4...\n")));

                    // Run a silent Command Prompt to run old JAMSTA code.
                    Process p = new Process();
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.WorkingDirectory = folderBrowserDialog.SelectedPath;
                    info.FileName = "CMD";
                    // (In order or commands) Merge all .ts files together into "MERGED.ts", run FFMPEG to convert the .ts file to .mp4, then delete the old .ts files.
                    info.Arguments = @"/C copy /b *.ts MERGED.ts && ffmpeg -loglevel panic -i MERGED.ts -acodec copy -vcodec copy JAMSTA.mp4 && del *.ts /f";
                    info.UseShellExecute = false;
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    info.CreateNoWindow = true;
                    p.StartInfo = info;
                    p.Start();
                    p.WaitForExit();

                    Thread.Sleep(2500);
                    output.Invoke(new Action(() => output.AppendText("Finished merging files!\n")));
                    Thread.Sleep(500);
                    output.Invoke(new Action(() => output.AppendText("Renaming merged file...\n")));
                    Thread.Sleep(500);

                    if (File.Exists(folderBrowserDialog.SelectedPath + "/JAMSTA.mp4"))
                    {
                        // Rename merged file.
                        if (renameText.Text == "" || renameText.Text == " " || renameText.Text == "Filename")
                        {
                            File.Move(@folderBrowserDialog.SelectedPath + "/JAMSTA.mp4", @folderBrowserDialog.SelectedPath + "/TIDALDownloaderX.mp4");
                            output.Invoke(new Action(() => output.AppendText("File renamed!\n")));
                            output.Invoke(new Action(() => output.AppendText("\n")));
                            output.Invoke(new Action(() => output.AppendText("Job completed!\n")));
                            output.Invoke(new Action(() => output.AppendText("You forgot to set a filename, so set default filename.\n")));
                            output.Invoke(new Action(() => output.AppendText("\n")));
                            output.Invoke(new Action(() => output.AppendText("Click ''Open Folder'' and look for ''TIDALDownloaderX.mp4''\n")));
                        }
                        else
                        {
                            File.Move(@folderBrowserDialog.SelectedPath + "/JAMSTA.mp4", @folderBrowserDialog.SelectedPath + "/" + renameText.Text + ".mp4");
                            output.Invoke(new Action(() => output.AppendText("File renamed!\n")));
                            output.Invoke(new Action(() => output.AppendText("\n")));
                            output.Invoke(new Action(() => output.AppendText("Job completed!\n")));
                            output.Invoke(new Action(() => output.AppendText("Click ''Open Folder'' and look for ''" + renameText.Text + ".mp4''\n")));
                        }

                        mp4Checkbox.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("JAMSTA.mp4 NOT FOUND", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        output.Invoke(new Action(() => output.Text = String.Empty));
                        output.AppendText("JAMSTA.mp4 wasn't found in the chosen folder. Did you download TIDAL's .ts files yet?\n");
                        mp4Checkbox.Enabled = true;
                        return;
                    }
                }
            }
            else // If "Convert to MP4" is NOT checked.
            {
                // Disable "Convert to MP4" checkbox.
                mp4Checkbox.Enabled = false;

                output.Invoke(new Action(() => output.Text = String.Empty));
                output.Invoke(new Action(() => output.AppendText("Merging downloaded .ts files...\n")));

                // Run a silent Command Prompt to run old JAMSTA code.
                Process p = new Process();
                ProcessStartInfo info = new ProcessStartInfo();
                info.WorkingDirectory = folderBrowserDialog.SelectedPath;
                info.FileName = "CMD";
                // (In order or commands) Merge all .ts files together into "MERGED.ts", run FFMPEG to convert the .ts file to .mp4, then delete the old .ts files.
                info.Arguments = @"/C copy /b *.ts MERGED.temp && del *.ts /f && ren MERGED.temp MERGED.ts";
                info.UseShellExecute = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                info.CreateNoWindow = true;
                p.StartInfo = info;
                p.Start();
                p.WaitForExit();

                Thread.Sleep(2500);
                output.Invoke(new Action(() => output.AppendText("Finished merging files!\n")));
                Thread.Sleep(500);
                output.Invoke(new Action(() => output.AppendText("Renaming merged file...\n")));
                Thread.Sleep(500);

                if (File.Exists(folderBrowserDialog.SelectedPath + "/MERGED.ts"))
                {
                    // Rename merged file.
                    if (renameText.Text == "" || renameText.Text == " " || renameText.Text == "Filename")
                    {
                        File.Move(@folderBrowserDialog.SelectedPath + "/MERGED.ts", @folderBrowserDialog.SelectedPath + "/TIDALDownloaderX.ts");
                        output.Invoke(new Action(() => output.AppendText("File renamed!\n")));
                        output.Invoke(new Action(() => output.AppendText("\n")));
                        output.Invoke(new Action(() => output.AppendText("Job completed!\n")));
                        output.Invoke(new Action(() => output.AppendText("You forgot to set a filename, so set default filename.\n")));
                        output.Invoke(new Action(() => output.AppendText("\n")));
                        output.Invoke(new Action(() => output.AppendText("Click ''Open Folder'' and look for ''TIDALDownloaderX.ts''\n")));
                    }
                    else
                    {
                        File.Move(@folderBrowserDialog.SelectedPath + "/MERGED.ts", @folderBrowserDialog.SelectedPath + "/" + renameText.Text + ".ts");
                        output.Invoke(new Action(() => output.AppendText("File renamed!\n")));
                        output.Invoke(new Action(() => output.AppendText("\n")));
                        output.Invoke(new Action(() => output.AppendText("Job completed!\n")));
                        output.Invoke(new Action(() => output.AppendText("Click ''Open Folder'' and look for ''" + renameText.Text + ".ts''\n")));
                    }

                    mp4Checkbox.Enabled = true;
                }
                else
                {
                    MessageBox.Show("MERGED.ts NOT FOUND", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    output.Invoke(new Action(() => output.Text = String.Empty));
                    output.AppendText("MERGED.ts wasn't found in the chosen folder. Did you download TIDAL's .ts files yet?\n");
                    mp4Checkbox.Enabled = true;
                    return;
                }
            }
        }

        private void mp4Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.mp4Chk = mp4Checkbox.Checked;
            Settings.Default.Save();
        }

        private void renameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
