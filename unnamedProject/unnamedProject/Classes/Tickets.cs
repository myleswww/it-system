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
    class Tickets
    {
        public int TicketID { get; set; }
        public int UserInfo { get; set; }
        public DateTime DateAccessed { get; set; }
        public int TicketStatus { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public Tickets(int ticketID, int userInfo, DateTime dateAccessed, int ticketStatus, string description, string notes)
        {
            TicketID = ticketID;
            UserInfo = userInfo;
            DateAccessed = dateAccessed;
            TicketStatus = ticketStatus;
            Description = description;
            Notes = notes;
        }

        public override string ToString()
        {
            return string.Format("Ticket #: {0}, User ID: {1}, Date Accessed {2:f}, Ticket Status {3}, Description: {4}, Notes: {5}",
                TicketID, UserInfo, DateAccessed, TicketStatus, Description, Notes);
        }
    }
}
