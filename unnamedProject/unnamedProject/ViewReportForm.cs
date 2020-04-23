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

namespace unnamedProject
{
    public partial class ViewReportForm : Form
    {
        Report report { get; set; }
        dbHandler handler;
        Users current;
        public ViewReportForm(Users cur, Report rep)
        {
            InitializeComponent();

            report = report;
            current = cur;

        }

        private void back_Click(object sender, EventArgs e)
        {
            var report = new Thread(() => Application.Run(new Forms.GenerateReportForm(current)));
            report.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void ViewReportForm_Load(object sender, EventArgs e)
        {
            char[] delimiter = { ',' };
            string[] labels = report.Description.Split(delimiter);
            switch (report.Type)
            {
                case 0:
                    LblReport.Text = "Unsolved Ticket Report";
                    LblNum.Text = "Number of Unsolved Tickets: ";
                    LblPercent.Text = "Percent of Unsolved Tickets: ";
                    
                    break;
                case 1:
                    LblReport.Text = "Solved Ticket Report";
                    LblNum.Text = "Number of Solved Tickets: ";
                    LblPercent.Text = "Percent of Solved Tickets: ";
                    
                    break;
                case 2:
                    LblReport.Text = "Existing Ticket Report";
                    LblNum.Text = "Number of Tickets in System: ";
                    LblPercent.Visible = false;
                    break;
            }
            LblID.Text = LblID.Text + " " + report.ID;
            LblManagerID.Text = LblManagerID.Text + " " + report.UserID;
            LblDateTime.Text = report.Date.ToString();
        }
    }
}
