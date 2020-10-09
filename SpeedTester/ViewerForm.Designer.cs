namespace SpeedTester
{
    partial class ViewerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.tcViews = new System.Windows.Forms.TabControl();
            this.tpPing = new System.Windows.Forms.TabPage();
            this.tpDownload = new System.Windows.Forms.TabPage();
            this.tpUpload = new System.Windows.Forms.TabPage();
            this.tpLastScan = new System.Windows.Forms.TabPage();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPacketLoss = new System.Windows.Forms.Label();
            this.lblISP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLatency = new System.Windows.Forms.Label();
            this.lblJitter = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDownElapsed = new System.Windows.Forms.Label();
            this.lblDownBytes = new System.Windows.Forms.Label();
            this.lblDownBandwidth = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblUpElapsed = new System.Windows.Forms.Label();
            this.lblUpBytes = new System.Windows.Forms.Label();
            this.lblUpBandwidth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbMbytes = new System.Windows.Forms.RadioButton();
            this.rbKBytes = new System.Windows.Forms.RadioButton();
            this.rbBytes = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblInternalIP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMacAddr = new System.Windows.Forms.Label();
            this.lblIsVpn = new System.Windows.Forms.Label();
            this.lblExternalIP = new System.Windows.Forms.Label();
            this.chkHideInfo = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblServerID = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblServerLoc = new System.Windows.Forms.Label();
            this.lblServerHost = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.btnViewOnline = new System.Windows.Forms.Button();
            this.chrtPing = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpCombined = new System.Windows.Forms.TabPage();
            this.chrtDownload = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtUpload = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtCombined = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tcViews.SuspendLayout();
            this.tpPing.SuspendLayout();
            this.tpDownload.SuspendLayout();
            this.tpUpload.SuspendLayout();
            this.tpLastScan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPing)).BeginInit();
            this.tpCombined.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCombined)).BeginInit();
            this.SuspendLayout();
            // 
            // tcViews
            // 
            this.tcViews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcViews.Controls.Add(this.tpPing);
            this.tcViews.Controls.Add(this.tpDownload);
            this.tcViews.Controls.Add(this.tpUpload);
            this.tcViews.Controls.Add(this.tpCombined);
            this.tcViews.Controls.Add(this.tpLastScan);
            this.tcViews.Location = new System.Drawing.Point(12, 12);
            this.tcViews.Name = "tcViews";
            this.tcViews.SelectedIndex = 0;
            this.tcViews.Size = new System.Drawing.Size(776, 426);
            this.tcViews.TabIndex = 0;
            // 
            // tpPing
            // 
            this.tpPing.Controls.Add(this.chrtPing);
            this.tpPing.Location = new System.Drawing.Point(4, 22);
            this.tpPing.Name = "tpPing";
            this.tpPing.Padding = new System.Windows.Forms.Padding(3);
            this.tpPing.Size = new System.Drawing.Size(768, 400);
            this.tpPing.TabIndex = 0;
            this.tpPing.Text = "Ping";
            this.tpPing.UseVisualStyleBackColor = true;
            // 
            // tpDownload
            // 
            this.tpDownload.Controls.Add(this.chrtDownload);
            this.tpDownload.Location = new System.Drawing.Point(4, 22);
            this.tpDownload.Name = "tpDownload";
            this.tpDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tpDownload.Size = new System.Drawing.Size(768, 400);
            this.tpDownload.TabIndex = 1;
            this.tpDownload.Text = "Download";
            this.tpDownload.UseVisualStyleBackColor = true;
            // 
            // tpUpload
            // 
            this.tpUpload.Controls.Add(this.chrtUpload);
            this.tpUpload.Location = new System.Drawing.Point(4, 22);
            this.tpUpload.Name = "tpUpload";
            this.tpUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpload.Size = new System.Drawing.Size(768, 400);
            this.tpUpload.TabIndex = 2;
            this.tpUpload.Text = "Upload";
            this.tpUpload.UseVisualStyleBackColor = true;
            // 
            // tpLastScan
            // 
            this.tpLastScan.Controls.Add(this.groupBox7);
            this.tpLastScan.Controls.Add(this.groupBox6);
            this.tpLastScan.Controls.Add(this.panel1);
            this.tpLastScan.Controls.Add(this.groupBox4);
            this.tpLastScan.Controls.Add(this.groupBox3);
            this.tpLastScan.Controls.Add(this.groupBox2);
            this.tpLastScan.Controls.Add(this.groupBox1);
            this.tpLastScan.Location = new System.Drawing.Point(4, 22);
            this.tpLastScan.Name = "tpLastScan";
            this.tpLastScan.Padding = new System.Windows.Forms.Padding(3);
            this.tpLastScan.Size = new System.Drawing.Size(768, 400);
            this.tpLastScan.TabIndex = 3;
            this.tpLastScan.Text = "Last Scan Results";
            this.tpLastScan.UseVisualStyleBackColor = true;
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(14, 16);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(61, 13);
            this.lblTimestamp.TabIndex = 0;
            this.lblTimestamp.Text = "Timestamp:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblISP);
            this.groupBox1.Controls.Add(this.lblPacketLoss);
            this.groupBox1.Controls.Add(this.lblTimestamp);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // lblPacketLoss
            // 
            this.lblPacketLoss.AutoSize = true;
            this.lblPacketLoss.Location = new System.Drawing.Point(6, 29);
            this.lblPacketLoss.Name = "lblPacketLoss";
            this.lblPacketLoss.Size = new System.Drawing.Size(69, 13);
            this.lblPacketLoss.TabIndex = 1;
            this.lblPacketLoss.Text = "Packet Loss:";
            // 
            // lblISP
            // 
            this.lblISP.AutoSize = true;
            this.lblISP.Location = new System.Drawing.Point(48, 42);
            this.lblISP.Name = "lblISP";
            this.lblISP.Size = new System.Drawing.Size(27, 13);
            this.lblISP.TabIndex = 2;
            this.lblISP.Text = "ISP:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lblJitter);
            this.groupBox2.Controls.Add(this.lblLatency);
            this.groupBox2.Location = new System.Drawing.Point(6, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ping";
            // 
            // lblLatency
            // 
            this.lblLatency.AutoSize = true;
            this.lblLatency.Location = new System.Drawing.Point(6, 16);
            this.lblLatency.Name = "lblLatency";
            this.lblLatency.Size = new System.Drawing.Size(48, 13);
            this.lblLatency.TabIndex = 1;
            this.lblLatency.Text = "Latency:";
            // 
            // lblJitter
            // 
            this.lblJitter.AutoSize = true;
            this.lblJitter.Location = new System.Drawing.Point(22, 29);
            this.lblJitter.Name = "lblJitter";
            this.lblJitter.Size = new System.Drawing.Size(32, 13);
            this.lblJitter.TabIndex = 2;
            this.lblJitter.Text = "Jitter:";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.lblDownElapsed);
            this.groupBox3.Controls.Add(this.lblDownBytes);
            this.groupBox3.Controls.Add(this.lblDownBandwidth);
            this.groupBox3.Location = new System.Drawing.Point(212, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download";
            // 
            // lblDownElapsed
            // 
            this.lblDownElapsed.AutoSize = true;
            this.lblDownElapsed.Location = new System.Drawing.Point(26, 42);
            this.lblDownElapsed.Name = "lblDownElapsed";
            this.lblDownElapsed.Size = new System.Drawing.Size(48, 13);
            this.lblDownElapsed.TabIndex = 2;
            this.lblDownElapsed.Text = "Elapsed:";
            // 
            // lblDownBytes
            // 
            this.lblDownBytes.AutoSize = true;
            this.lblDownBytes.Location = new System.Drawing.Point(38, 16);
            this.lblDownBytes.Name = "lblDownBytes";
            this.lblDownBytes.Size = new System.Drawing.Size(36, 13);
            this.lblDownBytes.TabIndex = 1;
            this.lblDownBytes.Text = "Bytes:";
            // 
            // lblDownBandwidth
            // 
            this.lblDownBandwidth.AutoSize = true;
            this.lblDownBandwidth.Location = new System.Drawing.Point(14, 29);
            this.lblDownBandwidth.Name = "lblDownBandwidth";
            this.lblDownBandwidth.Size = new System.Drawing.Size(60, 13);
            this.lblDownBandwidth.TabIndex = 0;
            this.lblDownBandwidth.Text = "Bandwidth:";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.lblUpElapsed);
            this.groupBox4.Controls.Add(this.lblUpBytes);
            this.groupBox4.Controls.Add(this.lblUpBandwidth);
            this.groupBox4.Location = new System.Drawing.Point(212, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 71);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Upload";
            // 
            // lblUpElapsed
            // 
            this.lblUpElapsed.AutoSize = true;
            this.lblUpElapsed.Location = new System.Drawing.Point(26, 42);
            this.lblUpElapsed.Name = "lblUpElapsed";
            this.lblUpElapsed.Size = new System.Drawing.Size(48, 13);
            this.lblUpElapsed.TabIndex = 2;
            this.lblUpElapsed.Text = "Elapsed:";
            // 
            // lblUpBytes
            // 
            this.lblUpBytes.AutoSize = true;
            this.lblUpBytes.Location = new System.Drawing.Point(38, 16);
            this.lblUpBytes.Name = "lblUpBytes";
            this.lblUpBytes.Size = new System.Drawing.Size(36, 13);
            this.lblUpBytes.TabIndex = 1;
            this.lblUpBytes.Text = "Bytes:";
            // 
            // lblUpBandwidth
            // 
            this.lblUpBandwidth.AutoSize = true;
            this.lblUpBandwidth.Location = new System.Drawing.Point(14, 29);
            this.lblUpBandwidth.Name = "lblUpBandwidth";
            this.lblUpBandwidth.Size = new System.Drawing.Size(60, 13);
            this.lblUpBandwidth.TabIndex = 0;
            this.lblUpBandwidth.Text = "Bandwidth:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewOnline);
            this.panel1.Controls.Add(this.chkHideInfo);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(601, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 155);
            this.panel1.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbMbytes);
            this.groupBox5.Controls.Add(this.rbKBytes);
            this.groupBox5.Controls.Add(this.rbBytes);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(91, 92);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Units";
            // 
            // rbMbytes
            // 
            this.rbMbytes.AutoSize = true;
            this.rbMbytes.Location = new System.Drawing.Point(6, 65);
            this.rbMbytes.Name = "rbMbytes";
            this.rbMbytes.Size = new System.Drawing.Size(77, 17);
            this.rbMbytes.TabIndex = 5;
            this.rbMbytes.Text = "Megabytes";
            this.rbMbytes.UseVisualStyleBackColor = true;
            this.rbMbytes.CheckedChanged += new System.EventHandler(this.HandleRadioButtons);
            // 
            // rbKBytes
            // 
            this.rbKBytes.AutoSize = true;
            this.rbKBytes.Location = new System.Drawing.Point(6, 42);
            this.rbKBytes.Name = "rbKBytes";
            this.rbKBytes.Size = new System.Drawing.Size(67, 17);
            this.rbKBytes.TabIndex = 4;
            this.rbKBytes.Text = "Kilobytes";
            this.rbKBytes.UseVisualStyleBackColor = true;
            this.rbKBytes.CheckedChanged += new System.EventHandler(this.HandleRadioButtons);
            // 
            // rbBytes
            // 
            this.rbBytes.AutoSize = true;
            this.rbBytes.Checked = true;
            this.rbBytes.Location = new System.Drawing.Point(6, 19);
            this.rbBytes.Name = "rbBytes";
            this.rbBytes.Size = new System.Drawing.Size(51, 17);
            this.rbBytes.TabIndex = 3;
            this.rbBytes.TabStop = true;
            this.rbBytes.Text = "Bytes";
            this.rbBytes.UseVisualStyleBackColor = true;
            this.rbBytes.CheckedChanged += new System.EventHandler(this.HandleRadioButtons);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.lblExternalIP);
            this.groupBox6.Controls.Add(this.lblIsVpn);
            this.groupBox6.Controls.Add(this.lblMacAddr);
            this.groupBox6.Controls.Add(this.lblName);
            this.groupBox6.Controls.Add(this.lblInternalIP);
            this.groupBox6.Location = new System.Drawing.Point(6, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 97);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Interface";
            // 
            // lblInternalIP
            // 
            this.lblInternalIP.AutoSize = true;
            this.lblInternalIP.Location = new System.Drawing.Point(22, 16);
            this.lblInternalIP.Name = "lblInternalIP";
            this.lblInternalIP.Size = new System.Drawing.Size(58, 13);
            this.lblInternalIP.TabIndex = 0;
            this.lblInternalIP.Text = "Internal IP:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblMacAddr
            // 
            this.lblMacAddr.AutoSize = true;
            this.lblMacAddr.Location = new System.Drawing.Point(6, 42);
            this.lblMacAddr.Name = "lblMacAddr";
            this.lblMacAddr.Size = new System.Drawing.Size(74, 13);
            this.lblMacAddr.TabIndex = 2;
            this.lblMacAddr.Text = "MAC Address:";
            // 
            // lblIsVpn
            // 
            this.lblIsVpn.AutoSize = true;
            this.lblIsVpn.Location = new System.Drawing.Point(37, 55);
            this.lblIsVpn.Name = "lblIsVpn";
            this.lblIsVpn.Size = new System.Drawing.Size(43, 13);
            this.lblIsVpn.TabIndex = 3;
            this.lblIsVpn.Text = "Is VPN:";
            // 
            // lblExternalIP
            // 
            this.lblExternalIP.AutoSize = true;
            this.lblExternalIP.Location = new System.Drawing.Point(19, 68);
            this.lblExternalIP.Name = "lblExternalIP";
            this.lblExternalIP.Size = new System.Drawing.Size(61, 13);
            this.lblExternalIP.TabIndex = 4;
            this.lblExternalIP.Text = "External IP:";
            // 
            // chkHideInfo
            // 
            this.chkHideInfo.AutoSize = true;
            this.chkHideInfo.Checked = true;
            this.chkHideInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideInfo.Location = new System.Drawing.Point(3, 97);
            this.chkHideInfo.Name = "chkHideInfo";
            this.chkHideInfo.Size = new System.Drawing.Size(146, 17);
            this.chkHideInfo.TabIndex = 1;
            this.chkHideInfo.Text = "Hide Sensitive Infomation";
            this.chkHideInfo.UseVisualStyleBackColor = true;
            this.chkHideInfo.CheckedChanged += new System.EventHandler(this.chkHideInfo_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.lblServerIP);
            this.groupBox7.Controls.Add(this.lblServerPort);
            this.groupBox7.Controls.Add(this.lblServerHost);
            this.groupBox7.Controls.Add(this.lblServerLoc);
            this.groupBox7.Controls.Add(this.lblServerName);
            this.groupBox7.Controls.Add(this.lblServerID);
            this.groupBox7.Location = new System.Drawing.Point(212, 164);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 110);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Server";
            // 
            // lblServerID
            // 
            this.lblServerID.AutoSize = true;
            this.lblServerID.Location = new System.Drawing.Point(5, 16);
            this.lblServerID.Name = "lblServerID";
            this.lblServerID.Size = new System.Drawing.Size(55, 13);
            this.lblServerID.TabIndex = 0;
            this.lblServerID.Text = "Server ID:";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(22, 29);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(38, 13);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Name:";
            // 
            // lblServerLoc
            // 
            this.lblServerLoc.AutoSize = true;
            this.lblServerLoc.Location = new System.Drawing.Point(9, 42);
            this.lblServerLoc.Name = "lblServerLoc";
            this.lblServerLoc.Size = new System.Drawing.Size(51, 13);
            this.lblServerLoc.TabIndex = 2;
            this.lblServerLoc.Text = "Location:";
            // 
            // lblServerHost
            // 
            this.lblServerHost.AutoSize = true;
            this.lblServerHost.Location = new System.Drawing.Point(28, 55);
            this.lblServerHost.Name = "lblServerHost";
            this.lblServerHost.Size = new System.Drawing.Size(32, 13);
            this.lblServerHost.TabIndex = 3;
            this.lblServerHost.Text = "Host:";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(31, 68);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(29, 13);
            this.lblServerPort.TabIndex = 4;
            this.lblServerPort.Text = "Port:";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(6, 81);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(54, 13);
            this.lblServerIP.TabIndex = 5;
            this.lblServerIP.Text = "Server IP:";
            // 
            // btnViewOnline
            // 
            this.btnViewOnline.Location = new System.Drawing.Point(3, 125);
            this.btnViewOnline.Name = "btnViewOnline";
            this.btnViewOnline.Size = new System.Drawing.Size(146, 23);
            this.btnViewOnline.TabIndex = 2;
            this.btnViewOnline.Text = "View Online";
            this.btnViewOnline.UseVisualStyleBackColor = true;
            this.btnViewOnline.Click += new System.EventHandler(this.btnViewOnline_Click);
            // 
            // chrtPing
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtPing.ChartAreas.Add(chartArea1);
            this.chrtPing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtPing.Location = new System.Drawing.Point(3, 3);
            this.chrtPing.Name = "chrtPing";
            this.chrtPing.Size = new System.Drawing.Size(762, 394);
            this.chrtPing.SuppressExceptions = true;
            this.chrtPing.TabIndex = 0;
            this.chrtPing.Text = "Ping";
            // 
            // tpCombined
            // 
            this.tpCombined.Controls.Add(this.chrtCombined);
            this.tpCombined.Location = new System.Drawing.Point(4, 22);
            this.tpCombined.Name = "tpCombined";
            this.tpCombined.Size = new System.Drawing.Size(768, 400);
            this.tpCombined.TabIndex = 4;
            this.tpCombined.Text = "Combined";
            this.tpCombined.UseVisualStyleBackColor = true;
            // 
            // chrtDownload
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtDownload.ChartAreas.Add(chartArea2);
            this.chrtDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtDownload.Location = new System.Drawing.Point(3, 3);
            this.chrtDownload.Name = "chrtDownload";
            this.chrtDownload.Size = new System.Drawing.Size(762, 394);
            this.chrtDownload.SuppressExceptions = true;
            this.chrtDownload.TabIndex = 1;
            this.chrtDownload.Text = "Download";
            // 
            // chrtUpload
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtUpload.ChartAreas.Add(chartArea3);
            this.chrtUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtUpload.Location = new System.Drawing.Point(3, 3);
            this.chrtUpload.Name = "chrtUpload";
            this.chrtUpload.Size = new System.Drawing.Size(762, 394);
            this.chrtUpload.SuppressExceptions = true;
            this.chrtUpload.TabIndex = 1;
            this.chrtUpload.Text = "Upload";
            // 
            // chrtCombined
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtCombined.ChartAreas.Add(chartArea4);
            this.chrtCombined.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtCombined.Location = new System.Drawing.Point(0, 0);
            this.chrtCombined.Name = "chrtCombined";
            this.chrtCombined.Size = new System.Drawing.Size(768, 400);
            this.chrtCombined.SuppressExceptions = true;
            this.chrtCombined.TabIndex = 1;
            this.chrtCombined.Text = "Combined";
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcViews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewerForm";
            this.Text = "Speedtest Viewer";
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            this.tcViews.ResumeLayout(false);
            this.tpPing.ResumeLayout(false);
            this.tpDownload.ResumeLayout(false);
            this.tpUpload.ResumeLayout(false);
            this.tpLastScan.ResumeLayout(false);
            this.tpLastScan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPing)).EndInit();
            this.tpCombined.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCombined)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcViews;
        private System.Windows.Forms.TabPage tpPing;
        private System.Windows.Forms.TabPage tpDownload;
        private System.Windows.Forms.TabPage tpUpload;
        private System.Windows.Forms.TabPage tpLastScan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Label lblPacketLoss;
        private System.Windows.Forms.Label lblISP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLatency;
        private System.Windows.Forms.Label lblJitter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDownElapsed;
        private System.Windows.Forms.Label lblDownBytes;
        private System.Windows.Forms.Label lblDownBandwidth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblUpElapsed;
        private System.Windows.Forms.Label lblUpBytes;
        private System.Windows.Forms.Label lblUpBandwidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbMbytes;
        private System.Windows.Forms.RadioButton rbKBytes;
        private System.Windows.Forms.RadioButton rbBytes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblInternalIP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMacAddr;
        private System.Windows.Forms.Label lblIsVpn;
        private System.Windows.Forms.Label lblExternalIP;
        private System.Windows.Forms.CheckBox chkHideInfo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblServerID;
        private System.Windows.Forms.Label lblServerLoc;
        private System.Windows.Forms.Label lblServerHost;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Button btnViewOnline;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPing;
        private System.Windows.Forms.TabPage tpCombined;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDownload;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUpload;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCombined;
    }
}

