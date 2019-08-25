using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIDALDownloaderX.UI
{
    public partial class updateForm : Form
    {
        public updateForm()
        {
            InitializeComponent();
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            // Bring to center of screen.
            CenterToScreen();

            // Load up latest changelog.
            WebRequest wr = WebRequest.Create("http://aiir.xyz/TIDALDownloaderX/TDX-Changelog.txt");
            WebResponse ws = wr.GetResponse();
            StreamReader sr = new StreamReader(ws.GetResponseStream());

            string newVersion = sr.ReadToEnd();

            // Put the changelog text into the textbox.
            changelog.Text = newVersion;
        }

        private void changelog_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // If "Updated" is clicked, open TDX webpage and close TDX.
            Process.Start("https://aiir.xyz/TIDALDownloaderX/");
            Application.Exit();
        }

        private void noUpdate_Click(object sender, EventArgs e)
        {
            // If "No Thanks" is clicked, close update window.
            Close();
        }

        private void updateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
