using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Authors:Myles Wright, Matthew O'hern, Parker Winters, and Nick Stitely
/// </summary>

namespace unnamedProject
{
    public class Tickets
    {
        public int TicketID { get; set; } //class members
        public int UserInfo { get; set; }
        public DateTime DateAccessed { get; set; }
        public int TicketStatus { get; set; }
        public string Description { get; set; }
        public int Assigned { get; set; }
        public int Priority { get; set; }

        public Tickets(int userInfo, DateTime dateAccessed, int ticketStatus, string description, int assigned)
        {
            UserInfo = userInfo;
            DateAccessed = dateAccessed;
            TicketStatus = ticketStatus;
            Description = description;
            Assigned = assigned;
        }

        public Tickets(int ID, int userInfo, DateTime dateAccessed, int ticketStatus, string description, int assigned)
        {
            TicketID = ID;
            UserInfo = userInfo;
            DateAccessed = dateAccessed;
            TicketStatus = ticketStatus;
            Description = description;
            Assigned = assigned;
        }

        public override string ToString() //this needs to be formatted better
        {
            return string.Format("{0}, {4}, {2:f}",
                TicketID, UserInfo, DateAccessed, TicketStatus, Description);
        }
    }
}
