using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Formularios;

namespace P1_GestionListaMusical
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Formularios.FrmMain());
        }
    }
}