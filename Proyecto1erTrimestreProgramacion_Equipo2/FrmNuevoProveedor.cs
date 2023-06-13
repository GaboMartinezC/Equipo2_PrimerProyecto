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
    public partial class FrmNuevoProveedor : Form
    {
        public FrmNuevoProveedor()
        {
            InitializeComponent();
        }

        //nuevo proveedor
        public bool IngresarProveedor()
        {
            bool retval = true;
            Proveedor proveedor = new Proveedor();
            ProveedorBL proveedorBL = new ProveedorBL();
            proveedor.Descripcion = txtNombre.Text.ToUpper().Trim();
            proveedor.Email = txtEmail.Text.ToUpper().Trim();
            proveedor.Telefono = txtTelefono.Text.ToUpper().Trim();
            if (chbxEditorial is CheckBox)
            {
                if (((CheckBox)chbxEditorial).Checked)
                {
                    proveedor.EsEditorial = true;
                }
                else
                {
                    proveedor.EsEditorial = false;
                }
            }
            return retval;
        }

        //limpiar la chbx
        public void LimpiarChbx()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtEmail.Text = string.Empty;
            txtEmail.Focus();
            txtTelefono.Text = string.Empty;
            txtTelefono.Focus();

            foreach (Control chbxEditorial in pnlNuevoProveedor.Controls)
            {
                if (chbxEditorial is CheckBox)
                {
                    if (((CheckBox)chbxEditorial).Checked)
                    {
                        ((CheckBox)chbxEditorial).Checked = false;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IngresarProveedor();
            LimpiarChbx();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // drag del form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
