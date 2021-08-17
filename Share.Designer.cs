
namespace SuperPad
{
    partial class Share
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Share));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.fromLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAttach = new System.Windows.Forms.LinkLabel();
            this.bodyTextbox = new System.Windows.Forms.TextBox();
            this.bodyLbl = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.toTextbox = new System.Windows.Forms.TextBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblLocation = new System.Windows.Forms.Label();
            this.serverTextbox = new System.Windows.Forms.TextBox();
            this.serverLbl = new System.Windows.Forms.Label();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Send Note";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.portTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.serverTextbox);
            this.groupBox1.Controls.Add(this.serverLbl);
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.passwordLbl);
            this.groupBox1.Controls.Add(this.fromTextbox);
            this.groupBox1.Controls.Add(this.fromLbl);
            this.groupBox1.Location = new System.Drawing.Point(18, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(76, 47);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(519, 20);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Location = new System.Drawing.Point(6, 50);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(64, 17);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // fromTextbox
            // 
            this.fromTextbox.Location = new System.Drawing.Point(76, 19);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(519, 20);
            this.fromTextbox.TabIndex = 1;
            this.fromTextbox.TextChanged += new System.EventHandler(this.fromTextbox_TextChanged);
            // 
            // fromLbl
            // 
            this.fromLbl.Location = new System.Drawing.Point(6, 22);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(49, 20);
            this.fromLbl.TabIndex = 0;
            this.fromLbl.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblLocation);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.btnAttach);
            this.groupBox2.Controls.Add(this.bodyTextbox);
            this.groupBox2.Controls.Add(this.bodyLbl);
            this.groupBox2.Controls.Add(this.titleTextbox);
            this.groupBox2.Controls.Add(this.titleLbl);
            this.groupBox2.Controls.Add(this.toTextbox);
            this.groupBox2.Controls.Add(this.toLbl);
            this.groupBox2.Location = new System.Drawing.Point(18, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 284);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnAttach
            // 
            this.btnAttach.Image = global::SuperPad.Properties.Resources.attach_24px;
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnAttach.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAttach.Location = new System.Drawing.Point(180, 240);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(98, 30);
            this.btnAttach.TabIndex = 6;
            this.btnAttach.TabStop = true;
            this.btnAttach.Text = "      Attatch Note";
            this.btnAttach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttach.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAttach_LinkClicked);
            // 
            // bodyTextbox
            // 
            this.bodyTextbox.Location = new System.Drawing.Point(76, 73);
            this.bodyTextbox.Multiline = true;
            this.bodyTextbox.Name = "bodyTextbox";
            this.bodyTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bodyTextbox.Size = new System.Drawing.Size(519, 161);
            this.bodyTextbox.TabIndex = 5;
            // 
            // bodyLbl
            // 
            this.bodyLbl.Location = new System.Drawing.Point(6, 76);
            this.bodyLbl.Name = "bodyLbl";
            this.bodyLbl.Size = new System.Drawing.Size(64, 17);
            this.bodyLbl.TabIndex = 4;
            this.bodyLbl.Text = "Body";
            // 
            // titleTextbox
            // 
            this.titleTextbox.AcceptsReturn = true;
            this.titleTextbox.Location = new System.Drawing.Point(76, 47);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(519, 20);
            this.titleTextbox.TabIndex = 3;
            // 
            // titleLbl
            // 
            this.titleLbl.Location = new System.Drawing.Point(6, 50);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(64, 17);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Title";
            // 
            // toTextbox
            // 
            this.toTextbox.Location = new System.Drawing.Point(76, 19);
            this.toTextbox.Name = "toTextbox";
            this.toTextbox.Size = new System.Drawing.Size(519, 20);
            this.toTextbox.TabIndex = 1;
            // 
            // toLbl
            // 
            this.toLbl.Location = new System.Drawing.Point(6, 22);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(49, 20);
            this.toLbl.TabIndex = 0;
            this.toLbl.Text = "To";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(123)))), ((int)(((byte)(230)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(76, 238);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 32);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text document|*.txt|All files|*.*";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLocation.Location = new System.Drawing.Point(284, 249);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 13);
            this.lblLocation.TabIndex = 8;
            // 
            // serverTextbox
            // 
            this.serverTextbox.Location = new System.Drawing.Point(76, 73);
            this.serverTextbox.MaxLength = 100;
            this.serverTextbox.Name = "serverTextbox";
            this.serverTextbox.Size = new System.Drawing.Size(519, 20);
            this.serverTextbox.TabIndex = 5;
            this.serverTextbox.Text = "smtp.gmail.com";
            // 
            // serverLbl
            // 
            this.serverLbl.Location = new System.Drawing.Point(6, 73);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(49, 20);
            this.serverLbl.TabIndex = 4;
            this.serverLbl.Text = "Server";
            // 
            // portTextbox
            // 
            this.portTextbox.Location = new System.Drawing.Point(76, 99);
            this.portTextbox.MaxLength = 25;
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(467, 20);
            this.portTextbox.TabIndex = 7;
            this.portTextbox.Text = "587";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(549, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "SSL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Share";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Share";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Share_FormClosing);
            this.Load += new System.EventHandler(this.Share_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bodyTextbox;
        private System.Windows.Forms.Label bodyLbl;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox toTextbox;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.LinkLabel btnAttach;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTextbox;
        private System.Windows.Forms.Label serverLbl;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}