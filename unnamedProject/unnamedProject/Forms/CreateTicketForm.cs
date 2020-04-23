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

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Tickets newTick = new Tickets(current.GetId(), DateTime.Now, (4), txtbxDesc.Text, (-1));
            handler.AddTicket(newTick);
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
