﻿namespace GUI
{
    partial class FrmNuevoAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoAutor));
            panelPadreNuevoProveedor = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panelPadreNuevoProveedor.Size = new Size(316, 271);
            panelPadreNuevoProveedor.TabIndex = 0;
            panelPadreNuevoProveedor.Paint += panelPadreNuevoProveedor_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 163);
            panel5.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(57, 110);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
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
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Location = new Point(88, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(131, 84);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(86, 43);
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
            panel6.Size = new Size(48, 163);
            panel6.TabIndex = 0;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(287, 45);
            panelBarraSuperior.TabIndex = 2;
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panelBtnSalir);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(287, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(29, 271);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 185);
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
            // FrmNuevoAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 243);
            ClientSize = new Size(316, 271);
            Controls.Add(panelPadreNuevoProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoAutor";
            Text = "FrmNuevoAutor";
            panelPadreNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}