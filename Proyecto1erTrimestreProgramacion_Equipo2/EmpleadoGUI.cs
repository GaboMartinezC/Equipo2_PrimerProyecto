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
    public partial class EmpleadoGUI : Form
    {
        private EmpleadoBL bl = new EmpleadoBL();
        private DataTable dt = new DataTable();
        public EmpleadoGUI()
        {
            InitializeComponent();
            FormatoDT();
        }
        private void FormatoDT()
        {
            try
            {
                this.dt = bl.BuscarTodos();
                this.dgvEmpleado.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {
            FrmNuevoEmpleado f = new FrmNuevoEmpleado();
            EmpleadoGUI em = new EmpleadoGUI();
            f.Location = em.Location;
            f.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarEmpleado f = new FrmBuscarEmpleado();
            EmpleadoGUI em = new EmpleadoGUI();
            f.Location = em.Location;
            f.Show();
        }
    }
}
