namespace GUI
{
    partial class LoginGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            panelBarraSuperior = new Panel();
            panel4 = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnSalir = new PictureBox();
            btnMaximizar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label3 = new Label();
            pbxIngresar = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel11 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            panelBarraSuperior.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxIngresar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.BackColor = Color.FromArgb(139, 166, 172);
            panelBarraSuperior.BorderStyle = BorderStyle.FixedSingle;
            panelBarraSuperior.Controls.Add(panel4);
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(658, 30);
            panelBarraSuperior.TabIndex = 2;
            panelBarraSuperior.Paint += panelBarraSuperior_Paint;
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnRestaurar);
            panel4.Controls.Add(btnMinimizar);
            panel4.Controls.Add(btnSalir);
            panel4.Controls.Add(btnMaximizar);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(527, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(129, 28);
            panel4.TabIndex = 4;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(75, 0);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(15, 30);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 8;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click_1;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(42, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(12, 30);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 7;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(106, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(11, 30);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 5;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(75, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(13, 30);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 6;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 87);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 132);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(140, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(152, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(140, 132);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(152, 23);
            txtContrasena.TabIndex = 6;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(139, 166, 172);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 25);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 7;
            label3.Text = "Ingrese los siguientes datos ";
            label3.Click += label3_Click;
            // 
            // pbxIngresar
            // 
            pbxIngresar.BackColor = SystemColors.ButtonFace;
            pbxIngresar.Location = new Point(111, 192);
            pbxIngresar.Name = "pbxIngresar";
            pbxIngresar.Size = new Size(134, 35);
            pbxIngresar.TabIndex = 8;
            pbxIngresar.TabStop = false;
            pbxIngresar.Click += pbxIngresar_Click;
            pbxIngresar.MouseHover += pbxIngresar_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 166, 172);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pbxIngresar);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(34, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 262);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(91, 47);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 10;
            label4.Text = "para iniciar sesión";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel11);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 338);
            panel2.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(34, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(341, 32);
            panel9.TabIndex = 15;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(375, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(42, 291);
            panel8.TabIndex = 14;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(34, 291);
            panel7.TabIndex = 10;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 291);
            panel11.Name = "panel11";
            panel11.Size = new Size(417, 47);
            panel11.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(417, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 71);
            panel3.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(417, 288);
            panel5.Name = "panel5";
            panel5.Size = new Size(241, 80);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(614, 101);
            panel6.Name = "panel6";
            panel6.Size = new Size(44, 187);
            panel6.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(417, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 190);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 368);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelBarraSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginGUI";
            Text = "LoginGUI";
            panelBarraSuperior.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxIngresar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarraSuperior;
        private Panel panel4;
        private PictureBox btnRestaurar;
        private PictureBox btnMinimizar;
        private PictureBox btnSalir;
        private PictureBox btnMaximizar;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label3;
        private PictureBox pbxIngresar;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Panel panel11;
        private Panel panel7;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Panel panel9;
        private Panel panel8;
    }
}