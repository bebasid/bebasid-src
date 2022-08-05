namespace bebasid
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
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnUninstallHosts = new System.Windows.Forms.Button();
            this.btnUpdateHosts = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTypeHosts = new System.Windows.Forms.Label();
            this.labelTitikDua1 = new System.Windows.Forms.Label();
            this.labelTitikDua2 = new System.Windows.Forms.Label();
            this.statusHostsValue = new System.Windows.Forms.Label();
            this.labelTypeHostsValue = new System.Windows.Forms.Label();
            this.buttonChangeTypeHosts = new System.Windows.Forms.Button();
            this.installationStatus = new System.Windows.Forms.Label();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVersi = new System.Windows.Forms.Label();
            this.labelTitikDua3 = new System.Windows.Forms.Label();
            this.labelVersiRemote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(12, 153);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(95, 26);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnUninstallHosts
            // 
            this.btnUninstallHosts.Location = new System.Drawing.Point(130, 153);
            this.btnUninstallHosts.Name = "btnUninstallHosts";
            this.btnUninstallHosts.Size = new System.Drawing.Size(95, 26);
            this.btnUninstallHosts.TabIndex = 1;
            this.btnUninstallHosts.Text = "Uninstall";
            this.btnUninstallHosts.UseVisualStyleBackColor = true;
            this.btnUninstallHosts.Click += new System.EventHandler(this.btnUninstallHosts_Click);
            // 
            // btnUpdateHosts
            // 
            this.btnUpdateHosts.Location = new System.Drawing.Point(12, 185);
            this.btnUpdateHosts.Name = "btnUpdateHosts";
            this.btnUpdateHosts.Size = new System.Drawing.Size(95, 26);
            this.btnUpdateHosts.TabIndex = 2;
            this.btnUpdateHosts.Text = "Update";
            this.btnUpdateHosts.UseVisualStyleBackColor = true;
            this.btnUpdateHosts.Click += new System.EventHandler(this.btnUpdateHosts_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 82);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status";
            // 
            // labelTypeHosts
            // 
            this.labelTypeHosts.AutoSize = true;
            this.labelTypeHosts.Location = new System.Drawing.Point(12, 105);
            this.labelTypeHosts.Name = "labelTypeHosts";
            this.labelTypeHosts.Size = new System.Drawing.Size(58, 13);
            this.labelTypeHosts.TabIndex = 4;
            this.labelTypeHosts.Text = "Tipe Hosts";
            // 
            // labelTitikDua1
            // 
            this.labelTitikDua1.AutoSize = true;
            this.labelTitikDua1.Location = new System.Drawing.Point(81, 82);
            this.labelTitikDua1.Name = "labelTitikDua1";
            this.labelTitikDua1.Size = new System.Drawing.Size(10, 13);
            this.labelTitikDua1.TabIndex = 5;
            this.labelTitikDua1.Text = ":";
            // 
            // labelTitikDua2
            // 
            this.labelTitikDua2.AutoSize = true;
            this.labelTitikDua2.Location = new System.Drawing.Point(81, 105);
            this.labelTitikDua2.Name = "labelTitikDua2";
            this.labelTitikDua2.Size = new System.Drawing.Size(10, 13);
            this.labelTitikDua2.TabIndex = 6;
            this.labelTitikDua2.Text = ":";
            // 
            // statusHostsValue
            // 
            this.statusHostsValue.AutoSize = true;
            this.statusHostsValue.Location = new System.Drawing.Point(97, 82);
            this.statusHostsValue.Name = "statusHostsValue";
            this.statusHostsValue.Size = new System.Drawing.Size(10, 13);
            this.statusHostsValue.TabIndex = 7;
            this.statusHostsValue.Text = "-";
            // 
            // labelTypeHostsValue
            // 
            this.labelTypeHostsValue.AutoSize = true;
            this.labelTypeHostsValue.Location = new System.Drawing.Point(97, 105);
            this.labelTypeHostsValue.Name = "labelTypeHostsValue";
            this.labelTypeHostsValue.Size = new System.Drawing.Size(10, 13);
            this.labelTypeHostsValue.TabIndex = 8;
            this.labelTypeHostsValue.Text = "-";
            // 
            // buttonChangeTypeHosts
            // 
            this.buttonChangeTypeHosts.Location = new System.Drawing.Point(130, 185);
            this.buttonChangeTypeHosts.Name = "buttonChangeTypeHosts";
            this.buttonChangeTypeHosts.Size = new System.Drawing.Size(95, 26);
            this.buttonChangeTypeHosts.TabIndex = 9;
            this.buttonChangeTypeHosts.Text = "NSFW Mode";
            this.buttonChangeTypeHosts.UseVisualStyleBackColor = true;
            this.buttonChangeTypeHosts.Click += new System.EventHandler(this.buttonChangeTypeHosts_Click);
            // 
            // installationStatus
            // 
            this.installationStatus.AutoSize = true;
            this.installationStatus.Location = new System.Drawing.Point(12, 221);
            this.installationStatus.Name = "installationStatus";
            this.installationStatus.Size = new System.Drawing.Size(100, 13);
            this.installationStatus.TabIndex = 10;
            this.installationStatus.Text = "Menunggu Perintah";
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Location = new System.Drawing.Point(190, 283);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(35, 13);
            this.linkAbout.TabIndex = 11;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "About";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 240);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "BY KINI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "BEBASID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "bebasid v1.1 (Win/GUI)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Versi Hosts";
            // 
            // labelVersi
            // 
            this.labelVersi.AutoSize = true;
            this.labelVersi.Location = new System.Drawing.Point(97, 127);
            this.labelVersi.Name = "labelVersi";
            this.labelVersi.Size = new System.Drawing.Size(10, 13);
            this.labelVersi.TabIndex = 23;
            this.labelVersi.Text = "-";
            // 
            // labelTitikDua3
            // 
            this.labelTitikDua3.AutoSize = true;
            this.labelTitikDua3.Location = new System.Drawing.Point(81, 127);
            this.labelTitikDua3.Name = "labelTitikDua3";
            this.labelTitikDua3.Size = new System.Drawing.Size(10, 13);
            this.labelTitikDua3.TabIndex = 22;
            this.labelTitikDua3.Text = ":";
            // 
            // labelVersiRemote
            // 
            this.labelVersiRemote.AutoSize = true;
            this.labelVersiRemote.Location = new System.Drawing.Point(113, 127);
            this.labelVersiRemote.Name = "labelVersiRemote";
            this.labelVersiRemote.Size = new System.Drawing.Size(10, 13);
            this.labelVersiRemote.TabIndex = 24;
            this.labelVersiRemote.Text = "-";
            this.labelVersiRemote.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(237, 305);
            this.Controls.Add(this.labelVersiRemote);
            this.Controls.Add(this.labelVersi);
            this.Controls.Add(this.labelTitikDua3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.installationStatus);
            this.Controls.Add(this.buttonChangeTypeHosts);
            this.Controls.Add(this.labelTypeHostsValue);
            this.Controls.Add(this.statusHostsValue);
            this.Controls.Add(this.labelTitikDua2);
            this.Controls.Add(this.labelTitikDua1);
            this.Controls.Add(this.labelTypeHosts);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnUpdateHosts);
            this.Controls.Add(this.btnUninstallHosts);
            this.Controls.Add(this.btnInstall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bebasid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnUninstallHosts;
        private System.Windows.Forms.Button btnUpdateHosts;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTypeHosts;
        private System.Windows.Forms.Label labelTitikDua1;
        private System.Windows.Forms.Label labelTitikDua2;
        private System.Windows.Forms.Label statusHostsValue;
        private System.Windows.Forms.Label labelTypeHostsValue;
        private System.Windows.Forms.Button buttonChangeTypeHosts;
        private System.Windows.Forms.Label installationStatus;
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVersi;
        private System.Windows.Forms.Label labelTitikDua3;
        private System.Windows.Forms.Label labelVersiRemote;
    }
}

