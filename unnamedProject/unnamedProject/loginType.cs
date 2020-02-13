using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace unnamedProject
{
    class loginType
    {
        public bool checkAndRecieve(string userName, string passWord)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=nhds2020.database.windows.net;Initial Catalog=NothingHelpDeskSpring2020; Authentication=Active Directory Password ;User ID=mohern@butler.edu;Password=Littlebro77%");
            string query = "Select * from User_Info Where Username = '" + userName.Trim() + "' and Password = '" + passWord.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (true)
                {
                    var admin = new Thread(() => Application.Run(new AdminForm()));
                    admin.Start();
                    return true;
                }
            }
            else
                return false;
        }

    }
}
