using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace unnamedProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        //SignIn
        private void button1_Click(object sender, EventArgs e)
        {
            dbHandler login = new dbHandler();
            bool DaveTheFriendlyObject = login.checkAndRecieve(usernameBox.Text, passwordBox.Text);
            if (DaveTheFriendlyObject)
            {
                this.Hide();
                
                Thread th = Thread.CurrentThread;
                th.Abort();
                this.Close();
            }
            else
            {
                errorIncorrect.Visible = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void fullBtn_Click(object sender, EventArgs e)
        {
            if(this.Width > 709 || this.Height > 404 || WindowState == FormWindowState.Maximized)
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
