namespace GUI
{
    partial class ProductoGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoGUI));
            panelNuevoProveedor = new Panel();
            btnNuevoProveedor = new PictureBox();
            panel1 = new Panel();
            txtBusqueda = new TextBox();
            dgvTodosProductos = new DataGridView();
            btnBuscarProveedor = new PictureBox();
            panelBTNBuscarProveedor = new Panel();
            panelNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNuevoProveedor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodosProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).BeginInit();
            panelBTNBuscarProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelNuevoProveedor
            // 
            panelNuevoProveedor.Controls.Add(btnNuevoProveedor);
            panelNuevoProveedor.Dock = DockStyle.Left;
            panelNuevoProveedor.Location = new Point(0, 0);
            panelNuevoProveedor.Name = "panelNuevoProveedor";
            panelNuevoProveedor.Size = new Size(151, 570);
            panelNuevoProveedor.TabIndex = 0;
            panelNuevoProveedor.Paint += panelNuevoProveedor_Paint;
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.Image = (Image)resources.GetObject("btnNuevoProveedor.Image");
            btnNuevoProveedor.Location = new Point(43, 25);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(70, 84);
            btnNuevoProveedor.SizeMode = PictureBoxSizeMode.Zoom;
            btnNuevoProveedor.TabIndex = 0;
            btnNuevoProveedor.TabStop = false;
            btnNuevoProveedor.Click += btnNuevoProveedor_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBusqueda);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(151, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 78);
            panel1.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.LightGray;
            txtBusqueda.Dock = DockStyle.Bottom;
            txtBusqueda.Location = new Point(0, 55);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Ingrese el producto que desea buscar";
            txtBusqueda.Size = new Size(530, 23);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // dgvTodosProductos
            // 
            dgvTodosProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodosProductos.Location = new Point(157, 118);
            dgvTodosProductos.Name = "dgvTodosProductos";
            dgvTodosProductos.RowHeadersWidth = 51;
            dgvTodosProductos.RowTemplate.Height = 25;
            dgvTodosProductos.Size = new Size(520, 370);
            dgvTodosProductos.TabIndex = 3;
            dgvTodosProductos.CellContentClick += dgvTodosProductos_CellContentClick;
            dgvTodosProductos.Paint += dgvTodosProductos_Paint;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Image = (Image)resources.GetObject("btnBuscarProveedor.Image");
            btnBuscarProveedor.Location = new Point(18, 36);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(41, 60);
            btnBuscarProveedor.SizeMode = PictureBoxSizeMode.Zoom;
            btnBuscarProveedor.TabIndex = 0;
            btnBuscarProveedor.TabStop = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // panelBTNBuscarProveedor
            // 
            panelBTNBuscarProveedor.Controls.Add(btnBuscarProveedor);
            panelBTNBuscarProveedor.Dock = DockStyle.Right;
            panelBTNBuscarProveedor.Location = new Point(681, 0);
            panelBTNBuscarProveedor.Name = "panelBTNBuscarProveedor";
            panelBTNBuscarProveedor.Size = new Size(119, 570);
            panelBTNBuscarProveedor.TabIndex = 1;
            // 
            // ProductoGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 243);
            ClientSize = new Size(800, 570);
            Controls.Add(dgvTodosProductos);
            Controls.Add(panel1);
            Controls.Add(panelBTNBuscarProveedor);
            Controls.Add(panelNuevoProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductoGUI";
            Text = "ProductoGUI";
            panelNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnNuevoProveedor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodosProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).EndInit();
            panelBTNBuscarProveedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNuevoProveedor;
        private PictureBox btnNuevoProveedor;
        private Panel panel1;
        private TextBox txtBusqueda;
        private DataGridView dgvTodosProductos;
        private PictureBox btnBuscarProveedor;
        private Panel panelBTNBuscarProveedor;
    }
}