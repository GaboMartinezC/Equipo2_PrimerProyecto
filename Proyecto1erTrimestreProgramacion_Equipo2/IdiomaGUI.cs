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
    public partial class IdiomaGUI : Form
    {
        public IdiomaGUI()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e) 
        { 

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IdiomaGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarIdioma f = new FrmBuscarIdioma();
            IdiomaGUI i = new IdiomaGUI();
            f.Location = i.Location;
            f.Show();
        }

        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {
            FrmNuevoidioma f = new FrmNuevoidioma();
            IdiomaGUI i = new IdiomaGUI();
            f.Location = i.Location;    
            f.Show();   
        }
    }
}
