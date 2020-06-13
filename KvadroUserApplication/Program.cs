using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace KvadroUserApplication
{
    static class SQLRequestsData
    {
      //  public static string conStr = @"Data Source=DESKTOP-QA4157T\SQLEXPRESS;Initial Catalog=KvadroDataBase;Integrated Security=True";
        public static string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\KvadroDataBase.mdf;Integrated Security = True; Connect Timeout = 30";
    }

    static class Program
    {
        static Mutex m_mutex;
        static bool InstanceExists()
        {
            bool createdNew;
            m_mutex = new Mutex(false, "OneInstanceApplication", out createdNew);
            return (!createdNew);
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (InstanceExists())
            {
                MessageBox.Show("Вы не можете запустить вторую копию приложения!","Запуск приложения");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
