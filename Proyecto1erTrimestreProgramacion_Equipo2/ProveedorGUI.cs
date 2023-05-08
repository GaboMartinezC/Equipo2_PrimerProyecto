using BL;
using ET;
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
    public partial class ProveedorGUI : Form
    {
        private ProveedorBL bl = new ProveedorBL();
        private DataTable dtProducto;
        public ProveedorGUI()
        {
            InitializeComponent();
            FormatoDT();
        }
        private void FormatoDT()
        {
            try
            {
                this.dtProducto = bl.BuscarTodo();
                this.dgvTodosProveedor.DataSource = dtProducto;
                for (int i = 0; i < 5; i++)
                    this.dgvTodosProveedor.Columns[i].ReadOnly = true;
                this.dgvTodosProveedor.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
        }

        private void panelBTNBuscarProveedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {
            // se instancia un nuevo form de ingreso de proveedor
            FrmNuevoProveedor f = new FrmNuevoProveedor();
            // se instancia un form de proveedor
            ProveedorGUI p = new ProveedorGUI();
            // el proposito de esta instancia es porder obtener su posición
            f.Location = p.Location;
            // se muestra el form de ingreso de proveedor
            f.Show();
        }

        private void btnNuevoProveedor_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarProveedor f = new FrmBuscarProveedor();
            ProveedorGUI p = new ProveedorGUI();
            f.Location = p.Location;
            f.Show();
        }
    }
}
