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
using Power.Properties;
using System.Runtime.InteropServices;
using System.Media;

namespace Power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Process check = new Process();
        int x = 0;
        int y = 0;
        string type;
        string location;
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RoshSoft\\");
            check.StartInfo.FileName = "cmd.exe";
            check.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            #region Tool Tips
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(this.SD, "Shutdown");
            tip1.SetToolTip(this.SDl, "Shutdown");

            ToolTip tip2 = new ToolTip();
            tip2.SetToolTip(this.R, "Restart");
            tip2.SetToolTip(this.Rl, "Restart");

            ToolTip tip3 = new ToolTip();
            tip3.SetToolTip(this.H, "Hibernate");
            tip3.SetToolTip(this.Hl, "Hibernate");

            ToolTip tip4 = new ToolTip();
            tip4.SetToolTip(this.SB, "Standby");
            tip4.SetToolTip(this.SBl, "Standby");

            ToolTip tip5 = new ToolTip();
            tip5.SetToolTip(this.L, "Lock");
            tip5.SetToolTip(this.Ll, "Lock");

            ToolTip tip6 = new ToolTip();
            tip6.SetToolTip(this.LO, "Log Off");
            tip6.SetToolTip(this.LOl, "Log Off");

            ToolTip tip7 = new ToolTip();
            tip7.SetToolTip(this.SO, "Screen Off");
            tip7.SetToolTip(this.SOl, "Screen Off");

            ToolTip tip8 = new ToolTip();
            tip8.SetToolTip(this.date, "Date");

            ToolTip tip9 = new ToolTip();
            tip9.SetToolTip(this.time, "Time");

            ToolTip tip10 = new ToolTip();
            tip10.SetToolTip(this.label1, "Visit Official Website of RoshSoft Co.");

            ToolTip tip11 = new ToolTip();
            tip11.SetToolTip(this.label2, "About");
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            if (Properties.Settings.Default.always == true)
            {
                new Info(1).Show();
            }
            else if (Properties.Settings.Default.first == true)
            {
                new Info(1).Show();
            }
            Properties.Settings.Default.first = false;
            Properties.Settings.Default.Save();
            
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Power\n\nVersion : 7. 15. 09. 26\nApplication Developer : Roshana Pitigala\n\n© RoshSoft Co.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region icon change
        private void H_MouseLeave(object sender, EventArgs e)
        {
            H.BackgroundImage = Resources.Hn;
        }

        private void H_MouseEnter(object sender, EventArgs e)
        {
            H.BackgroundImage = Resources.Hn1;
        }

        private void SD_MouseEnter(object sender, EventArgs e)
        {
            SD.BackgroundImage = Resources.S1;
        }

        private void SD_MouseLeave(object sender, EventArgs e)
        {
            SD.BackgroundImage = Resources.S;
        }

        private void R_MouseEnter(object sender, EventArgs e)
        {
            R.BackgroundImage = Resources.R1;
        }

        private void R_MouseLeave(object sender, EventArgs e)
        {
            R.BackgroundImage = Resources.R;
        }

        private void SB_MouseEnter(object sender, EventArgs e)
        {
            SB.BackgroundImage = Resources.SB1;
        }

        private void SB_MouseLeave(object sender, EventArgs e)
        {
            SB.BackgroundImage = Resources.SB;
        }

        private void L_MouseEnter(object sender, EventArgs e)
        {
            L.BackgroundImage = Resources.L1;
        }

        private void L_MouseLeave(object sender, EventArgs e)
        {
            L.BackgroundImage = Resources.L;
        }

        private void LO_MouseEnter(object sender, EventArgs e)
        {
            LO.BackgroundImage = Resources.LO1;
        }

        private void LO_MouseLeave(object sender, EventArgs e)
        {
            LO.BackgroundImage = Resources.LO;
        }

        private void SO_MouseEnter(object sender, EventArgs e)
        {
            SO.BackgroundImage = Resources.SO1;
        }

        private void SO_MouseLeave(object sender, EventArgs e)
        {
            SO.BackgroundImage = Resources.SO;
        }
        #endregion

        private void L_MouseDown(object sender, MouseEventArgs e)
        {
            y = 0;
            x = 0;
            timer2.Enabled = true;
            type = "lock";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x++;
            y = x;
            if (y >= Properties.Settings.Default.hold)
            {
                timer2.Enabled = false;
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
            }
        }

        private void L_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Enabled = false;
            if (y < Properties.Settings.Default.hold)
            {
                if (Application.OpenForms["action"] == null)
                {
                    new action(type).Show();
                }
                else
                {
                    Application.OpenForms["action"].Focus();
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void SD_MouseDown(object sender, MouseEventArgs e)
        {
            y = 0;
            x = 0;
            timer2.Enabled = true;
            type = "SD";
        }

        private void R_MouseDown(object sender, MouseEventArgs e)
        {
            y = 0;
            x = 0;
            timer2.Enabled = true;
            type = "R";
        }

        private void Hl_MouseDown(object sender, MouseEventArgs e)
        {
            y = 0;
            x = 0;
            timer2.Enabled = true;
            type = "H";
        }

        private void SBl_MouseDown(object sender, MouseEventArgs e)
        {
            y = 0;
            x = 0;
            timer2.Enabled = true;
            type = "SB";
        }

        private void LO_MouseDown(object sender, MouseEventArgs e)
        {
            y = 0;
            x = 0;
            timer2.Enabled = true;
            type = "LO";
        }

        private void SO_MouseDown(object sender, MouseEventArgs e)
        {
            y = 0;
            x = 0;
            timer2.Enabled = true;
            type = "SO";
        }

        private void prefencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Settings"] == null)
            {
                new Settings().Show();
            }
            else
            {
                Application.OpenForms["Settings"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("http://roshsoftco.blogspot.com");
        }

        private void SDb_Click(object sender, EventArgs e)
        {
            type = "SD";
            if (Application.OpenForms["action"] == null)
            {
                new action(type).Show();
            }
            else
            {
                Application.OpenForms["action"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void Rb_Click(object sender, EventArgs e)
        {
            type = "R";
            if (Application.OpenForms["action"] == null)
            {
                new action(type).Show();
            }
            else
            {
                Application.OpenForms["action"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void Hb_Click(object sender, EventArgs e)
        {
            type = "H";
            if (Application.OpenForms["action"] == null)
            {
                new action(type).Show();
            }
            else
            {
                Application.OpenForms["action"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void SBb_Click(object sender, EventArgs e)
        {
            type = "SB";
            if (Application.OpenForms["action"] == null)
            {
                new action(type).Show();
            }
            else
            {
                Application.OpenForms["action"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void Lb_Click(object sender, EventArgs e)
        {
            type = "lock";
            if (Application.OpenForms["action"] == null)
            {
                new action(type).Show();
            }
            else
            {
                Application.OpenForms["action"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void LOb_Click(object sender, EventArgs e)
        {
            type = "LO";
            if (Application.OpenForms["action"] == null)
            {
                new action(type).Show();
            }
            else
            {
                Application.OpenForms["action"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void SOb_Click(object sender, EventArgs e)
        {
            type = "SO";
            if (Application.OpenForms["action"] == null)
            {
                new action(type).Show();
            }
            else
            {
                Application.OpenForms["action"].Focus();
                SystemSounds.Beep.Play();
            }
        }

        private void reportBugsRequestHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.jotform.me/roshsoft/contact");
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Info"] == null)
            {
                new Info(2).Show();
            }
            else
            {
                Application.OpenForms["Info"].Close();
                new Info(2).Show();
            }
        }

    }
}