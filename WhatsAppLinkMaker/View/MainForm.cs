using WhatsAppLinkMaker.Business;
using System;
using System.Windows.Forms;

namespace WhatsAppLinkMaker
{
    public partial class MainForm : Form
    {
        CreateLink clsCL = new CreateLink();
        public MainForm()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = WhatsAppLinkMaker.Properties.Resources.icons8_close_window_32px_1;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = WhatsAppLinkMaker.Properties.Resources.icons8_close_window_32px;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtLink.Text = clsCL.fncGetLink(txtNumber.Text, txtInputText.Text);
        }
    }
}
