using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
        List<Users> allUsers;
        Users assignedMember;
        int assignedIndex;

        public ViewTicketForm(Users cur, Tickets tick)
        {
            InitializeComponent();
            current = cur;
            ticket = tick;
            contact = handler.LoadUserInfoFromDb(tick.UserInfo);
            if (ticket.Assigned != -1)
                assignedMember = handler.LoadUserInfoFromDb(tick.Assigned);
        }

        private void ViewTicketForm_Load(object sender, EventArgs e)
        {
            LblID.Text = "ID: "+ ticket.TicketID;
            richTextBox1.Text = ticket.Description;
            lblContact.Text = "Contact: " + contact.Username;
            label2.Text = ticket.DateAccessed.ToString();
            allUsers = handler.LoadAll();
            foreach (Users user in allUsers)
            {
                comboBox1.Items.Add(user.Id);
            }
            if (ticket.Assigned != -1)
            {
                l.Text = assignedMember.Username;
                assignedIndex = comboBox1.Items.IndexOf(assignedMember.Id);
                comboBox1.SelectedIndex = assignedIndex;
            }
            else
            {
                l.Text = "unassigned";
                assignedIndex = -1;
            }
            notes = handler.GetNotes(ticket.TicketID);
            listBox1.Items.AddRange(notes.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ticket.Assigned != -1)
            {
                if (current.Id == assignedMember.Id)
                {
                    if (richTextBox2.Text != "")
                    {
                        Notes newnote = new Notes(current.Id, ticket.TicketID, DateTime.Now, richTextBox2.Text);
                        handler.AddNote(newnote);
                        MessageBox.Show("Your note has been submitted!");
                        listBox1.Items.Clear();
                        notes = handler.GetNotes(ticket.TicketID);
                        listBox1.Items.AddRange(notes.ToArray());
                    }
                    if (richTextBox1.Text != "")
                    {
                        ticket.Description = richTextBox1.Text;
                        handler.UpdateTicket(ticket);
                    }
                }
            }
            if (current.LevelAccess == 0 || current.LevelAccess == 1)
            {
                ticket.Assigned = (int)comboBox1.SelectedItem;
                handler.UpdateTicket(ticket);
                assignedMember = handler.LoadUserInfoFromDb(ticket.Assigned);
                l.Text = assignedMember.Username;
            }
        }


        private void btnEmail_Click(object sender, EventArgs e)
        {
            string subject = "Your Ticket has been updated!";
            string body = String.Format("<p> Your Ticket has been updated! <br>" +
                           "Ticket ID: {0} <br>" +
                           "Description: {1} <br>" +
                           "{3} <p>"
                           , ticket.TicketID, ticket.Description, richTextBox2.Text);

            EmailSend send = new EmailSend(contact.Email, subject, body);
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


        private void back_Click_1(object sender, EventArgs e)
        {
            var admin = new Thread(() => Application.Run(current.getForm()));
            admin.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void minimizeBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Notes selectedNote = notes[listBox1.SelectedIndex];
                richTextBox2.Text = selectedNote.getNoteInfo();
            }
            catch { }
        }
    }
}
