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
using System.Data.SqlClient;

namespace unnamedProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logIn = new Thread(() => Application.Run(new LoginForm()));
            logIn.Start();
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reg = new Thread(() => Application.Run(new register()));
            reg.Start();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {   if (optionPanel.Visible == false)
            {
                optionPanel.Show();
            }
            else if(optionPanel.Visible == true)
            {
                optionPanel.Hide();
            }

        }
    }
}
