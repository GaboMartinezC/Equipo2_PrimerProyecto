using BL;
using Proyecto1erTrimestreProgramacion_Equipo2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SucursalGUI : Form
    {
        SucursalesBL bl = new SucursalesBL();
        DataTable dt;
        public SucursalGUI()
        {
            InitializeComponent();
            FormatoDT();
        }
        private void FormatoDT()
        {
            dt = bl.BuscarTodoSucursal();
            dgvSucursales.DataSource = dt;  
            for(int i=0; i <4 ;i++)
            {
                dgvSucursales.Columns[i].ReadOnly = true;
            }
        }
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void panelBTNBuscarProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {
            FrmNuevoSucursal f = new FrmNuevoSucursal();
            SucursalGUI s = new SucursalGUI();
            f.Location = s.Location;
            f.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarSucursal f = new FrmBuscarSucursal();
            SucursalGUI s = new SucursalGUI();
            f.Location = s.Location;
            f.Show();
        }
    }
}
