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
    public partial class CreateTicketForm : Form
    {

        Users current = new Users();
        dbHandler handler = new dbHandler();
        public CreateTicketForm(Users curr)
        {
            InitializeComponent();
            current = curr;
        }

        private void CreateTicketForm_Load(object sender, EventArgs e)
        {
            errorMsg.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Tickets newTick = new Tickets(current.GetId(), DateTime.Now, (4), txtbxSubject.Text, (-1));
                handler.AddTicket(newTick);
                Notes note = new Notes(current.Id, newTick.TicketID, DateTime.Now, txtbxDesc.Text);
                handler.AddNote(note);
                
                if(txtbxSubject.Text == ""||txtbxDesc.Text == "")
                {
                    errorMsg.Visible = true;
                    errorMsg.Text = "Please do not leave fields blank.";
                }
                else
                {
                    errorMsg.Visible = true;
                    errorMsg.Text = "Submitted ticket!";
                }

            }
            catch (Exception)
            {
                errorMsg.Visible = true;
                errorMsg.Text = "Something went terribly wrong.";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            var newForm = new Thread(() => Application.Run(current.getForm()));
            newForm.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }
    }
}
