using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace giPerf_3
{
    public partial class mainForm : Form
    {
        private Process cmd = new Process();

        public mainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            cmd.OutputDataReceived += (object sender, System.Diagnostics.DataReceivedEventArgs e) => printText(e.Data);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Process
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();
            cmd.BeginOutputReadLine();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (radBtnServer.Checked)
            {
                if (txbPort.Text == "")
                {
                    executeCommand(@".\Resources\iperf3.exe -s");
                }
                else
                {
                    executeCommand(@".\Resources\iperf3.exe -s -p " + txbPort.Text);
                }

            }
            else if (txbIP.Text != "" & txbTime.Text != "")
            {
                // Start Countdown
                Thread bgThread = new Thread(() => threadCountdown(Convert.ToInt32(txbTime.Text)));
                bgThread.Start();

                // Execute Command
                if (txbPort.Text == "")
                {
                    executeCommand(@".\Resources\iperf3.exe -c " + txbIP.Text + " -t " + txbTime.Text);
                }
                else
                {
                    executeCommand(@".\Resources\iperf3.exe -c " + txbIP.Text + " -p " + txbPort.Text + " -t " + txbTime.Text);
                }
            }
            else
            {
                MessageBox.Show("There is a wrong input. Please make sure that everything is set up properly!", "Launch-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] procArr = Process.GetProcessesByName("ipferf3");
                foreach (Process p in procArr)
                {
                    p.Kill();
                }

                cmd.Close();
                Environment.Exit(0);
            }
            catch (Exception eX)
            {
                Debug.WriteLine(eX.Message);
            }
        }

        private void radBtnServer_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnServer.Checked)
            {
                txbIP.Enabled = false;
                txbTime.Enabled = false;
            }
            else
            {
                txbIP.Enabled = true;
                txbTime.Enabled = true;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void threadCountdown(int pSeconds)
        {
            int iCounter = pSeconds++;
            progBar.Maximum = pSeconds;
            while (iCounter > 0)
            {
                // Label
                lblSeconds.Text = "Secondy remaining: " + iCounter;
                Thread.Sleep(1000);
                iCounter--;

                // Progressbar
                progBar.Value = iCounter;
            }
        }

        private void printText(string pText)
        {
            try
            {
                rtxbOutput.AppendText(pText + "\r");
            }
            catch (Exception) { }
        }

        private void executeCommand(string pCommand)
        {
            cmd.StandardInput.WriteLine(pCommand);
            cmd.StandardInput.Flush();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void txbTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txbTime.Text);
                txbTime.BackColor = DefaultBackColor;
            }
            catch (Exception)
            {
                txbTime.BackColor = Color.Red;
            }
        }

        private void txbPort_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txbPort.Text);
                txbPort.BackColor = DefaultBackColor;
            }
            catch (Exception)
            {
                txbPort.BackColor = Color.Red;
            }
        }
    }
}
