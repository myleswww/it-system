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
using System.Data.SqlClient;

/// <summary>
/// Authors:Myles Wright, Matthew O'hern, Parker Winters, and Nick Stitely
/// </summary>

namespace unnamedProject
{
    public partial class AdminForm : Form
    {
        
        public AdminForm()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logIn = new Thread(() => Application.Run(new LoginForm()));
            logIn.Start();

            Thread th = Thread.CurrentThread; //aborts the current thread
            th.Abort();
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reg = new Thread(() => Application.Run(new register()));
            reg.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            if (optionPanel.Visible == false)
            {
                optionPanel.Show();
            }
            else if(optionPanel.Visible == true)
            {
                optionPanel.Hide();
            }

            
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
                ticketTable.Size = mainPanel.Size;

                //screen scaling

            }
            else
            {
                WindowState = FormWindowState.Maximized;
                fullBtn.ImageIndex = 0;
                fullBtn.FlatAppearance.BorderSize = 0;
                fullBtn.Width = 15;
                fullBtn.Height = 15;
                ticketTable.Size = mainPanel.Size;

                //screen scaling

            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            //WindowState = FormWindowState.Maximized;
            if(this.Width > 1067 || this.Height > 554 || WindowState == FormWindowState.Maximized)
            {
                //maximize button image is set to the png image
                fullBtn.ImageIndex = 0;
                fullBtn.FlatAppearance.BorderSize = 0;
                fullBtn.Width = 15;
                fullBtn.Height = 15;
          


            }
            else
            {
                fullBtn.FlatAppearance.BorderSize = 1;
                fullBtn.Width = 15;
                fullBtn.Height = 12;
                fullBtn.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
                fullBtn.ImageIndex = -1;

            }
        }

        private void optionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var alluser = new Thread(() => Application.Run(new Forms.UserViewForm()));
            alluser.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var setting = new Thread(() => Application.Run(new Forms.UserViewForm()));
            setting.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var setting = new Thread(() => Application.Run(new Forms.GenerateReportForm()));
            setting.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }
    }
}
