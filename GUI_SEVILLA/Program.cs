using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SEVILLA
{
    static class Program
    {
        public static String ConnStr = "";
        public static String OurReportSource = "";
        public static String OurLogSource = "";
        public static String OurImagelocation = "";
        public static String database = "";
        public static String Server = "";
        public static String dbUsername = "";
        public static String dbPassword = "";
        public static DateTime Datetoday = DateTime.Now;
        public static DatabasePicker databasepcker = null;
        [STAThread]
        static void Main()
        {
            databasepcker = new DatabasePicker();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            databasepcker.SetConnctionString();
            Application.Run(new frmLogin());
        }
    }
}
