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

/// <summary>
/// Authors:Myles Wright, Matthew O'hern, Parker Winters, and Nick Stitely
/// </summary>

namespace unnamedProject
{
    public partial class register : Form
    {
        Users current;
        public register(Users current)
        {
            InitializeComponent();
            this.current = current;
        }

        private void confirm_TextChanged(object sender, EventArgs e)
        {
            if (confirm.Text == "") //if a user does not fill in a text box, a red asterisk appears
            {
                conPassAst.Visible = true;
            }
            else
            {
                conPassAst.Visible = false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int accessValue;
            switch (roleCombo.Text) //switch statement determines access value of user being registered
            {
                case "Admin": accessValue = 0;
                     break;
                case "Report Manager": accessValue = 1;
                    break;
                case "IT Support Member": accessValue = 2;
                    break;
                case "Project Member": accessValue = 3;
                    break;
                 default: accessValue = 4;
                    break;
            }
                
            if (password.Text == "" || confirm.Text == "" || username.Text == "" || firstName.Text == "" ||  lastName.Text == "" || email.Text == "")
                error.Text = "Error: null values... why you do this?";
            else
            {
                if (password.Text != confirm.Text)
                    error.Text = "Error: Passwords do not match";
                else
                {
                    dbHandler login = new dbHandler();
                    login.newUser(username.Text, password.Text, firstName.Text, lastName.Text, email.Text, accessValue);

                    //send email
                    string subject = "Welcome to the Untitled Team family, " + firstName.Text;
                    string body =String.Format("<p> You have been added to the Untitled Team team, welcome! <br>" +
                                   "Here is your new username and password! <br>" +
                                   "Username: {0} <br>" +
                                   "Password: {1} <br>" +
                                   "If you wish to change it you can do so in the Account Prefrences tab in the program. <p>"
                                   , username.Text, password.Text);

                    EmailSend send = new EmailSend(email.Text, subject, body);


                    var admin = new Thread(() => Application.Run(new AdminForm(current)));
                    admin.Start();
                    Thread th = Thread.CurrentThread;
                    th.Abort();
                    
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            var admin = new Thread(() => Application.Run(new AdminForm(current)));
            admin.Start();
            
            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text == "") //if a user does not fill in a text box, a red asterisk appears
            {
                ast1.Visible = true;
            }
            else
            {
                ast1.Visible = false;
            }
        }
        


        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "") //if a user does not fill in a text box, a red asterisk appears
            {
                passAst.Visible = true;
            }
            else
            {
                passAst.Visible = false;
            }
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            if (firstName.Text == "") //if a user does not fill in a text box, a red asterisk appears
            {
                fNameAst.Visible = true;
            }
            else
            {
                fNameAst.Visible = false;
            }
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            if (lastName.Text == "") //if a user does not fill in a text box, a red asterisk appears
            {
                lNameAst.Visible = true;
            }
            else
            {
                lNameAst.Visible = false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text == "") //if a user does not fill in a text box, a red asterisk appears
            {
                eAst.Visible = true;
            }
            else
            {
                eAst.Visible = false;
            }
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

        private void register_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void roleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
