using System;
using System.Threading;
using System.Windows.Forms;

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

            Thread fakeGui = new Thread(() =>
            {
                Application.Run(new FakeGuiForm());
            });
            fakeGui.SetApartmentState(ApartmentState.STA);
            fakeGui.Start();
                
            Application.Run(new MainForm());
        }
    }
}
