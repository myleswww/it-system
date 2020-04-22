using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unnamedProject
{
    public class Notes
    {
        public int User_Info_Id { get; set; }
        public int tickets_ticketID { get; set; }
        public DateTime date_written { get; set; }
        public string note_info { get; set; }

        public Notes(int userID, int ticketID, DateTime date, string info)
        {
            User_Info_Id = userID;
            tickets_ticketID = ticketID;
            date_written = date;
            note_info = info;
        }
        public Notes()
        {

        }

        public override string ToString()
        {
            return note_info + "   " + date_written;
        }
    }
}
