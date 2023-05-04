namespace GUI
{
    partial class ProductoGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoGUI));
            this.panelNuevoProveedor = new System.Windows.Forms.Panel();
            this.btnNuevoProveedor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelFrmNuevoProveedor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarProveedor = new System.Windows.Forms.PictureBox();
            this.panelBTNBuscarProveedor = new System.Windows.Forms.Panel();
            this.panelNuevoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedor)).BeginInit();
            this.panelBTNBuscarProveedor.SuspendLayout();
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
            this.panelNuevoProveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNuevoProveedor_Paint);
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
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(151, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 78);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ingrese el producto que desea buscar";
            this.textBox1.Size = new System.Drawing.Size(530, 23);
            this.textBox1.TabIndex = 0;
            // 
            // panelFrmNuevoProveedor
            // 
            this.panelFrmNuevoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFrmNuevoProveedor.Location = new System.Drawing.Point(151, 0);
            this.panelFrmNuevoProveedor.Name = "panelFrmNuevoProveedor";
            this.panelFrmNuevoProveedor.Size = new System.Drawing.Size(530, 570);
            this.panelFrmNuevoProveedor.TabIndex = 4;
            this.panelFrmNuevoProveedor.Visible = false;
            this.panelFrmNuevoProveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFrmNuevoProveedor_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(520, 370);
            this.dataGridView1.TabIndex = 3;
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
            // ProductoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.panelFrmNuevoProveedor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBTNBuscarProveedor);
            this.Controls.Add(this.panelNuevoProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductoGUI";
            this.Text = "ProductoGUI";
            this.panelNuevoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedor)).EndInit();
            this.panelBTNBuscarProveedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNuevoProveedor;
        private PictureBox btnNuevoProveedor;
        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panelFrmNuevoProveedor;
        private PictureBox btnBuscarProveedor;
        private Panel panelBTNBuscarProveedor;
    }
}