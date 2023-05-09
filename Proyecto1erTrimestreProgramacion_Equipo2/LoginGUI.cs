using BL;
using ET;
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
        private uint rol;
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
            uint rol = bl.BuscarEmpleado(txtUsuario.Text, txtContrasena.Text);
            if (rol != 0)
            {
                this.rol = rol; 
                return true;
            }
                
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
                Empleado em = new Empleado();
                em.Cedula = txtUsuario.Text;
                em.Contrasena = txtContrasena.Text;
                em.IdRol = this.rol;
                Principal principal = new Principal(em);
                principal.Show();
            }
        }
        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
