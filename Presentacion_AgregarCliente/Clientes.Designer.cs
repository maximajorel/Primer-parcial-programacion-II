namespace Presentacion_AgregarCliente
{
    partial class formPresentacionClientes
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
            dataGridClientes = new DataGridView();
            LabelID = new Label();
            textboxID = new TextBox();
            labelNombre = new Label();
            textboxNombre = new TextBox();
            labelApellido = new Label();
            textboxApellido = new TextBox();
            label1 = new Label();
            textboxTelefono = new TextBox();
            labelFechaNac = new Label();
            calendarioFechaNac = new DateTimePicker();
            labelDescuento = new Label();
            numericDescuento = new NumericUpDown();
            botonAgregarCliente = new Button();
            botonLimpiarCampos = new Button();
            botonEditarCliente = new Button();
            buttonEliminarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDescuento).BeginInit();
            SuspendLayout();
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(12, 12);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientes.Size = new Size(776, 233);
            dataGridClientes.TabIndex = 0;
            dataGridClientes.CellContentClick += dataGridClientes_CellContentClick;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelID.Location = new Point(12, 250);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(34, 30);
            LabelID.TabIndex = 2;
            LabelID.Text = "ID";
            // 
            // textboxID
            // 
            textboxID.Enabled = false;
            textboxID.Location = new Point(52, 257);
            textboxID.Name = "textboxID";
            textboxID.ReadOnly = true;
            textboxID.Size = new Size(58, 23);
            textboxID.TabIndex = 3;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(12, 292);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(89, 30);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre";
            // 
            // textboxNombre
            // 
            textboxNombre.Location = new Point(107, 299);
            textboxNombre.Name = "textboxNombre";
            textboxNombre.Size = new Size(143, 23);
            textboxNombre.TabIndex = 6;
            textboxNombre.KeyPress += textboxNombre_KeyPress;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(256, 292);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(89, 30);
            labelApellido.TabIndex = 7;
            labelApellido.Text = "Apellido";
            // 
            // textboxApellido
            // 
            textboxApellido.Location = new Point(351, 299);
            textboxApellido.Name = "textboxApellido";
            textboxApellido.Size = new Size(234, 23);
            textboxApellido.TabIndex = 8;
            textboxApellido.TextChanged += textboxApellido_TextChanged;
            textboxApellido.KeyPress += textboxApellido_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 337);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 9;
            label1.Text = "Telefono";
            // 
            // textboxTelefono
            // 
            textboxTelefono.Location = new Point(107, 344);
            textboxTelefono.Name = "textboxTelefono";
            textboxTelefono.Size = new Size(143, 23);
            textboxTelefono.TabIndex = 10;
            textboxTelefono.TextChanged += textboxTelefono_TextChanged;
            textboxTelefono.KeyPress += textboxTelefono_KeyPress;
            // 
            // labelFechaNac
            // 
            labelFechaNac.AutoSize = true;
            labelFechaNac.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaNac.Location = new Point(256, 337);
            labelFechaNac.Name = "labelFechaNac";
            labelFechaNac.Size = new Size(180, 30);
            labelFechaNac.TabIndex = 11;
            labelFechaNac.Text = "Fecha Nacimiento";
            // 
            // calendarioFechaNac
            // 
            calendarioFechaNac.Location = new Point(442, 341);
            calendarioFechaNac.Name = "calendarioFechaNac";
            calendarioFechaNac.Size = new Size(143, 23);
            calendarioFechaNac.TabIndex = 12;
            calendarioFechaNac.TabStop = false;
            // 
            // labelDescuento
            // 
            labelDescuento.AutoSize = true;
            labelDescuento.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescuento.Location = new Point(12, 384);
            labelDescuento.Name = "labelDescuento";
            labelDescuento.Size = new Size(112, 30);
            labelDescuento.TabIndex = 13;
            labelDescuento.Text = "Descuento";
            // 
            // numericDescuento
            // 
            numericDescuento.Location = new Point(130, 391);
            numericDescuento.Name = "numericDescuento";
            numericDescuento.Size = new Size(120, 23);
            numericDescuento.TabIndex = 14;
            // 
            // botonAgregarCliente
            // 
            botonAgregarCliente.Location = new Point(616, 284);
            botonAgregarCliente.Name = "botonAgregarCliente";
            botonAgregarCliente.Size = new Size(172, 38);
            botonAgregarCliente.TabIndex = 18;
            botonAgregarCliente.Text = "Agregar cliente";
            botonAgregarCliente.UseVisualStyleBackColor = true;
            botonAgregarCliente.Click += botonAgregarCliente_Click;
            // 
            // botonLimpiarCampos
            // 
            botonLimpiarCampos.Location = new Point(12, 435);
            botonLimpiarCampos.Name = "botonLimpiarCampos";
            botonLimpiarCampos.Size = new Size(172, 28);
            botonLimpiarCampos.TabIndex = 22;
            botonLimpiarCampos.Text = "Limpiar campos";
            botonLimpiarCampos.UseVisualStyleBackColor = true;
            botonLimpiarCampos.Click += botonLimpiarCampos_Click;
            // 
            // botonEditarCliente
            // 
            botonEditarCliente.Location = new Point(616, 328);
            botonEditarCliente.Name = "botonEditarCliente";
            botonEditarCliente.Size = new Size(172, 38);
            botonEditarCliente.TabIndex = 23;
            botonEditarCliente.Text = "Editar cliente";
            botonEditarCliente.UseVisualStyleBackColor = true;
            botonEditarCliente.Click += botonEditarCliente_Click;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.Location = new Point(616, 372);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(172, 38);
            buttonEliminarCliente.TabIndex = 24;
            buttonEliminarCliente.Text = "Eliminar cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = true;
            buttonEliminarCliente.Click += buttonEliminarCliente_Click;
            // 
            // formPresentacionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(botonEditarCliente);
            Controls.Add(botonLimpiarCampos);
            Controls.Add(botonAgregarCliente);
            Controls.Add(numericDescuento);
            Controls.Add(labelDescuento);
            Controls.Add(calendarioFechaNac);
            Controls.Add(labelFechaNac);
            Controls.Add(textboxTelefono);
            Controls.Add(label1);
            Controls.Add(textboxApellido);
            Controls.Add(labelApellido);
            Controls.Add(textboxNombre);
            Controls.Add(labelNombre);
            Controls.Add(textboxID);
            Controls.Add(LabelID);
            Controls.Add(dataGridClientes);
            Name = "formPresentacionClientes";
            Text = "Clientes";
            Load += formPresentacionClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDescuento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridClientes;
        private Label LabelID;
        private TextBox textboxID;
        private Label labelNombre;
        private TextBox textboxNombre;
        private Label labelApellido;
        private TextBox textboxApellido;
        private Label label1;
        private TextBox textboxTelefono;
        private Label labelFechaNac;
        private DateTimePicker calendarioFechaNac;
        private Label labelDescuento;
        private NumericUpDown numericDescuento;
        private Button botonAgregarCliente;
        private Button botonLimpiarCampos;
        private Button botonEditarCliente;
        private Button buttonEliminarCliente;
    }
}
