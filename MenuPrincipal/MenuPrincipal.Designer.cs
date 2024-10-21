﻿namespace MenuPrincipal
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
            label1 = new Label();
            labelRolUsuarioDinamico = new Label();
            labelUsuarioDinamico = new Label();
            SuspendLayout();
            // 
            // BotonSalir
            // 
            BotonSalir.Location = new Point(498, 299);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(145, 23);
            BotonSalir.TabIndex = 1;
            BotonSalir.Text = "Salir del sistema";
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // botonActualizacionEmpleados
            // 
            botonActualizacionEmpleados.Location = new Point(64, 134);
            botonActualizacionEmpleados.Name = "botonActualizacionEmpleados";
            botonActualizacionEmpleados.Size = new Size(189, 116);
            botonActualizacionEmpleados.TabIndex = 2;
            botonActualizacionEmpleados.Text = "Actualizar Roles de usuarios";
            botonActualizacionEmpleados.UseVisualStyleBackColor = true;
            botonActualizacionEmpleados.Click += botonActualizacionEmpleados_Click;
            // 
            // botonCompraProducto
            // 
            botonCompraProducto.Location = new Point(259, 134);
            botonCompraProducto.Name = "botonCompraProducto";
            botonCompraProducto.Size = new Size(189, 116);
            botonCompraProducto.TabIndex = 3;
            botonCompraProducto.Text = "Compra de Producto";
            botonCompraProducto.UseVisualStyleBackColor = true;
            botonCompraProducto.Click += botonCompraProducto_Click;
            // 
            // botonVentaDeProductos
            // 
            botonVentaDeProductos.Location = new Point(454, 134);
            botonVentaDeProductos.Name = "botonVentaDeProductos";
            botonVentaDeProductos.Size = new Size(189, 116);
            botonVentaDeProductos.TabIndex = 4;
            botonVentaDeProductos.Text = "Venta de Productos";
            botonVentaDeProductos.UseVisualStyleBackColor = true;
            botonVentaDeProductos.Click += botonVentaDeProductos_Click;
            // 
            // botonConsultaMovimientos
            // 
            botonConsultaMovimientos.Location = new Point(64, 256);
            botonConsultaMovimientos.Name = "botonConsultaMovimientos";
            botonConsultaMovimientos.RightToLeft = RightToLeft.No;
            botonConsultaMovimientos.Size = new Size(579, 37);
            botonConsultaMovimientos.TabIndex = 5;
            botonConsultaMovimientos.Text = "Acciones de producto";
            botonConsultaMovimientos.UseVisualStyleBackColor = true;
            botonConsultaMovimientos.Click += botonConsultaMovimientos_Click;
            // 
            // labelBienvenidaEstatico
            // 
            labelBienvenidaEstatico.AutoSize = true;
            labelBienvenidaEstatico.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenidaEstatico.Location = new Point(111, 46);
            labelBienvenidaEstatico.Name = "labelBienvenidaEstatico";
            labelBienvenidaEstatico.Size = new Size(262, 32);
            labelBienvenidaEstatico.TabIndex = 6;
            labelBienvenidaEstatico.Text = "Bienvenido de nuevo,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label1.Location = new Point(117, 78);
            label1.Name = "label1";
            label1.Size = new Size(83, 13);
            label1.TabIndex = 7;
            label1.Text = "Rol de usuario:";
            // 
            // labelRolUsuarioDinamico
            // 
            labelRolUsuarioDinamico.AutoSize = true;
            labelRolUsuarioDinamico.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            labelRolUsuarioDinamico.Location = new Point(200, 78);
            labelRolUsuarioDinamico.Name = "labelRolUsuarioDinamico";
            labelRolUsuarioDinamico.Size = new Size(0, 13);
            labelRolUsuarioDinamico.TabIndex = 8;
            // 
            // labelUsuarioDinamico
            // 
            labelUsuarioDinamico.AutoSize = true;
            labelUsuarioDinamico.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuarioDinamico.Location = new Point(367, 46);
            labelUsuarioDinamico.Name = "labelUsuarioDinamico";
            labelUsuarioDinamico.Size = new Size(0, 32);
            labelUsuarioDinamico.TabIndex = 9;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(705, 377);
            Controls.Add(labelUsuarioDinamico);
            Controls.Add(labelRolUsuarioDinamico);
            Controls.Add(label1);
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
        private Label label1;
        private Label labelRolUsuarioDinamico;
        private Label labelUsuarioDinamico;
    }
}
