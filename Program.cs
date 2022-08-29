using Order_Management_System___OODJ.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Order_Management_System___OODJ
{
    internal static class Program
    {
        private static Utils utils = new Utils(); 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            utils.seedOrdersData();
            utils.seedAdminUserData();
            utils.seedProductsData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
