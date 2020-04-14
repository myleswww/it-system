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
    public partial class GenerateReportForm : Form
    {
        Users current;
        public void GenerateReportForm_Load(object sender, EventArgs e)
        {

        }

        public GenerateReportForm(Users current)
        {
            InitializeComponent();
            this.current = current;
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var admin = new Thread(() => Application.Run(current.getForm()));
            admin.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void btnUnsolvedTicket_Click(object sender, EventArgs e)
        {
            var report = new Thread(() => Application.Run(new ReportForm(0, current)));
            report.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void btnSolvedTickets_Click(object sender, EventArgs e)
        {
            var report = new Thread(() => Application.Run(new ReportForm(1, current)));
            report.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void btnExistingTickets_Click(object sender, EventArgs e)
        {
            var report = new Thread(() => Application.Run(new ReportForm(2, current)));
            report.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void BtnViewReports_Click(object sender, EventArgs e)
        {

        }
    }
}
