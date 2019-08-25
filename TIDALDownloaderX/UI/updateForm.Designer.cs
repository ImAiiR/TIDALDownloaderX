namespace TIDALDownloaderX.UI
{
    partial class updateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateForm));
            this.updateLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.noUpdate = new System.Windows.Forms.Button();
            this.changelog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(12, 9);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(474, 52);
            this.updateLabel.TabIndex = 0;
            this.updateLabel.Text = resources.GetString("updateLabel.Text");
            this.updateLabel.Click += new System.EventHandler(this.updateLabel_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(376, 226);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // noUpdate
            // 
            this.noUpdate.Location = new System.Drawing.Point(457, 226);
            this.noUpdate.Name = "noUpdate";
            this.noUpdate.Size = new System.Drawing.Size(75, 23);
            this.noUpdate.TabIndex = 2;
            this.noUpdate.Text = "No Thanks";
            this.noUpdate.UseVisualStyleBackColor = true;
            this.noUpdate.Click += new System.EventHandler(this.noUpdate_Click);
            // 
            // changelog
            // 
            this.changelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelog.Location = new System.Drawing.Point(12, 73);
            this.changelog.MaximumSize = new System.Drawing.Size(520, 147);
            this.changelog.MinimumSize = new System.Drawing.Size(520, 147);
            this.changelog.Multiline = true;
            this.changelog.Name = "changelog";
            this.changelog.ReadOnly = true;
            this.changelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.changelog.Size = new System.Drawing.Size(520, 147);
            this.changelog.TabIndex = 3;
            this.changelog.TextChanged += new System.EventHandler(this.changelog_TextChanged);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.changelog);
            this.Controls.Add(this.noUpdate);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 300);
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "updateForm";
            this.Text = "New Version Found!";
            this.Load += new System.EventHandler(this.updateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button noUpdate;
        private System.Windows.Forms.TextBox changelog;
    }
}