using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TidalDownloader
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutForm_Load(object sender, EventArgs e)
        {
            aboutTextBox.Invoke(new Action(() => aboutTextBox.Text = String.Empty));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText(" Original Program - Alex Janka (italicsjenga)\n")));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText(" Modified By - AiiR\n")));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText("\n")));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText(" FFmpeg Created By - FFmpeg team\n")));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText("\n")));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText(" Copyright © 2019\n")));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText("\n")));
            aboutTextBox.Invoke(new Action(() => aboutTextBox.AppendText(" Version " + Assembly.GetExecutingAssembly().GetName().Version)));
        }
    }
}
