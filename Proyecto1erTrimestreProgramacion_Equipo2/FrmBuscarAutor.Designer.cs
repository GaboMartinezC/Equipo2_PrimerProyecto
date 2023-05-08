namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    partial class FrmBuscarAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarAutor));
            panelPadreBuscarProveedor = new Panel();
            txtApellidos = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panelPadreBuscarProveedor.Controls.Add(txtApellidos);
            panelPadreBuscarProveedor.Controls.Add(label3);
            panelPadreBuscarProveedor.Controls.Add(txtNombre);
            panelPadreBuscarProveedor.Controls.Add(label2);
            panelPadreBuscarProveedor.Controls.Add(panel6);
            panelPadreBuscarProveedor.Controls.Add(panel4);
            panelPadreBuscarProveedor.Controls.Add(panelBarraSuperior);
            panelPadreBuscarProveedor.Controls.Add(panelBtnSalir);
            panelPadreBuscarProveedor.Dock = DockStyle.Fill;
            panelPadreBuscarProveedor.Location = new Point(0, 0);
            panelPadreBuscarProveedor.Name = "panelPadreBuscarProveedor";
            panelPadreBuscarProveedor.Size = new Size(437, 255);
            panelPadreBuscarProveedor.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(156, 140);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(175, 23);
            txtApellidos.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 142);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 105);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 182);
            panel6.Name = "panel6";
            panel6.Size = new Size(392, 73);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(pictureBox1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(276, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(116, 73);
            panel7.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(358, 15);
            label1.TabIndex = 0;
            label1.Text = "Los datos que ingresó coinciden con el siguiente autor";
            label1.Click += label1_Click_1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(16, 43);
            panel5.TabIndex = 1;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(392, 46);
            panelBarraSuperior.TabIndex = 1;
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown;
            // 
            // panelBtnSalir
            // 
            panelBtnSalir.Controls.Add(panel2);
            panelBtnSalir.Controls.Add(panel1);
            panelBtnSalir.Dock = DockStyle.Right;
            panelBtnSalir.Location = new Point(392, 0);
            panelBtnSalir.Name = "panelBtnSalir";
            panelBtnSalir.Size = new Size(45, 255);
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
            panel1.Size = new Size(18, 255);
            panel1.TabIndex = 0;
            // 
            // FrmBuscarAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 255);
            Controls.Add(panelPadreBuscarProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBuscarAutor";
            Text = "Form1";
            panelPadreBuscarProveedor.ResumeLayout(false);
            panelPadreBuscarProveedor.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtApellidos;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
    }
}