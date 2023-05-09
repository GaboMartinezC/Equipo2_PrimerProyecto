using ET;
using BL;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Permissions;
using Accessibility;
namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Empleado empleado = new Empleado();
            empleado.IdRol = 1;
            //Application.Run(new GUI.LoginGUI());
            Application.Run(new GUI.Principal(empleado));
        }
    }
}
