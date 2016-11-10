using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Security.Principal;

namespace Power
{
    static class Program
    {
        public static readonly string version = "7. 16. 11. 10";
        public static readonly string location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"RoshSoft\Power\");
        static Mutex mutex = new Mutex(true, "{01079a23-0bc6-4d4c-8c6a-40382ed1300a}");
        //GUID : 01079a23-0bc6-4d4c-8c6a-40382ed1300a //8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F
        /// <summary>
        /// Power User Interface by RoshSoft Co.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.Run(new home());
                mutex.ReleaseMutex();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
        
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }

    }
}
