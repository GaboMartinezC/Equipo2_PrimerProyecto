namespace GUI
{
    partial class FrmEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradas));
            cbxSucursales = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            dgvProductosEntrada = new DataGridView();
            btnRealizarEntrada = new Button();
            cbxProductos = new ComboBox();
            pbxAgregarDetalle = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductosEntrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAgregarDetalle).BeginInit();
            SuspendLayout();
            // 
            // cbxSucursales
            // 
            cbxSucursales.FormattingEnabled = true;
            cbxSucursales.Location = new Point(397, 36);
            cbxSucursales.Name = "cbxSucursales";
            cbxSucursales.Size = new Size(163, 23);
            cbxSucursales.TabIndex = 4;
            cbxSucursales.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 38);
            label1.Name = "label1";
            label1.Size = new Size(202, 16);
            label1.TabIndex = 2;
            label1.Text = "Seleccione en que sucursal ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 77);
            label2.Name = "label2";
            label2.Size = new Size(149, 16);
            label2.TabIndex = 5;
            label2.Text = "Ingrese el producto: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(601, 75);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(55, 23);
            txtCantidad.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(522, 80);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 7;
            label3.Text = "Cantidad:";
            // 
            // dgvProductosEntrada
            // 
            dgvProductosEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosEntrada.Location = new Point(77, 123);
            dgvProductosEntrada.Name = "dgvProductosEntrada";
            dgvProductosEntrada.RowTemplate.Height = 25;
            dgvProductosEntrada.Size = new Size(648, 247);
            dgvProductosEntrada.TabIndex = 8;
            dgvProductosEntrada.CellContentClick += dgvProductosEntrada_CellContentClick;
            // 
            // btnRealizarEntrada
            // 
            btnRealizarEntrada.BackColor = Color.FromArgb(189, 205, 208);
            btnRealizarEntrada.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRealizarEntrada.Location = new Point(301, 384);
            btnRealizarEntrada.Name = "btnRealizarEntrada";
            btnRealizarEntrada.Size = new Size(169, 44);
            btnRealizarEntrada.TabIndex = 9;
            btnRealizarEntrada.Text = "Realizar entrada";
            btnRealizarEntrada.UseVisualStyleBackColor = false;
            // 
            // cbxProductos
            // 
            cbxProductos.FormattingEnabled = true;
            cbxProductos.Location = new Point(233, 78);
            cbxProductos.Name = "cbxProductos";
            cbxProductos.Size = new Size(266, 23);
            cbxProductos.TabIndex = 10;
            // 
            // pbxAgregarDetalle
            // 
            pbxAgregarDetalle.Image = (Image)resources.GetObject("pbxAgregarDetalle.Image");
            pbxAgregarDetalle.Location = new Point(664, 69);
            pbxAgregarDetalle.Name = "pbxAgregarDetalle";
            pbxAgregarDetalle.Size = new Size(61, 32);
            pbxAgregarDetalle.SizeMode = PictureBoxSizeMode.Zoom;
            pbxAgregarDetalle.TabIndex = 12;
            pbxAgregarDetalle.TabStop = false;
            pbxAgregarDetalle.Click += pbxAgregarDetalle_Click;
            // 
            // FrmEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 243);
            ClientSize = new Size(800, 450);
            Controls.Add(pbxAgregarDetalle);
            Controls.Add(cbxProductos);
            Controls.Add(btnRealizarEntrada);
            Controls.Add(dgvProductosEntrada);
            Controls.Add(label3);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(cbxSucursales);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEntradas";
            Text = "FrmEntradas";
            ((System.ComponentModel.ISupportInitialize)dgvProductosEntrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAgregarDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbxSucursales;
        private Label label1;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private DataGridView dgvProductosEntrada;
        private Button btnRealizarEntrada;
        private ComboBox cbxProductos;
        private PictureBox pbxAgregarDetalle;
    }
}