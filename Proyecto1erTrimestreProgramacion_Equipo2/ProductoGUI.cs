using BL;
using Proyecto1erTrimestreProgramacion_Equipo2;
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
    public partial class ProductoGUI : Form
    {
        private ProductoBL bl = new ProductoBL();
        private DataTable dtProducto;

        public ProductoGUI()
        {
            InitializeComponent();
            FormatoDT();
        }
        private void FormatoDT()
        {
            try
            {
                this.dtProducto = bl.BuscarTodoProductoGeneral();
                this.dgvTodosProductos.DataSource = dtProducto;
                for (int i = 0; i < 10; i++)
                    this.dgvTodosProductos.Columns[i].ReadOnly = true;
                this.dgvTodosProductos.Columns[10].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {
            /*FrmNuevoProducto f = new FrmNuevoProducto();
            panelFrmNuevoProveedor.Visible= true;
            OpenChildFormInPanel(f);*/
            // se instancia un nuevo form de ingreso de producto
            FrmNuevoProducto f = new FrmNuevoProducto();
            // se instancia un form de producto
            ProductoGUI p = new ProductoGUI();
            // el proposito de esta instancia es porder obtener su posición
            f.Location = p.Location;
            // se muestra el form de ingreso de producto
            f.Show();

        }

        private void btnIngresarEntradas_Click(object sender, EventArgs e)
        {
            /*FrmEntradas f = new FrmEntradas();
            // se instancia un form de producto
            ProductoGUI p = new ProductoGUI();
            // el proposito de esta instancia es porder obtener su posición
            f.Location = p.Location;
            // se muestra el form de ingreso de producto
            f.Show();*/
        }
    }
}
