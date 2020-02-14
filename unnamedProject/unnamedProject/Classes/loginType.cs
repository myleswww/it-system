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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=nhds2020.database.windows.net;Initial Catalog=NothingHelpDeskSpring2020; Authentication=Active Directory Password ;User ID=mohern@butler.edu;Password=Littlebro77%");
        public bool checkAndRecieve(string userName, string passWord)
        {
            sqlcon.Open();
            string query = "Select * from User_Info Where Username = '" + userName.Trim() + "' and Password = '" + passWord.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (dtbl.Rows[0]["levelAccess"].ToString() == "0")
                {
                    var admin = new Thread(() => Application.Run(new AdminForm()));
                    admin.Start();
                    Thread th = Thread.CurrentThread;
                    th.Abort();
                    sqlcon.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                sqlcon.Close();
                return false;
            }
        }

        public void newUser(string username, string password, string fname, string lname, string email, int levelAccess)
        {
            sqlcon.Open();
            string query = "Select MAX(Id) from User_Info"; //query to select max id
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(query, sqlcon);
            
            SqlDataReader reader;

            reader = command.ExecuteReader();
            double newId = 0;
            while (reader.Read())
            {
                int str = reader.GetInt32(0);
                newId = str + 1;
            }
            reader.Close();

            command = new SqlCommand("sp_insert", sqlcon);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", newId);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@firstName", fname);
            command.Parameters.AddWithValue("@lastName", lname);
            command.Parameters.AddWithValue("@levelAccess", levelAccess);
            command.ExecuteNonQuery();
            MessageBox.Show("User added!", "User added", MessageBoxButtons.OK);
            sda.Dispose();
            sqlcon.Close();
        }

    }
}
