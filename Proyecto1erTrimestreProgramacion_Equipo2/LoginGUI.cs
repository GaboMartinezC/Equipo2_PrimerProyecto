using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }
        private bool ValidarCampos()
        {
            if (txtUsuario.Text.Equals(string.Empty) || txtContrasena.Text.Equals(string.Empty))
                return true;
            else return false;
        }
        private bool ValidarUsuario()
        {
            EmpleadoBL bl = new EmpleadoBL();
            if (bl.BuscarEmpleado(txtUsuario.Text, txtContrasena.Text) != 0)
                return true;
            else
                return false;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
             
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pbxIngresar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos() && ValidarUsuario())
            {
                Principal principal = new Principal();
                principal.Show();
            }
        }
        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
