using BL;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmEntradas : Form
    {
        List<DetalleEntrada> listaDetalles;
        SucursalesBL sucursalBl = new SucursalesBL();
        ProductoBL productoBl = new ProductoBL();
        DataTable sucursales;
        DataTable productos;
        DataTable lsDetalles;
        Empleado empleadoResponsable = new ();
        public FrmEntradas(Empleado e)
        {
            InitializeComponent();
            CargarComboBox();
            this.empleadoResponsable = e;
            FormatoDT();
        }
        private void FormatoDT()
        {
            lsDetalles = new();
            DataColumn dcProducto = new("Producto");
            DataColumn dcSucursal = new("Sucursal");
            DataColumn dcCantidad= new("Cantidad");
            lsDetalles.Columns.Add(dcProducto);
            lsDetalles.Columns.Add(dcSucursal);
            lsDetalles.Columns.Add(dcCantidad);
            dgvProductosEntrada.DataSource = lsDetalles;
            dgvProductosEntrada.Columns[0].Width = 205;
            dgvProductosEntrada.Columns[1].Width = 205;
            dgvProductosEntrada.Columns[2].Width = 205;
        }
        private void CargarComboBox()
        {
            sucursales = sucursalBl.BuscarTodoSucursal();
            productos = productoBl.BuscarTodoProductoGeneral();
            for (int i = 0; i < productos.Rows.Count; i++)
            {
                //se agregan todas las descripciones de producto como una opcion
                cbxProductos.Items.Add((string)productos.Rows[i]["descripcion"]);
            }
            for (int i = 0; i < sucursales.Rows.Count; i++)
            {
                //se agregan todas las ubicaciones de sucursal como una opcion
                cbxSucursales.Items.Add((string)sucursales.Rows[i]["ubicacion"]);
            }
        }
        private void pbxAgregarDetalle_Click(object sender, EventArgs e)
        {
            DetalleEntrada de = new DetalleEntrada();
            EncabezadoEntrada ee = new EncabezadoEntrada(); 
            string ubi = cbxSucursales.Text;
            string prod = cbxProductos.Text;
            productos = productoBl.BuscarTodoProductoGeneral();
            sucursales = sucursalBl.BuscarTodoSucursal();
            for (int i = 0; i < sucursales.Rows.Count; i++)
            {
                if ((string)sucursales.Rows[i]["ubicacion"] == ubi)
                    ee.IdSucursal = Convert.ToUInt32(sucursales.Rows[i]["id"]);
            }
            for(int i = 0;i < productos.Rows.Count;i++)
            {
                if ((string)productos.Rows[i]["descripcion"] == prod)
                    de.IdProducto = Convert.ToUInt32(productos.Rows[i]["id"]);
                    
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
