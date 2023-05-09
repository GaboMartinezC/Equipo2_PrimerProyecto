namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    partial class FrmBuscarProducto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProducto));
            panelPadreBuscarProveedor = new Panel();
            cbxEstudiantil = new CheckBox();
            labelPrecio = new Label();
            txtPrecio = new TextBox();
            labelDescripcion = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtStockMin = new TextBox();
            labelStockMax = new Label();
            txtStockMax = new TextBox();
            labelProductoProveedor = new Label();
            txtProveedor = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            pbxEditarProducto = new PictureBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            panelBarraSuperior = new Panel();
            panelBtnSalir = new Panel();
            panel2 = new Panel();
            btnSalir = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            panelPadreBuscarProveedor.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEditarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panelBtnSalir.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            SuspendLayout();
            // 
            // panelPadreBuscarProveedor
            // 
            panelPadreBuscarProveedor.BackColor = Color.FromArgb(248, 248, 243);
            panelPadreBuscarProveedor.Controls.Add(cbxEstudiantil);
            panelPadreBuscarProveedor.Controls.Add(labelPrecio);
            panelPadreBuscarProveedor.Controls.Add(txtPrecio);
            panelPadreBuscarProveedor.Controls.Add(labelDescripcion);
            panelPadreBuscarProveedor.Controls.Add(txtDescripcion);
            panelPadreBuscarProveedor.Controls.Add(label2);
            panelPadreBuscarProveedor.Controls.Add(txtStockMin);
            panelPadreBuscarProveedor.Controls.Add(labelStockMax);
            panelPadreBuscarProveedor.Controls.Add(txtStockMax);
            panelPadreBuscarProveedor.Controls.Add(labelProductoProveedor);
            panelPadreBuscarProveedor.Controls.Add(txtProveedor);
            panelPadreBuscarProveedor.Controls.Add(panel6);
            panelPadreBuscarProveedor.Controls.Add(panel4);
            panelPadreBuscarProveedor.Controls.Add(panelBarraSuperior);
            panelPadreBuscarProveedor.Controls.Add(panelBtnSalir);
            panelPadreBuscarProveedor.Dock = DockStyle.Fill;
            panelPadreBuscarProveedor.Location = new Point(0, 0);
            panelPadreBuscarProveedor.Name = "panelPadreBuscarProveedor";
            panelPadreBuscarProveedor.Size = new Size(437, 396);
            panelPadreBuscarProveedor.TabIndex = 0;
            panelPadreBuscarProveedor.Paint += panelPadreBuscarProveedor_Paint;
            // 
            // cbxEstudiantil
            // 
            cbxEstudiantil.AutoSize = true;
            cbxEstudiantil.Enabled = false;
            cbxEstudiantil.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxEstudiantil.Location = new Point(141, 285);
            cbxEstudiantil.Name = "cbxEstudiantil";
            cbxEstudiantil.RightToLeft = RightToLeft.Yes;
            cbxEstudiantil.Size = new Size(123, 24);
            cbxEstudiantil.TabIndex = 16;
            cbxEstudiantil.Text = "Es estudiantil";
            cbxEstudiantil.UseVisualStyleBackColor = true;
            cbxEstudiantil.CheckedChanged += cbxEstudiantil_CheckedChanged;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrecio.Location = new Point(83, 253);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(57, 20);
            labelPrecio.TabIndex = 13;
            labelPrecio.Text = "Precio:";
            labelPrecio.Click += label3_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(146, 249);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(166, 23);
            txtPrecio.TabIndex = 12;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(68, 215);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(96, 20);
            labelDescripcion.TabIndex = 11;
            labelDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(146, 212);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(166, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 179);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 9;
            label2.Text = "Stock Min:";
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(146, 176);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.ReadOnly = true;
            txtStockMin.Size = new Size(166, 23);
            txtStockMin.TabIndex = 8;
            // 
            // labelStockMax
            // 
            labelStockMax.AutoSize = true;
            labelStockMax.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStockMax.Location = new Point(72, 143);
            labelStockMax.Name = "labelStockMax";
            labelStockMax.Size = new Size(87, 20);
            labelStockMax.TabIndex = 7;
            labelStockMax.Text = "Stock Max:";
            // 
            // txtStockMax
            // 
            txtStockMax.Location = new Point(146, 140);
            txtStockMax.Name = "txtStockMax";
            txtStockMax.ReadOnly = true;
            txtStockMax.Size = new Size(166, 23);
            txtStockMax.TabIndex = 6;
            // 
            // labelProductoProveedor
            // 
            labelProductoProveedor.AutoSize = true;
            labelProductoProveedor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductoProveedor.Location = new Point(76, 107);
            labelProductoProveedor.Name = "labelProductoProveedor";
            labelProductoProveedor.Size = new Size(85, 20);
            labelProductoProveedor.TabIndex = 5;
            labelProductoProveedor.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(146, 104);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.ReadOnly = true;
            txtProveedor.Size = new Size(166, 23);
            txtProveedor.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 323);
            panel6.Name = "panel6";
            panel6.Size = new Size(392, 73);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(pbxEditarProducto);
            panel7.Controls.Add(pictureBox1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(276, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(116, 73);
            panel7.TabIndex = 0;
            // 
            // pbxEditarProducto
            // 
            pbxEditarProducto.Image = (Image)resources.GetObject("pbxEditarProducto.Image");
            pbxEditarProducto.Location = new Point(33, 3);
            pbxEditarProducto.Name = "pbxEditarProducto";
            pbxEditarProducto.Size = new Size(33, 33);
            pbxEditarProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEditarProducto.TabIndex = 1;
            pbxEditarProducto.TabStop = false;
            pbxEditarProducto.Click += pbxEditarProducto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 43);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 20);
            label1.TabIndex = 0;
            label1.Text = "Los datos que ingresó coinciden con ";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(19, 43);
            panel5.TabIndex = 1;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(392, 46);
            panelBarraSuperior.TabIndex = 1;
            panelBarraSuperior.MouseDown += panel3_MouseDown;
            // 
            // panelBtnSalir
            // 
            panelBtnSalir.Controls.Add(panel2);
            panelBtnSalir.Controls.Add(panel1);
            panelBtnSalir.Dock = DockStyle.Right;
            panelBtnSalir.Location = new Point(392, 0);
            panelBtnSalir.Name = "panelBtnSalir";
            panelBtnSalir.Size = new Size(45, 396);
            panelBtnSalir.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(27, 46);
            panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(16, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(11, 46);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 6;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click_2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(27, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 396);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(100, 20);
            label3.Name = "label3";
            label3.Size = new Size(186, 20);
            label3.TabIndex = 2;
            label3.Text = "el siguiente proveedor";
            // 
            // FrmBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 396);
            Controls.Add(panelPadreBuscarProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBuscarProducto";
            Text = "Form1";
            panelPadreBuscarProveedor.ResumeLayout(false);
            panelPadreBuscarProveedor.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxEditarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelBtnSalir.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPadreBuscarProveedor;
        private Panel panelBtnSalir;
        private Panel panel2;
        private Panel panel1;
        private Panel panelBarraSuperior;
        private PictureBox btnSalir;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pbxEditarProducto;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private TextBox txtProveedor;
        private Label labelProductoProveedor;
        private Label labelStockMax;
        private TextBox txtStockMax;
        private Label label2;
        private TextBox txtStockMin;
        private Label labelDescripcion;
        private TextBox txtDescripcion;
        private Label labelPrecio;
        private TextBox txtPrecio;
        private CheckBox cbxEstudiantil;
        private Label label3;
    }
}