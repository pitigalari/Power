using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PowerBP
{
    public partial class warning : Form
    {
        public warning()
        {
            InitializeComponent();
        }

        readonly int finalTime = 10;
        int time;
        int abortTime = 5;

        private void warning_Load(object sender, EventArgs e)
        {
            if (Form1.type == "CT")
            {
                time = Form1.CT;
                timer1.Interval = 250;
            }
            else
            {
                time = finalTime;
                timer1.Interval = 1000;
            }
            label1.Text = Program.MainForm.BTip;
            label2.Text = time.ToString();
            progressBar1.Value = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.type == "CT")
            {
                time = Form1.CT;
                if (time == 0)
                {
                    this.Close();
                }

            }
            else
            {
                time--;
                if (time < 0)
                {
                    if (Form1.command == "SD")
                    {
                        Form1.check.StartInfo.Arguments = "/c shutdown -s -t 1";
                        Form1.check.Start();
                    }
                    else if (Form1.command == "R")
                    {
                        Form1.check.StartInfo.Arguments = "/c shutdown -r -t 1";
                        Form1.check.Start();
                    }
                    else if (Form1.command == "H")
                    {
                        Form1.check.StartInfo.Arguments = "/c shutdown -h";
                        Form1.check.Start();
                    }
                    else if (Form1.command == "SB")
                    {
                        Application.SetSuspendState(PowerState.Suspend, true, true);
                    }
                    else if (Form1.command == "lock")
                    {
                        Form1.check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                        Form1.check.Start();
                    }
                    else if (Form1.command == "LO")
                    {
                        Form1.check.StartInfo.Arguments = "/c shutdown -l";
                        Form1.check.Start();
                    }
                    else if (Form1.command == "SO")
                    {
                        Form1.SendMessage(this.Handle.ToInt32(), 0x0112, 0xF170, 2);
                    }
                    else
                    {
                        MessageBox.Show("Error Code : PBP3005-1\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    Program.MainForm.exit();
                }
            }
            if (time > 0)
            {
                progressBar1.Value = ((time * 100) / finalTime);
            }
            else
            {
                progressBar1.Value = 0;
            }
            if (time >= 0)
            {
                label2.Text = time.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.type == "CT")
            {
                timer1.Dispose();
                this.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Program.MainForm.timer1.Stop();
            Program.MainForm.timer2.Stop();
            Program.MainForm.timer3.Stop();
            Program.MainForm.infoCMS.Text = Program.MainForm.BTip + " command aborted";
            Program.MainForm.TimeCMS.Text = "0minute(s) 0second(s)";
            Program.MainForm.notifyIcon1.ShowBalloonTip(abortTime, Program.MainForm.BTip + " command Aborted", Program.MainForm.BTip + " command aborted by user. Power Background Process will terminate now.", ToolTipIcon.Info);
            timer2.Start();
        }


        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (time <= 5)
            {
                label2.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (abortTime == 0)
            {
                Program.MainForm.exit();
            }
            else
            {
                abortTime--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (Form1.command == "SD")
            {
                Form1.check.StartInfo.Arguments = "/c shutdown -s -t 1";
                Form1.check.Start();
            }
            else if (Form1.command == "R")
            {
                Form1.check.StartInfo.Arguments = "/c shutdown -r -t 1";
                Form1.check.Start();
            }
            else if (Form1.command == "H")
            {
                Form1.check.StartInfo.Arguments = "/c shutdown -h";
                Form1.check.Start();
            }
            else if (Form1.command == "SB")
            {
                Application.SetSuspendState(PowerState.Suspend, true, true);
            }
            else if (Form1.command == "lock")
            {
                Form1.check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                Form1.check.Start();
            }
            else if (Form1.command == "LO")
            {
                Form1.check.StartInfo.Arguments = "/c shutdown -l";
                Form1.check.Start();
            }
            else if (Form1.command == "SO")
            {
                Form1.SendMessage(this.Handle.ToInt32(), 0x0112, 0xF170, 2);
            }
            else
            {
                MessageBox.Show("Error Code : PBP3005-1\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Program.MainForm.exit();
        }

    }
}
