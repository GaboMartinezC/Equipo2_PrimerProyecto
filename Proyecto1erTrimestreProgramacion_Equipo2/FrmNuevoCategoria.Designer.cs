namespace GUI
{
    partial class FrmNuevoCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoCategoria));
            panelPadreNuevoProveedor = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            checkBoxGeneroLiterario = new CheckBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            panelBarraSuperior = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panelBtnSalir = new Panel();
            btnSalir = new PictureBox();
            panel3 = new Panel();
            panelPadreNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelBtnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            SuspendLayout();
            // 
            // panelPadreNuevoProveedor
            // 
            panelPadreNuevoProveedor.Controls.Add(pictureBox1);
            panelPadreNuevoProveedor.Controls.Add(panel5);
            panelPadreNuevoProveedor.Controls.Add(panelBarraSuperior);
            panelPadreNuevoProveedor.Controls.Add(panel1);
            panelPadreNuevoProveedor.Dock = DockStyle.Fill;
            panelPadreNuevoProveedor.Location = new Point(0, 0);
            panelPadreNuevoProveedor.Name = "panelPadreNuevoProveedor";
            panelPadreNuevoProveedor.Size = new Size(316, 242);
            panelPadreNuevoProveedor.TabIndex = 0;
            panelPadreNuevoProveedor.Paint += panelPadreNuevoProveedor_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(checkBoxGeneroLiterario);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 136);
            panel5.TabIndex = 3;
            // 
            // checkBoxGeneroLiterario
            // 
            checkBoxGeneroLiterario.AutoSize = true;
            checkBoxGeneroLiterario.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxGeneroLiterario.Location = new Point(75, 90);
            checkBoxGeneroLiterario.Name = "checkBoxGeneroLiterario";
            checkBoxGeneroLiterario.Size = new Size(168, 20);
            checkBoxGeneroLiterario.TabIndex = 8;
            checkBoxGeneroLiterario.Text = "  Es Genero Literario";
            checkBoxGeneroLiterario.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(84, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 18);
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
            panel6.Size = new Size(48, 136);
            panel6.TabIndex = 0;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(287, 45);
            panelBarraSuperior.TabIndex = 2;
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panelBtnSalir);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(287, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(29, 242);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(29, 86);
            panel4.TabIndex = 1;
            // 
            // panelBtnSalir
            // 
            panelBtnSalir.Controls.Add(btnSalir);
            panelBtnSalir.Controls.Add(panel3);
            panelBtnSalir.Dock = DockStyle.Top;
            panelBtnSalir.Location = new Point(0, 0);
            panelBtnSalir.Name = "panelBtnSalir";
            panelBtnSalir.Size = new Size(29, 45);
            panelBtnSalir.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(3, 0);
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
            panel3.Location = new Point(14, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 45);
            panel3.TabIndex = 0;
            // 
            // FrmNuevoCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 243);
            ClientSize = new Size(316, 242);
            Controls.Add(panelPadreNuevoProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoCategoria";
            Text = "FrmNuevoCategoria";
            panelPadreNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Panel panelBarraSuperior;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBoxGeneroLiterario;
    }
}