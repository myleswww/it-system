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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var admin = new Thread(() => Application.Run(new AdminForm()));
            admin.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtbxEmail.ReadOnly = false;
            TxtbxPassword.ReadOnly = false;
            TxtbxUsername.ReadOnly = false;
        }
    }
}
