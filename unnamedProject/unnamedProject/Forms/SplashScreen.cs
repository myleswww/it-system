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
using System.Drawing.Text;
using System.IO;

namespace unnamedProject.Forms
{
    public partial class SplashScreen : Form
    {
        
        
        System.Windows.Forms.Timer tmr;
        public SplashScreen()
        {
            InitializeComponent();
           
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new System.Windows.Forms.Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            var login = new Thread(() => Application.Run(new LoginForm()));
            login.Start();
            
            //hide this form
            
            Thread th = Thread.CurrentThread;
            th.Abort();
            this.Close();

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
