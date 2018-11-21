using System;
using System.Windows.Forms;
using EstoqueEsteticaSenac.Forms;
using EstoqueEsteticaSenac.Forms.Cadastro;
using EstoqueEsteticaSenac.Forms.Relatorios;


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
            Application.Run(new FormRelatorioDeUsuarios());
        }
    }
}
