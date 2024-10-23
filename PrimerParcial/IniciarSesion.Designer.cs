namespace PrimerParcial
{
    partial class IniciarSesion
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
            labelIniciarSesion = new Label();
            LabelUsuario = new Label();
            labelContraseña = new Label();
            botonIniciarSesion = new Button();
            textboxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            labelIniciarSesion.AutoSize = true;
            labelIniciarSesion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIniciarSesion.ForeColor = Color.White;
            labelIniciarSesion.Location = new Point(59, 56);
            labelIniciarSesion.Name = "labelIniciarSesion";
            labelIniciarSesion.Size = new Size(264, 32);
            labelIniciarSesion.TabIndex = 0;
            labelIniciarSesion.Text = "Bienvenido al Sistema";
            labelIniciarSesion.Click += label1_Click;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.White;
            LabelUsuario.Location = new Point(36, 157);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(62, 20);
            LabelUsuario.TabIndex = 1;
            LabelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            labelContraseña.ForeColor = Color.White;
            labelContraseña.Location = new Point(36, 251);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(86, 20);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "Contraseña";
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.BackColor = Color.FromArgb(187, 107, 220);
            botonIniciarSesion.BackgroundImageLayout = ImageLayout.None;
            botonIniciarSesion.Cursor = Cursors.Hand;
            botonIniciarSesion.FlatAppearance.BorderSize = 0;
            botonIniciarSesion.FlatStyle = FlatStyle.Flat;
            botonIniciarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonIniciarSesion.ForeColor = Color.White;
            botonIniciarSesion.Location = new Point(106, 355);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(158, 61);
            botonIniciarSesion.TabIndex = 3;
            botonIniciarSesion.Text = "Iniciar Sesion";
            botonIniciarSesion.UseVisualStyleBackColor = false;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // textboxUsuario
            // 
            textboxUsuario.BackColor = Color.FromArgb(37, 37, 37);
            textboxUsuario.BorderStyle = BorderStyle.None;
            textboxUsuario.ForeColor = Color.White;
            textboxUsuario.Location = new Point(36, 192);
            textboxUsuario.Name = "textboxUsuario";
            textboxUsuario.Size = new Size(305, 16);
            textboxUsuario.TabIndex = 4;
            textboxUsuario.TextChanged += textboxUsuario_TextChanged;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.FromArgb(37, 37, 37);
            textBoxContraseña.BorderStyle = BorderStyle.None;
            textBoxContraseña.ForeColor = Color.White;
            textBoxContraseña.Location = new Point(36, 281);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(305, 16);
            textBoxContraseña.TabIndex = 5;
            textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(187, 107, 220);
            panel2.Location = new Point(36, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 3);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(187, 107, 220);
            panel3.Location = new Point(36, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 3);
            panel3.TabIndex = 7;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(365, 466);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(textBoxContraseña);
            Controls.Add(textboxUsuario);
            Controls.Add(botonIniciarSesion);
            Controls.Add(labelContraseña);
            Controls.Add(LabelUsuario);
            Controls.Add(labelIniciarSesion);
            Name = "IniciarSesion";
            Text = "Iniciar Sesion";
            Load += IniciarSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIniciarSesion;
        private Label LabelUsuario;
        private Label labelContraseña;
        private Button botonIniciarSesion;
        private TextBox textboxUsuario;
        private TextBox textBoxContraseña;
        private Panel panel2;
        private Panel panel3;
    }
}
