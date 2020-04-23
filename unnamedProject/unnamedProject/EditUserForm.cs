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

namespace unnamedProject
{
    public partial class EditUserForm : Form
    {
        Users selectedUser, current;
        dbHandler handler;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int newLevel = 5;
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Admin":
                        newLevel = 0;
                        break;
                    case "Project Member":
                        newLevel = 3;
                        break;
                    case "IT Support":
                        newLevel = 2;
                        break;
                    case "Report Manager":
                        newLevel = 1;
                        break;
                    case "Deactivate User":
                        newLevel = 4;
                        break;
                }

                selectedUser.LevelAccess = newLevel;
                handler.UpdateLevel(selectedUser);
            }
            catch (Exception)
            {

            }
            finally
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Changed the role of " + selectedUser.Fname + "!";
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            handler = new dbHandler();
            lblMessage.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        public EditUserForm(Users selected, Users cur)
        {
            InitializeComponent();
            selectedUser = selected;
            current = cur;
        }
    }
}
