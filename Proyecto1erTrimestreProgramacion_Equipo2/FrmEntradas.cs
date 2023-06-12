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
        List<DetalleEntrada> listaDetalles = new();
        SucursalesBL sucursalBl = new SucursalesBL();
        ProductoBL productoBl = new ProductoBL();
        DataTable sucursales;
        DataTable productos;
        DataTable lsDetalles;
        Empleado empleadoResponsable;
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
            this.productos = productoBl.BuscarTodoProductoGeneral();
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

        private void pbxAgregarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleEntrada de = new DetalleEntrada();
                string prod = cbxProductos.Text;
                uint idProd = 0, cantidad = Convert.ToUInt32(txtCantidad.Text);
                bool productoRegistrado = false;
                for (int i = 0; i < productos.Rows.Count; i++)
                {
                    if (productos.Rows[i]["DESCRIPCION"].ToString().Equals(prod))
                        idProd = Convert.ToUInt32(productos.Rows[i]["ID"]);
                }
                foreach (DetalleEntrada d in listaDetalles)
                {
                    if (d.Id == idProd)
                    {
                        productoRegistrado = true;
                        d.Cantidad = d.Cantidad + cantidad;
                        break;
                    }
                }
                if (!productoRegistrado)
                {
                    listaDetalles.Add(new DetalleEntrada
                    {
                        IdProducto = idProd,
                        Cantidad = cantidad
                    });
                    lsDetalles.Rows.Add(prod, cbxSucursales.Text, cantidad.ToString());
                }
                dgvProductosEntrada.DataSource = lsDetalles;
            }
            catch 
            {
                MessageBox.Show("Ha habido un problema, registre solo números");
            }
        }
        private uint ConseguirIdEmpleado()
        {
            EmpleadoBL bl = new();
            DataTable dt = bl.BuscarTodos();
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                if ((string)dt.Rows[i]["CEDULA"] == this.empleadoResponsable.Cedula)
                    return Convert.ToUInt32(dt.Rows[i]["ID"]);
            }
            return 0;
        }
        private void btnRealizarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                EncabezadoEntrada entrada = new();
                EncabezadoEntradaBL bl = new();
                DetalleEntradaBL de = new();
                string sucursal = cbxSucursales.Text;
                entrada.IdEmpleado = ConseguirIdEmpleado();
                for (int i = 0; i < sucursales.Rows.Count; i++)
                {
                    if ((string)sucursales.Rows[i]["UBICACION"] == sucursal)
                        entrada.IdSucursal = Convert.ToUInt32(sucursales.Rows[i]["ID"]);
                }
                if (!de.ValidarDetalleEntrada(listaDetalles, entrada.IdSucursal))
                    MessageBox.Show("Hay un problema con el stock máximo y mínimo, revise correctamente");
                else
                {
                    if(bl.IngresarEntrada(entrada, listaDetalles)) 
                    {
                        MessageBox.Show("Ingreso correcto");
                        cbxSucursales.Text = string.Empty;
                        cbxProductos.Text = string.Empty;
                        txtCantidad.Text = string.Empty;
                    }
                    else
                        MessageBox.Show("Ha sucedido un problema");
                }
            }
            catch
            {
                MessageBox.Show("Ha habido un problema");
            }
            
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            if (pnlRegistro.Visible)
            {
                pnlRegistro.Visible = false;
                btnRealizarEntrada.Visible = true;
            }
            else
            {
                DetalleEntradaBL bl = new();
                dgvRegistro.DataSource = bl.VerTodoRegistroEntradas();
                pnlRegistro.Visible = true;
                btnRealizarEntrada.Visible = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cbxSucursales.Text = string.Empty;
            cbxProductos.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            FormatoDT();
        }
    }
}
