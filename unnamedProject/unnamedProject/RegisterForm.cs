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
    }
}
