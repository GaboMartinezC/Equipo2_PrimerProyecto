namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    partial class FrmBuscarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarSucursal));
            panelPadreBuscarProveedor = new Panel();
            txtTelefono = new TextBox();
            txtUbicacion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            pbxEditarSucursal = new PictureBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            panelBarraSuperior = new Panel();
            panelBtnSalir = new Panel();
            panel2 = new Panel();
            btnSalir = new PictureBox();
            panel1 = new Panel();
            panelPadreBuscarProveedor.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEditarSucursal).BeginInit();
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
            panelPadreBuscarProveedor.Controls.Add(txtTelefono);
            panelPadreBuscarProveedor.Controls.Add(txtUbicacion);
            panelPadreBuscarProveedor.Controls.Add(label3);
            panelPadreBuscarProveedor.Controls.Add(label2);
            panelPadreBuscarProveedor.Controls.Add(panel6);
            panelPadreBuscarProveedor.Controls.Add(panel4);
            panelPadreBuscarProveedor.Controls.Add(panelBarraSuperior);
            panelPadreBuscarProveedor.Controls.Add(panelBtnSalir);
            panelPadreBuscarProveedor.Dock = DockStyle.Fill;
            panelPadreBuscarProveedor.Location = new Point(0, 0);
            panelPadreBuscarProveedor.Name = "panelPadreBuscarProveedor";
            panelPadreBuscarProveedor.Size = new Size(437, 260);
            panelPadreBuscarProveedor.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(144, 148);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(178, 23);
            txtTelefono.TabIndex = 7;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(144, 109);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.ReadOnly = true;
            txtUbicacion.Size = new Size(178, 23);
            txtUbicacion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 148);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 111);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Ubicación: ";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 187);
            panel6.Name = "panel6";
            panel6.Size = new Size(392, 73);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(pbxEditarSucursal);
            panel7.Controls.Add(pictureBox1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(276, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(116, 73);
            panel7.TabIndex = 0;
            // 
            // pbxEditarSucursal
            // 
            pbxEditarSucursal.Image = (Image)resources.GetObject("pbxEditarSucursal.Image");
            pbxEditarSucursal.Location = new Point(33, 3);
            pbxEditarSucursal.Name = "pbxEditarSucursal";
            pbxEditarSucursal.Size = new Size(33, 33);
            pbxEditarSucursal.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEditarSucursal.TabIndex = 1;
            pbxEditarSucursal.TabStop = false;
            pbxEditarSucursal.Click += pictureBox2_Click;
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
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(379, 15);
            label1.TabIndex = 0;
            label1.Text = "Los datos que ingresó coinciden con la siguiente sucursal";
            label1.Click += label1_Click_1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 43);
            panel5.TabIndex = 1;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(392, 46);
            panelBarraSuperior.TabIndex = 1;
            panelBarraSuperior.Click += panelBarraSuperior_Click;
            panelBarraSuperior.Paint += panelBarraSuperior_Paint;
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown;
            // 
            // panelBtnSalir
            // 
            panelBtnSalir.Controls.Add(panel2);
            panelBtnSalir.Controls.Add(panel1);
            panelBtnSalir.Dock = DockStyle.Right;
            panelBtnSalir.Location = new Point(392, 0);
            panelBtnSalir.Name = "panelBtnSalir";
            panelBtnSalir.Size = new Size(45, 260);
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
            btnSalir.Click += btnSalir_Click_1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(27, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 260);
            panel1.TabIndex = 0;
            // 
            // FrmBuscarSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 260);
            Controls.Add(panelPadreBuscarProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBuscarSucursal";
            Text = "Form1";
            panelPadreBuscarProveedor.ResumeLayout(false);
            panelPadreBuscarProveedor.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxEditarSucursal).EndInit();
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
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pbxEditarSucursal;
        private PictureBox pictureBox1;
        private TextBox txtTelefono;
        private TextBox txtUbicacion;
        private Label label3;
        private Label label2;
    }
}