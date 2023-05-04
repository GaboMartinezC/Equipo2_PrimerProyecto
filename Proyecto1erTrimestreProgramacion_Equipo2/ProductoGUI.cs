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
        public ProductoGUI()
        {
            InitializeComponent();
        }
        private Form active = null;
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void panelBTNBuscarProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFrmNuevoProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoProveedor_Click_1(object sender, EventArgs e)
        {
            /*FrmNuevoProducto f = new FrmNuevoProducto();
            panelFrmNuevoProveedor.Visible= true;
            OpenChildFormInPanel(f);*/
            FrmNuevoProducto f = new FrmNuevoProducto();
            f.Show();
            f.Location = FrmNuevoProducto.btn;
        }
        private void CloseChildForm()
        {
            if(active != null)
            {
                active.Close();
                active = null;
            }
        }
        private void panelNuevoProveedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
