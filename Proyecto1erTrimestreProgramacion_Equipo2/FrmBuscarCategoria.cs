using System.Runtime.InteropServices;

namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    public partial class FrmBuscarCategoria : Form
    {
        public FrmBuscarCategoria()
        {
            InitializeComponent();
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.ReadOnly)
            {
                //habilita la edición de las textbox
                txtDescripcion.ReadOnly = false;
                cbxEsGenero.Enabled = false;
            }
            else
            {
                //deshabilita la edición de las textbox
                txtDescripcion.ReadOnly = true;
                cbxEsGenero.Enabled = true;
            }
        }
    }
}