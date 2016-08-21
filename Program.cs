using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QuickStarter
{
    static class Program
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool bNew = true;

            // There can be only one... instance of this application on a machine.
            using (Mutex mutex = new Mutex(true, "MYAPP_0D36E4C9-399D-4b05-BDA3-EE059FB77E8D", out bNew))
            {
                if (bNew)
                {
                    Application.Run(new QuickStarter());
                }
                else
                {
                    Process me = Process.GetCurrentProcess();
                    foreach (Process proc in Process.GetProcessesByName(me.ProcessName))
                    {
                        if (proc.Id != me.Id)
                        {
                            SetForegroundWindow(proc.MainWindowHandle);
                            break;
                        }
                    }
                }
            }
        }
    }
}