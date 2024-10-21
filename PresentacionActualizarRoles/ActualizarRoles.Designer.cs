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
            LabelID = new Label();
            textboxID = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            textboxNombre = new TextBox();
            textboxApellido = new TextBox();
            label1 = new Label();
            textboxTelefono = new TextBox();
            labelFechaNac = new Label();
            calendarioFechaNac = new DateTimePicker();
            labelUsuario = new Label();
            textboxUsuario = new TextBox();
            textboxContraseña = new TextBox();
            label2 = new Label();
            labelRolUsuario = new Label();
            comboboxRolUsuario = new ComboBox();
            botonAgregarUsuario = new Button();
            botonEditarUsuario = new Button();
            button1 = new Button();
            botonLimpiarCampos = new Button();
            botonVolverMenuPrincipal = new Button();
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
            tablaUsuarios.CellClick += tablaUsuarios_CellClick;
            tablaUsuarios.CellContentClick += tablaUsuarios_CellContentClick;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelID.Location = new Point(12, 355);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(34, 30);
            LabelID.TabIndex = 1;
            LabelID.Text = "ID";
            // 
            // textboxID
            // 
            textboxID.Enabled = false;
            textboxID.Location = new Point(53, 362);
            textboxID.Name = "textboxID";
            textboxID.Size = new Size(58, 23);
            textboxID.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(12, 403);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(89, 30);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(256, 403);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(89, 30);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "Apellido";
            // 
            // textboxNombre
            // 
            textboxNombre.Location = new Point(107, 410);
            textboxNombre.Name = "textboxNombre";
            textboxNombre.Size = new Size(143, 23);
            textboxNombre.TabIndex = 5;
            // 
            // textboxApellido
            // 
            textboxApellido.Location = new Point(351, 410);
            textboxApellido.Name = "textboxApellido";
            textboxApellido.Size = new Size(234, 23);
            textboxApellido.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 456);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 7;
            label1.Text = "Telefono";
            // 
            // textboxTelefono
            // 
            textboxTelefono.Location = new Point(107, 463);
            textboxTelefono.Name = "textboxTelefono";
            textboxTelefono.Size = new Size(143, 23);
            textboxTelefono.TabIndex = 8;
            // 
            // labelFechaNac
            // 
            labelFechaNac.AutoSize = true;
            labelFechaNac.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaNac.Location = new Point(256, 456);
            labelFechaNac.Name = "labelFechaNac";
            labelFechaNac.Size = new Size(180, 30);
            labelFechaNac.TabIndex = 9;
            labelFechaNac.Text = "Fecha Nacimiento";
            // 
            // calendarioFechaNac
            // 
            calendarioFechaNac.Location = new Point(442, 463);
            calendarioFechaNac.Name = "calendarioFechaNac";
            calendarioFechaNac.Size = new Size(143, 23);
            calendarioFechaNac.TabIndex = 10;
            calendarioFechaNac.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(12, 509);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(83, 30);
            labelUsuario.TabIndex = 11;
            labelUsuario.Text = "Usuario";
            // 
            // textboxUsuario
            // 
            textboxUsuario.Location = new Point(107, 516);
            textboxUsuario.Name = "textboxUsuario";
            textboxUsuario.Size = new Size(143, 23);
            textboxUsuario.TabIndex = 12;
            // 
            // textboxContraseña
            // 
            textboxContraseña.Location = new Point(389, 516);
            textboxContraseña.Name = "textboxContraseña";
            textboxContraseña.Size = new Size(196, 23);
            textboxContraseña.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 509);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 13;
            label2.Text = "Contraseña";
            // 
            // labelRolUsuario
            // 
            labelRolUsuario.AutoSize = true;
            labelRolUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRolUsuario.Location = new Point(12, 562);
            labelRolUsuario.Name = "labelRolUsuario";
            labelRolUsuario.Size = new Size(145, 30);
            labelRolUsuario.TabIndex = 15;
            labelRolUsuario.Text = "Rol de usuario";
            // 
            // comboboxRolUsuario
            // 
            comboboxRolUsuario.FormattingEnabled = true;
            comboboxRolUsuario.Items.AddRange(new object[] { "Operador", "Auditor", "Administrador" });
            comboboxRolUsuario.Location = new Point(163, 569);
            comboboxRolUsuario.Name = "comboboxRolUsuario";
            comboboxRolUsuario.Size = new Size(422, 23);
            comboboxRolUsuario.TabIndex = 16;
            comboboxRolUsuario.Text = "Seleccione una opción";
            // 
            // botonAgregarUsuario
            // 
            botonAgregarUsuario.Location = new Point(620, 383);
            botonAgregarUsuario.Name = "botonAgregarUsuario";
            botonAgregarUsuario.Size = new Size(172, 38);
            botonAgregarUsuario.TabIndex = 17;
            botonAgregarUsuario.Text = "Agregar Usuario";
            botonAgregarUsuario.UseVisualStyleBackColor = true;
            botonAgregarUsuario.Click += botonAgregarUsuario_Click;
            // 
            // botonEditarUsuario
            // 
            botonEditarUsuario.Location = new Point(620, 448);
            botonEditarUsuario.Name = "botonEditarUsuario";
            botonEditarUsuario.Size = new Size(172, 38);
            botonEditarUsuario.TabIndex = 19;
            botonEditarUsuario.Text = "Editar usuario";
            botonEditarUsuario.UseVisualStyleBackColor = true;
            botonEditarUsuario.Click += botonEditarUsuario_Click;
            // 
            // button1
            // 
            button1.Location = new Point(620, 510);
            button1.Name = "button1";
            button1.Size = new Size(172, 38);
            button1.TabIndex = 20;
            button1.Text = "Eliminar usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // botonLimpiarCampos
            // 
            botonLimpiarCampos.Location = new Point(12, 613);
            botonLimpiarCampos.Name = "botonLimpiarCampos";
            botonLimpiarCampos.Size = new Size(172, 28);
            botonLimpiarCampos.TabIndex = 21;
            botonLimpiarCampos.Text = "Limpiar campos";
            botonLimpiarCampos.UseVisualStyleBackColor = true;
            botonLimpiarCampos.Click += botonLimpiarCampos_Click;
            // 
            // botonVolverMenuPrincipal
            // 
            botonVolverMenuPrincipal.Location = new Point(202, 613);
            botonVolverMenuPrincipal.Name = "botonVolverMenuPrincipal";
            botonVolverMenuPrincipal.Size = new Size(172, 28);
            botonVolverMenuPrincipal.TabIndex = 22;
            botonVolverMenuPrincipal.Text = "Volver al menú";
            botonVolverMenuPrincipal.UseVisualStyleBackColor = true;
            botonVolverMenuPrincipal.Click += botonVolverMenuPrincipal_Click;
            // 
            // actualizarRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 653);
            Controls.Add(botonVolverMenuPrincipal);
            Controls.Add(botonLimpiarCampos);
            Controls.Add(button1);
            Controls.Add(botonEditarUsuario);
            Controls.Add(botonAgregarUsuario);
            Controls.Add(comboboxRolUsuario);
            Controls.Add(labelRolUsuario);
            Controls.Add(textboxContraseña);
            Controls.Add(label2);
            Controls.Add(textboxUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(calendarioFechaNac);
            Controls.Add(labelFechaNac);
            Controls.Add(textboxTelefono);
            Controls.Add(label1);
            Controls.Add(textboxApellido);
            Controls.Add(textboxNombre);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textboxID);
            Controls.Add(LabelID);
            Controls.Add(tablaUsuarios);
            Name = "actualizarRoles";
            Text = "Actualizar Roles";
            Load += actualizarRoles_Load;
            ((System.ComponentModel.ISupportInitialize)tablaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaUsuarios;
        private Label LabelID;
        private TextBox textboxID;
        private Label labelNombre;
        private Label labelApellido;
        private TextBox textboxNombre;
        private TextBox textboxApellido;
        private Label label1;
        private TextBox textboxTelefono;
        private Label labelFechaNac;
        private DateTimePicker calendarioFechaNac;
        private Label labelUsuario;
        private TextBox textboxUsuario;
        private TextBox textboxContraseña;
        private Label label2;
        private Label labelRolUsuario;
        private ComboBox comboboxRolUsuario;
        private Button botonAgregarUsuario;
        private Button botonEditarUsuario;
        private Button button1;
        private Button botonLimpiarCampos;
        private Button botonVolverMenuPrincipal;
    }
}
