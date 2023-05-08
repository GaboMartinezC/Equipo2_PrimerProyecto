using GUI;
using System.Runtime.InteropServices;

namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    public partial class FrmBuscarProducto : Form
    {

        public FrmBuscarProducto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelBusqueda_Click(object sender, EventArgs e)
        {
        }

        private void labelBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelPadreBuscarProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbxEditarProducto_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.ReadOnly)
            {
                //habilita la edición de las textbox
                txtDescripcion.ReadOnly = false;
                txtProveedor.ReadOnly = false;
                txtStockMax.ReadOnly = false;
                txtStockMin.ReadOnly = false;
                txtPrecio.ReadOnly = false;
                cbxEstudiantil.Enabled = false;
            }
            else
            {
                //deshabilita la edición de las textbox
                txtDescripcion.ReadOnly = true;
                txtProveedor.ReadOnly = true;
                txtStockMax.ReadOnly = true;
                txtStockMin.ReadOnly = true;
                txtPrecio.ReadOnly = true;
                cbxEstudiantil.Enabled = true;
            }
        }

        private void cbxEstudiantil_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}