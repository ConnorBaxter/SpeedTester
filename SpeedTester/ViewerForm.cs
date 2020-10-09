using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;
using SpeedTestBackgroundWorker;

namespace SpeedTester
{
    public partial class ViewerForm : Form
    {
        private string PathToCSVFile = Environment.CurrentDirectory + "/../../../SpeedTestBackgroundWorker/bin/Debug/Data/Values.csv";
        private string PathToLastScanFile = Environment.CurrentDirectory + "/../../../SpeedTestBackgroundWorker/bin/Debug/Data/Report.dat";

        List<double> Pings = new List<double>();
        List<int> Downloads = new List<int>();
        List<int> Uploads = new List<int>();

        private Root LastScanResult;

        public ViewerForm()
        {
            InitializeComponent();
        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {
            LastScanResult = JsonConvert.DeserializeObject<Root>(File.ReadAllText(PathToLastScanFile));

            PopulateLastScanTab();
            ToggleSensitiveInfo();

            PopulateDataLists();
            DisplayData();
        }

        private void PopulateDataLists()
        {
            using (StreamReader sr = new StreamReader(PathToCSVFile))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] vals = line.Split(',');
                    if(vals.Length != 3) continue;

                    Pings.Add(double.Parse(vals[0]));
                    Downloads.Add(ConvertToMegabytes(int.Parse(vals[1])));
                    Uploads.Add(ConvertToMegabytes(int.Parse(vals[2])));
                }
            }
        }

        private int ConvertToMegabytes(int bytes)
        {
            return ((bytes) / 1024) / 1024;
        }

        private void DisplayData()
        {
            ShowPings();
            ShowDownloads();
            ShowUploads();
            ShowCombined();
        }

        private void ShowPings()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Spline;

            foreach (double ping in Pings)
            {
                series.Points.Add(ping);
            }

            series.Color = Color.Red;

            chrtPing.Series.Add(series);
        }
        private void ShowDownloads()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Spline;

            foreach (int time in Downloads)
            {
                series.Points.Add(time);
            }

            series.Color = Color.Blue;

            chrtDownload.Series.Add(series);
        }
        private void ShowUploads()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Spline;

            foreach (int time in Uploads)
            {
                series.Points.Add(time);
            }

            series.Color = Color.Green;

            chrtUpload.Series.Add(series);
        }
        private void ShowCombined()
        {
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Spline;
            foreach (double ping in Pings) { series1.Points.Add(ping); }
            series1.Color = Color.Red;
            series1.YAxisType = AxisType.Secondary;

            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Spline;
            foreach (int down in Downloads) { series2.Points.Add(down); }
            series2.Color = Color.Blue;
            series2.YAxisType = AxisType.Primary;

            Series series3 = new Series();
            series3.ChartType = SeriesChartType.Spline;
            foreach (int up in Uploads) { series3.Points.Add(up); }
            series3.Color = Color.Green;
            series3.YAxisType = AxisType.Primary;


            chrtCombined.Series.Add(series1);
            chrtCombined.Series.Add(series2);
            chrtCombined.Series.Add(series3);
        }

        private void HandleRadioButtons(object sender, EventArgs e)
        {
            int ByteCode = 0;
            int KByteCode = 1;
            int MByteCode = 2;

            if (rbBytes.Checked)
            {
                rbKBytes.Checked = false;
                rbMbytes.Checked = false;

                ChangeUnits(ByteCode);
            }

            if (rbKBytes.Checked)
            {
                rbBytes.Checked = false;
                rbMbytes.Checked = false;

                ChangeUnits(KByteCode);
            }

            if (rbMbytes.Checked)
            {
                rbBytes.Checked = false;
                rbKBytes.Checked = false;

                ChangeUnits(MByteCode);
            }
        }

        private void ChangeUnits(int code)
        {
            switch (code)
            {
                case 0:
                    lblDownBytes.Text = "Bytes: " + LastScanResult.download.bytes;
                    lblUpBytes.Text = "Bytes: " + LastScanResult.upload.bytes;
                    lblDownBytes.Location = new Point(38, 16);
                    lblUpBytes.Location = new Point(38, 16);
                    break;
                case 1:
                    lblDownBytes.Text = "Kilobytes: " + LastScanResult.download.bytes / 1024;
                    lblUpBytes.Text = "Kilobytes: " + LastScanResult.upload.bytes / 1024;
                    lblDownBytes.Location = new Point(22, 16);
                    lblUpBytes.Location = new Point(22, 16);
                    break;
                case 2:
                    lblDownBytes.Text = "Megabytes: " + (LastScanResult.download.bytes / 1024) / 1024;
                    lblUpBytes.Text = "Megabytes: " + (LastScanResult.upload.bytes / 1024) / 1024;
                    lblDownBytes.Location = new Point(12, 16);
                    lblUpBytes.Location = new Point(12, 16);
                    break;
                default:
                    ChangeUnits(0);
                    break;
            }
        }

        private void ToggleSensitiveInfo()
        {
            if (chkHideInfo.Checked)
            {
                lblName.Text = "Name: Hidden";
                lblMacAddr.Text = "MAC Address: Hidden";
                lblExternalIP.Text = "External IP: Hidden";
            }
            else
            {
                lblName.Text = "Name: " + LastScanResult.iface.name;
                lblMacAddr.Text = "MAC Address: " + LastScanResult.iface.macAddr;
                lblExternalIP.Text = "External IP: " + LastScanResult.iface.externalIp;
            }
        }

        private void PopulateLastScanTab()
        {
            lblTimestamp.Text = "Timestamp: " + LastScanResult.timestamp;
            lblPacketLoss.Text = "Packet Loss: " + LastScanResult.packetLoss;
            lblISP.Text = "ISP: " + LastScanResult.isp;

            lblLatency.Text = "Latency: " + LastScanResult.ping.latency;
            lblJitter.Text = "Jitter: " + LastScanResult.ping.jitter;

            lblDownBandwidth.Text = "Bandwidth: " + LastScanResult.download.bandwidth;
            lblDownBytes.Text = "Bytes: " + LastScanResult.download.bytes;
            lblDownElapsed.Text = "Elapsed: " + LastScanResult.download.elapsed;

            lblUpBandwidth.Text = "Bandwidth: " + LastScanResult.upload.bandwidth;
            lblUpBytes.Text = "Bytes: " + LastScanResult.upload.bytes;
            lblUpElapsed.Text = "Elapsed: " + LastScanResult.upload.elapsed;

            lblInternalIP.Text = "Internal IP: " + LastScanResult.iface.internalIp;
            lblName.Text = "Name: " + LastScanResult.iface.name;
            lblMacAddr.Text = "MAC Address: " + LastScanResult.iface.macAddr;
            lblIsVpn.Text = "Is VPN: " + LastScanResult.iface.isVpn;
            lblExternalIP.Text = "External IP: " + LastScanResult.iface.externalIp;

            lblServerID.Text = "Server ID: " + LastScanResult.server.id;
            lblServerName.Text = "Name: " + LastScanResult.server.name;
            lblServerLoc.Text = "Location: " + LastScanResult.server.location + 
                                ", " + LastScanResult.server.country;
            lblServerHost.Text = "Host: " + LastScanResult.server.host;
            lblServerPort.Text = "Port: " + LastScanResult.server.port;
            lblServerIP.Text = "Server IP: " + LastScanResult.server.ip;
        }

        private void chkHideInfo_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSensitiveInfo();
        }

        private void btnViewOnline_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LastScanResult.result.url);
        }
    }
}
