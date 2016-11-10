using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Power.Properties;
using System.Media;

namespace Power
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            #region Tool Tips
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(this.ico, "Help - Information Panel");
            #endregion

            if (Properties.Settings.Default.always == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            if (Properties.Settings.Default.hold == 3)
            {
                comboBox1.Text = "Short";
            }

            else if (Properties.Settings.Default.hold == 6)
            {
                comboBox1.Text = "Medium";
            }

            else if (Properties.Settings.Default.hold == 12)
            {
                comboBox1.Text = "Long";
            }
            else
            {
                Properties.Settings.Default.hold = 6;
                Properties.Settings.Default.Save();
                comboBox1.Text = "Medium";
            }

            if (Properties.Settings.Default.action == true)
            {
                comboBox2.Text = "Specific Time Filter";
            }

            else
            {
                comboBox2.Text = "Countdown Trigger";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.always = true;
            }
            else
            {
                Properties.Settings.Default.always = false;
            }

            if (comboBox1.Text == "Short")
            {
                Properties.Settings.Default.hold = 3;
                Properties.Settings.Default.Save();
            }

            else if (comboBox1.Text == "Medium")
            {
                Properties.Settings.Default.hold = 6;
                Properties.Settings.Default.Save();
            }

            else if (comboBox1.Text == "Long")
            {
                Properties.Settings.Default.hold = 12;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Saving Failed. An unexpected error occered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Properties.Settings.Default.hold == 3)
                {
                    comboBox1.Text = "Short";
                }

                else if (Properties.Settings.Default.hold == 6)
                {
                    comboBox1.Text = "Medium";
                }

                else if (Properties.Settings.Default.hold == 12)
                {
                    comboBox1.Text = "Long";
                }

            }
            ////////////////////
            if (comboBox2.Text == "Specific Time Filter")
            {
                Properties.Settings.Default.action = true;
                Properties.Settings.Default.Save();
                this.Close();
            }

            else if (comboBox2.Text == "Countdown Trigger")
            {
                Properties.Settings.Default.action = false;
                Properties.Settings.Default.Save();
                this.Close();
            }

            else
            {
                MessageBox.Show("Saving Failed. Unexpected error occered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Properties.Settings.Default.action == true)
                {
                    comboBox2.Text = "Specific Time Filter";
                }

                else if (Properties.Settings.Default.action == false)
                {
                    comboBox2.Text = "Countdown Trigger";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("powercfg.cpl");
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("timedate.cpl");
        }

        private void ico_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Info"] == null)
            {
                new Info(4).Show();
            }
            else
            {
                Application.OpenForms["Info"].Close();
                new Info(4).Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Info"] == null)
            {
                new Info(4).Show();
            }
            else
            {
                Application.OpenForms["Info"].Close();
                new Info(4).Show();
            }
        }
    }
}
