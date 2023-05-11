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
    public partial class CategoriaGUI : Form
    {
        public CategoriaGUI()
        {
            InitializeComponent();
        }
        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {
            FrmNuevoCategoria f = new FrmNuevoCategoria();
            CategoriaGUI c = new CategoriaGUI();
            f.Location = c.Location;
            f.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarCategoria f = new FrmBuscarCategoria();
            CategoriaGUI c = new CategoriaGUI();
            f.Location = c.Location;
            f.Show();
        }
    }
}
