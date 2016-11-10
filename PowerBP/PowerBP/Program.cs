using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PowerBP
{
    static class Program
    {
        public static readonly string version = "7. 16. 11. 10";
        public static readonly string location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"RoshSoft\Power\");
        public static Form1 MainForm;
        /// <summary>
        /// Power Background Process by RoshSoft Co.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            if (File.Exists(location + "power.dll"))
            {
                MainForm = new Form1();
                Application.Run(MainForm);
            }
            else
            {
                MessageBox.Show(location + "power.dll");
                MessageBox.Show("The application is temporary unavailable or you have no authorized permission to access it.", "PowerCS - Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }
    }
}
