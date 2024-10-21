namespace PresentacionComprarProducto
{
    partial class ComprarProducto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tablaProductos = new DataGridView();
            comboBoxEmpleados = new ComboBox();
            LabelID = new Label();
            textBoxNumeroFactura = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBoxNombreClientes = new ComboBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tablaProductos
            // 
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new Point(12, 12);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.Size = new Size(534, 263);
            tablaProductos.TabIndex = 0;
            tablaProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxEmpleados
            // 
            comboBoxEmpleados.FormattingEnabled = true;
            comboBoxEmpleados.Location = new Point(97, 403);
            comboBoxEmpleados.Name = "comboBoxEmpleados";
            comboBoxEmpleados.Size = new Size(164, 23);
            comboBoxEmpleados.TabIndex = 1;
            comboBoxEmpleados.Text = "Seleccione una opcion";
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelID.Location = new Point(12, 300);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(143, 21);
            LabelID.TabIndex = 2;
            LabelID.Text = "Numero de Factura";
            // 
            // textBoxNumeroFactura
            // 
            textBoxNumeroFactura.Location = new Point(161, 300);
            textBoxNumeroFactura.Name = "textBoxNumeroFactura";
            textBoxNumeroFactura.Size = new Size(100, 23);
            textBoxNumeroFactura.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 330);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 4;
            label1.Text = "Tipo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 365);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(68, 365);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 401);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 8;
            label3.Text = "Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 437);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 9;
            label4.Text = "Cliente";
            // 
            // comboBoxNombreClientes
            // 
            comboBoxNombreClientes.FormattingEnabled = true;
            comboBoxNombreClientes.Location = new Point(97, 435);
            comboBoxNombreClientes.Name = "comboBoxNombreClientes";
            comboBoxNombreClientes.Size = new Size(164, 23);
            comboBoxNombreClientes.TabIndex = 10;
            comboBoxNombreClientes.Text = "Seleccione una opcion";
            comboBoxNombreClientes.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 472);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 11;
            label5.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(97, 472);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(164, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(709, 12);
            label6.Name = "label6";
            label6.Size = new Size(195, 21);
            label6.TabIndex = 13;
            label6.Text = "Informacion de producto";
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 554);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(comboBoxNombreClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBoxNumeroFactura);
            Controls.Add(LabelID);
            Controls.Add(comboBoxEmpleados);
            Controls.Add(tablaProductos);
            Name = "ComprarProducto";
            Text = "Comprar Producto";
            Load += ComprarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaProductos;
        private ComboBox comboBoxEmpleados;
        private Label LabelID;
        private TextBox textBoxNumeroFactura;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxNombreClientes;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
    }
}
