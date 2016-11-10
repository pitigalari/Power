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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://roshsoftco.blogspot.com");
        }

        private void about_Load(object sender, EventArgs e)
        {
            label1.Text = Program.version;
        }
    }
}
