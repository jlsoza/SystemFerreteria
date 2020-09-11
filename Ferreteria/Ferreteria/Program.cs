using Ferreteria.MenuPrincipal;
using Login_Desing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Ferreteria.MenuPrincipal.Menu());
            Application.Run(new Frm_Login());
            //Application.Run(new Frm_Usuario());
        }
    }
}
