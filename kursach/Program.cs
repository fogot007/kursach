using System;
using System.Windows.Forms;

namespace kursach
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var login = new Login();
            Application.Run(login);
            
        }
    }
}
