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
            panelNuevoProveedor = new Panel();
            btnNuevoProveedor = new PictureBox();
            panelBTNBuscarProveedor = new Panel();
            btnBuscarProveedor = new PictureBox();
            panel1 = new Panel();
            txtBuscarIdioma = new TextBox();
            dgvIdioma = new DataGridView();
            panelNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNuevoProveedor).BeginInit();
            panelBTNBuscarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIdioma).BeginInit();
            SuspendLayout();
            // 
            // panelNuevoProveedor
            // 
            panelNuevoProveedor.Controls.Add(btnNuevoProveedor);
            panelNuevoProveedor.Dock = DockStyle.Left;
            panelNuevoProveedor.Location = new Point(0, 0);
            panelNuevoProveedor.Name = "panelNuevoProveedor";
            panelNuevoProveedor.Size = new Size(151, 570);
            panelNuevoProveedor.TabIndex = 0;
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.Image = (Image)resources.GetObject("btnNuevoProveedor.Image");
            btnNuevoProveedor.Location = new Point(43, 25);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(70, 84);
            btnNuevoProveedor.SizeMode = PictureBoxSizeMode.Zoom;
            btnNuevoProveedor.TabIndex = 0;
            btnNuevoProveedor.TabStop = false;
            btnNuevoProveedor.Click += btnNuevoProveedor_Click_1;
            // 
            // panelBTNBuscarProveedor
            // 
            panelBTNBuscarProveedor.Controls.Add(btnBuscarProveedor);
            panelBTNBuscarProveedor.Dock = DockStyle.Right;
            panelBTNBuscarProveedor.Location = new Point(681, 0);
            panelBTNBuscarProveedor.Name = "panelBTNBuscarProveedor";
            panelBTNBuscarProveedor.Size = new Size(119, 570);
            panelBTNBuscarProveedor.TabIndex = 1;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Image = (Image)resources.GetObject("btnBuscarProveedor.Image");
            btnBuscarProveedor.Location = new Point(18, 36);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(41, 60);
            btnBuscarProveedor.SizeMode = PictureBoxSizeMode.Zoom;
            btnBuscarProveedor.TabIndex = 0;
            btnBuscarProveedor.TabStop = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscarIdioma);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(151, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 78);
            panel1.TabIndex = 2;
            // 
            // txtBuscarIdioma
            // 
            txtBuscarIdioma.BackColor = Color.LightGray;
            txtBuscarIdioma.Dock = DockStyle.Bottom;
            txtBuscarIdioma.Location = new Point(0, 55);
            txtBuscarIdioma.Name = "txtBuscarIdioma";
            txtBuscarIdioma.PlaceholderText = "Ingrese el idioma que desea buscar";
            txtBuscarIdioma.Size = new Size(530, 23);
            txtBuscarIdioma.TabIndex = 0;
            txtBuscarIdioma.TextChanged += textBox1_TextChanged;
            // 
            // dgvIdioma
            // 
            dgvIdioma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIdioma.Location = new Point(151, 127);
            dgvIdioma.Name = "dgvIdioma";
            dgvIdioma.RowTemplate.Height = 25;
            dgvIdioma.Size = new Size(524, 342);
            dgvIdioma.TabIndex = 3;
            dgvIdioma.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // IdiomaGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 243);
            ClientSize = new Size(800, 570);
            Controls.Add(dgvIdioma);
            Controls.Add(panel1);
            Controls.Add(panelBTNBuscarProveedor);
            Controls.Add(panelNuevoProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IdiomaGUI";
            Text = "IdiomaGUI";
            Load += IdiomaGUI_Load;
            panelNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnNuevoProveedor).EndInit();
            panelBTNBuscarProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIdioma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNuevoProveedor;
        private PictureBox btnNuevoProveedor;
        private Panel panelBTNBuscarProveedor;
        private PictureBox btnBuscarProveedor;
        private Panel panel1;
        private TextBox txtBuscarIdioma;
        private DataGridView dgvIdioma;
    }
}