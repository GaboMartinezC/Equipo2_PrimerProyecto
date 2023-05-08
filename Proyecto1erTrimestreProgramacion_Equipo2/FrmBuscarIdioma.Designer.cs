namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    partial class FrmBuscarIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarIdioma));
            panelPadreBuscarProveedor = new Panel();
            txtDescripcion = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            pbxEditarIdioma = new PictureBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pbxEditarIdioma).BeginInit();
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
            panelPadreBuscarProveedor.Controls.Add(txtDescripcion);
            panelPadreBuscarProveedor.Controls.Add(label3);
            panelPadreBuscarProveedor.Controls.Add(panel6);
            panelPadreBuscarProveedor.Controls.Add(panel4);
            panelPadreBuscarProveedor.Controls.Add(panelBarraSuperior);
            panelPadreBuscarProveedor.Controls.Add(panelBtnSalir);
            panelPadreBuscarProveedor.Dock = DockStyle.Fill;
            panelPadreBuscarProveedor.Location = new Point(0, 0);
            panelPadreBuscarProveedor.Name = "panelPadreBuscarProveedor";
            panelPadreBuscarProveedor.Size = new Size(437, 220);
            panelPadreBuscarProveedor.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(163, 112);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(157, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 112);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 147);
            panel6.Name = "panel6";
            panel6.Size = new Size(392, 73);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(pbxEditarIdioma);
            panel7.Controls.Add(pictureBox1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(276, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(116, 73);
            panel7.TabIndex = 0;
            // 
            // pbxEditarIdioma
            // 
            pbxEditarIdioma.Image = (Image)resources.GetObject("pbxEditarIdioma.Image");
            pbxEditarIdioma.Location = new Point(33, 3);
            pbxEditarIdioma.Name = "pbxEditarIdioma";
            pbxEditarIdioma.Size = new Size(33, 33);
            pbxEditarIdioma.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEditarIdioma.TabIndex = 1;
            pbxEditarIdioma.TabStop = false;
            pbxEditarIdioma.Click += pictureBox2_Click;
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
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 43);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(129, 21);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 2;
            label2.Text = "siguiente idioma";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, -1);
            label1.Name = "label1";
            label1.Size = new Size(326, 20);
            label1.TabIndex = 0;
            label1.Text = "Los datos que ingresó coinciden con el ";
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
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown;
            // 
            // panelBtnSalir
            // 
            panelBtnSalir.Controls.Add(panel2);
            panelBtnSalir.Controls.Add(panel1);
            panelBtnSalir.Dock = DockStyle.Right;
            panelBtnSalir.Location = new Point(392, 0);
            panelBtnSalir.Name = "panelBtnSalir";
            panelBtnSalir.Size = new Size(45, 220);
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
            panel1.Size = new Size(18, 220);
            panel1.TabIndex = 0;
            // 
            // FrmBuscarIdioma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 220);
            Controls.Add(panelPadreBuscarProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBuscarIdioma";
            Text = "FrmBuscarIdioma";
            panelPadreBuscarProveedor.ResumeLayout(false);
            panelPadreBuscarProveedor.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxEditarIdioma).EndInit();
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
        private PictureBox pbxEditarIdioma;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
    }
}