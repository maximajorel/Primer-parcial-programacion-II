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
            texboxTipoComprobante = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBoxNombreClientes = new ComboBox();
            label5 = new Label();
            numericUpCantidadProducto = new NumericUpDown();
            label6 = new Label();
            labelIDProducto = new Label();
            textBoxIDProducto = new TextBox();
            label7 = new Label();
            textBoxNombreProducto = new TextBox();
            tituloTotalProducto = new Label();
            labelTotalCompraProducto = new Label();
            buttonLimpiarCampos = new Button();
            buttonCargarFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpCantidadProducto).BeginInit();
            SuspendLayout();
            // 
            // tablaProductos
            // 
            tablaProductos.AllowUserToAddRows = false;
            tablaProductos.AllowUserToDeleteRows = false;
            tablaProductos.AllowUserToOrderColumns = true;
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new Point(12, 12);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.ReadOnly = true;
            tablaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaProductos.Size = new Size(534, 263);
            tablaProductos.TabIndex = 0;
            tablaProductos.CellClick += tablaProductos_CellClick;
            // 
            // comboBoxEmpleados
            // 
            comboBoxEmpleados.FormattingEnabled = true;
            comboBoxEmpleados.Location = new Point(97, 403);
            comboBoxEmpleados.Name = "comboBoxEmpleados";
            comboBoxEmpleados.Size = new Size(164, 23);
            comboBoxEmpleados.TabIndex = 1;
            comboBoxEmpleados.SelectedIndexChanged += comboBoxEmpleados_SelectedIndexChanged;
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
            // texboxTipoComprobante
            // 
            texboxTipoComprobante.Location = new Point(58, 332);
            texboxTipoComprobante.Name = "texboxTipoComprobante";
            texboxTipoComprobante.Size = new Size(203, 23);
            texboxTipoComprobante.TabIndex = 5;
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
            // numericUpCantidadProducto
            // 
            numericUpCantidadProducto.Location = new Point(97, 472);
            numericUpCantidadProducto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpCantidadProducto.Name = "numericUpCantidadProducto";
            numericUpCantidadProducto.Size = new Size(164, 23);
            numericUpCantidadProducto.TabIndex = 12;
            numericUpCantidadProducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpCantidadProducto.ValueChanged += numericUpCantidadProducto_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(552, 12);
            label6.Name = "label6";
            label6.Size = new Size(195, 21);
            label6.TabIndex = 13;
            label6.Text = "Informacion de producto";
            // 
            // labelIDProducto
            // 
            labelIDProducto.AutoSize = true;
            labelIDProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDProducto.Location = new Point(552, 49);
            labelIDProducto.Name = "labelIDProducto";
            labelIDProducto.Size = new Size(113, 21);
            labelIDProducto.TabIndex = 14;
            labelIDProducto.Text = "ID de producto";
            // 
            // textBoxIDProducto
            // 
            textBoxIDProducto.Location = new Point(671, 51);
            textBoxIDProducto.Name = "textBoxIDProducto";
            textBoxIDProducto.ReadOnly = true;
            textBoxIDProducto.Size = new Size(100, 23);
            textBoxIDProducto.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(552, 95);
            label7.Name = "label7";
            label7.Size = new Size(156, 21);
            label7.TabIndex = 16;
            label7.Text = "Nombre de producto";
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(709, 95);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.ReadOnly = true;
            textBoxNombreProducto.Size = new Size(132, 23);
            textBoxNombreProducto.TabIndex = 17;
            // 
            // tituloTotalProducto
            // 
            tituloTotalProducto.AutoSize = true;
            tituloTotalProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloTotalProducto.Location = new Point(552, 149);
            tituloTotalProducto.Name = "tituloTotalProducto";
            tituloTotalProducto.Size = new Size(58, 21);
            tituloTotalProducto.TabIndex = 18;
            tituloTotalProducto.Text = "Total: $";
            // 
            // labelTotalCompraProducto
            // 
            labelTotalCompraProducto.AutoSize = true;
            labelTotalCompraProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalCompraProducto.Location = new Point(610, 149);
            labelTotalCompraProducto.Name = "labelTotalCompraProducto";
            labelTotalCompraProducto.Size = new Size(0, 21);
            labelTotalCompraProducto.TabIndex = 19;
            // 
            // buttonLimpiarCampos
            // 
            buttonLimpiarCampos.Location = new Point(533, 519);
            buttonLimpiarCampos.Name = "buttonLimpiarCampos";
            buttonLimpiarCampos.Size = new Size(155, 23);
            buttonLimpiarCampos.TabIndex = 20;
            buttonLimpiarCampos.Text = "Limpiar Campos";
            buttonLimpiarCampos.UseVisualStyleBackColor = true;
            buttonLimpiarCampos.Click += buttonLimpiarCampos_Click;
            // 
            // buttonCargarFactura
            // 
            buttonCargarFactura.Location = new Point(694, 519);
            buttonCargarFactura.Name = "buttonCargarFactura";
            buttonCargarFactura.Size = new Size(155, 23);
            buttonCargarFactura.TabIndex = 21;
            buttonCargarFactura.Text = "Cargar Factura";
            buttonCargarFactura.UseVisualStyleBackColor = true;
            buttonCargarFactura.Click += buttonCargarFactura_Click;
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 554);
            Controls.Add(buttonCargarFactura);
            Controls.Add(buttonLimpiarCampos);
            Controls.Add(labelTotalCompraProducto);
            Controls.Add(tituloTotalProducto);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(label7);
            Controls.Add(textBoxIDProducto);
            Controls.Add(labelIDProducto);
            Controls.Add(label6);
            Controls.Add(numericUpCantidadProducto);
            Controls.Add(label5);
            Controls.Add(comboBoxNombreClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(texboxTipoComprobante);
            Controls.Add(label1);
            Controls.Add(textBoxNumeroFactura);
            Controls.Add(LabelID);
            Controls.Add(comboBoxEmpleados);
            Controls.Add(tablaProductos);
            Name = "ComprarProducto";
            Text = "Comprar Producto";
            Load += ComprarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpCantidadProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaProductos;
        private ComboBox comboBoxEmpleados;
        private Label LabelID;
        private TextBox textBoxNumeroFactura;
        private Label label1;
        private TextBox texboxTipoComprobante;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxNombreClientes;
        private Label label5;
        private NumericUpDown numericUpCantidadProducto;
        private Label label6;
        private Label labelIDProducto;
        private TextBox textBoxIDProducto;
        private Label label7;
        private TextBox textBoxNombreProducto;
        private Label tituloTotalProducto;
        private Label labelTotalCompraProducto;
        private Button buttonLimpiarCampos;
        private Button buttonCargarFactura;
    }
}
