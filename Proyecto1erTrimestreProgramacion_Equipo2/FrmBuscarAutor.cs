using System.Runtime.InteropServices;

namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    public partial class FrmBuscarAutor : Form
    {
        public FrmBuscarAutor()
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
            if (txtNombre.ReadOnly)
            {
                //habilita la edición de las textbox
                txtNombre.ReadOnly = false;
                txtApellidos.ReadOnly = false;
            }
            else
            {
                //deshabilita la edición de las textbox
                txtNombre.ReadOnly = true;
                txtApellidos.ReadOnly = true;
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}