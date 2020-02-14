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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Password
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Username
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //SignIn
        private void button1_Click(object sender, EventArgs e)
        {
            loginType login = new loginType();
            bool DaveTheFriendlyObject = login.checkAndRecieve(usernameBox.Text, passwordBox.Text);
            if (DaveTheFriendlyObject)
            {
                this.Hide();
                this.Close();
            }
            else
            {
                errorIncorrect.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
