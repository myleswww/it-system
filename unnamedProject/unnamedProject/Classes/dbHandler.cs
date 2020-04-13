using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

/// <summary>
/// Authors:Myles Wright, Matthew O'hern, Parker Winters, and Nick Stitely
/// </summary>

namespace unnamedProject
{
    class dbHandler
    {      //connection string
        public Users curretOnlineUser;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=nhds2020.database.windows.net;Initial Catalog=NothingHelpDeskSpring2020;User ID=fruit;Password=mangoMaster!");
        public bool checkAndRecieve(string userName, string passWord)
        {
            sqlcon.Open(); //open the connection
            //create a query to select everything from user where the username and password are equal
            string query = "Select * from User_Info Where Username = '" + userName.Trim() + "' and Password = '" + passWord.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon); 
            DataTable dtbl = new DataTable(); //make a data table for the info
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1) //if the row count = 1, it only grabbed one user. 
            {
                int tep = (int)dtbl.Rows[0]["ID"];
                curretOnlineUser = LoadUserInfoFromDb(tep);
                if (dtbl.Rows[0]["levelAccess"].ToString() == "0") //if level access is 0, it's an admin
                {
                    var admin = new Thread(() => Application.Run(new AdminForm(curretOnlineUser))); //create var for admin form
                    admin.SetApartmentState(ApartmentState.STA); //set hte apartment state to sta so things like web browsers have functionality
                    admin.Start(); //start the admin form
                    Thread th = Thread.CurrentThread; //current thread
                    th.Abort(); //abort the current thread
                    sqlcon.Close(); //close the sql connection
                    return true; //return true to prevent error 
                }
                else if(dtbl.Rows[0]["levelAccess"].ToString() == "1") //if lvl access = 1, it's a report manager
                {
                    var reportManager = new Thread(() => Application.Run(new Forms.ReportManagerForm(curretOnlineUser))); //create var for form
                    reportManager.SetApartmentState(ApartmentState.STA); //set apartment state
                    reportManager.Start(); //start the form
                    Thread th = Thread.CurrentThread; //current thread
                    th.Abort(); //abort the current thread; this saves memory so we don't have to rely on c# garbage collection
                    sqlcon.Close(); //close the current connection
                    return true; //return true
                }
                else if (dtbl.Rows[0]["levelAccess"].ToString() == "2") //if it is a support team member
                {
                    var supportMember = new Thread(() => Application.Run(new Forms.SupportForm(curretOnlineUser))); //new var for form
                    supportMember.SetApartmentState(ApartmentState.STA); //set apartment state
                    supportMember.Start(); //start the new form
                    Thread th = Thread.CurrentThread; //current thread
                    th.Abort(); //abort the current thread
                    sqlcon.Close(); //close connection
                    return true; //return true
                }
                else if (dtbl.Rows[0]["levelAccess"].ToString() == "3") //this is a project member
                {
                    var projectMember = new Thread(() => Application.Run(new Forms.ProjectMemberForm(curretOnlineUser))); //new var
                    projectMember.SetApartmentState(ApartmentState.STA); //apartment state
                    projectMember.Start(); //start form
                    Thread th = Thread.CurrentThread; //current thread
                    th.Abort(); //abort the current thread
                    sqlcon.Close(); //close connection
                    return true; //return true
                }
                else
                {
                    sqlcon.Close();
                    return false; //When a user is deactivated, their lvlaccess will change to 4, and will trigger this case. 
                                 //This means they won't be able to log in and will recieve an error
                }
            }
            else
            {
                sqlcon.Close(); //if the db returns multiple users or no users, meaning there are either duplicate values or
                return false;   //the username or password are not correct, so the user cannot log in
            }
        }

        public void newUser(string username, string password, string fname, string lname, string email, int levelAccess)
        {//this function adds a new user into the database
            sqlcon.Open(); //open the connection
            string query = "Select MAX(Id) from User_Info"; //query to select max id
            SqlDataAdapter sda = new SqlDataAdapter(); //data adapter
            SqlCommand command = new SqlCommand(query, sqlcon); //create a new command with the above query
            
            SqlDataReader reader; //data reader

            reader = command.ExecuteReader(); //start the data reader
            double newId = 0; //make a var for 
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

        public List<Tickets> LoadTicketsFromDb()
        {
            //declare a list of Employee objects
            List<Tickets> tickets;

            tickets = new List<Tickets>(); //instantiate the employees list

            try //error handling
            {

                Tickets tempticket;

                sqlcon.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tickets", sqlcon);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {

                    int ticketID = (int)reader["ID"];
                    int userInfo = (int)reader["User_Info_Id"];
                    DateTime dateAccessed = (DateTime)reader["date_accessed"];
                    int ticketStatus = (int)reader["ticket_status"];
                    string description = (string)reader["description"];
                    string notes = (string)reader["notes"];

                    tempticket = new Tickets(ticketID,userInfo,dateAccessed,ticketStatus,description,notes);

                    tickets.Add(tempticket);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

            }
            finally
            {
                sqlcon.Close();

            }

            return tickets;

        }

        public Users LoadUserInfoFromDb(int currentUserID)
        {
            string username = null;
            string fname = null;
            string lname = null;
            string email = null;
            int levelAccess = 3;

                SqlCommand sqlCommand = new SqlCommand("Select * from User_Info Where ID = '" + currentUserID + "'", sqlcon);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    username = (string)reader["Username"];
                    fname = (string)reader["firstname"];
                    lname = (string)reader["lastname"];
                    email = (string)reader["Email"];
                    levelAccess = (int)reader["levelAccess"];
                }
                Users currentUser = new Users(username, fname, lname, email, levelAccess);
                return currentUser;
        }

        public List<Users> LoadAll()
        {
            string query = "SELECT Id, Username, firstName, lastName, levelAccess FROM User_Info"; //select id and levelaccess so the admin can update someones access status if needed
            sqlcon.Open(); //open that connection!
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon); //data adapter
            DataTable dtbl = new DataTable("Users");
            sda.Fill(dtbl); //fill the data table!
            List<Users> users = new List<Users>();
            users = (from DataRow r in dtbl.Rows //list of users to return
                     select new Users()
                     {
                         Id = (int)r["Id"],
                         Username = r["Username"].ToString(),
                         Fname = r["firstName"].ToString(),
                         Lname = r["lastName"].ToString(),
                         LevelAccess = (int)r["levelAccess"]
                     }).ToList(); //this needs to be a list
            sqlcon.Close(); //don't forget to close the connection
            return users;


        }

        public void UpdateUser(Users user)
        {
            //Lets update!!!!
            sqlcon.Open(); //dont forget to open that connection!
            string update = "UPDATE User_Info SET Id = @id, Username = @username, Password = @password, Email = @email, firstName = @first, lastName = @last, levelAccess = @level WHERE Id = @id"; //update where ID's are equal
            SqlCommand command = new SqlCommand(update, sqlcon);
            command.Parameters.AddWithValue("@id", user.Id);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@first", user.Fname);
            command.Parameters.AddWithValue("@last", user.Lname);
            command.Parameters.AddWithValue("@level", user.LevelAccess);

            command.ExecuteNonQuery();
            sqlcon.Close();
        }

        public void UpdateTicket(Tickets ticket)
        {
            sqlcon.Open();
            string update = "UPDATE tickets SET ID = @id, date_accessed = @date, ticket_status = @status, description = @desc WHERE ID = @id";
            SqlCommand command = new SqlCommand(update, sqlcon);
            command.Parameters.AddWithValue("@id", ticket.TicketID);
            command.Parameters.AddWithValue("@date", ticket.DateAccessed);
            command.Parameters.AddWithValue("@status", ticket.TicketStatus);
            command.Parameters.AddWithValue("@desc", ticket.Description);

            command.ExecuteNonQuery();
            sqlcon.Close();
        }

        //TODO: Function for adding new note to note table.
        public void AddNote(int ticketId)
        {
            sqlcon.Open();

        }

        //TODO: Function for getting notes for a particular ticket
        public List<Notes> GetNotes(int ticketID)
        {

        }
    }
}
