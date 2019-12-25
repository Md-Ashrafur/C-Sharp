using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Back(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Forward(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void home(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bing.com");
        }

        private void Reload(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://"+address.Text);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://" + address.Text);
        }

        private void address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                webBrowser1.Navigate("https://" + address.Text);
            }
        }
    }
}
