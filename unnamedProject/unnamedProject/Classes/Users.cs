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
    public class Users
    {
        public string Username { get; set; }
        public  string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public int LevelAccess { get; set; }
        public int Id { get; set; }

        public string Password { get; set; } //set to protected so that it cannot be accessed by anyone

        public Users(string username, string fname, string lname, string email, int levelAccess, int id)
        {
            Username = username;
            Fname = fname;
            Lname = lname;
            Email = email;
            LevelAccess = levelAccess;
            Id = id;
        }
        public Users()
        {

        }

        public int GetId()
        {
            return Id;
        }

        public string GetLname()
        {
            return Lname;
        }
        public string GetFname()
        {
            return Fname;
        }

        //TODO: Find a way to format the listbox so that everything aligns with the labels
        public override string ToString()
        {
            return "         " + Fname + "    " + Lname + "         " + Id.ToString() + "         " + GetAccessString(LevelAccess); //return the access name, not just thed integer
        }

        public string GetAccessString(int level) //returns the name of the role based on the level access integer
        {
            string role = ""; //has to be assigned to a value at first
            switch (level)
            {
                case 0: role = "Admin";
                    break;
                case 1: role = "Report Manager";
                    break;
                case 2: role = "Support Member";
                    break;
                case 3: role = "Project Member";
                    break;
                case 4: role = "Deactivated";
                    break;
            }
            return role;
        }
    }
}
