using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            int tickets = getTickets();
            int percent = getPercent();
            int newTick = getNewTickets(); //calculations


            report.Description = tickets.ToString() + ", " + percent.ToString() + ", " + newTick.ToString();


            report.ID = handler.AddReport(report); //add the report to the database, while recieving the new id back


            switch (report.Type)
            {
                case 0: 
                    LblReport.Text = "Unsolved Ticket Report";
                    break;
                case 1:
                    LblReport.Text = "Solved Ticket Report";
                    break;
                case 2:
                    LblReport.Text = "Existing Ticket Report";
                    break;
            }

            LblID.Text = report.ID.ToString();
            LblManagerID.Text = report.UserID.ToString();
            LblDateTime.Text = report.Date.ToString();
            LblNum.Text = tickets.ToString();
            LblPercent.Text = percent.ToString();
            LblNew.Text = newTick.ToString();

            
        }
        
        //TODO: Function to get number of certain kinds of tickets
        public int getTickets()
        {
            int count = handler.GetTicketCount(report.Type);
            return count;
        }
        
        //TODO: Function to get percentage of certain kinds of tickets
        public int getPercent()
        {
            int percent = handler.GetPercent(report.Type);
            return percent;
        }

        //TODO: Function to get the number of new tickets in the last 30 days
        public int getNewTickets()
        {
            DateTime date = DateTime.Now.AddDays(-30);
            int count = handler.GetTicketCount(date);
            return count;
        }
        

    }
}
