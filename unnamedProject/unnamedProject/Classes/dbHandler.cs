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
    {   

        /*
         * 0 - Admin
         * 1 - Report Manager
         * 2 - Support Member
         * 3 - Project Member
         * 4 - Deactivated
         * 
         */

        
        //connection string
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



        public List<Tickets> LoadTicketsFromDb(int status) //loads list of tickets from the db based on what type of ticket we want, 0-3
        {
            //declare a list of Employee objects
            List<Tickets> tickets;

            tickets = new List<Tickets>(); //instantiate the employees list

            try //error handling
            {

                Tickets tempticket;

                sqlcon.Open();
                /*
                 * 0 - new
                 * 1 - open
                 * 2 - FAP
                 * 3 - Closed
                 * 4 - Unassigned
                 */
                string query = "SELECT * FROM tickets WHERE ticket_status = " + status;

                SqlCommand sqlCommand = new SqlCommand(query, sqlcon);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {

                    int ticketID = (int)reader["ID"];
                    int userInfo = (int)reader["User_Info_Id"];
                    DateTime dateAccessed = (DateTime)reader["date_accessed"];
                    int ticketStatus = (int)reader["ticket_status"];
                    string description = (string)reader["description"];
                    string notes = (string)reader["notes"];
                    int assigned = (int)reader["Assigned"];

                    tempticket = new Tickets(ticketID,userInfo,dateAccessed,ticketStatus,description,assigned);

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



        public Users LoadUserInfoFromDb(int currentUserID) //loads a single users info into a current user object
        {
            string username = null;
            string fname = null;
            string lname = null;
            string email = null;
            int levelAccess = 3;

            sqlcon.Close();
            sqlcon.Open();

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
                Users currentUser = new Users(username, fname, lname, email, levelAccess, currentUserID);
                sqlcon.Close();
                return currentUser;
        }



        public List<Users> LoadAll() //loads a list of every single user in the system
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

        public void UpdateLevel(Users user)
        {
            sqlcon.Open(); //dont forget to open that connection!
            string update = "UPDATE User_Info SET Id = @id, levelAccess = @level WHERE Id = @id"; //update where ID's are equal
            SqlCommand command = new SqlCommand(update, sqlcon);
            command.Parameters.AddWithValue("@id", user.Id);
            command.Parameters.AddWithValue("@level", user.LevelAccess);

            command.ExecuteNonQuery();
            sqlcon.Close();
        }



        public void UpdateTicket(Tickets ticket) //updates tickets
        {
            sqlcon.Open();
            string update = "UPDATE tickets SET ID = @id, date_accessed = @date, ticket_status = @status, description = @desc, assigned = @ass WHERE ID = @id";
            SqlCommand command = new SqlCommand(update, sqlcon);
            command.Parameters.AddWithValue("@id", ticket.TicketID);
            command.Parameters.AddWithValue("@date", ticket.DateAccessed);
            command.Parameters.AddWithValue("@status", ticket.TicketStatus);
            command.Parameters.AddWithValue("@desc", ticket.Description);
            command.Parameters.AddWithValue("@ass", ticket.Assigned);

            command.ExecuteNonQuery();
            sqlcon.Close();
        }



        //Function for adding new note to note table.
        public void AddNote(Notes note)
        {
            int newID = 0;
            sqlcon.Open();
            string query = "SELECT MAX(ID) from notes";
            SqlCommand command = new SqlCommand(query, sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //did the db return null?
                if (reader.IsDBNull(0))
                {
                    newID = 1;
                }
                else
                {
                    newID = reader.GetInt32(0);
                    newID++;
                }
            }
            sqlcon.Close();
            
            sqlcon.Open();
            string insert = "INSERT INTO notes (ID, User_Info_Id, tickets_ticketID, date_writtten, note_info) VALUES (@id, @userID, @ticketID, @date, @info)";
            command = new SqlCommand(insert, sqlcon);
            command.Parameters.AddWithValue("@id", newID);
            command.Parameters.AddWithValue("@userID", note.User_Info_Id);
            command.Parameters.AddWithValue("@ticketID", note.tickets_ticketID);
            command.Parameters.AddWithValue("@date", note.date_written);
            command.Parameters.AddWithValue("@info", note.note_info);

            command.ExecuteNonQuery();
            sqlcon.Close();
        }



        //Gets list of notes that match a ticket ID
        public List<Notes> GetNotes(int ticketID)
        {
            string query = "SELECT User_Info_Id, tickets_ticketID, date_writtten, note_info FROM notes WHERE tickets_ticketID = " + ticketID; //selects all rows that have the matching ticket ID which is a foreign key in the notes table
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dataTable = new DataTable("Notes");
            sda.Fill(dataTable);
            List<Notes> noteList = new List<Notes>();
            noteList = (from DataRow r in dataTable.Rows
                        select new Notes()
                        {
                            User_Info_Id = (int)r["User_Info_Id"],
                            tickets_ticketID = (int)r["tickets_ticketID"],
                            date_written = (DateTime)r["date_writtten"],
                            note_info = r["note_info"].ToString()
                        }).ToList();
            sqlcon.Close();
            return noteList;
        }

        public void AddTicket(Tickets ticket)
        {
            
            
                //do max id 
                int newID = 0;
                sqlcon.Open();
                string query = "SELECT MAX(ID) FROM tickets";
                SqlCommand command = new SqlCommand(query, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0)) //does the table have anything in it?
                    {
                        newID = 1;

                    }
                    else
                    {
                        newID = reader.GetInt32(0);
                        newID++;
                    }
                }
                sqlcon.Close();

                ticket.TicketID = newID;



                sqlcon.Open();

                string insert = "INSERT INTO tickets (ID, User_Info_Id, date_accessed, ticket_status, description, notes, priority, assigned) VALUES (@id, @userid, @date, @status, @desc, @notes, @priority, @assigned)";
                command = new SqlCommand(insert, sqlcon);
                command.Parameters.AddWithValue("@id", ticket.TicketID);
                command.Parameters.AddWithValue("@userid", ticket.UserInfo);
                command.Parameters.AddWithValue("@date", ticket.DateAccessed);
                command.Parameters.AddWithValue("@status", ticket.TicketStatus);
                command.Parameters.AddWithValue("@desc", ticket.Description);
            command.Parameters.AddWithValue("@notes", "note");
                command.Parameters.AddWithValue("@priority", ticket.Priority);
                command.Parameters.AddWithValue("@assigned", ticket.Assigned);

                command.ExecuteNonQuery();

                sqlcon.Close();

        }


        //Function for adding new report
        public int AddReport(Report report) //returns the id of the report to be displayed on the form
        {
            //first select max id and assign it to the report
            int newID = 0;
            sqlcon.Open();
            string query = "SELECT MAX(ID) FROM reports";
            SqlCommand command = new SqlCommand(query, sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //did the db return null?
                if (reader.IsDBNull(0))
                {
                    newID = 1;
                }
                else
                {
                    newID = reader.GetInt32(0);
                    newID++;
                }
            }
            sqlcon.Close();

            report.ID = newID;

            sqlcon.Open();
            string insert = "INSERT INTO reports (ID, date_accessed, User_Info_Id, description, type) VALUES (@id, @date, @userid, @desc, @type)";
            command = new SqlCommand(insert, sqlcon);
            command.Parameters.AddWithValue("@id", report.ID);
            command.Parameters.AddWithValue("@date", report.Date);
            command.Parameters.AddWithValue("@userid", report.UserID);
            command.Parameters.AddWithValue("@desc", report.Description);
            command.Parameters.AddWithValue("@type", report.Type);

            command.ExecuteNonQuery();
            sqlcon.Close();
            return report.ID;
        }


        //Function to pull list of reports from database
        public List<Report> GetReports()
        {
            string query = "SELECT * FROM reports";
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable table = new DataTable("Reports");
            sda.Fill(table);
            List<Report> reports = new List<Report>();
            reports = (from DataRow r in table.Rows
                       select new Report()
                       {
                           ID = (int)r["ID"],
                           Date = (DateTime)r["date_accessed"],
                           UserID = (int)r["User_Info_Id"],
                           Description = r["description"].ToString(),
                           Type = (int)r["type"]

                       }).ToList();
            sqlcon.Close();
            return reports;
        }


        //Function to get count of types of tickets
        public int GetTicketCount()
        {
            int count = 0;
            string query = "Select COUNT(*) FROM tickets";
            sqlcon.Open();
            SqlCommand command = new SqlCommand(query, sqlcon);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                count = read.GetInt32(0);
            }
            sqlcon.Close();
            return count;

        }


        public int GetTicketCount(int type)
        {
            int count = 0;
            string query = "Select COUNT(*) FROM tickets WHERE ticket_status = " + type;
            sqlcon.Open();
            SqlCommand command = new SqlCommand(query, sqlcon);
            SqlDataReader read = command.ExecuteReader();
            
            while (read.Read())
            {
                count = read.GetInt32(0);
            }
            sqlcon.Close();
            return count;
            
        }

        //overloaded get ticket function including date
        public int GetTicketCount(DateTime date)
        {
            int count = 0;
            string query = "Select COUNT(*) FROM tickets WHERE date_accessed >= '" + date.ToString() + "'";
            sqlcon.Open();
            SqlCommand command = new SqlCommand(query, sqlcon);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                count = read.GetInt32(0);
            }
            sqlcon.Close();
            return count;
        }


        public int GetPercent(int type) //this function counts all of the tickets and then does math on them using other functions to return to the reports area
        {
            int ticketCount;
            int count = 0;
            string query = "Select COUNT(*) FROM tickets";
            sqlcon.Open();
            SqlCommand command = new SqlCommand(query, sqlcon);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                count = read.GetInt32(0);
            }

            sqlcon.Close();
            
            ticketCount = GetTicketCount(type);


            int percent = ((ticketCount*100)/ count);
            return percent;
        }

        
    }
}
