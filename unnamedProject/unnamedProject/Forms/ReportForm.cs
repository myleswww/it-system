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
    public partial class ReportForm : Form
    {
        Report report { get; set; }
        dbHandler handler;
        Users current;
        public ReportForm(int type, Users user)
        {
            InitializeComponent();
            report = new Report(); // create a new report
            report.Type = type;

            current = user;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            handler = new dbHandler();

            report.Date = DateTime.Now;
            report.UserID = current.Id;

            int tickets = 0;
            int percent = 0;
            int newTick = getNewTickets(); //calculations


            


            switch (report.Type)
            {
                case 0: 
                    LblReport.Text = "Unsolved Ticket Report";
                    LblNum.Text = "Number of Unsolved Tickets: ";
                    LblPercent.Text = "Percent of Unsolved Tickets: ";
                    tickets = getTickets(0) + getTickets(1);
                    percent = getPercent(0) + getPercent(1);
                    break;
                case 1:
                    LblReport.Text = "Solved Ticket Report";
                    LblNum.Text = "Number of Solved Tickets: ";
                    LblPercent.Text = "Percent of Solved Tickets: ";
                    tickets = getTickets(2) + getTickets(3);
                    percent = getPercent(2) + getPercent(3);
                    break;
                case 2:
                    LblReport.Text = "Existing Ticket Report";
                    tickets = handler.GetTicketCount();
                    percent = 0;
                    LblNum.Text = "Number of Tickets in System: ";
                    LblPercent.Visible = false;
                    break;
            }

            report.Description = tickets.ToString() + ", " + percent.ToString() + ", " + newTick.ToString();


            report.ID = handler.AddReport(report); //add the report to the database, while recieving the new id back

            LblID.Text += report.ID.ToString();
            LblManagerID.Text += report.UserID.ToString();
            LblDateTime.Text = report.Date.ToString();
            LblNum.Text += tickets.ToString();
            LblPercent.Text += percent.ToString();
            LblNew.Text += newTick.ToString();

            
        }
        
        //TODO: Function to get number of certain kinds of tickets
        public int getTickets(int ticketType)
        {
            int count = handler.GetTicketCount(ticketType);
            return count;
        }
        
        //TODO: Function to get percentage of certain kinds of tickets
        public int getPercent(int ticketType)
        {
            int percent = handler.GetPercent(ticketType);
            return percent;
        }

        //TODO: Function to get the number of new tickets in the last 30 days
        public int getNewTickets()
        {
            DateTime date = DateTime.Now.AddDays(-30);
            int count = handler.GetTicketCount(date);
            return count;
        }

        private void back_Click(object sender, EventArgs e)
        {
            var report = new Thread(() => Application.Run(new Forms.GenerateReportForm(current)));
            report.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }
    }
}
