using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace e_learning_system
{
    static class Program
    {
        public static MySqlConnection conn;
        public static string ordb = "datasource=sql2.freemysqlhosting.net;port=3306;username=sql2360011;password=mD4%jK1*;database=sql2360011";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sign_in());

        }
    }
}
