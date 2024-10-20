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
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            SuspendLayout();
            // 
            // tablaProductos
            // 
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new Point(288, 12);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.Size = new Size(258, 263);
            tablaProductos.TabIndex = 0;
            tablaProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 554);
            Controls.Add(tablaProductos);
            Name = "ComprarProducto";
            Text = "Comprar Producto";
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaProductos;
    }
}
