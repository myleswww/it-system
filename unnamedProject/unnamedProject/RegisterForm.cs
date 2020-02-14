﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace unnamedProject
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void lastnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void confirmLabel_Click(object sender, EventArgs e)
        {

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
            if (password.Text == "" || confirm.Text == "" || username.Text == "" || firstName.Text == "" ||  lastName.Text == "" || email.Text == "")
                error.Text = "Error: null values... why you do this?";
            else
            {
                if (password.Text != confirm.Text)
                    error.Text = "Error: Passwords do not match";
                else
                {
                    loginType login = new loginType();
                    login.newUser(username.Text,password.Text,firstName.Text,lastName.Text,email.Text,(int)levelAccess.Value);
                    this.Hide();
                    var admin = new Thread(() => Application.Run(new AdminForm()));
                    admin.Start();
                    this.Close();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var admin = new Thread(() => Application.Run(new AdminForm()));
            admin.Start();
            this.Close();
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
        

        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void levelAccess_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
