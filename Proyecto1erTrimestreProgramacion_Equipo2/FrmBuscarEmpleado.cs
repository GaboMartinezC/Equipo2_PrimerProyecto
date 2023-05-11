using System.Runtime.InteropServices;

namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    public partial class FrmBuscarEmpleado : Form
    {
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtCedula.ReadOnly)
            {
                //habilita la edición de las textbox
                txtCedula.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtEstado.ReadOnly = false;
                txtNombre.ReadOnly = false;
                txtRol.ReadOnly = false;
                txtTelefono.ReadOnly = false;
            }
            else
            {
                //deshabilita la edición de las textbox
                txtCedula.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtEstado.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtRol.ReadOnly = true;
                txtTelefono.ReadOnly = true;
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