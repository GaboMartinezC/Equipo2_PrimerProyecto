namespace GUI
{
    partial class CategoriaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaGUI));
            panelNuevoProveedor = new Panel();
            btnNuevoProveedor = new PictureBox();
            panelBTNBuscarProveedor = new Panel();
            btnBuscarProveedor = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panelNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNuevoProveedor).BeginInit();
            panelBTNBuscarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(151, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 78);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 55);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese la categoria que desea buscar";
            textBox1.Size = new Size(530, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 370);
            dataGridView1.TabIndex = 3;
            // 
            // CategoriaGUI
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
            Name = "CategoriaGUI";
            Text = "CategoriaGUI";
            panelNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnNuevoProveedor).EndInit();
            panelBTNBuscarProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBuscarProveedor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNuevoProveedor;
        private PictureBox btnNuevoProveedor;
        private Panel panelBTNBuscarProveedor;
        private PictureBox btnBuscarProveedor;
        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}