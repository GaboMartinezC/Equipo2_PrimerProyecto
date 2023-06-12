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
            this.cbxSucursales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductosEntrada = new System.Windows.Forms.DataGridView();
            this.btnRealizarEntrada = new System.Windows.Forms.Button();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.pbxAgregarDetalle = new System.Windows.Forms.PictureBox();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSucursales
            // 
            this.cbxSucursales.FormattingEnabled = true;
            this.cbxSucursales.Location = new System.Drawing.Point(397, 36);
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(163, 23);
            this.cbxSucursales.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione en que sucursal ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el producto: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(601, 75);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 23);
            this.txtCantidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(522, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // dgvProductosEntrada
            // 
            this.dgvProductosEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEntrada.Location = new System.Drawing.Point(77, 123);
            this.dgvProductosEntrada.Name = "dgvProductosEntrada";
            this.dgvProductosEntrada.RowTemplate.Height = 25;
            this.dgvProductosEntrada.Size = new System.Drawing.Size(648, 247);
            this.dgvProductosEntrada.TabIndex = 8;
            // 
            // btnRealizarEntrada
            // 
            this.btnRealizarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(208)))));
            this.btnRealizarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRealizarEntrada.Location = new System.Drawing.Point(301, 384);
            this.btnRealizarEntrada.Name = "btnRealizarEntrada";
            this.btnRealizarEntrada.Size = new System.Drawing.Size(169, 44);
            this.btnRealizarEntrada.TabIndex = 9;
            this.btnRealizarEntrada.Text = "Realizar entrada";
            this.btnRealizarEntrada.UseVisualStyleBackColor = false;
            // 
            // cbxProductos
            // 
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(233, 78);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(266, 23);
            this.cbxProductos.TabIndex = 10;
            // 
            // pbxAgregarDetalle
            // 
            this.pbxAgregarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("pbxAgregarDetalle.Image")));
            this.pbxAgregarDetalle.Location = new System.Drawing.Point(664, 69);
            this.pbxAgregarDetalle.Name = "pbxAgregarDetalle";
            this.pbxAgregarDetalle.Size = new System.Drawing.Size(61, 32);
            this.pbxAgregarDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAgregarDetalle.TabIndex = 12;
            this.pbxAgregarDetalle.TabStop = false;
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(800, 30);
            this.panelBarraSuperior.TabIndex = 13;
            this.panelBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraSuperior_MouseDown);
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBarraSuperior);
            this.Controls.Add(this.pbxAgregarDetalle);
            this.Controls.Add(this.cbxProductos);
            this.Controls.Add(this.btnRealizarEntrada);
            this.Controls.Add(this.dgvProductosEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSucursales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntradas";
            this.Text = "FrmEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panelBarraSuperior;
    }
}