using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Power.Properties;
using System.Runtime.InteropServices;
using System.Media;
using System.Diagnostics;
using System.IO;

namespace Power
{
    public partial class MB : Form
    {
        public MB(string title, bool close, string message, string buttonText1, string buttonText2)
        {
            InitializeComponent();
            this.Text = title;
            if (close == true)
            {
                this.ControlBox = true;
            }
            else
            {
                this.ControlBox = false;
            }
            label1.Text = message;
            button1.Text = buttonText1;
            button2.Text = buttonText2;

        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle.ToInt32(), 0x0112, 0xF140, 2);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle.ToInt32(), 0x0112, 0xF170, 2);
            Application.Exit();
        }

    }
}
