using Pav2022.P2.InfraestructuraTransversal.IoC;
using Pav2022.P2.Presentacion.IoC;
using System;
using System.Windows.Forms;

namespace Pav2022.P2.Presentacion
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new IoCContenedorUnity();
            IoCFabrica.Instancia.SetContenedor(container);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AdministradorDeTareas.Instance.IniciarAplicacion();
            Application.Run(Application.OpenForms[0]);
        }
    }
}
