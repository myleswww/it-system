﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Authors:Myles Wright, Matthew O'hern, Parker Winters, and Nick Stitely
/// </summary>

namespace unnamedProject.Forms
{
    public partial class ReportManagerForm : Form
    {
        private List<Tickets> tickets;
        private dbHandler dbhadler = new dbHandler();
        Users current;
        public ReportManagerForm(Users current)
        {
            InitializeComponent();
            this.current = current;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logIn = new Thread(() => Application.Run(new LoginForm()));
            logIn.Start();
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reg = new Thread(() => Application.Run(new register(current)));
            reg.Start();
            this.Close();
        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            if (optionPanel.Visible == false)
            {
                optionPanel.Show();
            }
            else if (optionPanel.Visible == true)
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

        private void ReportManagerForm_Load(object sender, EventArgs e)
        {
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

        private void buttonCollapse_Click_1(object sender, EventArgs e)
        {
            if (optionPanel.Visible == false)
            {
                optionPanel.Show();
            }
            else if (optionPanel.Visible == true)
            {
                optionPanel.Hide();
            }
        }

        private void logOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var logIn = new Thread(() => Application.Run(new LoginForm()));
            logIn.Start();

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

        private void reportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var setting = new Thread(() => Application.Run(new Forms.GenerateReportForm(current)));
            setting.Start();

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
        private void openTab_Click(object sender, EventArgs e)
        {
            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(1);
            OpenList.Items.AddRange(tickets.ToArray());
        }

        private void closedTab_Click(object sender, EventArgs e)
        {
            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(4);
            OpenList.Items.AddRange(tickets.ToArray());
        }

        private void FAPTab_Click(object sender, EventArgs e)
        {
            OpenList.Visible = true;
            OpenList.Items.Clear();
            tickets = dbhadler.LoadTicketsFromDb(3);
            OpenList.Items.AddRange(tickets.ToArray());
        }
    }
}