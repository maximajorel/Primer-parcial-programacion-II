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
            SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            labelIniciarSesion.AutoSize = true;
            labelIniciarSesion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIniciarSesion.Location = new Point(113, 72);
            labelIniciarSesion.Name = "labelIniciarSesion";
            labelIniciarSesion.Size = new Size(158, 32);
            labelIniciarSesion.TabIndex = 0;
            labelIniciarSesion.Text = "Inciar sesión";
            labelIniciarSesion.Click += label1_Click;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Location = new Point(36, 157);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(47, 15);
            LabelUsuario.TabIndex = 1;
            LabelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(36, 251);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "Contraseña";
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.Location = new Point(113, 386);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(158, 23);
            botonIniciarSesion.TabIndex = 3;
            botonIniciarSesion.Text = "Iniciar Sesion";
            botonIniciarSesion.UseVisualStyleBackColor = true;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // textboxUsuario
            // 
            textboxUsuario.Location = new Point(36, 192);
            textboxUsuario.Name = "textboxUsuario";
            textboxUsuario.Size = new Size(305, 23);
            textboxUsuario.TabIndex = 4;
            textboxUsuario.TextChanged += textboxUsuario_TextChanged;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(36, 281);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(305, 23);
            textBoxContraseña.TabIndex = 5;
            textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 605);
            Controls.Add(textBoxContraseña);
            Controls.Add(textboxUsuario);
            Controls.Add(botonIniciarSesion);
            Controls.Add(labelContraseña);
            Controls.Add(LabelUsuario);
            Controls.Add(labelIniciarSesion);
            Name = "IniciarSesion";
            Text = "Form1";
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
    }
}
