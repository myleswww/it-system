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
            var reports = new Thread(() => Application.Run(new ViewReportsForm(current)));
            reports.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }
    }
}
