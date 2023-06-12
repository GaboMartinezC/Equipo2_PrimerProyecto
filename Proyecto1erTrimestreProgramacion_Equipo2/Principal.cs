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
    public partial class Principal : Form
    {
        private Form active = null;
        private Empleado empleadoLogeado;
        //para hacer el drag de la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ValidarPermisos(uint idRol)
        {
            PermisosBL pBl = new PermisosBL();
            bool[] lsPermisos = pBl.BuscarPermisoRol(Convert.ToInt32(idRol));
            if (!lsPermisos[0])
            {
                panelAutor.Visible = false;
                panelIdiomas.Visible = false;
                panelCategoria.Visible = false;
            }
            if (!lsPermisos[1])
                panelProveedor.Visible = false;
            if (!lsPermisos[2])
                panelSucursal.Visible = false;
            if (!lsPermisos[3])
                panelProductos.Visible = false;
            if (!lsPermisos[4])
                btnInventario.Visible = false;
            if (!lsPermisos[5])
                panelEmpleados.Visible = false;
        }
        public Principal(Empleado empleado)
        {
            InitializeComponent();
            this.empleadoLogeado = empleado;
            this.ValidarPermisos(empleado.IdRol);
        }
        private void OpenChildFormInPanel(Form childForm)
        {
            //Si existe un formulario activo lo cierra
            if (active != null)
                active.Close();
            //Iguala el activo al formulario de par�metros
            active = childForm;
            //Da comportamiento de panel al formulario
            childForm.TopLevel = false;
            //Quita las opciones del formulario
            childForm.FormBorderStyle = FormBorderStyle.None;
            //Da un dock completo
            childForm.Dock = DockStyle.Fill;
            //Lo agrega al panel que est� debajo de la imagen de logo
            panelPadre.Controls.Add(childForm);
            //Superpone el formulario
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panelBarraControles_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panelProductos_Click(object sender, EventArgs e)
        {
            ProductoGUI p = new ProductoGUI();
            OpenChildFormInPanel(p);
        }

        private void panelProveedor_Click(object sender, EventArgs e)
        {
            ProveedorGUI p = new ProveedorGUI();
            OpenChildFormInPanel(p);
        }

        private void panelAutor_Click(object sender, EventArgs e)
        {
            AutorGUI a = new AutorGUI();
            OpenChildFormInPanel(a);
        }

        private void panelIdiomas_Click(object sender, EventArgs e)
        {
            IdiomaGUI i = new IdiomaGUI();
            OpenChildFormInPanel(i);
        }

        private void panelCategoria_Click(object sender, EventArgs e)
        {
            CategoriaGUI c = new CategoriaGUI();
            OpenChildFormInPanel(c);    
        }

        private void panelSucursal_Click(object sender, EventArgs e)
        {
            SucursalGUI s = new SucursalGUI();
            OpenChildFormInPanel(s);
        }

        private void panelEmpleados_Click(object sender, EventArgs e)
        {
            EmpleadoGUI em = new EmpleadoGUI(); 
            OpenChildFormInPanel(em);
        }

        private void panelSalir_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelSalir_Click(object sender, EventArgs e)
        {
            if (active != null)
            {
                active.Close();
                active = null;
            }
        }

        private void panelIdiomas_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraControles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmEntradas em = new (this.empleadoLogeado);
            OpenChildFormInPanel(em);
        }
    }
}
