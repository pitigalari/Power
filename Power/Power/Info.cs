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
    public partial class Info : Form
    {
        public Info(int x)
        {
            InitializeComponent();
            page = x;
        }

        int page = 1;

        private void Info_Load(object sender, EventArgs e)
        {
            if (page == 1 || page == 0)
            {
                rB1.Checked = true;
            }
            else if (page == 2)
            {
                rB2.Checked = true;
            }
            else if (page == 3)
            {
                rB3.Checked = true;
            }
            else if (page == 4)
            {
                rB4.Checked = true;
            }
            else if (page == 5)
            {
                rB5.Checked = true;
            }

            if (Properties.Settings.Default.always == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void Page_Select(object sender, EventArgs e)
        {
            if (rB1.Checked == true)
            {
                head.Text = "Welcome to Power...";
                body1.Show();
                body2.Hide();
                body3.Hide();
                body4.Hide();
                body5.Hide();
            }
            else if (rB2.Checked == true)
            {
                head.Text = "Main window...";
                body1.Hide();
                body2.Show();
                body3.Hide();
                body4.Hide();
                body5.Hide();
            }
            else if (rB3.Checked == true)
            {
                head.Text = "Action Panel...";
                body1.Hide();
                body2.Hide();
                body3.Show();
                body4.Hide();
                body5.Hide();
            }
            else if (rB4.Checked == true)
            {
                head.Text = "Settings Panel...";
                body1.Hide();
                body2.Hide();
                body3.Hide();
                body4.Show();
                body5.Hide();
            }
            else if (rB5.Checked == true)
            {
                head.Text = "Power Background Process...";
                body1.Hide();
                body2.Hide();
                body3.Hide();
                body4.Hide();
                body5.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.always = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.always = false;
                Properties.Settings.Default.Save();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (rB1.Checked == true)
            {
                rB2.Checked = true;
            }
            else if (rB2.Checked == true)
            {
                rB3.Checked = true;
            }
            else if (rB3.Checked == true)
            {
                rB4.Checked = true;
            }
            else if (rB4.Checked == true)
            {
                rB5.Checked = true;
            }
            else
            {
                rB1.Checked = true;
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (rB5.Checked == true)
            {
                rB4.Checked = true;
            }
            else if (rB4.Checked == true)
            {
                rB3.Checked = true;
            }
            else if (rB3.Checked == true)
            {
                rB2.Checked = true;
            }
            else if (rB2.Checked == true)
            {
                rB1.Checked = true;
            }
            else
            {
                rB5.Checked = true;
            }
        }
    }
}
