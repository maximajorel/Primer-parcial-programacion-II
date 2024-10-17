namespace PresentacionActualizarRoles
{
    partial class actualizarRoles
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
            tablaUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tablaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // tablaUsuarios
            // 
            tablaUsuarios.AllowUserToAddRows = false;
            tablaUsuarios.AllowUserToDeleteRows = false;
            tablaUsuarios.AllowUserToOrderColumns = true;
            tablaUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            tablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            tablaUsuarios.Location = new Point(12, 12);
            tablaUsuarios.MultiSelect = false;
            tablaUsuarios.Name = "tablaUsuarios";
            tablaUsuarios.ReadOnly = true;
            tablaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaUsuarios.Size = new Size(780, 324);
            tablaUsuarios.TabIndex = 0;
            tablaUsuarios.CellContentClick += tablaUsuarios_CellContentClick;
            // 
            // actualizarRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 538);
            Controls.Add(tablaUsuarios);
            Name = "actualizarRoles";
            Text = "Actualizar Roles";
            Load += actualizarRoles_Load;
            ((System.ComponentModel.ISupportInitialize)tablaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaUsuarios;
    }
}
