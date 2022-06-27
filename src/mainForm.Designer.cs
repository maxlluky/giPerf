namespace giPerf_3
{
    partial class mainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnStartTest = new System.Windows.Forms.Button();
            this.rtxbOutput = new System.Windows.Forms.RichTextBox();
            this.gBoxType = new System.Windows.Forms.GroupBox();
            this.radBtnClient = new System.Windows.Forms.RadioButton();
            this.radBtnServer = new System.Windows.Forms.RadioButton();
            this.gBoxMain = new System.Windows.Forms.GroupBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.gBoxType.SuspendLayout();
            this.gBoxMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartTest
            // 
            this.btnStartTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnStartTest.FlatAppearance.BorderSize = 0;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTest.ForeColor = System.Drawing.Color.White;
            this.btnStartTest.Location = new System.Drawing.Point(5, 387);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(85, 23);
            this.btnStartTest.TabIndex = 3;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // rtxbOutput
            // 
            this.rtxbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.rtxbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbOutput.ForeColor = System.Drawing.Color.White;
            this.rtxbOutput.Location = new System.Drawing.Point(5, 20);
            this.rtxbOutput.Name = "rtxbOutput";
            this.rtxbOutput.Size = new System.Drawing.Size(772, 363);
            this.rtxbOutput.TabIndex = 0;
            this.rtxbOutput.TabStop = false;
            this.rtxbOutput.Text = "";
            // 
            // gBoxType
            // 
            this.gBoxType.Controls.Add(this.radBtnClient);
            this.gBoxType.Controls.Add(this.radBtnServer);
            this.gBoxType.ForeColor = System.Drawing.Color.White;
            this.gBoxType.Location = new System.Drawing.Point(5, 40);
            this.gBoxType.Name = "gBoxType";
            this.gBoxType.Size = new System.Drawing.Size(200, 45);
            this.gBoxType.TabIndex = 0;
            this.gBoxType.TabStop = false;
            this.gBoxType.Text = "Execution type";
            // 
            // radBtnClient
            // 
            this.radBtnClient.AutoSize = true;
            this.radBtnClient.Checked = true;
            this.radBtnClient.Location = new System.Drawing.Point(110, 20);
            this.radBtnClient.Name = "radBtnClient";
            this.radBtnClient.Size = new System.Drawing.Size(84, 17);
            this.radBtnClient.TabIndex = 1;
            this.radBtnClient.TabStop = true;
            this.radBtnClient.Text = "Act as Client";
            this.radBtnClient.UseVisualStyleBackColor = true;
            // 
            // radBtnServer
            // 
            this.radBtnServer.AutoSize = true;
            this.radBtnServer.Location = new System.Drawing.Point(10, 20);
            this.radBtnServer.Name = "radBtnServer";
            this.radBtnServer.Size = new System.Drawing.Size(89, 17);
            this.radBtnServer.TabIndex = 0;
            this.radBtnServer.TabStop = true;
            this.radBtnServer.Text = "Act as Server";
            this.radBtnServer.UseVisualStyleBackColor = true;
            this.radBtnServer.CheckedChanged += new System.EventHandler(this.radBtnServer_CheckedChanged);
            // 
            // gBoxMain
            // 
            this.gBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxMain.Controls.Add(this.progBar);
            this.gBoxMain.Controls.Add(this.lblSeconds);
            this.gBoxMain.Controls.Add(this.rtxbOutput);
            this.gBoxMain.Controls.Add(this.btnStartTest);
            this.gBoxMain.ForeColor = System.Drawing.Color.White;
            this.gBoxMain.Location = new System.Drawing.Point(5, 90);
            this.gBoxMain.Name = "gBoxMain";
            this.gBoxMain.Size = new System.Drawing.Size(782, 417);
            this.gBoxMain.TabIndex = 0;
            this.gBoxMain.TabStop = false;
            this.gBoxMain.Text = "Output";
            // 
            // progBar
            // 
            this.progBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progBar.ForeColor = System.Drawing.Color.Black;
            this.progBar.Location = new System.Drawing.Point(652, 387);
            this.progBar.MarqueeAnimationSpeed = 50;
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(120, 23);
            this.progBar.Step = 1;
            this.progBar.TabIndex = 0;
            this.progBar.Value = 100;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(100, 392);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(106, 13);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "Secondy remaining: -";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(435, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(84, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Seconds to test:";
            // 
            // txbTime
            // 
            this.txbTime.Location = new System.Drawing.Point(520, 20);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(50, 20);
            this.txbTime.TabIndex = 3;
            this.txbTime.TextChanged += new System.EventHandler(this.txbTime_TextChanged);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(8, 23);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(117, 13);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "Server-IP or Hostname:";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(130, 20);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(205, 20);
            this.txbIP.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.picBoxLogo);
            this.panelTop.Controls.Add(this.lblTitel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(792, 30);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = global::giPerf_3.Properties.Resources.close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(767, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::giPerf_3.Properties.Resources.bandwidth;
            this.picBoxLogo.Location = new System.Drawing.Point(5, 5);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(20, 20);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(30, 10);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(46, 13);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "giPerf 3 ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.txbPort);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.txbTime);
            this.groupBox1.Controls.Add(this.txbIP);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(210, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(345, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port:";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(375, 20);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(50, 20);
            this.txbPort.TabIndex = 6;
            this.txbPort.TextChanged += new System.EventHandler(this.txbPort_TextChanged);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(792, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.gBoxMain);
            this.Controls.Add(this.gBoxType);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giPerf 3 Client";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gBoxType.ResumeLayout(false);
            this.gBoxType.PerformLayout();
            this.gBoxMain.ResumeLayout(false);
            this.gBoxMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.RichTextBox rtxbOutput;
        private System.Windows.Forms.GroupBox gBoxType;
        private System.Windows.Forms.RadioButton radBtnClient;
        private System.Windows.Forms.RadioButton radBtnServer;
        private System.Windows.Forms.GroupBox gBoxMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txbPort;
    }
}

