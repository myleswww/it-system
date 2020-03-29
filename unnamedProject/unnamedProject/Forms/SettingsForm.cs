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
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var admin = new Thread(() => Application.Run(new AdminForm()));
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
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //save the data to the textboxes
            TxtbxEmail.ReadOnly = true;
            TxtbxPassword.ReadOnly = true;
            TxtbxUsername.ReadOnly = true;

            BtnSave.Visible = false;

            //update the database using the user class as a "middleman"
        }

        private void fullBtn_Click(object sender, EventArgs e)
        {
            if (this.Width > 1067 || this.Height > 554 || WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal; //All of this is for the button itself
                fullBtn.FlatAppearance.BorderSize = 1;
                fullBtn.Width = 15;
                fullBtn.Height = 12;
                fullBtn.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
                fullBtn.ImageIndex = -1;


                //screen scaling

            }
            else
            {
                WindowState = FormWindowState.Maximized;
                fullBtn.ImageIndex = 0;
                fullBtn.FlatAppearance.BorderSize = 0;
                fullBtn.Width = 15;
                fullBtn.Height = 15;

                //screen scaling

            }
        }
    }
}
