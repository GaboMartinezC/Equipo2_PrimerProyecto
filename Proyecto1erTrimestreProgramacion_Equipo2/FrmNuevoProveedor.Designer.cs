namespace GUI
{
    partial class FrmNuevoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoProveedor));
            panelPadreNuevoProveedor = new Panel();
            pnlNuevoProveedor = new Panel();
            chbxEditorial = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtTelefono = new Label();
            tctTelefono = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            panel2 = new Panel();
            panelBtnGuardarNuevoProveedor = new Panel();
            btnAgregar = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            panelBtnSalir = new Panel();
            btnSalir = new PictureBox();
            panel3 = new Panel();
            panelPadreNuevoProveedor.SuspendLayout();
            pnlNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBtnGuardarNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            panel1.SuspendLayout();
            panelBtnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            SuspendLayout();
            // 
            // panelPadreNuevoProveedor
            // 
            panelPadreNuevoProveedor.Controls.Add(pnlNuevoProveedor);
            panelPadreNuevoProveedor.Controls.Add(panel2);
            panelPadreNuevoProveedor.Controls.Add(panelBtnGuardarNuevoProveedor);
            panelPadreNuevoProveedor.Controls.Add(panel1);
            panelPadreNuevoProveedor.Dock = DockStyle.Fill;
            panelPadreNuevoProveedor.Location = new Point(0, 0);
            panelPadreNuevoProveedor.Name = "panelPadreNuevoProveedor";
            panelPadreNuevoProveedor.Size = new Size(367, 354);
            panelPadreNuevoProveedor.TabIndex = 0;
            // 
            // pnlNuevoProveedor
            // 
            pnlNuevoProveedor.Controls.Add(chbxEditorial);
            pnlNuevoProveedor.Controls.Add(pictureBox4);
            pnlNuevoProveedor.Controls.Add(pictureBox3);
            pnlNuevoProveedor.Controls.Add(pictureBox2);
            pnlNuevoProveedor.Controls.Add(txtTelefono);
            pnlNuevoProveedor.Controls.Add(tctTelefono);
            pnlNuevoProveedor.Controls.Add(txtEmail);
            pnlNuevoProveedor.Controls.Add(label2);
            pnlNuevoProveedor.Controls.Add(txtNombre);
            pnlNuevoProveedor.Controls.Add(label1);
            pnlNuevoProveedor.Controls.Add(panel6);
            pnlNuevoProveedor.Dock = DockStyle.Top;
            pnlNuevoProveedor.Location = new Point(0, 45);
            pnlNuevoProveedor.Name = "pnlNuevoProveedor";
            pnlNuevoProveedor.Size = new Size(335, 247);
            pnlNuevoProveedor.TabIndex = 3;
            // 
            // chbxEditorial
            // 
            chbxEditorial.AutoSize = true;
            chbxEditorial.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chbxEditorial.Location = new Point(130, 223);
            chbxEditorial.Name = "chbxEditorial";
            chbxEditorial.Size = new Size(105, 20);
            chbxEditorial.TabIndex = 10;
            chbxEditorial.Text = "Es editorial";
            chbxEditorial.UseVisualStyleBackColor = true;
            chbxEditorial.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(64, 177);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(69, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(151, 153);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(69, 16);
            txtTelefono.TabIndex = 6;
            txtTelefono.Text = "Teléfono";
            // 
            // tctTelefono
            // 
            tctTelefono.BackColor = Color.LightGray;
            tctTelefono.Location = new Point(100, 176);
            tctTelefono.Name = "tctTelefono";
            tctTelefono.Size = new Size(215, 23);
            tctTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightGray;
            txtEmail.Location = new Point(100, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 23);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(163, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.Location = new Point(100, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 16);
            label1.TabIndex = 1;
            label1.Text = "Nombre ";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(58, 247);
            panel6.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 45);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panelBtnGuardarNuevoProveedor
            // 
            panelBtnGuardarNuevoProveedor.Controls.Add(btnAgregar);
            panelBtnGuardarNuevoProveedor.Dock = DockStyle.Bottom;
            panelBtnGuardarNuevoProveedor.Location = new Point(0, 295);
            panelBtnGuardarNuevoProveedor.Name = "panelBtnGuardarNuevoProveedor";
            panelBtnGuardarNuevoProveedor.Size = new Size(335, 59);
            panelBtnGuardarNuevoProveedor.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(279, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(61, 32);
            btnAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregar.TabIndex = 0;
            btnAgregar.TabStop = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panelBtnSalir);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(335, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(32, 354);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 268);
            panel4.Name = "panel4";
            panel4.Size = new Size(32, 86);
            panel4.TabIndex = 1;
            // 
            // panelBtnSalir
            // 
            panelBtnSalir.Controls.Add(btnSalir);
            panelBtnSalir.Controls.Add(panel3);
            panelBtnSalir.Dock = DockStyle.Top;
            panelBtnSalir.Location = new Point(0, 0);
            panelBtnSalir.Name = "panelBtnSalir";
            panelBtnSalir.Size = new Size(32, 45);
            panelBtnSalir.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(6, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(11, 45);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 7;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(17, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 45);
            panel3.TabIndex = 0;
            // 
            // FrmNuevoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 243);
            ClientSize = new Size(367, 354);
            Controls.Add(panelPadreNuevoProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoProveedor";
            Text = "FrmNuevoProveedor";
            panelPadreNuevoProveedor.ResumeLayout(false);
            pnlNuevoProveedor.ResumeLayout(false);
            pnlNuevoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBtnGuardarNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            panel1.ResumeLayout(false);
            panelBtnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPadreNuevoProveedor;
        private Panel panel1;
        private Panel panelBtnSalir;
        private Panel panel4;
        private PictureBox btnSalir;
        private Panel panel3;
        private Panel pnlNuevoProveedor;
        private Label label1;
        private Panel panel6;
        private Panel panel2;
        private Panel panelBtnGuardarNuevoProveedor;
        private PictureBox btnAgregar;
        private Label label2;
        private TextBox txtNombre;
        private Label txtTelefono;
        private TextBox tctTelefono;
        private TextBox txtEmail;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CheckBox chbxEditorial;
    }
}