using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace client_details
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
         Application.Run(new Form1());
         // Application.Run(new User_Input2());

          //  Application.Run(new RepositionColumns());
            //Application.Run(new VisibleColumns());
           // Application.Run(new Token_Dlg2());
            

        }
    }
}
