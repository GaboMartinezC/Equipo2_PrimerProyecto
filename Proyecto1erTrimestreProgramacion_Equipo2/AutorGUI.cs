using BL;
using ET;
using Proyecto1erTrimestreProgramacion_Equipo2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AutorGUI : Form
    {
        private AutorBL bl = new AutorBL();
        private DataTable dtAutor = null;
        public AutorGUI()
        {
            InitializeComponent();
            FormatoDT();
        }
        private void FormatoDT()
        {
            try
            {
                this.dtAutor = bl.BuscarTodos();
                this.dgvTodosAutor.DataSource = dtAutor;
                for (int i = 0; i < 3; i++)
                    this.dgvTodosAutor.Columns[i].ReadOnly = true;
                this.dgvTodosAutor.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            FrmNuevoAutor f = new FrmNuevoAutor();
            AutorGUI a = new AutorGUI();
            f.Location = a.Location;
            f.Show();
        }
    }
}
