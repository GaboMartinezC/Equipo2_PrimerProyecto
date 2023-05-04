namespace GUI
{
    partial class IdiomaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdiomaGUI));
            this.panelNuevoProveedor = new System.Windows.Forms.Panel();
            this.btnNuevoProveedor = new System.Windows.Forms.PictureBox();
            this.panelBTNBuscarProveedor = new System.Windows.Forms.Panel();
            this.btnBuscarProveedor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarIdioma = new System.Windows.Forms.TextBox();
            this.panelFrmHijoNuevo = new System.Windows.Forms.Panel();
            this.panelPadreNuevoProveedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVerTodosIdioma = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBtnSalir = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoProveedor)).BeginInit();
            this.panelBTNBuscarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelFrmHijoNuevo.SuspendLayout();
            this.panelPadreNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTodosIdioma)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelBtnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNuevoProveedor
            // 
            this.panelNuevoProveedor.Controls.Add(this.btnNuevoProveedor);
            this.panelNuevoProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNuevoProveedor.Location = new System.Drawing.Point(0, 0);
            this.panelNuevoProveedor.Name = "panelNuevoProveedor";
            this.panelNuevoProveedor.Size = new System.Drawing.Size(151, 570);
            this.panelNuevoProveedor.TabIndex = 0;
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProveedor.Image")));
            this.btnNuevoProveedor.Location = new System.Drawing.Point(43, 25);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(70, 84);
            this.btnNuevoProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevoProveedor.TabIndex = 0;
            this.btnNuevoProveedor.TabStop = false;
            // 
            // panelBTNBuscarProveedor
            // 
            this.panelBTNBuscarProveedor.Controls.Add(this.btnBuscarProveedor);
            this.panelBTNBuscarProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBTNBuscarProveedor.Location = new System.Drawing.Point(681, 0);
            this.panelBTNBuscarProveedor.Name = "panelBTNBuscarProveedor";
            this.panelBTNBuscarProveedor.Size = new System.Drawing.Size(119, 570);
            this.panelBTNBuscarProveedor.TabIndex = 1;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProveedor.Image")));
            this.btnBuscarProveedor.Location = new System.Drawing.Point(18, 36);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(41, 60);
            this.btnBuscarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarProveedor.TabIndex = 0;
            this.btnBuscarProveedor.TabStop = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscarIdioma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(151, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 78);
            this.panel1.TabIndex = 2;
            // 
            // txtBuscarIdioma
            // 
            this.txtBuscarIdioma.BackColor = System.Drawing.Color.LightGray;
            this.txtBuscarIdioma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBuscarIdioma.Location = new System.Drawing.Point(0, 55);
            this.txtBuscarIdioma.Name = "txtBuscarIdioma";
            this.txtBuscarIdioma.PlaceholderText = "Ingrese el idioma que desea buscar";
            this.txtBuscarIdioma.Size = new System.Drawing.Size(530, 23);
            this.txtBuscarIdioma.TabIndex = 0;
            this.txtBuscarIdioma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelFrmHijoNuevo
            // 
            this.panelFrmHijoNuevo.Controls.Add(this.panelPadreNuevoProveedor);
            this.panelFrmHijoNuevo.Location = new System.Drawing.Point(262, 147);
            this.panelFrmHijoNuevo.Name = "panelFrmHijoNuevo";
            this.panelFrmHijoNuevo.Size = new System.Drawing.Size(316, 242);
            this.panelFrmHijoNuevo.TabIndex = 4;
            this.panelFrmHijoNuevo.Visible = false;
            // 
            // panelPadreNuevoProveedor
            // 
            this.panelPadreNuevoProveedor.Controls.Add(this.pictureBox1);
            this.panelPadreNuevoProveedor.Controls.Add(this.panel5);
            this.panelPadreNuevoProveedor.Controls.Add(this.panel2);
            this.panelPadreNuevoProveedor.Controls.Add(this.panel3);
            this.panelPadreNuevoProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadreNuevoProveedor.Location = new System.Drawing.Point(0, 0);
            this.panelPadreNuevoProveedor.Name = "panelPadreNuevoProveedor";
            this.panelPadreNuevoProveedor.Size = new System.Drawing.Size(316, 242);
            this.panelPadreNuevoProveedor.TabIndex = 1;
            this.panelPadreNuevoProveedor.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 113);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(73, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre ";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(39, 113);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvVerTodosIdioma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 45);
            this.panel2.TabIndex = 2;
            // 
            // dgvVerTodosIdioma
            // 
            this.dgvVerTodosIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerTodosIdioma.Location = new System.Drawing.Point(-69, -40);
            this.dgvVerTodosIdioma.Name = "dgvVerTodosIdioma";
            this.dgvVerTodosIdioma.RowTemplate.Height = 25;
            this.dgvVerTodosIdioma.Size = new System.Drawing.Size(456, 282);
            this.dgvVerTodosIdioma.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panelBtnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(284, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 242);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 86);
            this.panel4.TabIndex = 1;
            // 
            // panelBtnSalir
            // 
            this.panelBtnSalir.Controls.Add(this.btnSalir);
            this.panelBtnSalir.Controls.Add(this.panel7);
            this.panelBtnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnSalir.Location = new System.Drawing.Point(0, 0);
            this.panelBtnSalir.Name = "panelBtnSalir";
            this.panelBtnSalir.Size = new System.Drawing.Size(32, 45);
            this.panelBtnSalir.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(6, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(11, 45);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(17, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 45);
            this.panel7.TabIndex = 0;
            // 
            // IdiomaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.panelFrmHijoNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBTNBuscarProveedor);
            this.Controls.Add(this.panelNuevoProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdiomaGUI";
            this.Text = "IdiomaGUI";
            this.Load += new System.EventHandler(this.IdiomaGUI_Load);
            this.panelNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoProveedor)).EndInit();
            this.panelBTNBuscarProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFrmHijoNuevo.ResumeLayout(false);
            this.panelPadreNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTodosIdioma)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelBtnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNuevoProveedor;
        private PictureBox btnNuevoProveedor;
        private Panel panelBTNBuscarProveedor;
        private PictureBox btnBuscarProveedor;
        private Panel panel1;
        private TextBox txtBuscarIdioma;
        private Panel panelFrmHijoNuevo;
        private Panel panelPadreNuevoProveedor;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panelBtnSalir;
        private PictureBox btnSalir;
        private Panel panel7;
        private DataGridView dgvVerTodosIdioma;
    }
}