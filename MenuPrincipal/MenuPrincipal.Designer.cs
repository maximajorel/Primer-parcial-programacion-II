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
            SuspendLayout();
            // 
            // BotonSalir
            // 
            BotonSalir.Location = new Point(643, 415);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(145, 23);
            BotonSalir.TabIndex = 1;
            BotonSalir.Text = "Salir del sistema";
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // botonActualizacionEmpleados
            // 
            botonActualizacionEmpleados.Location = new Point(88, 130);
            botonActualizacionEmpleados.Name = "botonActualizacionEmpleados";
            botonActualizacionEmpleados.Size = new Size(189, 116);
            botonActualizacionEmpleados.TabIndex = 2;
            botonActualizacionEmpleados.Text = "Actualizar Roles de usuarios";
            botonActualizacionEmpleados.UseVisualStyleBackColor = true;
            botonActualizacionEmpleados.Click += botonActualizacionEmpleados_Click;
            // 
            // botonCompraProducto
            // 
            botonCompraProducto.Location = new Point(283, 130);
            botonCompraProducto.Name = "botonCompraProducto";
            botonCompraProducto.Size = new Size(189, 116);
            botonCompraProducto.TabIndex = 3;
            botonCompraProducto.Text = "Compra de Producto";
            botonCompraProducto.UseVisualStyleBackColor = true;
            botonCompraProducto.Click += botonCompraProducto_Click;
            // 
            // botonVentaDeProductos
            // 
            botonVentaDeProductos.Location = new Point(478, 130);
            botonVentaDeProductos.Name = "botonVentaDeProductos";
            botonVentaDeProductos.Size = new Size(189, 116);
            botonVentaDeProductos.TabIndex = 4;
            botonVentaDeProductos.Text = "Venta de Productos";
            botonVentaDeProductos.UseVisualStyleBackColor = true;
            botonVentaDeProductos.Click += botonVentaDeProductos_Click;
            // 
            // botonConsultaMovimientos
            // 
            botonConsultaMovimientos.Location = new Point(88, 252);
            botonConsultaMovimientos.Name = "botonConsultaMovimientos";
            botonConsultaMovimientos.RightToLeft = RightToLeft.No;
            botonConsultaMovimientos.Size = new Size(579, 37);
            botonConsultaMovimientos.TabIndex = 5;
            botonConsultaMovimientos.Text = "Acciones de producto";
            botonConsultaMovimientos.UseVisualStyleBackColor = true;
            botonConsultaMovimientos.Click += botonConsultaMovimientos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonConsultaMovimientos);
            Controls.Add(botonVentaDeProductos);
            Controls.Add(botonCompraProducto);
            Controls.Add(botonActualizacionEmpleados);
            Controls.Add(BotonSalir);
            Name = "MenuPrincipal";
            Text = "Menú Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button BotonSalir;
        private Button botonActualizacionEmpleados;
        private Button botonCompraProducto;
        private Button botonVentaDeProductos;
        private Button botonConsultaMovimientos;
    }
}
