using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace unnamedProject
{
    public partial class ViewReportsForm : Form
    {
        Users current;
        public ViewReportsForm(Users cur)
        {
            InitializeComponent();
            current = cur;
        }

        private void ViewReportsForm_Load(object sender, EventArgs e)
        { 
            dbHandler handler = new dbHandler();
            List<Report> reports = handler.GetReports();
            LstBxReports.Items.AddRange(reports.ToArray());
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new Thread(() => Application.Run(new Forms.GenerateReportForm(current)));
            form.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }
    }
}
