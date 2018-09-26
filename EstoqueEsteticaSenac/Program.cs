using System;
using System.Windows.Forms;
using EstoqueEsteticaSenac.Forms;
using EstoqueEsteticaSenac.Forms.Cadastro;

namespace EstoqueEsteticaSenac
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
            Application.Run(new Splash());
        }
    }
}
