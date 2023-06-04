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
            FormatoDT("0");
        }
        private void FormatoDT(string cedula)
        {
            try
            {
                if (cedula.Equals("0"))
                {
                    this.dt = bl.BuscarTodos();
                    this.dgvEmpleado.DataSource = dt;
                    for (int i = 0; i < dgvEmpleado.ColumnCount; i++)
                        this.dgvEmpleado.Columns[i].ReadOnly = true;
                }
                else
                {
                    for (int i = 0; i<dt.Rows.Count; i++)
                    {
                        char[] ced = dt.Rows[i]["CEDULA"].ToString().ToCharArray();
                        char[] cedComparar = cedula.ToCharArray();
                        for (int j = 0; j<cedComparar.Length; j++)
                        {
                            if (ced[j] != cedComparar[j])
                                dt.Rows[i].Delete();
                        }
                    }
                    this.dgvEmpleado.DataSource = dt;
                    for (int i = 0; i < dgvEmpleado.ColumnCount; i++)
                        this.dgvEmpleado.Columns[i].ReadOnly = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado f = new FrmNuevoEmpleado();
            EmpleadoGUI em = new EmpleadoGUI();
            f.Location = em.Location;
            f.Show();
        }
        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            String txtCedBuscar = txtBuscarEmpleado.Text;
            FormatoDT(txtCedBuscar);
        }

        private int btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            String txtCedBuscar = txtBuscarEmpleado.Text;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["CEDULA"].ToString().Equals(txtCedBuscar))
                {
                    FrmBuscarEmpleado b = new FrmBuscarEmpleado();
                    EmpleadoGUI em = new EmpleadoGUI();
                    b.Location = em.Location;
                    b.Show();
                    return 0;
                }
            }
            MessageBox.Show("No encontrado");
            return 0;
        }
    }
}
