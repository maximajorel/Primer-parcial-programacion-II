﻿namespace PresentacionConsultaMovimientos
{
    partial class ConsultaMovimiento
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
            tablaProductos = new DataGridView();
            LabelID = new Label();
            textboxID = new TextBox();
            labelCodigoProducto = new Label();
            textboxCodigoProducto = new TextBox();
            labelNombreProductoLargo = new Label();
            textBoxNombreProducto = new TextBox();
            label1 = new Label();
            textBoxNombreCortoProducto = new TextBox();
            labelPrecioCosto = new Label();
            textBoxPrecioCosto = new TextBox();
            labelStock = new Label();
            textboxStockActual = new TextBox();
            labelStockMinimo = new Label();
            textBoxStockMinimo = new TextBox();
            labelPorcentajeGanancia = new Label();
            textBoxPorcentajeGanancia = new TextBox();
            botonAgregarProducto = new Button();
            botonLimpiarCampos = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            SuspendLayout();
            // 
            // tablaProductos
            // 
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new Point(12, 12);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.ReadOnly = true;
            tablaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaProductos.Size = new Size(941, 280);
            tablaProductos.TabIndex = 0;
            tablaProductos.CellClick += tablaProductos_CellClick;
            tablaProductos.CellContentClick += tablaProductos_CellContentClick;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelID.Location = new Point(12, 323);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(34, 30);
            LabelID.TabIndex = 2;
            LabelID.Text = "ID";
            // 
            // textboxID
            // 
            textboxID.Enabled = false;
            textboxID.Location = new Point(52, 330);
            textboxID.Name = "textboxID";
            textboxID.Size = new Size(58, 23);
            textboxID.TabIndex = 3;
            // 
            // labelCodigoProducto
            // 
            labelCodigoProducto.AutoSize = true;
            labelCodigoProducto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCodigoProducto.Location = new Point(12, 372);
            labelCodigoProducto.Name = "labelCodigoProducto";
            labelCodigoProducto.Size = new Size(198, 30);
            labelCodigoProducto.TabIndex = 4;
            labelCodigoProducto.Text = "Codigo de producto";
            // 
            // textboxCodigoProducto
            // 
            textboxCodigoProducto.Location = new Point(216, 379);
            textboxCodigoProducto.Name = "textboxCodigoProducto";
            textboxCodigoProducto.Size = new Size(143, 23);
            textboxCodigoProducto.TabIndex = 6;
            // 
            // labelNombreProductoLargo
            // 
            labelNombreProductoLargo.AutoSize = true;
            labelNombreProductoLargo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreProductoLargo.Location = new Point(12, 418);
            labelNombreProductoLargo.Name = "labelNombreProductoLargo";
            labelNombreProductoLargo.Size = new Size(208, 30);
            labelNombreProductoLargo.TabIndex = 7;
            labelNombreProductoLargo.Text = "Nombre de producto";
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(216, 425);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(143, 23);
            textBoxNombreProducto.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 418);
            label1.Name = "label1";
            label1.Size = new Size(262, 30);
            label1.TabIndex = 9;
            label1.Text = "Nombre corto de producto";
            // 
            // textBoxNombreCortoProducto
            // 
            textBoxNombreCortoProducto.Location = new Point(633, 425);
            textBoxNombreCortoProducto.Name = "textBoxNombreCortoProducto";
            textBoxNombreCortoProducto.Size = new Size(143, 23);
            textBoxNombreCortoProducto.TabIndex = 10;
            // 
            // labelPrecioCosto
            // 
            labelPrecioCosto.AutoSize = true;
            labelPrecioCosto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrecioCosto.Location = new Point(12, 463);
            labelPrecioCosto.Name = "labelPrecioCosto";
            labelPrecioCosto.Size = new Size(129, 30);
            labelPrecioCosto.TabIndex = 11;
            labelPrecioCosto.Text = "Precio Costo";
            // 
            // textBoxPrecioCosto
            // 
            textBoxPrecioCosto.Location = new Point(147, 470);
            textBoxPrecioCosto.Name = "textBoxPrecioCosto";
            textBoxPrecioCosto.Size = new Size(212, 23);
            textBoxPrecioCosto.TabIndex = 12;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStock.Location = new Point(12, 507);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(127, 30);
            labelStock.TabIndex = 13;
            labelStock.Text = "Stock Actual";
            // 
            // textboxStockActual
            // 
            textboxStockActual.Location = new Point(147, 514);
            textboxStockActual.Name = "textboxStockActual";
            textboxStockActual.Size = new Size(212, 23);
            textboxStockActual.TabIndex = 14;
            // 
            // labelStockMinimo
            // 
            labelStockMinimo.AutoSize = true;
            labelStockMinimo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStockMinimo.Location = new Point(365, 507);
            labelStockMinimo.Name = "labelStockMinimo";
            labelStockMinimo.Size = new Size(139, 30);
            labelStockMinimo.TabIndex = 15;
            labelStockMinimo.Text = "Stock Minimo";
            // 
            // textBoxStockMinimo
            // 
            textBoxStockMinimo.Location = new Point(510, 514);
            textBoxStockMinimo.Name = "textBoxStockMinimo";
            textBoxStockMinimo.Size = new Size(266, 23);
            textBoxStockMinimo.TabIndex = 16;
            // 
            // labelPorcentajeGanancia
            // 
            labelPorcentajeGanancia.AutoSize = true;
            labelPorcentajeGanancia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPorcentajeGanancia.Location = new Point(365, 463);
            labelPorcentajeGanancia.Name = "labelPorcentajeGanancia";
            labelPorcentajeGanancia.Size = new Size(229, 30);
            labelPorcentajeGanancia.TabIndex = 17;
            labelPorcentajeGanancia.Text = "Porcentaje de ganancia";
            // 
            // textBoxPorcentajeGanancia
            // 
            textBoxPorcentajeGanancia.Location = new Point(590, 470);
            textBoxPorcentajeGanancia.Name = "textBoxPorcentajeGanancia";
            textBoxPorcentajeGanancia.Size = new Size(186, 23);
            textBoxPorcentajeGanancia.TabIndex = 18;
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Location = new Point(793, 330);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new Size(160, 68);
            botonAgregarProducto.TabIndex = 19;
            botonAgregarProducto.Text = "Agregar Producto";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += botonAgregarProducto_Click;
            // 
            // botonLimpiarCampos
            // 
            botonLimpiarCampos.Location = new Point(12, 560);
            botonLimpiarCampos.Name = "botonLimpiarCampos";
            botonLimpiarCampos.Size = new Size(172, 28);
            botonLimpiarCampos.TabIndex = 22;
            botonLimpiarCampos.Text = "Limpiar campos";
            botonLimpiarCampos.UseVisualStyleBackColor = true;
            botonLimpiarCampos.Click += botonLimpiarCampos_Click;
            // 
            // ConsultaMovimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 687);
            Controls.Add(botonLimpiarCampos);
            Controls.Add(botonAgregarProducto);
            Controls.Add(textBoxPorcentajeGanancia);
            Controls.Add(labelPorcentajeGanancia);
            Controls.Add(textBoxStockMinimo);
            Controls.Add(labelStockMinimo);
            Controls.Add(textboxStockActual);
            Controls.Add(labelStock);
            Controls.Add(textBoxPrecioCosto);
            Controls.Add(labelPrecioCosto);
            Controls.Add(textBoxNombreCortoProducto);
            Controls.Add(label1);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(labelNombreProductoLargo);
            Controls.Add(textboxCodigoProducto);
            Controls.Add(labelCodigoProducto);
            Controls.Add(textboxID);
            Controls.Add(LabelID);
            Controls.Add(tablaProductos);
            Name = "ConsultaMovimiento";
            Text = "Form1";
            Load += ConsultaMovimiento_Load;
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaProductos;
        private Label LabelID;
        private TextBox textboxID;
        private Label labelCodigoProducto;
        private TextBox textboxCodigoProducto;
        private Label labelNombreProductoLargo;
        private TextBox textBoxNombreProducto;
        private Label label1;
        private TextBox textBoxNombreCortoProducto;
        private Label labelPrecioCosto;
        private TextBox textBoxPrecioCosto;
        private Label labelStock;
        private TextBox textboxStockActual;
        private Label labelStockMinimo;
        private TextBox textBoxStockMinimo;
        private Label labelPorcentajeGanancia;
        private TextBox textBoxPorcentajeGanancia;
        private Button botonAgregarProducto;
        private Button botonLimpiarCampos;
    }
}