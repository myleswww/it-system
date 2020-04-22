using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unnamedProject
{
    public partial class WebBrowserForm : Form
    {
        Users current;
        string defaultURL = "www.butler.edu";
        private bool mouseDown;
        private Point lastLocation;
        public WebBrowserForm(Users current)
        {
            InitializeComponent();
            this.current = current;
            wbrDisplay.Navigate(defaultURL);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void fullBtn_Click(object sender, EventArgs e)
        {
            if (this.Width > 753 || this.Height > 429 || WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void back_Click(object sender, EventArgs e)
        {


            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            wbrDisplay.Navigate(txtURL.Text);
        }

        private void WebBrowserForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void WebBrowserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void WebBrowserForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
