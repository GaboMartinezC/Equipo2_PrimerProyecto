using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;
using BL;

namespace GUI
{
    public partial class FrmNuevoEmpleado : Form
    {
        public FrmNuevoEmpleado()
        {
            InitializeComponent();
            CargarCombo();
        }
        private void CargarCombo()
        {
            RolUsuarioBL rubl = new RolUsuarioBL();
            DataTable dt = rubl.BuscarTodo();
            cbRolUsuario.DataSource = dt;
            cbRolUsuario.Text = "Rol de Usuario";
            cbRolUsuario.DisplayMember = "DESCRIPCION";
            cbRolUsuario.ValueMember = "ID";
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Equals(string.Empty) || txtNombre.Text.Equals(string.Empty)
                || txtEmail.Text.Equals(string.Empty) || txtContrasena.Text.Equals(string.Empty) ||
                txtTelefono.Text.Equals(string.Empty))
                MessageBox.Show("Es necesario ingresar datos");
            else
            {
                EmpleadoBL bl = new EmpleadoBL();
                Empleado empleado = new Empleado();
                empleado.Cedula = txtCedula.Text;
                empleado.NombreCompleto = txtNombre.Text;
                empleado.Email = txtEmail.Text;
                empleado.Contrasena = txtContrasena.Text;
                empleado.NumeroTelefonico = txtTelefono.Text;
                empleado.IdRol = Convert.ToUInt32((int)cbRolUsuario.SelectedValue);
                if (ContactosUsuarioValidos(empleado))
                {
                    if (bl.IngresarEmpleado(empleado))
                        MessageBox.Show("Datos ingresados Correctamente");
                    else
                        MessageBox.Show("Hubo un problema");
                }
            }
        }
        private bool ContactosUsuarioValidos(Empleado empleado)
        {
            bool retVal = true;
            int cantArroba = 0;
            //Convierte el email del empleado en una arreglo de caracteres
            char[] email = empleado.Email.ToCharArray();
            //Recorre el arreglo
            foreach (char c in empleado.Email)
            {
                //Busca arrobas en el email
                if (c == '@')
                    cantArroba++;
            }
            //Si encuentra más de una o no encuentra, devuelve un falso
            if (cantArroba != 1)
                retVal = false;
            //Valida el que siga sin encontrar ninguna anomalía
            if (retVal)
            {
                //Finalmente, recorre el numero telefonico del empleado
                foreach (char c in empleado.NumeroTelefonico)
                {
                    //Si existe algún elemento que no sea un numero, devuelve falso y sale del ciclo
                    if (!(c >= '0' && c <= '9'))
                    {
                        retVal = false;
                        break;
                    }
                }
            }
            return retVal;
        }
        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            NuevoPermiso f = new NuevoPermiso();
            FrmNuevoEmpleado a = new();
            f.Location = a.Location;
            f.Show();
        }
    }
}
