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

/// <summary>
/// Authors:Myles Wright, Matthew O'hern, Parker Winters, and Nick Stitely
/// </summary>

namespace unnamedProject.Forms
{
    public partial class SplashScreen : Form
    {
        private const string Filename = @"ROGFONTS-REGULAR.OTF"; //filename of the font we want
        string path = Path.Combine(Environment.CurrentDirectory, Filename); //the current directory will be bin/debug, so I added the actual font file to the debug file
        
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
            
            //PrivateFontCollection privateFont = new PrivateFontCollection(); //create new private font collection
            //privateFont.AddFontFile(path);          //add the file path of the font to the collection
            //FontFamily fontFamily = privateFont.Families[0];        //set the fontfamily to the index of the font file that we want
            //Font rogFont = new Font(fontFamily, 36, FontStyle.Regular);     //set the font to the previous fontfamily value, set font size, and fontstyle
            //lblTitle.Font = rogFont;        //set font of label
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
