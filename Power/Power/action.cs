using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Power.Properties;
using System.Runtime.InteropServices;
using System.Media;
using System.Security.Principal;

namespace Power
{
    public partial class action : Form
    {
        public action(string a)
        {
            InitializeComponent();
            type = a;
        }

        bool admin = home.admin;
        Process check = new Process();
        string type = "NA";
        string command;
        int h;
        int m;
        int s;
        int ask = 0;
        string location = Program.location;

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToShortTimeString();
            if (YYnud.Value == DateTime.Now.Year)
            {
                MMnud.Minimum = DateTime.Now.Month;
                if (MMnud.Value == DateTime.Now.Month)
                {
                    DDnud.Minimum = DateTime.Now.Day;
                    if (DDnud.Value == DateTime.Now.Day)
                    {
                        Hnud.Minimum = DateTime.Now.Hour;
                        if (Hnud.Value == DateTime.Now.Hour)
                        {
                            Mnud.Minimum = DateTime.Now.Minute;
                        }
                        else
                        {
                            Mnud.Minimum = 0;
                        }
                    }
                    else
                    {
                        Hnud.Minimum = 0;
                        Mnud.Minimum = 0;
                    }
                }
                else
                {
                    DDnud.Minimum = 1;
                    Hnud.Minimum = 0;
                    Mnud.Minimum = 0;
                }
            }
            else
            {
                MMnud.Minimum = 1;
                DDnud.Minimum = 1;
                Hnud.Minimum = 0;
                Mnud.Minimum = 0;
            }
        }

        private void action_Shown(object sender, EventArgs e)
        {
            if (admin)
            {
                this.Text = "Power - Action Panel : [Administrator]";
            }
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToShortTimeString();
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }
        }

        private void action_Load(object sender, EventArgs e)
        {
            #region Tool Tips
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(this.ico, "Help - Information Panel");

            ToolTip tip2 = new ToolTip();
            tip2.SetToolTip(this.comboBox1, "Select a Command to issue");

            ToolTip tip3 = new ToolTip();
            tip3.SetToolTip(this.radioButton1, "Method 1 : Specific Time");

            ToolTip tip4 = new ToolTip();
            tip4.SetToolTip(this.radioButton2, "Method 2 : Countdown Trigger");

            #endregion


            check.StartInfo.FileName = "cmd.exe";
            check.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            YYnud.Minimum = DateTime.Now.Year;
            YYnud.Maximum = DateTime.Now.Year + 2;
            MMnud.Value = DateTime.Now.Month;
            DDnud.Value = DateTime.Now.Day;
            Hnud.Value = DateTime.Now.Hour;
            Mnud.Value = DateTime.Now.Minute;
            if (YYnud.Value == DateTime.Now.Year)
            {
                MMnud.Minimum = DateTime.Now.Month;
                if (MMnud.Value == DateTime.Now.Month)
                {
                    DDnud.Minimum = DateTime.Now.Day;
                    if (DDnud.Value == DateTime.Now.Day)
                    {
                        Hnud.Minimum = DateTime.Now.Hour;
                        if (Hnud.Value == DateTime.Now.Hour)
                        {
                            Mnud.Minimum = DateTime.Now.Minute;
                        }
                        else
                        {
                            Mnud.Minimum = 0;
                        }
                    }
                    else
                    {
                        Hnud.Minimum = 0;
                        Mnud.Minimum = 0;
                    }
                }
                else
                {
                    DDnud.Minimum = 1;
                    Hnud.Minimum = 0;
                    Mnud.Minimum = 0;
                }
            }
            else
            {
                MMnud.Minimum = 1;
                DDnud.Minimum = 1;
                Hnud.Minimum = 0;
                Mnud.Minimum = 0;
            }

            if (type == "SD")
            {
                command = "Shutdown";
            }
            else if (type == "R")
            {
                command = "Restart";
            }
            else if (type == "H")
            {
                command = "Hibernate";
            }
            else if (type == "SB")
            {
                command = "Standby";
            }
            else if (type == "lock")
            {
                command = "Lock";
            }
            else if (type == "LO")
            {
                command = "Log Off";
            }
            else if (type == "SO")
            {
                command = "Screen Off";
            }
            else
            {
                command = "-Select Command-";
            }
            comboBox1.Text = command;
            if (type == "SD" || type == "R" || type == "LO")
            {
                ask = 1;
                checkBox1.Checked = true;
            }

            if (Properties.Settings.Default.action == true)
            {
                radioButton1.Checked = true;
            }

            else
            {
                radioButton2.Checked = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label7.Enabled = false;

                Hnud.Enabled = true;
                Mnud.Enabled = true;
                DDnud.Enabled = true;
                MMnud.Enabled = true;
                YYnud.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label6.Enabled = true;
                label8.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                label12.Enabled = true;
                label13.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label7.Enabled = true;

                Hnud.Enabled = false;
                Mnud.Enabled = false;
                DDnud.Enabled = false;
                MMnud.Enabled = false;
                YYnud.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label6.Enabled = false;
                label8.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            if (checkBox1.Checked)
                ask = 1;
            else
                ask = 0;

            #region CT
            if (radioButton2.Checked == true)
            {
                if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0)
                {
                    if (type == "SD")
                    {
                        if (MessageBox.Show("Are you sure you want to Shutdown the computer now? Any unsaved data will be lost.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            check.StartInfo.Arguments = "/c shutdown -s -t1";
                            check.Start();
                            Application.Exit();
                        }
                    }
                    else if (type == "R")
                    {
                        if (MessageBox.Show("Are you sure you want to Restart the computer now? Any unsaved data will be lost.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            check.StartInfo.Arguments = "/c shutdown -r -t1";
                            check.Start();
                            Application.Exit();
                        }
                    }
                    else if (type == "H")
                    {
                        if (MessageBox.Show("Are you sure you want to Hibernate the computer now?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            check.StartInfo.Arguments = "/c shutdown -h";
                            check.Start();
                            Application.Exit();
                        }
                    }
                    else if (type == "SB")
                    {
                        if (MessageBox.Show("Are you sure you want to put your computer to Standby now?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Application.SetSuspendState(PowerState.Suspend, true, true);
                            Application.Exit();
                        }
                    }
                    else if (type == "lock")
                    {
                        if (MessageBox.Show("Are you sure you want to lock your profile now?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                            check.Start();
                            Application.Exit();
                        }
                    }
                    else if (type == "LO")
                    {
                        if (MessageBox.Show("Are you sure you want to Log Off now? Any unsaved data will be lost.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            check.StartInfo.Arguments = "/c shutdown -l";
                            check.Start();
                            Application.Exit();
                        }
                    }
                    else if (type == "SO")
                    {
                        if (Application.OpenForms["MB"] == null)
                        {
                            new MB("Choose an action", true, "What is the action you wish to proceed?", "Screen Server", "Screen Off").Show();
                        }
                        else
                        {
                            Application.OpenForms["MB"].Focus();
                            SystemSounds.Beep.Play();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an command from the Dropdown.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (type == "NA")
                    {
                        MessageBox.Show("Please select an command from the Dropdown given.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        h = Convert.ToInt32(numericUpDown1.Value) * 60;
                        m = Convert.ToInt32(numericUpDown2.Value);
                        s = h + m;

                        if (!File.Exists("PowerBP.exe"))
                        {
                            MessageBox.Show("Failed to issue the command due to a failure in the Power Background Process. Try reinstalling the application.", "PowerBP Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.WriteAllText(location + "power.dll", "CT\r\n" + type + "\r\n" + s.ToString() + "\r\n" + ask.ToString());
                            try
                            {
                                Process.Start(@"PowerBP.exe");
                                Application.Exit();
                            }
                            catch
                            {
                                MessageBox.Show("Failed to start Power Background Process. Please try again.", "PowerBP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }

                    }
                }
            }
            #endregion
            #region ST
            else
            {
                if (YYnud.Value == DateTime.Now.Year)
                {
                    if (MMnud.Value == DateTime.Now.Month)
                    {
                        if (DDnud.Value == DateTime.Now.Day)
                        {
                            if (Hnud.Value == DateTime.Now.Hour)
                            {
                                if (Mnud.Value == DateTime.Now.Minute)
                                {
                                    if (type == "SD")
                                    {
                                        if (MessageBox.Show("Are you sure you want to Shutdown the computer now? Any unsaved data will be lost.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -s -t1";
                                            check.Start();
                                            Application.Exit();
                                        }
                                    }
                                    else if (type == "R")
                                    {
                                        if (MessageBox.Show("Are you sure you want to Restart the computer now? Any unsaved data will be lost.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -r -t1";
                                            check.Start();
                                            Application.Exit();
                                        }
                                    }
                                    else if (type == "H")
                                    {
                                        if (MessageBox.Show("Are you sure you want to Hibernate the computer now?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -h";
                                            check.Start();
                                            Application.Exit();
                                        }
                                    }
                                    else if (type == "SB")
                                    {
                                        if (MessageBox.Show("Are you sure you want to put your computer to Standby now?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            Application.SetSuspendState(PowerState.Suspend, true, true);
                                            Application.Exit();
                                        }
                                    }
                                    else if (type == "lock")
                                    {
                                        if (MessageBox.Show("Are you sure you want to lock your profile now?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            check.StartInfo.Arguments = "/c rundll32.exe user32.dll, LockWorkStation";
                                            check.Start();
                                            Application.Exit();
                                        }
                                    }
                                    else if (type == "LO")
                                    {
                                        if (MessageBox.Show("Are you sure you want to Log Off now? Any unsaved data will be lost.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            check.StartInfo.Arguments = "/c shutdown -l";
                                            check.Start();
                                            Application.Exit();
                                        }
                                    }
                                    else if (type == "SO")
                                    {
                                        if (Application.OpenForms["MB"] == null)
                                        {
                                            new MB("Choose an action", true, "What is the action you wish to proceed?", "Screen Server", "Screen Off").Show();
                                        }
                                        else
                                        {
                                            Application.OpenForms["MB"].Focus();
                                            SystemSounds.Beep.Play();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please select an command from the Dropdown.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (type == "NA")
                                    {
                                        MessageBox.Show("Please select an command from the Dropdown given.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {

                                        if (!File.Exists("PowerBP.exe"))
                                        {
                                            MessageBox.Show("Failed to issue the command due to a failure in the Power Background Process. Try reinstalling the application.", "PowerBP Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            File.WriteAllText(location + "power.dll", "ST\r\n" + type + "\r\n" + Hnud.Value.ToString() + "\r\n" + Mnud.Value.ToString() + "\r\n" + DDnud.Value.ToString() + "\r\n" + MMnud.Value.ToString() + "\r\n" + YYnud.Value.ToString() + "\r\n" + ask.ToString());
                                            if (!File.Exists("PowerBP.exe"))
                                            {
                                                MessageBox.Show("Failed to issue the command due to a failure in the Power Background Process. Try reinstalling the application.", "PowerBP Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    Process.Start(@"PowerBP.exe");
                                                    Application.Exit();
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("Failed to start Power Background Process. Please try again.", "PowerBP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    this.Close();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (type == "NA")
                                {
                                    MessageBox.Show("Please select an command from the Dropdown given.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {

                                    if (!File.Exists("PowerBP.exe"))
                                    {
                                        MessageBox.Show("Failed to issue the command due to a failure in the Power Background Process. Try reinstalling the application.", "PowerBP Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        File.WriteAllText(location + "power.dll", "ST\r\n" + type + "\r\n" + Hnud.Value.ToString() + "\r\n" + Mnud.Value.ToString() + "\r\n" + DDnud.Value.ToString() + "\r\n" + MMnud.Value.ToString() + "\r\n" + YYnud.Value.ToString() + "\r\n" + ask.ToString());
                                        Process.Start(@"PowerBP.exe");
                                        Application.Exit();
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (type == "NA")
                            {
                                MessageBox.Show("Please select an command from the Dropdown given.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (!File.Exists("PowerBP.exe"))
                                {
                                    MessageBox.Show("Failed to issue the command due to a failure in the Power Background Process. Try reinstalling the application.", "PowerBP Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    File.WriteAllText(location + "power.dll", "ST\r\n" + type + "\r\n" + Hnud.Value.ToString() + "\r\n" + Mnud.Value.ToString() + "\r\n" + DDnud.Value.ToString() + "\r\n" + MMnud.Value.ToString() + "\r\n" + YYnud.Value.ToString() + "\r\n" + ask.ToString());
                                    Process.Start(@"PowerBP.exe");
                                    Application.Exit();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (type == "NA")
                        {
                            MessageBox.Show("Please select an command from the Dropdown given.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (!File.Exists("PowerBP.exe"))
                            {
                                MessageBox.Show("Failed to issue the command due to a failure in the Power Background Process. Try reinstalling the application.", "PowerBP Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                File.WriteAllText(location + "power.dll", "ST\r\n" + type + "\r\n" + Hnud.Value.ToString() + "\r\n" + Mnud.Value.ToString() + "\r\n" + DDnud.Value.ToString() + "\r\n" + MMnud.Value.ToString() + "\r\n" + YYnud.Value.ToString() + "\r\n" + ask.ToString());
                                Process.Start(@"PowerBP.exe");
                                Application.Exit();
                            }
                        }
                    }
                }

                else
                {
                    if (type == "NA")
                    {
                        MessageBox.Show("Please select an command from the Dropdown given.", "Select Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!File.Exists("PowerBP.exe"))
                        {
                            MessageBox.Show("Failed to issue the command due to a failure in the Power Background Process. Try reinstalling the application.", "PowerBP Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.WriteAllText(location + "power.dll", "ST\r\n" + type + "\r\n" + Hnud.Value.ToString() + "\r\n" + Mnud.Value.ToString() + "\r\n" + DDnud.Value.ToString() + "\r\n" + MMnud.Value.ToString() + "\r\n" + YYnud.Value.ToString() + "\r\n" + ask.ToString());
                            Process.Start(@"PowerBP.exe");
                            Application.Exit();
                        }
                    }
                }
            }
            #endregion
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Shutdown")
            {
                type = "SD";
            }
            else if (comboBox1.Text == "Restart")
            {
                type = "R";
            }
            else if (comboBox1.Text == "Hibernate")
            {
                type = "H";
            }
            else if (comboBox1.Text == "Standby")
            {
                type = "SB";
            }
            else if (comboBox1.Text == "Lock")
            {
                type = "lock";
            }
            else if (comboBox1.Text == "Log Off")
            {
                type = "LO";
            }
            else if (comboBox1.Text == "Screen Off")
            {
                type = "SO";
            }
            else
            {
                type = "NA";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && (type == "SD" || type == "R" || type == "LO"))
            {
                if (MessageBox.Show("Commands will be executed without giving you a final warning which may cause lost of any unsaved data. Do you wish to proceed?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ask = 0;
                }
                else
                {
                    checkBox1.Checked = true;
                    ask = 1;
                }
            }
            else
            {
                ask = 1;
            }
        }

        private void MMnud_ValueChanged(object sender, EventArgs e)
        {
            if (YYnud.Value == DateTime.Now.Year)
            {
                MMnud.Minimum = DateTime.Now.Month;
                if (MMnud.Value == DateTime.Now.Month)
                {
                    DDnud.Minimum = DateTime.Now.Day;
                    if (DDnud.Value == DateTime.Now.Day)
                    {
                        Hnud.Minimum = DateTime.Now.Hour;
                        if (Hnud.Value == DateTime.Now.Hour)
                        {
                            Mnud.Minimum = DateTime.Now.Minute;
                        }
                        else
                        {
                            Mnud.Minimum = 0;
                        }
                    }
                    else
                    {
                        Hnud.Minimum = 0;
                        Mnud.Minimum = 0;
                    }
                }
                else
                {
                    DDnud.Minimum = 1;
                    Hnud.Minimum = 0;
                    Mnud.Minimum = 0;
                }
            }
            else
            {
                MMnud.Minimum = 1;
                DDnud.Minimum = 1;
                Hnud.Minimum = 0;
                Mnud.Minimum = 0;
            }

            if (MMnud.Value == 1 || MMnud.Value == 3 || MMnud.Value == 5 || MMnud.Value == 7 || MMnud.Value == 8 || MMnud.Value == 10 || MMnud.Value == 12)
            {
                DDnud.Maximum = 31;
            }
            else if (MMnud.Value == 2)
            {
                DDnud.Maximum = 28;
            }
            else
            {
                DDnud.Maximum = 30;
            }
        }

        private void YYnud_ValueChanged(object sender, EventArgs e)
        {
            if (YYnud.Value == DateTime.Now.Year)
            {
                MMnud.Minimum = DateTime.Now.Month;
                if (MMnud.Value == DateTime.Now.Month)
                {
                    DDnud.Minimum = DateTime.Now.Day;
                    if (DDnud.Value == DateTime.Now.Day)
                    {
                        Hnud.Minimum = DateTime.Now.Hour;
                        if (Hnud.Value == DateTime.Now.Hour)
                        {
                            Mnud.Minimum = DateTime.Now.Minute;
                        }
                        else
                        {
                            Mnud.Minimum = 0;
                        }
                    }
                    else
                    {
                        Hnud.Minimum = 0;
                        Mnud.Minimum = 0;
                    }
                }
                else
                {
                    DDnud.Minimum = 1;
                    Hnud.Minimum = 0;
                    Mnud.Minimum = 0;
                }
            }
            else
            {
                MMnud.Minimum = 1;
                DDnud.Minimum = 1;
                Hnud.Minimum = 0;
                Mnud.Minimum = 0;
            }
        }

        private void DDnud_ValueChanged(object sender, EventArgs e)
        {
            if (YYnud.Value == DateTime.Now.Year)
            {
                MMnud.Minimum = DateTime.Now.Month;
                if (MMnud.Value == DateTime.Now.Month)
                {
                    DDnud.Minimum = DateTime.Now.Day;
                    if (DDnud.Value == DateTime.Now.Day)
                    {
                        Hnud.Minimum = DateTime.Now.Hour;
                        if (Hnud.Value == DateTime.Now.Hour)
                        {
                            Mnud.Minimum = DateTime.Now.Minute;
                        }
                        else
                        {
                            Mnud.Minimum = 0;
                        }
                    }
                    else
                    {
                        Hnud.Minimum = 0;
                        Mnud.Minimum = 0;
                    }
                }
                else
                {
                    DDnud.Minimum = 1;
                    Hnud.Minimum = 0;
                    Mnud.Minimum = 0;
                }
            }
            else
            {
                MMnud.Minimum = 1;
                DDnud.Minimum = 1;
                Hnud.Minimum = 0;
                Mnud.Minimum = 0;
            }
        }

        private void Hnud_ValueChanged(object sender, EventArgs e)
        {
            if (YYnud.Value == DateTime.Now.Year)
            {
                MMnud.Minimum = DateTime.Now.Month;
                if (MMnud.Value == DateTime.Now.Month)
                {
                    DDnud.Minimum = DateTime.Now.Day;
                    if (DDnud.Value == DateTime.Now.Day)
                    {
                        Hnud.Minimum = DateTime.Now.Hour;
                        if (Hnud.Value == DateTime.Now.Hour)
                        {
                            Mnud.Minimum = DateTime.Now.Minute;
                        }
                        else
                        {
                            Mnud.Minimum = 0;
                        }
                    }
                    else
                    {
                        Hnud.Minimum = 0;
                        Mnud.Minimum = 0;
                    }
                }
                else
                {
                    DDnud.Minimum = 1;
                    Hnud.Minimum = 0;
                    Mnud.Minimum = 0;
                }
            }
            else
            {
                MMnud.Minimum = 1;
                DDnud.Minimum = 1;
                Hnud.Minimum = 0;
                Mnud.Minimum = 0;
            }
        }

        private void ico_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Info"] == null)
            {
                new Info(3).Show();
            }
            else
            {
                Application.OpenForms["Info"].Close();
                new Info(3).Show();
            }

        }

    }
}
