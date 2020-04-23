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
        public List<Report> reports;

        public ViewReportsForm(Users cur)
        {
            InitializeComponent();
            current = cur;
        }

        private void ViewReportsForm_Load(object sender, EventArgs e)
        { 
            dbHandler handler = new dbHandler();
            reports = handler.GetReports();
            LstBxReports.Items.AddRange(mergeSort(reports.ToArray(),0,reports.Count()-1,0));
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new Thread(() => Application.Run(new Forms.GenerateReportForm(current)));
            form.Start();

            Thread th = Thread.CurrentThread;
            th.Abort();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public Report[] merge(Report[] a, int first, int middle, int last, int orderType)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            int i = first;
            int j = middle + 1;
            int index = first;
            Report aUser; 
            Report bUser;
            Report[] c = new Report[a.Count()];

            while (i <= middle && j <= last)
            {
                aUser = a[i];
                bUser = a[j];
                if (orderType == 0)
                {
                    if (aUser.ID > bUser.ID)
                        c[index++] = a[i++];
                    else
                        c[index++] = a[j++];
                }
            }
            if (i > middle)
                while (j <= last)
                    c[index++] = a[j++];
            else
                while (i <= middle)
                    c[index++] = a[i++];
            for (int k = first; k < index; k++)
                a[k] = c[k];
            return a;
        }

        public Report[] mergeSort(Report[] usersArray, int first, int last, int orderType)
        {
            if (first < last)
            {
                int middle = (first + last) / 2;
                mergeSort(usersArray, first, middle, orderType);
                mergeSort(usersArray, (middle + 1), last, orderType);
                merge(usersArray, first, middle, last, orderType);
            }
            return usersArray;
        }

        private void LstBxReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            Report selectedReport = reports[LstBxReports.SelectedIndex];
            this.Hide();

            var form = new Thread(() => Application.Run(new ViewReportForm(current, selectedReport)));

            form.Start();
            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();
        }
    }
}
