namespace PresentacionVenderProducto
{
    partial class VenderProducto
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
            dataGridViewClientes = new DataGridView();
            LabelID = new Label();
            textBoxIdProducto = new TextBox();
            label1 = new Label();
            numericUpDownCantidadProducto = new NumericUpDown();
            label2 = new Label();
            labelApellidoNombre = new Label();
            textBoxApellidoNombre = new TextBox();
            label4 = new Label();
            labelTotalProductoFinal = new Label();
            textBoxIdCliente = new TextBox();
            buttonLimpiarCampos = new Button();
            buttonRealizarVenta = new Button();
            label3 = new Label();
            numericUpDownNumeroFactura = new NumericUpDown();
            label5 = new Label();
            comboBoxVendedor = new ComboBox();
            label6 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            textBoxTipoFactura = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeroFactura).BeginInit();
            SuspendLayout();
            // 
            // tablaProductos
            // 
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new Point(12, 12);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.ReadOnly = true;
            tablaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaProductos.Size = new Size(651, 283);
            tablaProductos.TabIndex = 0;
            tablaProductos.CellClick += tablaProductos_CellClick;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(669, 12);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(525, 283);
            dataGridViewClientes.TabIndex = 1;
            dataGridViewClientes.CellClick += dataGridViewClientes_CellClick;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelID.Location = new Point(12, 342);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(124, 30);
            LabelID.TabIndex = 3;
            LabelID.Text = "ID Producto";
            // 
            // textBoxIdProducto
            // 
            textBoxIdProducto.Location = new Point(142, 345);
            textBoxIdProducto.Name = "textBoxIdProducto";
            textBoxIdProducto.ReadOnly = true;
            textBoxIdProducto.Size = new Size(100, 23);
            textBoxIdProducto.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 381);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 5;
            label1.Text = "Cantidad Producto:";
            // 
            // numericUpDownCantidadProducto
            // 
            numericUpDownCantidadProducto.Location = new Point(209, 388);
            numericUpDownCantidadProducto.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownCantidadProducto.Name = "numericUpDownCantidadProducto";
            numericUpDownCantidadProducto.Size = new Size(120, 23);
            numericUpDownCantidadProducto.TabIndex = 6;
            numericUpDownCantidadProducto.ValueChanged += numericUpDownCantidadProducto_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(669, 301);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 7;
            label2.Text = "ID Cliente";
            // 
            // labelApellidoNombre
            // 
            labelApellidoNombre.AutoSize = true;
            labelApellidoNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellidoNombre.Location = new Point(669, 335);
            labelApellidoNombre.Name = "labelApellidoNombre";
            labelApellidoNombre.Size = new Size(183, 30);
            labelApellidoNombre.TabIndex = 8;
            labelApellidoNombre.Text = "Apellido y nombre";
            // 
            // textBoxApellidoNombre
            // 
            textBoxApellidoNombre.Location = new Point(858, 342);
            textBoxApellidoNombre.Name = "textBoxApellidoNombre";
            textBoxApellidoNombre.ReadOnly = true;
            textBoxApellidoNombre.Size = new Size(336, 23);
            textBoxApellidoNombre.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(671, 551);
            label4.Name = "label4";
            label4.Size = new Size(204, 30);
            label4.TabIndex = 10;
            label4.Text = "Total con descuento:";
            // 
            // labelTotalProductoFinal
            // 
            labelTotalProductoFinal.AutoSize = true;
            labelTotalProductoFinal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalProductoFinal.Location = new Point(867, 551);
            labelTotalProductoFinal.Name = "labelTotalProductoFinal";
            labelTotalProductoFinal.Size = new Size(35, 30);
            labelTotalProductoFinal.TabIndex = 11;
            labelTotalProductoFinal.Text = "$0";
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.Location = new Point(779, 307);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.ReadOnly = true;
            textBoxIdCliente.Size = new Size(46, 23);
            textBoxIdCliente.TabIndex = 12;
            // 
            // buttonLimpiarCampos
            // 
            buttonLimpiarCampos.Location = new Point(12, 648);
            buttonLimpiarCampos.Name = "buttonLimpiarCampos";
            buttonLimpiarCampos.Size = new Size(191, 23);
            buttonLimpiarCampos.TabIndex = 13;
            buttonLimpiarCampos.Text = "Limpiar Campos";
            buttonLimpiarCampos.UseVisualStyleBackColor = true;
            buttonLimpiarCampos.Click += buttonLimpiarCampos_Click;
            // 
            // buttonRealizarVenta
            // 
            buttonRealizarVenta.Location = new Point(676, 604);
            buttonRealizarVenta.Name = "buttonRealizarVenta";
            buttonRealizarVenta.Size = new Size(519, 67);
            buttonRealizarVenta.TabIndex = 14;
            buttonRealizarVenta.Text = "Realizar Venta";
            buttonRealizarVenta.UseVisualStyleBackColor = true;
            buttonRealizarVenta.Click += buttonRealizarVenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(670, 414);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 15;
            label3.Text = "Numero Factura";
            // 
            // numericUpDownNumeroFactura
            // 
            numericUpDownNumeroFactura.Location = new Point(838, 421);
            numericUpDownNumeroFactura.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownNumeroFactura.Name = "numericUpDownNumeroFactura";
            numericUpDownNumeroFactura.Size = new Size(120, 23);
            numericUpDownNumeroFactura.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(671, 453);
            label5.Name = "label5";
            label5.Size = new Size(102, 30);
            label5.TabIndex = 17;
            label5.Text = "Vendedor";
            // 
            // comboBoxVendedor
            // 
            comboBoxVendedor.FormattingEnabled = true;
            comboBoxVendedor.Location = new Point(779, 458);
            comboBoxVendedor.Name = "comboBoxVendedor";
            comboBoxVendedor.Size = new Size(178, 23);
            comboBoxVendedor.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(671, 500);
            label6.Name = "label6";
            label6.Size = new Size(229, 30);
            label6.TabIndex = 19;
            label6.Text = "Fecha de Comprobante";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(906, 506);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(288, 23);
            dateTimePickerFecha.TabIndex = 20;
            // 
            // textBoxTipoFactura
            // 
            textBoxTipoFactura.Location = new Point(808, 381);
            textBoxTipoFactura.Name = "textBoxTipoFactura";
            textBoxTipoFactura.Size = new Size(386, 23);
            textBoxTipoFactura.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(671, 374);
            label7.Name = "label7";
            label7.Size = new Size(131, 30);
            label7.TabIndex = 21;
            label7.Text = "Tipo Factura:";
            // 
            // VenderProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 699);
            Controls.Add(textBoxTipoFactura);
            Controls.Add(label7);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(label6);
            Controls.Add(comboBoxVendedor);
            Controls.Add(label5);
            Controls.Add(numericUpDownNumeroFactura);
            Controls.Add(label3);
            Controls.Add(buttonRealizarVenta);
            Controls.Add(buttonLimpiarCampos);
            Controls.Add(textBoxIdCliente);
            Controls.Add(labelTotalProductoFinal);
            Controls.Add(label4);
            Controls.Add(textBoxApellidoNombre);
            Controls.Add(labelApellidoNombre);
            Controls.Add(label2);
            Controls.Add(numericUpDownCantidadProducto);
            Controls.Add(label1);
            Controls.Add(textBoxIdProducto);
            Controls.Add(LabelID);
            Controls.Add(dataGridViewClientes);
            Controls.Add(tablaProductos);
            Name = "VenderProducto";
            Text = "Vender Producto";
            Load += VenderProducto_Load;
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeroFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaProductos;
        private DataGridView dataGridViewClientes;
        private Label LabelID;
        private TextBox textBoxIdProducto;
        private Label label1;
        private NumericUpDown numericUpDownCantidadProducto;
        private Label label2;
        private Label labelApellidoNombre;
        private TextBox textBoxApellidoNombre;
        private Label label4;
        private Label labelTotalProductoFinal;
        private TextBox textBoxIdCliente;
        private Button buttonLimpiarCampos;
        private Button buttonRealizarVenta;
        private Label label3;
        private NumericUpDown numericUpDownNumeroFactura;
        private Label label5;
        private ComboBox comboBoxVendedor;
        private Label label6;
        private DateTimePicker dateTimePickerFecha;
        private TextBox textBoxTipoFactura;
        private Label label7;
    }
}
