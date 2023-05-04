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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Principal()
        {
            InitializeComponent();
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
    }
}
