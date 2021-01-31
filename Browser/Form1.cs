using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            urlBox.Text = browser.Url.ToString();
            if (browser.CanGoBack) browser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            urlBox.Text = browser.Url.ToString();
            if (browser.CanGoForward) browser.GoForward();   
        }

        private void go_Click(object sender, EventArgs e)
        {
            urlBox.Text = browser.Url.ToString();
            browser.Navigate(urlBox.Text);
        }

        private void gmailButton_Click(object sender, EventArgs e)
        {
            urlBox.Text = browser.Url.ToString();
            browser.Navigate("https://mail.google.com/mail/u/0/");
        }

        private void webmailButton_Click(object sender, EventArgs e)
        {
            urlBox.Text = browser.Url.ToString();
            browser.Navigate("https://webmail.carnet.hr/login.php");
        }

        private void ispisButton_Click(object sender, EventArgs e)
        {
            browser.Print();
        }
    }
}
