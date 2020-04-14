using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unnamedProject
{
    class Report
    {
        public int Type { get; set; }
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Report(int id, int type, int userid, string description, string date)
        {
            ID = id;
            type = Type;
            userid = UserID;
            description = Description;
            Date = DateTime.Parse(date);
        }

        public Report() //default constructor
        {

        }

        public override string ToString()
        {
            string t = "";
            switch (this.Type)
            {
                case 0:
                    t = "Unsolved";
                    break;
                case 1:
                    t = "Solved";
                    break;
                case 2:
                    t = "Existing";
                    break;
            }
            return "   ID: " + ID + "            Type: " + t + "            Date: " + this.Date.ToString();
        }
    }
}
