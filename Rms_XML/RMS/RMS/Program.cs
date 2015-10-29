using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RMS
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
          //Application.Run(new Xml());
          // Application.Run(new Rms_Set_Limit());


          // Application.Run(new Rms_Set_Limit_Create());
          Application.Run(new Xml());
          //  Application.Run(new Rms_Set_Limit());
            //Client_Details.cs

            //Application.Run(new Fo_Banned_symbols());
          // Application.Run(new RepositionColumns());


           //Application.Run(new Select());
            //Application.Run(new Form1());

           // Application.Run(new Form3());

           // Application.Run(new Display_loggedin_users());


        }
    }
}
