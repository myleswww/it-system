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

namespace unnamedProject.Forms
{
    public partial class SettingsForm : Form
    {
        Users current;
        public SettingsForm(Users current)
        {
            InitializeComponent();
            this.current = current;
        }

        private void back_Click(object sender, EventArgs e)
        {
            var admin = new Thread(() => Application.Run(current.getForm()));
            admin.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtbxEmail.ReadOnly = false; //user can now edit the textboxes
            TxtbxPassword.ReadOnly = false;
            TxtbxUsername.ReadOnly = false;
            BtnSave.Visible = true;

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //fill in the textboxes with the user's info from the user class.
            TxtbxEmail.Text = current.Email;
            TxtbxUsername.Text = current.Username;
            //Do not include password in the user class because it is not secure
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            dbHandler handler = new dbHandler();
            if(TxtbxEmail.Text == "" || TxtbxPassword.Text == "" || TxtbxUsername.Text == "" || txtBxConfirm.Text == "" || TxtbxEmail.Text == null || TxtbxPassword.Text == null || TxtbxUsername.Text == null || txtBxConfirm.Text == null)
            {
                lblError.Visible = true;
                lblError.Text = "You have left a field blank!";
            }
            else if (TxtbxPassword.Text != txtBxConfirm.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Your passwords must match!";
            }
            else
            {
                //save the data to the textboxes
                TxtbxEmail.ReadOnly = true;
                TxtbxPassword.ReadOnly = true;
                TxtbxUsername.ReadOnly = true;

                BtnSave.Visible = false;

                //update the database 

                current.Email = TxtbxEmail.Text;
                current.Username = TxtbxUsername.Text;
                current.Password = TxtbxPassword.Text;

                handler.UpdateUser(current);
            }
            

            
            
        }

       
    }
}
