using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Power
{
    public partial class DefalutAction : Form
    {
        public DefalutAction()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Shutdown")
            {
                Properties.Settings.Default.defalut = "U";
                Properties.Settings.Default.Save();
                MessageBox.Show("Defalut Action has been set to Shutdown.", "Defalut Action Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (comboBox1.Text == "Restart")
            {
                Properties.Settings.Default.defalut = "R";
                Properties.Settings.Default.Save();
                MessageBox.Show("Defalut Action has been set to Restart.", "Defalut Action Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (comboBox1.Text == "Logoff")
            {
                Properties.Settings.Default.defalut = "L";
                Properties.Settings.Default.Save();
                MessageBox.Show("Defalut Action has been set to Logoff.", "Defalut Action Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (comboBox1.Text == "Lock")
            {
                Properties.Settings.Default.defalut = "O";
                Properties.Settings.Default.Save();
                MessageBox.Show("Defalut Action has been set to Lock.", "Defalut Action Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (comboBox1.Text == "Hibernate")
            {
                Properties.Settings.Default.defalut = "H";
                Properties.Settings.Default.Save();
                MessageBox.Show("Defalut Action has been set to Hibernate.", "Defalut Action Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (comboBox1.Text == "None")
            {
                Properties.Settings.Default.defalut = "None";
                Properties.Settings.Default.Save();
                MessageBox.Show("Defalut Actions that you had set before has been cleared.", "Defalut Action Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an option form the dropdown given.", "Select option to proceed", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void DefalutAction_Load(object sender, EventArgs e)
        {
            label2.Text = Properties.Settings.Default.defalut;
            if (label2.Text == "U")
            {
                comboBox1.Text = "Shutdown";
            }
            else if (label2.Text == "R")
            {
                comboBox1.Text = "Restart";
            }
            else if (label2.Text == "L")
            {
                comboBox1.Text = "Logoff";
            }
            else if (label2.Text == "O")
            {
                comboBox1.Text = "Lock";
            }
            else if (label2.Text == "S")
            {
                comboBox1.Text = "Standby";
            }
            else if (label2.Text == "H")
            {
                comboBox1.Text = "Hibernate";
            }
            else
            {
                comboBox1.Text = "None";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
