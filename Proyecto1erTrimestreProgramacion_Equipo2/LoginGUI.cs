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
            EmpleadoBL em = new EmpleadoBL();
            RolUsuarioBL rol = new RolUsuarioBL();
            DataTable empleados = em.BuscarTodos();
            DataTable roles = rol.BuscarTodo();
            bool retVal = false;
            for(int i = 0; i < empleados.Rows.Count;i++)
            {
                // compara la cedula ingresada con todas las cedulas de empleados en la DB
                if (txtUsuario.Text == empleados.Rows[i]["Cedula"].ToString())
                {
                    // se comprueban todas las contrasenas en la DB con la ingresada
                    if (txtContrasena.Text == empleados.Rows[i]["Contrasena"].ToString())
                    {
                        // si se encontro alguna coincidencia se permite el acceso
                        retVal = true;
                        break;
                    }
                }
                // si no se encontro ninguna coincidencia se niega el acceso
                if(!retVal)
                {
                    MessageBox.Show("Alguno de los datos ingresados es invalido");
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                    txtUsuario.Focus();
                }
                   
                
            }
            return retVal; 
        }
        private bool ValidarPermisos()
        {
            bool retVal = true;
            EmpleadoBL emp = new EmpleadoBL();
            RolUsuarioBL ol = new RolUsuarioBL();
            DataTable empleados = emp.BuscarTodos();
            DataTable roles = ol.BuscarTodo();
            for(int i = 0; i < empleados.Rows.Count; i++)
            {
                for(int j= 0; j < roles.Rows.Count;j++)
                {
                    
                }
                
            }
            return retVal;
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
        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void panelBarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarraSuperior_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void pbxIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && ValidarPermisos())
            {
                Principal principal = new Principal();
                principal.Show();
            }

        }

        private void pbxIngresar_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
