using ET;
using BL;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Permissions;
using Accessibility;
using DAL;

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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new GUI.LoginGUI());
            Bodega b = new Bodega();
            BodegaBL bl = new BodegaBL();
            b.IdProducto = 1;
            b.IdSucursal = 1;
            uint i = bl.BuscarProductoSucursal(b).Cantidad;
            MessageBox.Show(i.ToString());
        }
    }
}
