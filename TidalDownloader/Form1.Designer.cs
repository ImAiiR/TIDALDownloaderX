namespace TidalDownloader
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
            this.outfile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.suffix = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.startNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNo)).BeginInit();
            this.SuspendLayout();
            // 
            // URI
            // 
            this.URI.Location = new System.Drawing.Point(12, 29);
            this.URI.Name = "URI";
            this.URI.Size = new System.Drawing.Size(260, 20);
            this.URI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIDAL URI segment";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(12, 152);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(97, 23);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.clickDownload);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(115, 122);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(157, 194);
            this.output.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start:";
            // 
            // startNo
            // 
            this.startNo.Location = new System.Drawing.Point(50, 192);
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
            this.endNo.Location = new System.Drawing.Point(50, 219);
            this.endNo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.endNo.Name = "endNo";
            this.endNo.Size = new System.Drawing.Size(59, 20);
            this.endNo.TabIndex = 7;
            this.endNo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End:";
            // 
            // stitchButton
            // 
            this.stitchButton.Location = new System.Drawing.Point(12, 293);
            this.stitchButton.Name = "stitchButton";
            this.stitchButton.Size = new System.Drawing.Size(97, 23);
            this.stitchButton.TabIndex = 8;
            this.stitchButton.Text = "Stitch";
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
            // outfile
            // 
            this.outfile.Location = new System.Drawing.Point(12, 267);
            this.outfile.Name = "outfile";
            this.outfile.Size = new System.Drawing.Size(97, 20);
            this.outfile.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filename:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Suffix";
            // 
            // suffix
            // 
            this.suffix.Location = new System.Drawing.Point(12, 75);
            this.suffix.Name = "suffix";
            this.suffix.Size = new System.Drawing.Size(260, 20);
            this.suffix.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.suffix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outfile);
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
            this.Name = "Form1";
            this.Text = "TIDAL Downloader";
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
        private System.Windows.Forms.TextBox outfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox suffix;
    }
}

