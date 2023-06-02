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
            ApplicationConfiguration.Initialize();
            Application.Run(new GUI.LoginGUI());
            /*
            DetalleEntradaBL bl = new DetalleEntradaBL();
            DetalleEntrada b1 = new DetalleEntrada();
            b1.IdProducto = 1;
            b1.Cantidad = 200;
            DetalleEntrada b2 = new DetalleEntrada();
            b2.IdProducto = 2;
            b2.Cantidad = 10;
            Bodega b3 = new Bodega();
            b3.IdProducto = 2;
            b3.Cantidad = 10;
            b3.IdSucursal = 1;
            List<DetalleEntrada> ls = new List<DetalleEntrada>();
            ls.Add(b2);
            //ls.Add(b2);
            if (bl.IngresarDetalleEntrada(ls, 1)==0)
                MessageBox.Show("1");
            else MessageBox.Show("2");
            DetalleEntradaBL bl = new DetalleEntradaBL();
            Bodega b = new Bodega();
            b.IdProducto = 2;
            b.IdSucursal = 1;
            MessageBox.Show(bl.BuscarProductoSucursal(b).ToString());*/
        }
    }
}
