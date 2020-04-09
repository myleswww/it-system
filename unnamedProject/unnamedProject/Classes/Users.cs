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

        public Users(string username, string fname, string lname, string email, int levelAccess)
        {
            Username = username;
            Fname = fname;
            Lname = lname;
            Email = email;
            LevelAccess = levelAccess;
        }
    }
}
