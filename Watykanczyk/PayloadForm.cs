using System;
using System.Drawing;
using System.Windows.Forms;

namespace Watykanczyk
{
    public partial class PayloadForm : Form
    {
        public PayloadForm()
        {
            InitializeComponent();

            Screen primaryScreen = Screen.PrimaryScreen;

            int w = primaryScreen.Bounds.Width;
            int h = primaryScreen.Bounds.Height;

            Random r = new Random();

            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(r.Next(0, w - 100), r.Next(0, h - 100));


            int images = 38; // REMEMBER TO CHANGE IMAGES COUNT, WHEN NEW ONE IS ADDED
            int chosen = r.Next(1, images + 1);

            Bitmap bgImage = Properties.Resources.ResourceManager.GetObject($"_{chosen}") as Bitmap;
            this.BackgroundImage = bgImage;

            this.Size = bgImage.Size;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // WS_EX_TOOLWINDOW
                return cp;
            }
        }
    }
}
