using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaverecnyProjektIT4_2023.classes;

namespace ZaverecnyProjektIT4_2023
{
    internal static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            User user = formLogin.LoggedUser;
            if (user != null)
            {
                Application.Run(new FormMain(user));
            }
        }
    }
}
