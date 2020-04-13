using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unnamedProject
{
    class Notes
    {
        public int Id { get; set;}
        public int User_Info_Id { get; set; }
        public int tickets_ticketID { get; set; }
        public DateTime date_written { get; set; }
        public string note_info { get; set; }

        Notes(int id, int userID, int ticketID, DateTime date, string info)
        {
            Id = id;
            User_Info_Id = userID;
            tickets_ticketID = ticketID;
            date_written = date;
            note_info = info;
        }
        Notes() //blank constructor
        {

        }


    }
}
