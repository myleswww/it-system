using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unnamedProject.Forms
{
    public partial class ViewTicketForm : Form
    {
        dbHandler handler;
        Users current;
        Tickets ticket;
        Users contact;
        public ViewTicketForm(Users cur, Tickets tick)
        {
            InitializeComponent();
            current = cur;
            ticket = tick;
            contact = handler.LoadUserInfoFromDb(tick.UserInfo);
        }

        private void ViewTicketForm_Load(object sender, EventArgs e)
        {
            txtBxDescription.Text = ticket.Description;
            lblContact.Text = "Contact: " + contact.Username;
            label2.Text = ticket.DateAccessed.ToString();
        }

        private void txtBxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void l_Click(object sender, EventArgs e)
        {

        }
    }
}
