using System;
using System.Threading;
using System.Windows.Forms;
using WatykanczykV2.Forms;

namespace Watykanczyk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerForm());
        }
    }
}
