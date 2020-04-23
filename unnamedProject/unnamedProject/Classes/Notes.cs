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

        public string getNoteInfo()
        {
            return note_info;
        }

        public override string ToString()
        {
            int slength = note_info.Length;
            if(slength > 25)
                return note_info.Substring(0, 25) + "   " + date_written;
            else
                return note_info + "   " + date_written;
        }
    }
}
