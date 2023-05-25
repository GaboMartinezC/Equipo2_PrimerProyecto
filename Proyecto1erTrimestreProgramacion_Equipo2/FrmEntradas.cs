using BL;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public FrmEntradas()
        {
            InitializeComponent();
            CargarComboBox();
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
        private void dgvProductosEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
