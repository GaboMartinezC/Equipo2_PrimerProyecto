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
    public partial class AutorGUI : Form
    {
        public AutorGUI()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelBTNBuscarProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {

        }

        private void panelNuevoProveedor_Click(object sender, EventArgs e)
        {


        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            FrmNuevoAutor f = new FrmNuevoAutor();
            AutorGUI a = new AutorGUI();
            f.Location = a.Location;
            f.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarAutor f = new FrmBuscarAutor();    
            AutorGUI a = new AutorGUI();    
            f.Location = a.Location;
            f.Show();
        }
    }
}
