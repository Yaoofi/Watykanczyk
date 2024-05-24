using System;
using System.Media;
using System.Windows.Forms;

namespace Watykanczyk
{
    public partial class FakeGuiForm : Form
    {
        public FakeGuiForm()
        {
            InitializeComponent();

        }

        private void chkUnder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnder.Checked)
            {
                btnCheck.Enabled = true;
            }
            else
            {
                btnCheck.Enabled = false;
            }
        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int Month = int.Parse(txtMonth.Text);

            if (txtNumber.TextLength == 16 && txtCVC.TextLength == 3 && Month < 13 && Month > 0 && cbYear.SelectedIndex > currentYear - 2000 && cbYear.SelectedIndex < 138)
            {
                MessageBox.Show("Warning! There is no free robux dumb bitch >:)");
                MessageBox.Show("Btw thanks for yo mamas credit card number :)");
            }
            else if (txtNumber.TextLength != 16)
            {
                MessageBox.Show("Wrong Card Number (it shouldn't contain spaces, and should have 16 characters)");
            }
            else if (txtCVC.TextLength != 3)
            {
                MessageBox.Show("Wrong CVC (it should have 3 characters)");
            }
            else if (Month > 12 || Month < 1)
            {
                MessageBox.Show("Wrong month");
            }
            else if (cbYear.SelectedIndex < currentYear - 2000 || cbYear.SelectedIndex > 137)
            {
                MessageBox.Show("Wrong Year");
            }
        }
    }
}
