namespace TidalDownloader
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::TIDALDownloaderX.Properties.Resources.TDX_2_Cropped;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MinimumSize = new System.Drawing.Size(332, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aboutTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aboutTextBox.Location = new System.Drawing.Point(12, 37);
            this.aboutTextBox.MaximumSize = new System.Drawing.Size(332, 141);
            this.aboutTextBox.MinimumSize = new System.Drawing.Size(332, 141);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(332, 141);
            this.aboutTextBox.TabIndex = 1;
            this.aboutTextBox.Text = " Original Program - Alex Janka (italicsjenga)\n Modified By - AiiR\n\n JAMSTA Create" +
    "d By - AiiR\n FFmpeg Created By - FFmpeg team\n\n Copyright © 2019\n\n Version 1.0 (A" +
    "ugust 1, 2019)";
            this.aboutTextBox.TextChanged += new System.EventHandler(this.aboutTextBox_TextChanged);
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 190);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 229);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 229);
            this.Name = "aboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "About TIDALDownloaderX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox aboutTextBox;
    }
}