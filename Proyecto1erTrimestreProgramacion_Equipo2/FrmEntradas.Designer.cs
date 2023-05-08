namespace GUI
{
    partial class FrmEntradas
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            dgvProductosEntrada = new DataGridView();
            btnRealizarEntrada = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductosEntrada).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(397, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 38);
            label1.Name = "label1";
            label1.Size = new Size(202, 16);
            label1.TabIndex = 2;
            label1.Text = "Seleccione en que sucursal ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 77);
            label2.Name = "label2";
            label2.Size = new Size(149, 16);
            label2.TabIndex = 5;
            label2.Text = "Ingrese el producto: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(601, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(522, 80);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 7;
            label3.Text = "Cantidad:";
            // 
            // dgvProductosEntrada
            // 
            dgvProductosEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosEntrada.Location = new Point(77, 123);
            dgvProductosEntrada.Name = "dgvProductosEntrada";
            dgvProductosEntrada.RowTemplate.Height = 25;
            dgvProductosEntrada.Size = new Size(648, 247);
            dgvProductosEntrada.TabIndex = 8;
            dgvProductosEntrada.CellContentClick += dgvProductosEntrada_CellContentClick;
            // 
            // btnRealizarEntrada
            // 
            btnRealizarEntrada.BackColor = Color.FromArgb(189, 205, 208);
            btnRealizarEntrada.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRealizarEntrada.Location = new Point(301, 384);
            btnRealizarEntrada.Name = "btnRealizarEntrada";
            btnRealizarEntrada.Size = new Size(169, 44);
            btnRealizarEntrada.TabIndex = 9;
            btnRealizarEntrada.Text = "Realizar entrada";
            btnRealizarEntrada.UseVisualStyleBackColor = false;
            // 
            // FrmEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRealizarEntrada);
            Controls.Add(dgvProductosEntrada);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEntradas";
            Text = "FrmEntradas";
            ((System.ComponentModel.ISupportInitialize)dgvProductosEntrada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private DataGridView dgvProductosEntrada;
        private Button btnRealizarEntrada;
    }
}