namespace TIDALDownloaderX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.URI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startNo = new System.Windows.Forms.NumericUpDown();
            this.endNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.stitchButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pickFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.suffix = new System.Windows.Forms.TextBox();
            this.zeroURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setURL = new System.Windows.Forms.Button();
            this.jamstaOpen = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.openFolder = new System.Windows.Forms.Button();
            this.ffmpegButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNo)).BeginInit();
            this.SuspendLayout();
            // 
            // URI
            // 
            this.URI.Enabled = false;
            this.URI.Location = new System.Drawing.Point(50, 57);
            this.URI.Name = "URI";
            this.URI.ReadOnly = true;
            this.URI.Size = new System.Drawing.Size(222, 20);
            this.URI.TabIndex = 0;
            this.URI.TextChanged += new System.EventHandler(this.URI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prefix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(13, 180);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(96, 23);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.clickDownload);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.output.Location = new System.Drawing.Point(115, 122);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(157, 165);
            this.output.TabIndex = 3;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start:";
            // 
            // startNo
            // 
            this.startNo.Location = new System.Drawing.Point(51, 209);
            this.startNo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startNo.Name = "startNo";
            this.startNo.Size = new System.Drawing.Size(59, 20);
            this.startNo.TabIndex = 5;
            // 
            // endNo
            // 
            this.endNo.Location = new System.Drawing.Point(51, 236);
            this.endNo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.endNo.Name = "endNo";
            this.endNo.Size = new System.Drawing.Size(59, 20);
            this.endNo.TabIndex = 7;
            this.endNo.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.endNo.ValueChanged += new System.EventHandler(this.endNo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End:";
            // 
            // stitchButton
            // 
            this.stitchButton.Location = new System.Drawing.Point(13, 151);
            this.stitchButton.Name = "stitchButton";
            this.stitchButton.Size = new System.Drawing.Size(96, 23);
            this.stitchButton.TabIndex = 8;
            this.stitchButton.Text = "Move Files";
            this.stitchButton.UseVisualStyleBackColor = true;
            this.stitchButton.Click += new System.EventHandler(this.stitchButton_Click);
            // 
            // pickFolder
            // 
            this.pickFolder.Location = new System.Drawing.Point(13, 123);
            this.pickFolder.Name = "pickFolder";
            this.pickFolder.Size = new System.Drawing.Size(96, 23);
            this.pickFolder.TabIndex = 9;
            this.pickFolder.Text = "Choose Folder";
            this.pickFolder.UseVisualStyleBackColor = true;
            this.pickFolder.Click += new System.EventHandler(this.pickFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Suffix";
            // 
            // suffix
            // 
            this.suffix.Enabled = false;
            this.suffix.Location = new System.Drawing.Point(50, 83);
            this.suffix.Name = "suffix";
            this.suffix.ReadOnly = true;
            this.suffix.Size = new System.Drawing.Size(222, 20);
            this.suffix.TabIndex = 12;
            // 
            // zeroURL
            // 
            this.zeroURL.AcceptsReturn = true;
            this.zeroURL.Location = new System.Drawing.Point(16, 30);
            this.zeroURL.Name = "zeroURL";
            this.zeroURL.Size = new System.Drawing.Size(187, 20);
            this.zeroURL.TabIndex = 14;
            this.zeroURL.TextChanged += new System.EventHandler(this.zeroURL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "TIDAL URI \"0.ts\" Link";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // setURL
            // 
            this.setURL.Location = new System.Drawing.Point(209, 28);
            this.setURL.Name = "setURL";
            this.setURL.Size = new System.Drawing.Size(63, 23);
            this.setURL.TabIndex = 16;
            this.setURL.Text = "Set URL";
            this.setURL.UseVisualStyleBackColor = true;
            this.setURL.Click += new System.EventHandler(this.button1_Click);
            // 
            // jamstaOpen
            // 
            this.jamstaOpen.Location = new System.Drawing.Point(12, 264);
            this.jamstaOpen.Name = "jamstaOpen";
            this.jamstaOpen.Size = new System.Drawing.Size(97, 23);
            this.jamstaOpen.TabIndex = 17;
            this.jamstaOpen.Text = "Open JAMSTA";
            this.jamstaOpen.UseVisualStyleBackColor = true;
            this.jamstaOpen.Click += new System.EventHandler(this.jamstaOpen_Click_1);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(12, 293);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(97, 23);
            this.aboutButton.TabIndex = 18;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(115, 293);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(156, 23);
            this.openFolder.TabIndex = 19;
            this.openFolder.Text = "Open Folder";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // ffmpegButton
            // 
            this.ffmpegButton.Location = new System.Drawing.Point(132, 4);
            this.ffmpegButton.Name = "ffmpegButton";
            this.ffmpegButton.Size = new System.Drawing.Size(140, 23);
            this.ffmpegButton.TabIndex = 20;
            this.ffmpegButton.Text = "Download Needed Files";
            this.ffmpegButton.UseVisualStyleBackColor = true;
            this.ffmpegButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.ffmpegButton);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.jamstaOpen);
            this.Controls.Add(this.setURL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zeroURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.suffix);
            this.Controls.Add(this.pickFolder);
            this.Controls.Add(this.stitchButton);
            this.Controls.Add(this.endNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 367);
            this.MinimumSize = new System.Drawing.Size(300, 367);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TIDALDownloaderX";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startNo;
        private System.Windows.Forms.NumericUpDown endNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stitchButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button pickFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox suffix;
        private System.Windows.Forms.TextBox zeroURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setURL;
        private System.Windows.Forms.Button jamstaOpen;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Button ffmpegButton;
    }
}

