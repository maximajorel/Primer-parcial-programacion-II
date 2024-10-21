namespace MenuPrincipal
{
    partial class MenuPrincipal
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
            BotonSalir = new Button();
            botonActualizacionEmpleados = new Button();
            botonCompraProducto = new Button();
            botonVentaDeProductos = new Button();
            botonConsultaMovimientos = new Button();
            labelBienvenidaEstatico = new Label();
            labelTituloRolUsuario = new Label();
            labelRolUsuarioDinamico = new Label();
            labelUsuarioDinamico = new Label();
            buttonGestionarClientes = new Button();
            buttonVerComprobantes = new Button();
            SuspendLayout();
            // 
            // BotonSalir
            // 
            BotonSalir.Location = new Point(673, 421);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(145, 23);
            BotonSalir.TabIndex = 1;
            BotonSalir.Text = "Salir del sistema";
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // botonActualizacionEmpleados
            // 
            botonActualizacionEmpleados.Location = new Point(44, 131);
            botonActualizacionEmpleados.Name = "botonActualizacionEmpleados";
            botonActualizacionEmpleados.Size = new Size(189, 116);
            botonActualizacionEmpleados.TabIndex = 2;
            botonActualizacionEmpleados.Text = "Actualizar Roles de usuarios";
            botonActualizacionEmpleados.UseVisualStyleBackColor = true;
            botonActualizacionEmpleados.Click += botonActualizacionEmpleados_Click;
            // 
            // botonCompraProducto
            // 
            botonCompraProducto.Location = new Point(239, 131);
            botonCompraProducto.Name = "botonCompraProducto";
            botonCompraProducto.Size = new Size(189, 116);
            botonCompraProducto.TabIndex = 3;
            botonCompraProducto.Text = "Compra de Producto";
            botonCompraProducto.UseVisualStyleBackColor = true;
            botonCompraProducto.Click += botonCompraProducto_Click;
            // 
            // botonVentaDeProductos
            // 
            botonVentaDeProductos.Location = new Point(434, 131);
            botonVentaDeProductos.Name = "botonVentaDeProductos";
            botonVentaDeProductos.Size = new Size(189, 116);
            botonVentaDeProductos.TabIndex = 4;
            botonVentaDeProductos.Text = "Venta de Productos";
            botonVentaDeProductos.UseVisualStyleBackColor = true;
            botonVentaDeProductos.Click += botonVentaDeProductos_Click;
            // 
            // botonConsultaMovimientos
            // 
            botonConsultaMovimientos.Location = new Point(629, 131);
            botonConsultaMovimientos.Name = "botonConsultaMovimientos";
            botonConsultaMovimientos.RightToLeft = RightToLeft.No;
            botonConsultaMovimientos.Size = new Size(189, 116);
            botonConsultaMovimientos.TabIndex = 5;
            botonConsultaMovimientos.Text = "Acciones de producto";
            botonConsultaMovimientos.UseVisualStyleBackColor = true;
            botonConsultaMovimientos.Click += botonConsultaMovimientos_Click;
            // 
            // labelBienvenidaEstatico
            // 
            labelBienvenidaEstatico.AutoSize = true;
            labelBienvenidaEstatico.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenidaEstatico.Location = new Point(44, 35);
            labelBienvenidaEstatico.Name = "labelBienvenidaEstatico";
            labelBienvenidaEstatico.Size = new Size(262, 32);
            labelBienvenidaEstatico.TabIndex = 6;
            labelBienvenidaEstatico.Text = "Bienvenido de nuevo,";
            // 
            // labelTituloRolUsuario
            // 
            labelTituloRolUsuario.AutoSize = true;
            labelTituloRolUsuario.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            labelTituloRolUsuario.Location = new Point(50, 67);
            labelTituloRolUsuario.Name = "labelTituloRolUsuario";
            labelTituloRolUsuario.Size = new Size(83, 13);
            labelTituloRolUsuario.TabIndex = 7;
            labelTituloRolUsuario.Text = "Rol de usuario:";
            // 
            // labelRolUsuarioDinamico
            // 
            labelRolUsuarioDinamico.AutoSize = true;
            labelRolUsuarioDinamico.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            labelRolUsuarioDinamico.Location = new Point(133, 67);
            labelRolUsuarioDinamico.Name = "labelRolUsuarioDinamico";
            labelRolUsuarioDinamico.Size = new Size(0, 13);
            labelRolUsuarioDinamico.TabIndex = 8;
            // 
            // labelUsuarioDinamico
            // 
            labelUsuarioDinamico.AutoSize = true;
            labelUsuarioDinamico.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuarioDinamico.Location = new Point(302, 35);
            labelUsuarioDinamico.Name = "labelUsuarioDinamico";
            labelUsuarioDinamico.Size = new Size(0, 32);
            labelUsuarioDinamico.TabIndex = 9;
            // 
            // buttonGestionarClientes
            // 
            buttonGestionarClientes.Location = new Point(239, 253);
            buttonGestionarClientes.Name = "buttonGestionarClientes";
            buttonGestionarClientes.RightToLeft = RightToLeft.No;
            buttonGestionarClientes.Size = new Size(189, 116);
            buttonGestionarClientes.TabIndex = 10;
            buttonGestionarClientes.Text = "Gestionar Clientes";
            buttonGestionarClientes.UseVisualStyleBackColor = true;
            buttonGestionarClientes.Click += buttonGestionarClientes_Click;
            // 
            // buttonVerComprobantes
            // 
            buttonVerComprobantes.Location = new Point(434, 253);
            buttonVerComprobantes.Name = "buttonVerComprobantes";
            buttonVerComprobantes.RightToLeft = RightToLeft.No;
            buttonVerComprobantes.Size = new Size(189, 116);
            buttonVerComprobantes.TabIndex = 11;
            buttonVerComprobantes.Text = "Ver comprobantes";
            buttonVerComprobantes.UseVisualStyleBackColor = true;
            buttonVerComprobantes.Click += buttonVerComprobantes_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 477);
            Controls.Add(buttonVerComprobantes);
            Controls.Add(buttonGestionarClientes);
            Controls.Add(labelUsuarioDinamico);
            Controls.Add(labelRolUsuarioDinamico);
            Controls.Add(labelTituloRolUsuario);
            Controls.Add(labelBienvenidaEstatico);
            Controls.Add(botonConsultaMovimientos);
            Controls.Add(botonVentaDeProductos);
            Controls.Add(botonCompraProducto);
            Controls.Add(botonActualizacionEmpleados);
            Controls.Add(BotonSalir);
            Name = "MenuPrincipal";
            Text = "Menú Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BotonSalir;
        private Button botonActualizacionEmpleados;
        private Button botonCompraProducto;
        private Button botonVentaDeProductos;
        private Button botonConsultaMovimientos;
        private Label labelBienvenidaEstatico;
        private Label labelTituloRolUsuario;
        private Label labelRolUsuarioDinamico;
        private Label labelUsuarioDinamico;
        private Button buttonGestionarClientes;
        private Button buttonVerComprobantes;
    }
}
