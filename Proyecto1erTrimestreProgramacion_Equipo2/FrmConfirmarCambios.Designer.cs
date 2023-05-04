namespace GUI
{
    partial class FrmConfirmarCambios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmarCambios));
            panelPadreConfirmarCambios = new Panel();
            btnCancelarCambios = new Button();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panelPictureBox = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnConfirmarCambios = new Button();
            panelPadreConfirmarCambios.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPadreConfirmarCambios
            // 
            panelPadreConfirmarCambios.BackColor = Color.FromArgb(248, 248, 243);
            panelPadreConfirmarCambios.Controls.Add(btnConfirmarCambios);
            panelPadreConfirmarCambios.Controls.Add(btnCancelarCambios);
            panelPadreConfirmarCambios.Controls.Add(panel4);
            panelPadreConfirmarCambios.Controls.Add(panel3);
            panelPadreConfirmarCambios.Controls.Add(panel1);
            panelPadreConfirmarCambios.Dock = DockStyle.Fill;
            panelPadreConfirmarCambios.Location = new Point(0, 0);
            panelPadreConfirmarCambios.Name = "panelPadreConfirmarCambios";
            panelPadreConfirmarCambios.Size = new Size(274, 150);
            panelPadreConfirmarCambios.TabIndex = 0;
            // 
            // btnCancelarCambios
            // 
            btnCancelarCambios.BackColor = Color.LightGray;
            btnCancelarCambios.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnCancelarCambios.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 166, 172);
            btnCancelarCambios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarCambios.Location = new Point(56, 83);
            btnCancelarCambios.Name = "btnCancelarCambios";
            btnCancelarCambios.Size = new Size(75, 31);
            btnCancelarCambios.TabIndex = 3;
            btnCancelarCambios.Text = "Cancelar";
            btnCancelarCambios.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(56, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 33);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 0;
            label1.Text = "¿ Desea guardar los cambios ?";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(56, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 37);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelPictureBox);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(56, 150);
            panel1.TabIndex = 0;
            // 
            // panelPictureBox
            // 
            panelPictureBox.Controls.Add(pictureBox1);
            panelPictureBox.Dock = DockStyle.Top;
            panelPictureBox.Location = new Point(0, 37);
            panelPictureBox.Name = "panelPictureBox";
            panelPictureBox.Size = new Size(56, 33);
            panelPictureBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(56, 37);
            panel2.TabIndex = 0;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnConfirmarCambios.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 166, 172);
            btnConfirmarCambios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarCambios.Location = new Point(154, 84);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(83, 31);
            btnConfirmarCambios.TabIndex = 4;
            btnConfirmarCambios.Text = "Aceptar";
            btnConfirmarCambios.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmarCambios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 150);
            Controls.Add(panelPadreConfirmarCambios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfirmarCambios";
            Text = "FrmConfirmarCambios";
            panelPadreConfirmarCambios.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPadreConfirmarCambios;
        private Panel panel4;
        private Label label1;
        private Panel panel3;
        private Panel panel1;
        private Panel panelPictureBox;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnCancelarCambios;
        private Button btnConfirmarCambios;
    }
}