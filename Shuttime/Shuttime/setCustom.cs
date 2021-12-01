using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuttime
{
    public partial class setCustom : Form
    {
        public setCustom()
        {
            InitializeComponent();
        }

        private void timerStart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -s -f -t " + Convert.ToString(numericUpDown1.Value * 60);
            process.StartInfo = startInfo;
            process.Start();
            this.Close();
        }
    }
}
