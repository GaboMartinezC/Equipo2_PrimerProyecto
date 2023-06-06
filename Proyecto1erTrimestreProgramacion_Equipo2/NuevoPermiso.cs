using BL;
using ET;
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

namespace GUI
{
    public partial class NuevoPermiso : Form
    {

        public NuevoPermiso()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            RolUsuarioBL rubl = new RolUsuarioBL();
            RolUsuario ru = new RolUsuario();
            uint retValIngRol;
            List<Permisos> listaPermisos = new List<Permisos>();
            ru.Descripcion = txtPermiso.Text.Trim();
            retValIngRol = rubl.IngresarRolUsuario(ru);
            if (retValIngRol != 0)
            {
                if (this.chkDatos.Checked)
                {
                    Permisos pDatos = new Permisos();
                    pDatos.IdRol = retValIngRol;
                    pDatos.IdModulo = 1;
                    listaPermisos.Add(pDatos);
                }
                if (this.chkProveeduria.Checked)
                {
                    Permisos pProveeduria = new Permisos();
                    pProveeduria.IdRol = retValIngRol;
                    pProveeduria.IdModulo = 2;
                    listaPermisos.Add(pProveeduria);
                }
                if (this.chkSucursales.Checked)
                {
                    Permisos pSucursales = new Permisos();
                    pSucursales.IdRol = retValIngRol;
                    pSucursales.IdModulo = 3;
                    listaPermisos.Add(pSucursales);
                }
                if (this.chkProductos.Checked)
                {
                    Permisos pProductos = new Permisos();
                    pProductos.IdRol = retValIngRol;
                    pProductos.IdModulo = 4;
                    listaPermisos.Add(pProductos);
                }
                if (this.chkInventario.Checked)
                {
                    Permisos pInventario = new Permisos();
                    pInventario.IdRol = retValIngRol;
                    pInventario.IdModulo = 5;
                    listaPermisos.Add(pInventario);
                }
                if (this.chkEmpleados.Checked)
                {
                    Permisos pEmpleados = new Permisos();
                    pEmpleados.IdRol = retValIngRol;
                    pEmpleados.IdModulo = 6;
                    listaPermisos.Add(pEmpleados);
                }
                PermisosBL bl = new PermisosBL();
                if(bl.IngresarPermisos(listaPermisos))
                    MessageBox.Show("Datos ingresados correctamente");
            }
            else
                MessageBox.Show("Ha ocurrido un problema");
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
