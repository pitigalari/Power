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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string x = "01";
        //int a;
        //int b;
        //int c;
        //int d;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Power\n\nVersion : 6. 08. 07. 14\nApplication Developer : Roshana Pitigala\n\nComputer Society of Nalanda College\nCopyright ©  2014", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("You are going to cancel all the commands that you have given. Do you want to proceed?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (label1.Text == "free")
                {
                    Process.Start("shutdown", "-a");
                    System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /IM Power.exe");
                    MessageBox.Show("We will try our best to abort all the commands that you issued before.", "Command has been aborted.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                else
                {
                    Process.Start("shutdown", "-a");
                    System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /IM Power.exe");
                    MessageBox.Show("All system shutdown commands has been cancelled.", "Command has been aborted.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            if (numericUpDown1.Value == 24)
            {
                numericUpDown2.Maximum = 0;
            }
            else
            {
                numericUpDown2.Maximum = 59;
                a = int.Parse(numericUpDown1.Value.ToString());
                b = int.Parse(numericUpDown2.Value.ToString());
                c = a * 3600;
                d = b * 60;
                x = (c + d).ToString();
            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            a = int.Parse(numericUpDown1.Value.ToString());
            b = int.Parse(numericUpDown2.Value.ToString());
            c = a * 3600;
            d = b * 60;
            x = (c + d).ToString();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Standby")
            {
                label5.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                label4.Enabled = true;
                label2.Enabled = true;
                checkBox1.Enabled = false;
            }
            else if (comboBox1.Text == "Logoff")
            {
                label5.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                label4.Enabled = true;
                label2.Enabled = true;
                checkBox1.Enabled = true;
            }
            else if (comboBox1.Text == "Hibernate")
            {
                label5.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                label4.Enabled = true;
                label2.Enabled = true;
                checkBox1.Enabled = true;
            }
            else if (comboBox1.Text == "Lock")
            {
                label5.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                label4.Enabled = true;
                label2.Enabled = true;
                checkBox1.Enabled = false;
            }
            else
            {
                label5.Enabled = true;
                numericUpDown1.Enabled = true;
                label4.Enabled = true;
                numericUpDown2.Enabled = true;
                label2.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Shutdown")
            {

                if (checkBox1.Checked)
                {
                    if (x == "0" | x == "00")
                    {
                        Process.Start("shutdown", "-f -s -t 01");
                        //MessageBox.Show("System Shutdown command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        Process.Start("shutdown", "-f -s -t " + x);
                        MessageBox.Show("System Shutdown command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
                else
                {
                    if (x == "0" | x == "00")
                    {
                        Process.Start("shutdown", "-s -t 01");
                        //MessageBox.Show("System Shutdown command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        Process.Start("shutdown", "-s -t " + x);
                        MessageBox.Show("System Shutdown command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }

            }
            else if (comboBox1.Text == "Restart")
            {
                if (checkBox1.Checked)
                {
                    if (x == "0" | x == "00")
                    {
                        Process.Start("shutdown", "-f -r -t 01");
                        //MessageBox.Show("System Restart command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        Process.Start("shutdown", "-f -r -t " + x);
                        MessageBox.Show("System Restart command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
                else
                {
                    if (x == "0" | x == "00")
                    {
                        Process.Start("shutdown", "-r -t 01");
                        //MessageBox.Show("System Restart command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        Process.Start("shutdown", "-r -t " + x);
                        MessageBox.Show("System Restart command has been issued.", "Command Isuued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }

            }
            else if (comboBox1.Text == "Hibernate")
            {
                if (x == "0" | x == "00" | x == "01")
                {
                    if (checkBox1.Checked)
                    {
                        Process.Start("shutdown", "-f -h");
                        Application.Exit();
                    }
                    else
                    {
                        Process.Start("shutdown", "-h");
                        Application.Exit();
                    }
                }
                else
                {
                    Properties.Settings.Default.action = "Hibernate";
                    Properties.Settings.Default.time = x;
                    Properties.Settings.Default.Save();
                    new Timer().Show();
                    this.Close();
                }
            }
            else if (comboBox1.Text == "Logoff")
            {
                if (x == "0" | x == "00" | x == "01")
                {
                    if (checkBox1.Checked)
                    {
                        Process.Start("shutdown", "-f -l");
                        Application.Exit();
                    }
                    else
                    {
                        Process.Start("shutdown", "-l");
                        Application.Exit();
                    }
                }
                else
                {
                    Properties.Settings.Default.action = "Logoff";
                    Properties.Settings.Default.time = x;
                    Properties.Settings.Default.Save();
                    new Timer().Show();
                    this.Close();
                }
            }
            else if (comboBox1.Text == "Standby")
            {
                if (x == "0" | x == "00" | x == "01")
                {
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    Application.Exit();
                }
                else
                {
                    Properties.Settings.Default.action = "Standby";
                    Properties.Settings.Default.time = x;
                    Properties.Settings.Default.Save();
                    new Timer().Show();
                    this.Close();
                }
            }
            else if (comboBox1.Text == "Lock")
            {
                if (x == "0" | x == "00" | x == "01")
                {
                    Process.Start("cmd.exe", "/c rundll32.exe user32.dll, LockWorkStation");
                    Application.Exit();
                }
                else
                {
                    Properties.Settings.Default.action = "Lock";
                    Properties.Settings.Default.time = x;
                    Properties.Settings.Default.Save();
                    new Timer().Show();
                    this.Close();
                }

            }
            else
            {
                comboBox1.Text = "-Select Option-";
                MessageBox.Show("Please select an option form the dropdown given.", "Select option to proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Power\n\nVersion : 6. 29. 05. 14\nApplication Developer : Roshana Pitigala\n\nCopyright ©  2014", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "free")
            {

                MessageBox.Show("This Facility is available only in the Full Version", "Facility Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                checkBox1.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = Properties.Settings.Default.defalut;
            if (label6.Text == "U")
            {
                comboBox1.Text = "Shutdown";
            }
            else if (label6.Text == "R")
            {
                comboBox1.Text = "Restart";
            }
            else if (label6.Text == "L")
            {
                comboBox1.Text = "Logoff";
            }
            else if (label6.Text == "O")
            {
                comboBox1.Text = "Lock";
            }
            else if (label6.Text == "S")
            {
                comboBox1.Text = "Standby";
            }
            else if (label6.Text == "H")
            {
                comboBox1.Text = "Hibernate";
            }
            else
            {
                comboBox1.Text = "-Select Option-";
            }

        }

        private void setDefualtActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DefalutAction().Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Using this software you can set your computer to\nShutdown, Restart, Logoff, Hibernate, Standby or to Lock\nin an appropriate time.\nYou can also Force the Computer to proceed the actions.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void shortcutKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alt + U:-\nSelect the option Shutdown.\n\nAlt +R:-\nSelect the option Restart.\n\nAlt + L:-\nSelect the option Logoff.\n\nAlt + S:-\nSet the Computer to Standby immediately.\n\nAlt + O:-\nLock the User profile immediately.\n\nAlt + H:-\nSelect the option Hibernate.", "Help - Shortcut Keys", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Shutdown";
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Restart";
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Logoff";
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c rundll32.exe user32.dll, LockWorkStation");
            Application.Exit();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
            Application.Exit();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Hibernate";
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Power\n\nVersion : 6. 08. 07. 14\nApplication Developer : Roshana Pitigala\n\nCopyright ©  2014", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

