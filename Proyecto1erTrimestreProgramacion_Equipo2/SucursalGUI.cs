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
    public partial class SucursalGUI : Form
    {
        public SucursalGUI()
        {
            InitializeComponent();
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
            SucursalGUI  s = new SucursalGUI();
            f.Location = s.Location;
            f.Show();
        }
    }
}
