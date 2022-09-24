using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shuttime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }
        private void minute15_Click(object sender, EventArgs e)
        {
            SetTime("/C shutdown -s -f -t 900");
        }

        private void minute30_Click(object sender, EventArgs e)
        {
            SetTime("/C shutdown -s -f -t 1800");
        }

        private void minute45_Click(object sender, EventArgs e)
        {
            SetTime("/C shutdown -s -f -t 2700");
        }

        private void hours1_Click(object sender, EventArgs e)
        {
            SetTime("/C shutdown -s -f -t 3600");
        }

        private void turnOffActiveTimer_Click(object sender, EventArgs e)
        {
            SetTime("/C shutdown -a");
        }

        private void setCustom_Click(object sender, EventArgs e)
        {
            setCustom setCustom = new setCustom();
            setCustom.Show();
        }

        private void SetTime(string arguments)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = arguments;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
