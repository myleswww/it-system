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
    public partial class ViewExistingProblems : Form
    {
        Users current;
        List<Tickets> tickets;
        public void ViewExistingProblems_Load(object sender, EventArgs e)
        {
            dbHandler handler = new dbHandler();
            tickets = handler.LoadTicketsFromDb(4);
            LstBxProblems.Items.AddRange(tickets.ToArray());
        }
        public ViewExistingProblems(Users current)
        {
            InitializeComponent();
            this.current = current;
        }

        private void back_Click(object sender, EventArgs e)
        {
            var admin = new Thread(() => Application.Run(current.getForm()));
            admin.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fullBtn_Click(object sender, EventArgs e)
        {
            if (this.Width > 1067 || this.Height > 554 || WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal; //All of this is for the button itself
                fullBtn.FlatAppearance.BorderSize = 1;
                fullBtn.Width = 15;
                fullBtn.Height = 12;
                fullBtn.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
                fullBtn.ImageIndex = -1;
                LstBxProblems.Width = this.Width;

                //screen scaling

            }
            else
            {
                WindowState = FormWindowState.Maximized;
                fullBtn.ImageIndex = 0;
                fullBtn.FlatAppearance.BorderSize = 0;
                fullBtn.Width = 15;
                fullBtn.Height = 15;

                //screen scaling

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void LstBxProblems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Tickets selectedTicket = tickets[LstBxProblems.SelectedIndex];
                this.Hide();

                var form = new Thread(() => Application.Run(new Forms.ViewTicketForm(current, selectedTicket)));

                form.Start();
                Thread th = Thread.CurrentThread;
                th.Abort();
                this.Close();
            }
            catch { }
        }
    }
}
