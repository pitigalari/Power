using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Power
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        int x = Convert.ToInt32(Properties.Settings.Default.time);
        private void Timer_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show(Properties.Settings.Default.action+" command has been issued.", "Command issued.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            label3.Text= Properties.Settings.Default.action;
            label2.Text = Properties.Settings.Default.time;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x--;
            label1.Text=x.ToString();
            if(label3.Text=="Lock")
            {
            if (x == 0)
            {
                timer1.Stop();
                Process.Start("cmd.exe", "/c rundll32.exe user32.dll, LockWorkStation");
                Application.Exit();
            }
            }
            else if (label3.Text == "Standby")
            {
                if (x == 0)
                {
                    timer1.Stop();
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    Application.Exit();
                }
            }
            else if (label3.Text == "Logoff")
            {
                if (x == 0)
                {
                    timer1.Stop();
                    Process.Start("shutdown", "-l");
                    Application.Exit();
                }
            }
            else if (label3.Text == "Hibernate")
            {
                if (x == 0)
                {
                    timer1.Stop();
                    Process.Start("shutdown", "-h");
                    Application.Exit();
                }
            }
        }
    }
}
