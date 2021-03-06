using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Authors:Myles Wright, Matthew O'hern, Parker Winters, and Nick Stitely
/// </summary>

namespace unnamedProject
{
   
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread prim = new Thread(() => Application.Run(new Forms.SplashScreen()));
            prim.Start();
        }
    }
}
