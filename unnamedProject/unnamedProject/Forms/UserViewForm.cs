using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unnamedProject.Forms
{
    public partial class UserViewForm : Form
    {
        Users current;
        public UserViewForm(Users current)
        {
            InitializeComponent();
            this.current = current;
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            var admin = new Thread(() => Application.Run(new AdminForm(current)));
            admin.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void fullBtn_Click(object sender, EventArgs e)
        {
            if (this.Width > 753 || this.Height > 429 || WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void UserViewForm_Load(object sender, EventArgs e)
        {
            dbHandler db = new dbHandler();
            List<Users> us = db.LoadAll();
            LstBxUser.Items.AddRange(us.ToArray());
        }

        //TODO: Write function for sorting by alphabetical order, A-Z
        /*public List<Users> AphabeticalSort(List<Users> users)
        {
            //sort by alphabetical order
        }

        //TODO: Write function for sorting from Z-A
        public List<Users> ReverseAlphabetSort(List<Users> users)
        {

        }

        //TODO: Write function to sort by user ID
        public List<Users> SortByID(List<Users> users)
        {

        }
        */
    }
}
