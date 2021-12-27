
namespace SuperPad
{
    partial class Download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Download));
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.md5Lbl = new System.Windows.Forms.Label();
            this.spsLbl = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatus.Location = new System.Drawing.Point(14, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(255, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status: Connecting to update server";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 34);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(417, 23);
            this.progressBar.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(360, 63);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // md5Lbl
            // 
            this.md5Lbl.AutoSize = true;
            this.md5Lbl.Location = new System.Drawing.Point(3, 73);
            this.md5Lbl.Name = "md5Lbl";
            this.md5Lbl.Size = new System.Drawing.Size(38, 13);
            this.md5Lbl.TabIndex = 4;
            this.md5Lbl.Text = "label1";
            // 
            // spsLbl
            // 
            this.spsLbl.AutoSize = true;
            this.spsLbl.Location = new System.Drawing.Point(47, 73);
            this.spsLbl.Name = "spsLbl";
            this.spsLbl.Size = new System.Drawing.Size(105, 13);
            this.spsLbl.TabIndex = 5;
            this.spsLbl.Text = "superpadsetup.exe";
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(279, 63);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 23);
            this.yesBtn.TabIndex = 6;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Visible = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 89);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.spsLbl);
            this.Controls.Add(this.md5Lbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuperPad Updater";
            this.Load += new System.EventHandler(this.Download_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label md5Lbl;
        private System.Windows.Forms.Label spsLbl;
        private System.Windows.Forms.Button yesBtn;
    }
}