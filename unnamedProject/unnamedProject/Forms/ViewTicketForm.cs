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
        dbHandler handler = new dbHandler();
        Users current;
        Tickets ticket;
        Users contact;
        List<Notes> notes;

        public ViewTicketForm(Users cur, Tickets tick)
        {
            InitializeComponent();
            current = cur;
            ticket = tick;
            contact = handler.LoadUserInfoFromDb(tick.UserInfo);
        }

        private void ViewTicketForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = ticket.Description;
            lblContact.Text = "Contact: " + contact.Username;
            label2.Text = ticket.DateAccessed.ToString();
            if(ticket.Assigned != -1)
                l.Text = ticket.Assigned.ToString();
            else
                l.Text = "unassigned";
            notes = handler.GetNotes(ticket.TicketID);
            listBox1.Items.AddRange(notes.ToArray());
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
