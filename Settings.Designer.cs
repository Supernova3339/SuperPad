
namespace SuperPad
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.checkUpdates = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allowSharing = new System.Windows.Forms.CheckBox();
            this.darkMode1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkUpdates
            // 
            this.checkUpdates.AutoSize = true;
            this.checkUpdates.BackColor = System.Drawing.Color.Transparent;
            this.checkUpdates.Checked = true;
            this.checkUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUpdates.Location = new System.Drawing.Point(6, 19);
            this.checkUpdates.Name = "checkUpdates";
            this.checkUpdates.Size = new System.Drawing.Size(118, 17);
            this.checkUpdates.TabIndex = 6;
            this.checkUpdates.Text = "Check For Updates";
            this.checkUpdates.UseVisualStyleBackColor = false;
            this.checkUpdates.CheckedChanged += new System.EventHandler(this.checkUpdates_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allowSharing);
            this.groupBox1.Controls.Add(this.darkMode1);
            this.groupBox1.Controls.Add(this.checkUpdates);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 231);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SuperPad Settings";
            // 
            // allowSharing
            // 
            this.allowSharing.AutoSize = true;
            this.allowSharing.BackColor = System.Drawing.Color.Transparent;
            this.allowSharing.Location = new System.Drawing.Point(6, 42);
            this.allowSharing.Name = "allowSharing";
            this.allowSharing.Size = new System.Drawing.Size(62, 17);
            this.allowSharing.TabIndex = 8;
            this.allowSharing.Text = "Sharing";
            this.allowSharing.UseVisualStyleBackColor = false;
            this.allowSharing.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // darkMode1
            // 
            this.darkMode1.AutoSize = true;
            this.darkMode1.Location = new System.Drawing.Point(6, 65);
            this.darkMode1.Name = "darkMode1";
            this.darkMode1.Size = new System.Drawing.Size(79, 17);
            this.darkMode1.TabIndex = 7;
            this.darkMode1.Text = "Dark Mode";
            this.darkMode1.UseVisualStyleBackColor = true;
            this.darkMode1.CheckStateChanged += new System.EventHandler(this.darkMode1_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Check For Updates ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkUpdates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox darkMode1;
        private System.Windows.Forms.CheckBox allowSharing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}