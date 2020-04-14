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

        public ReportForm(int type)
        {
            InitializeComponent();
            report = new Report();
            report.Type = type;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            handler = new dbHandler();

            int tickets = getTickets();
            int percent = getPercent();
            int newTick = getNewTickets();

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
        }
        /*
        //TODO: Function to get number of certain kinds of tickets
        public int getTickets()
        {

        }

        //TODO: Function to get percentage of certain kinds of tickets
        public int getPercent()
        {
            
        }

        //TODO: Function to get the number of new tickets in the last 30 days
        public int getNewTickets()
        {

        }
        */

    }
}
