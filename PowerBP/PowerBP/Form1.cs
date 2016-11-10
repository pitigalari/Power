using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace PowerBP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process check = new Process();
        string type;
        string command;
        string BTip;
        int CT;
        int H;
        int M;
        int D;
        int MM;
        int YY;
        string timeLbl;
        int ask = 1;
        string location;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
            richTextBox1.Dispose();

        }

        private void openPowerUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"Power.exe");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to abort all issued commands and terminate PowerBP?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                notifyIcon1.Dispose();
                check.StartInfo.Arguments = "/c taskkill /F /IM PowerBP.exe /T";
                check.Start();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            #region Set Path
            location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RoshSoft\\");
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }
            #endregion
            check.StartInfo.FileName = "cmd.exe";
            check.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            if (File.Exists(location + "power.dll"))
            {
                richTextBox1.Text = File.ReadAllText(location + "power.dll");
                File.WriteAllText(location + "power.dll", "NA");
                #region Set Values
                {
                    if (richTextBox1.Text == "NA")
                    {
                        notifyIcon1.Dispose();
                        MessageBox.Show("The application is temporary unavailable or you have no authorized permission to access it.", "Application inaccessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else if (richTextBox1.Lines[0] == "CT" || richTextBox1.Lines[0] == "ST")
                    {
                        type = richTextBox1.Lines[0];
                        command = richTextBox1.Lines[1];
                        if (type == "CT")
                        {
                            CT = Convert.ToInt32(richTextBox1.Lines[2]);
                            ask = Convert.ToInt32(richTextBox1.Lines[3]);
                        }
                        else if (type == "ST")
                        {
                            H = Convert.ToInt32(richTextBox1.Lines[2]);
                            M = Convert.ToInt32(richTextBox1.Lines[3]);
                            D = Convert.ToInt32(richTextBox1.Lines[4]);
                            MM = Convert.ToInt32(richTextBox1.Lines[5]);
                            YY = Convert.ToInt32(richTextBox1.Lines[6]);
                            ask = Convert.ToInt32(richTextBox1.Lines[7]);
                        }
                    }
                    else
                    {
                        notifyIcon1.Dispose();
                        MessageBox.Show("Error Code : PBP3005-2\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    #region BTip
                    {
                        if (ask == 0)
                        {
                            checkBox1.Checked = false;
                        }
                        else
                        {
                            checkBox1.Checked = true;
                            ask = 1;
                        }

                        if (command == "SD")
                        {
                            BTip = "Shutdown";
                        }
                        else if (command == "R")
                        {
                            BTip = "Restart";
                        }
                        else if (command == "H")
                        {
                            BTip = "Hibernate";
                        }
                        else if (command == "SB")
                        {
                            BTip = "Standby";
                        }
                        else if (command == "lock")
                        {
                            BTip = "Lock";
                        }
                        else if (command == "LO")
                        {
                            BTip = "Log Off";
                        }
                        else if (command == "SO")
                        {
                            BTip = "Screen Off";
                        }
                        else
                        {
                            notifyIcon1.Dispose();
                            MessageBox.Show("Error Code : PBP3005-3\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }

                    #endregion

                }
                #endregion

                #region Timer Start
                {
                    #region CT
                    if (type == "CT")
                    {
                        typelbl.Text = "Countdown Trigger";
                        datelbl.Hide();
                        label8.Hide();
                        if (CT <= 7)
                        {
                            CT = CT * 60;
                            H = CT / 60;
                            M = CT - H * 60;
                            timeLbl = "Less than " + H.ToString() + " minute(s) ";
                            timer2.Enabled = true;
                            timer2_Tick(null, new EventArgs());
                            this.notifyIcon1.ShowBalloonTip(8, "Power Background Process Started", BTip + " command has been succesfully issued.\nLess than " + timeLbl + " remaining to " + BTip, ToolTipIcon.Info);
                        }
                        else
                        {
                            H = CT / 60;
                            M = CT - H * 60;
                            timeLbl = "Less than " + H.ToString() + " hour(s) " + M.ToString() + " minute(s)";
                            timer1.Enabled = true;
                            timer1_Tick(null, new EventArgs());
                            this.notifyIcon1.ShowBalloonTip(8, "Power Background Process Started", BTip + " command has been succesfully issued.\nLess than " + timeLbl + " remaining to " + BTip, ToolTipIcon.Info);
                        }
                        timelbl.Text = timeLbl + " remaining";
                    }
                    #endregion
                    #region ST
                    else
                    {
                        timelbl.Text = H.ToString() + " : " + M.ToString();
                        datelbl.Text = D.ToString() + " / " + MM.ToString() + " / " + YY.ToString();
                        typelbl.Text = "Specific Time";
                        timer3.Enabled = true;
                        timer3_Tick(null, new EventArgs());
                        this.notifyIcon1.ShowBalloonTip(8, "Power Background Process Started", BTip + " command has been succesfully issued.\n"+ H + ":" + M + " - " + D + "/" + MM + "/" + YY, ToolTipIcon.Info);
                        TimeCMS.Text = H + ":" + M + " - " + D + "/" + MM + "/" + YY;
                    }
                    #endregion

                    commandlbl.Text = BTip;
                    infoCMS.Text = BTip + " command running";
                }
                #endregion

            }
            else
            {
                notifyIcon1.Dispose();
                MessageBox.Show("The application is temporary unavailable or you have no authorized permission to access it.", "Application inaccessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void showCommandWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void aboutPowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Power Background Process\n\nVersion : 7. 15. 09. 26\nApplication Developer : Roshana Pitigala\n\n© RoshSoft Co.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (CT <= 7)
            {
                CT = CT * 60;
                timer2.Enabled = true;
                timer2.Start();
                timer1.Dispose();
            }
            else
            {
                CT--;
                H = CT / 60;
                M = CT - H * 60;
                timeLbl = H.ToString() + " hour(s) " + M.ToString() + "minute(s)";
                timelbl.Text = timeLbl + " remaining";
                TimeCMS.Text = timeLbl + " remaining";
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CT == 0)
            {
                if (!Directory.Exists(location))
                {
                    Directory.CreateDirectory(location);
                }

                timer2.Dispose();
                notifyIcon1.Dispose();
                File.WriteAllText(location + "power.dll", "NA");
                this.Hide();

                if (ask == 1)
                {
                    if (MessageBox.Show(BTip + " command is about to execute. Do you wish to proceed?", "PowerBP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (command == "SD")
                        {
                            check.StartInfo.Arguments = "/c shutdown -s -t 1";
                            check.Start();
                            Application.Exit();
                        }
                        else if (command == "R")
                        {
                            check.StartInfo.Arguments = "/c shutdown -r -t 1";
                            check.Start();
                            Application.Exit();
                        }
                        else if (command == "H")
                        {
                            check.StartInfo.Arguments = "/c shutdown -h";
                            check.Start();
                            Application.Exit();
                        }
                        else if (command == "SB")
                        {
                            Application.SetSuspendState(PowerState.Suspend, true, true);
                            Application.Exit();
                        }
                        else if (command == "lock")
                        {
                            check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                            check.Start();
                            Application.Exit();
                        }
                        else if (command == "LO")
                        {
                            check.StartInfo.Arguments = "/c shutdown -l";
                            check.Start();
                            Application.Exit();
                        }
                        else if (command == "SO")
                        {
                            SendMessage(this.Handle.ToInt32(), 0x0112, 0xF170, 2);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Error Code : PBP3005-1\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

                else
                {
                    if (command == "SD")
                    {
                        check.StartInfo.Arguments = "/c shutdown -s -t 1";
                        check.Start();
                        Application.Exit();
                    }
                    else if (command == "R")
                    {
                        check.StartInfo.Arguments = "/c shutdown -r -t 1";
                        check.Start();
                        Application.Exit();
                    }
                    else if (command == "H")
                    {
                        check.StartInfo.Arguments = "/c shutdown -h";
                        check.Start();
                        Application.Exit();
                    }
                    else if (command == "SB")
                    {
                        Application.SetSuspendState(PowerState.Suspend, true, true);
                        Application.Exit();
                    }
                    else if (command == "lock")
                    {
                        check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                        check.Start();
                        Application.Exit();
                    }
                    else if (command == "LO")
                    {
                        check.StartInfo.Arguments = "/c shutdown -l";
                        check.Start();
                        Application.Exit();
                    }
                    else if (command == "SO")
                    {
                        SendMessage(this.Handle.ToInt32(), 0x0112, 0xF170, 2);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Error Code : PBP3005-1\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            else
            {
                CT--;
                H = CT / 60;
                M = CT - H * 60;
                timeLbl = H.ToString() + " minute(s) " + M.ToString() + "second(s)";
                timelbl.Text = timeLbl + " remaining";
                TimeCMS.Text = timeLbl + " remaining";
                if (CT == 300)
                {
                    this.notifyIcon1.ShowBalloonTip(8, BTip + " command is about to execute", "You have Less than 5 minutes remaining. Save your work.", ToolTipIcon.Warning);
                }
                else if (CT == 60)
                {
                    this.notifyIcon1.ShowBalloonTip(8, BTip + " command is about to execute", "You have Less than a minute remaining. Save your work.", ToolTipIcon.Warning);
                }
                else if (CT == 30)
                {
                    if (command == "SD" || command == "R" || command == "LO")
                    {
                        this.notifyIcon1.ShowBalloonTip(8, "System is about to " + BTip, "You have Less than 30 seconds remaining. Any unsaved data will be lost.", ToolTipIcon.Warning);
                    }
                    else
                    {
                        this.notifyIcon1.ShowBalloonTip(8, BTip + " command is about to execute", "You have Less than 30 seconds remaining.", ToolTipIcon.Warning);
                    }
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ask = 1;
            }
            else
            {
                if (MessageBox.Show("Commands will be executed without your permission which may cause lost of any unsaved data. Use with your own risk. Do you wish to proceed?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ask = 0;
                }
                else
                {
                    checkBox1.Checked = true;
                    ask = 1;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (YY < DateTime.Now.Year)
            {
                this.notifyIcon1.ShowBalloonTip(8, "Command Expired", BTip + " command has expired.\nIssue another command using Power application.", ToolTipIcon.Error);
                MessageBox.Show(BTip + " command which was sheduled to " + H + ":" + M + " - " + D + "/" + MM + "/" + YY + " has expired. Application will now exit.", "Command Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                notifyIcon1.Dispose();
                Application.Exit();
            }
            else if (YY == DateTime.Now.Year)
            {
                if (MM < DateTime.Now.Month)
                {
                    this.notifyIcon1.ShowBalloonTip(8, "Command Expired", BTip + " command has expired.\nIssue another command using Power application.", ToolTipIcon.Error);
                    MessageBox.Show(BTip + " command which was sheduled to " + H + ":" + M + " - " + D + "/" + MM + "/" + YY + " has expired. Application will now exit.", "Command Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    notifyIcon1.Dispose();
                    Application.Exit();
                }
                else if (MM == DateTime.Now.Month)
                {
                    if (D < DateTime.Now.Day)
                    {
                        this.notifyIcon1.ShowBalloonTip(8, "Command Expired", BTip + " command has expired.\nIssue another command using Power application.", ToolTipIcon.Error);
                        MessageBox.Show(BTip + " command which was sheduled to " + H + ":" + M + " - " + D + "/" + MM + "/" + YY + " has expired. Application will now exit.", "Command Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        notifyIcon1.Dispose();
                        Application.Exit();
                    }

                    else if (D == DateTime.Now.Day)
                    {
                        if (H < DateTime.Now.Hour)
                        {
                            this.notifyIcon1.ShowBalloonTip(8, "Command Expired", BTip + " command has expired.\nIssue another command using Power application.", ToolTipIcon.Error);
                            MessageBox.Show(BTip + " command which was sheduled to " + H + ":" + M + " - " + D + "/" + MM + "/" + YY + " has expired. Application will now exit.", "Command Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            notifyIcon1.Dispose();
                            Application.Exit();
                        }
                        else if (H == DateTime.Now.Hour)
                        {
                            if (M < DateTime.Now.Minute)
                            {
                                this.notifyIcon1.ShowBalloonTip(8, "Command Expired", BTip + " command has expired.\nIssue another command using Power application.", ToolTipIcon.Error);
                                MessageBox.Show(BTip + " command which was sheduled to " + H + ":" + M + " - " + D + "/" + MM + "/" + YY + " has expired. Application will now exit.", "Command Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                notifyIcon1.Dispose();
                                Application.Exit();
                            }
                            else if (M > DateTime.Now.Minute)
                            {
                                int tempST = M - DateTime.Now.Minute;
                                if (tempST == 5)
                                {
                                    this.notifyIcon1.ShowBalloonTip(8, BTip + " command is about to execute", "You have Less than 5 minutes remaining. Save your work.", ToolTipIcon.Warning);
                                }
                                else if (tempST == 1)
                                {
                                    this.notifyIcon1.ShowBalloonTip(8, BTip + " command is about to execute", "You have Less than a minute remaining. Save your work. No more Popup messages will be displayed.", ToolTipIcon.Warning);
                                }
                            }
                            else if (M == DateTime.Now.Minute)
                            {
                                if (!Directory.Exists(location))
                                {
                                    Directory.CreateDirectory(location);
                                }
                                timer3.Dispose();
                                notifyIcon1.Dispose();
                                File.WriteAllText(location + "power.dll", "NA");
                                this.Hide();

                                if (ask == 1)
                                {
                                    if (MessageBox.Show(BTip + " command is about to execute. Do you wish to proceed?", "PowerBP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        if (command == "SD")
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -s -t 1";
                                            check.Start();
                                            Application.Exit();
                                        }
                                        else if (command == "R")
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -r -t 1";
                                            check.Start();
                                            Application.Exit();
                                        }
                                        else if (command == "H")
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -h";
                                            check.Start();
                                            Application.Exit();
                                        }
                                        else if (command == "SB")
                                        {
                                            Application.SetSuspendState(PowerState.Suspend, true, true);
                                            Application.Exit();
                                        }
                                        else if (command == "lock")
                                        {
                                            check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                                            check.Start();
                                            Application.Exit();
                                        }
                                        else if (command == "LO")
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -l";
                                            check.Start();
                                            Application.Exit();
                                        }
                                        else if (command == "SO")
                                        {
                                            SendMessage(this.Handle.ToInt32(), 0x0112, 0xF170, 2);
                                            Application.Exit();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error Code : PBP3005-1\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            Application.Exit();
                                        }
                                    }
                                    else
                                    {
                                        Application.Exit();
                                    }
                                }

                                else
                                {
                                    if (command == "SD")
                                    {
                                        check.StartInfo.Arguments = "/c shutdown -s -t 1";
                                        check.Start();
                                        Application.Exit();
                                    }
                                    else if (command == "R")
                                    {
                                        check.StartInfo.Arguments = "/c shutdown -r -t 1";
                                        check.Start();
                                        Application.Exit();
                                    }
                                    else if (command == "H")
                                    {
                                        check.StartInfo.Arguments = "/c shutdown -h";
                                        check.Start();
                                        Application.Exit();
                                    }
                                    else if (command == "SB")
                                    {
                                        Application.SetSuspendState(PowerState.Suspend, true, true);
                                        Application.Exit();
                                    }
                                    else if (command == "lock")
                                    {
                                        check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                                        check.Start();
                                        Application.Exit();
                                    }
                                    else if (command == "LO")
                                    {
                                        check.StartInfo.Arguments = "/c shutdown -l";
                                        check.Start();
                                        Application.Exit();
                                    }
                                    else if (command == "SO")
                                    {
                                        SendMessage(this.Handle.ToInt32(), 0x0112, 0xF170, 2);
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Code : PBP3005-1\n\nAn unhandled exception has occurred application will now exit.\nPlease report the error code to RoshSoft Co. Sorry for the inconvenience caused.", "PowerBP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        Application.Exit();
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to abort issued " + BTip +" command and Exit?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                notifyIcon1.Dispose();
                Application.Exit();
            }
        }

    }
}
        


