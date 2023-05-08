namespace GUI
{
    partial class AutorGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorGUI));
            panelNuevoProveedor = new Panel();
            btnNuevoAutor = new PictureBox();
            panelBTNBuscarProveedor = new Panel();
            btnBuscarProveedor = new PictureBox();
            panel1 = new Panel();
            txtBuscarAutor = new TextBox();
            dataGridView1 = new DataGridView();
            panelNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNuevoAutor).BeginInit();
            panelBTNBuscarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelNuevoProveedor
            // 
            panelNuevoProveedor.Controls.Add(btnNuevoAutor);
            panelNuevoProveedor.Dock = DockStyle.Left;
            panelNuevoProveedor.Location = new Point(0, 0);
            panelNuevoProveedor.Name = "panelNuevoProveedor";
            panelNuevoProveedor.Size = new Size(151, 570);
            panelNuevoProveedor.TabIndex = 0;
            panelNuevoProveedor.Click += panelNuevoProveedor_Click;
            // 
            // btnNuevoAutor
            // 
            btnNuevoAutor.Image = (Image)resources.GetObject("btnNuevoAutor.Image");
            btnNuevoAutor.Location = new Point(46, 28);
            btnNuevoAutor.Name = "btnNuevoAutor";
            btnNuevoAutor.Size = new Size(70, 84);
            btnNuevoAutor.SizeMode = PictureBoxSizeMode.Zoom;
            btnNuevoAutor.TabIndex = 1;
            btnNuevoAutor.TabStop = false;
            btnNuevoAutor.Click += btnNuevoAutor_Click;
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
            panel1.Controls.Add(txtBuscarAutor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(151, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 78);
            panel1.TabIndex = 2;
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor.BackColor = Color.LightGray;
            txtBuscarAutor.Dock = DockStyle.Bottom;
            txtBuscarAutor.Location = new Point(0, 55);
            txtBuscarAutor.Name = "txtBuscarAutor";
            txtBuscarAutor.PlaceholderText = "Ingrese el autor que desea buscar";
            txtBuscarAutor.Size = new Size(530, 23);
            txtBuscarAutor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 370);
            dataGridView1.TabIndex = 3;
            // 
            // AutorGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 243);
            ClientSize = new Size(800, 570);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panelBTNBuscarProveedor);
            Controls.Add(panelNuevoProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AutorGUI";
            Text = "AutorGUI";
            panelNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnNuevoAutor).EndInit();
            panelBTNBuscarProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNuevoProveedor;
        private Panel panelBTNBuscarProveedor;
        private PictureBox btnBuscarProveedor;
        private Panel panel1;
        private TextBox txtBuscarAutor;
        private DataGridView dataGridView1;
        private PictureBox btnNuevoAutor;
    }
}