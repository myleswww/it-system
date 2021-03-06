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
        private List<Tickets> tickets;
        private dbHandler dbhadler = new dbHandler();
        private Users current;

        public AdminForm(Users current)
        {
            InitializeComponent();
            this.current = current;
        }


        private void logOut_Click(object sender, EventArgs e)
        {                   //load the login form
            this.Hide();
            var logIn = new Thread(() => Application.Run(new LoginForm()));
            logIn.Start();

            Thread th = Thread.CurrentThread; //aborts the current thread
            th.Abort();
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide(); //load the register form
            var reg = new Thread(() => Application.Run(new register(current)));
            reg.Start();

            Thread th = Thread.CurrentThread; //abort the current thread
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
            LblHello.Text += current.Fname + "!";
            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(1);
            OpenList.Items.AddRange(tickets.ToArray());



            //WindowState = FormWindowState.Maximized;
            if (this.Width > 1067 || this.Height > 554 || WindowState == FormWindowState.Maximized)
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

        private void usersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var alluser = new Thread(() => Application.Run(new Forms.UserViewForm(current)));
            alluser.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var setting = new Thread(() => Application.Run(new Forms.SettingsForm(current)));
            setting.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var setting = new Thread(() => Application.Run(new Forms.GenerateReportForm(current)));
            setting.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }

        private void problemBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var existing = new Thread(() => Application.Run(new ViewExistingProblems(current)));
            existing.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }

        private void openTab_Click(object sender, EventArgs e)
        {
            FAPTab.BackColor = Color.FromArgb(64, 64, 64);
            FAPTab.ForeColor = SystemColors.ControlLightLight;

            newTab.BackColor = Color.FromArgb(64, 64, 64);
            newTab.ForeColor = SystemColors.ControlLightLight;

            closedTab.BackColor = Color.FromArgb(64, 64, 64);
            closedTab.ForeColor = SystemColors.ControlLightLight;

            openTab.BackColor = Color.FromArgb(240, 188, 94);
            openTab.ForeColor = Color.Black;

            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(1);
            OpenList.Items.AddRange(tickets.ToArray());
        }

        private void FAPTab_Click(object sender, EventArgs e)
        {
            newTab.BackColor = Color.FromArgb(64, 64, 64);
            newTab.ForeColor = SystemColors.ControlLightLight;

            closedTab.BackColor = Color.FromArgb(64, 64, 64);
            closedTab.ForeColor = SystemColors.ControlLightLight;

            openTab.BackColor = Color.FromArgb(64, 64, 64);
            openTab.ForeColor = SystemColors.ControlLightLight;

            FAPTab.BackColor = Color.FromArgb(240,188,94);
            FAPTab.ForeColor = Color.Black;

            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(2);
            OpenList.Items.AddRange(tickets.ToArray());
        }

        private void newTab_Click(object sender, EventArgs e)
        {
            closedTab.BackColor = Color.FromArgb(64, 64, 64);
            closedTab.ForeColor = SystemColors.ControlLightLight;

            openTab.BackColor = Color.FromArgb(64, 64, 64);
            openTab.ForeColor = SystemColors.ControlLightLight;

            FAPTab.BackColor = Color.FromArgb(64, 64, 64);
            FAPTab.ForeColor = SystemColors.ControlLightLight;

            newTab.BackColor = Color.FromArgb(240, 188, 94);
            newTab.ForeColor = Color.Black;

            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(0);
            OpenList.Items.AddRange(tickets.ToArray());
        }

        private void closedTab_Click(object sender, EventArgs e)
        {
            openTab.BackColor = Color.FromArgb(64, 64, 64);
            openTab.ForeColor = SystemColors.ControlLightLight;

            FAPTab.BackColor = Color.FromArgb(64, 64, 64);
            FAPTab.ForeColor = SystemColors.ControlLightLight;

            newTab.BackColor = Color.FromArgb(64, 64, 64);
            newTab.ForeColor = SystemColors.ControlLightLight;

            closedTab.BackColor = Color.FromArgb(240, 188, 94);
            closedTab.ForeColor = Color.Black;

            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(3);
            OpenList.Items.AddRange(tickets.ToArray());
        }

        private void OpenList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OpenList.Visible = true;
                Tickets selectedTicket = tickets[OpenList.SelectedIndex];
                this.Hide();

                var form = new Thread(() => Application.Run(new Forms.ViewTicketForm(current, selectedTicket)));

                form.Start();
                Thread th = Thread.CurrentThread;
                th.Abort();
                this.Close();
            }
            catch { }
        }

        private void onlineHelpBtn_Click(object sender, EventArgs e)
        {
            OpenList.Visible = false;
        }

        private void onlineHelpBtn_Click_1(object sender, EventArgs e)
        {
            var webbrowser = new Thread(() => Application.Run(new WebBrowserForm(current)));
            webbrowser.SetApartmentState(ApartmentState.STA);
            webbrowser.Start();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var form = new Thread(() => Application.Run(new CreateTicketForm(current)));

            form.Start();
            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }
    }
}
