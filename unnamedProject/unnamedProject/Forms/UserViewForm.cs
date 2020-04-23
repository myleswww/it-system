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
        List<Users> us;
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
            us = db.LoadAll();
            LstBxUser.Items.AddRange(us.ToArray());
        }

        public void sortHelp(List<Users> users, int orderType)
        {
            Users[] usersArray= new Users[users.Count()];
            for (int i=0; i<users.Count(); i++)
            {
                usersArray[i] = users.ElementAt(i);
            }
           usersArray= mergeSort(usersArray, 0, users.Count-1, orderType);
            LstBxUser.Items.AddRange(usersArray);
        }

        public Users[] merge(Users[] a, int first, int middle, int last, int orderType)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            int i = first;
            int j = middle + 1;
            int index = first;
            Users aUser;
            Users bUser;
            Users[] c = new Users[a.Count()];

            while (i <= middle && j <= last)
            {
                aUser = a[i];
                bUser = a[j];
                if (orderType == 0) { 
                    if (aUser.GetId() < bUser.GetId())
                        c[index++] = a[i++];
                    else
                        c[index++] = a[j++];
                 }
                else if (orderType == 1)
                {
                    if (comparer.Compare(aUser.GetLname(), bUser.GetLname()) < 0)
                        c[index++] = a[i++];
                    else
                        c[index++] = a[j++];
                }
                else if (orderType == 2)
                {
                    if (comparer.Compare(aUser.GetLname(), bUser.GetLname()) > 0)
                        c[index++] = a[i++];
                    else
                        c[index++] = a[j++];
                }
            }
            if (i > middle)
                while (j <= last)
                    c[index++] = a[j++];
            else
                while (i <= middle)
                    c[index++] = a[i++];
            for (int k = first; k < index; k++)
                a[k] = c[k];
            return a;
        }

        public Users[] mergeSort(Users[] usersArray, int first, int last, int orderType)
        {
            if (first < last)
            {
                int middle = (first + last) / 2;
                mergeSort(usersArray, first, middle, orderType);
                mergeSort(usersArray, (middle + 1), last, orderType);
                merge(usersArray, first, middle, last, orderType);
            }
            return usersArray;
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstBxUser.Items.Clear();
            sortHelp(us, ComboBoxSort.SelectedIndex);

        }

        private void LstBxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Users selectedUser = us[LstBxUser.SelectedIndex];
            var form = new Thread(() => Application.Run(new EditUserForm(selectedUser, current)));

            
            form.Start();

            
        }
    }
}
