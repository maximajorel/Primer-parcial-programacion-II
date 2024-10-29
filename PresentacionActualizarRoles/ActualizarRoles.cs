using System.Data;
using Negocio;

namespace PresentacionActualizarRoles
{
    public partial class actualizarRoles : Form
    {
        private ConexionSQL_Negocio consultaUsuarios;
        public bool volvermenu = false;
        public actualizarRoles()
        {
            InitializeComponent();

        }
        // Deshabilitar botones si los campos de textos se encuentran vacios
        
        public void LimpiarCajas()
        {
            textboxID.Text = "";
            textboxApellido.Text = "";
            textboxNombre.Text = "";
            textboxTelefono.Text = "";
            calendarioFechaNac.Text = "";
            textboxUsuario.Text = "";
            textboxContraseña.Text = "";
            comboboxRolUsuario.Text = "";
        }
        // Funcion para actualizar tablaUsuarios

        public void actualizarDatos()
        {
            ConexionSQL_Negocio consultaUsuarios = new ConexionSQL_Negocio(); ;
            DataTable usuarios = consultaUsuarios.verUsuarios();
            tablaUsuarios.DataSource = usuarios;
        }
        private void actualizarRoles_Load(object sender, EventArgs e)

        {
            actualizarDatos();
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxID.Text = tablaUsuarios.SelectedCells[0].Value.ToString();
            textboxApellido.Text = tablaUsuarios.SelectedCells[1].Value.ToString();
            textboxNombre.Text = tablaUsuarios.SelectedCells[2].Value.ToString();
            textboxTelefono.Text = tablaUsuarios.SelectedCells[3].Value.ToString();
            calendarioFechaNac.Text = tablaUsuarios.SelectedCells[4].Value.ToString();
            textboxUsuario.Text = tablaUsuarios.SelectedCells[5].Value.ToString();
            textboxContraseña.Text = tablaUsuarios.SelectedCells[6].Value.ToString();
            comboboxRolUsuario.Text = tablaUsuarios.SelectedCells[7].Value.ToString();
        }

        private void botonLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void botonAgregarUsuario_Click(object sender, EventArgs e)
        {
            DateTime fechaNac = calendarioFechaNac.Value;
            DateTime maxFechaNac = new DateTime(2010, 12, 31);

            if (fechaNac > maxFechaNac)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser posterior a 2010.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textboxApellido.Text) ||
                string.IsNullOrWhiteSpace(textboxNombre.Text) ||
                string.IsNullOrWhiteSpace(textboxTelefono.Text) ||
                string.IsNullOrWhiteSpace(textboxUsuario.Text) ||
                string.IsNullOrWhiteSpace(textboxContraseña.Text) ||
                string.IsNullOrWhiteSpace(comboboxRolUsuario.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios.");
            }
            else
            {
                string fechaNacStr = calendarioFechaNac.Value.ToString("yyyy-MM-dd");
                ConexionSQL_Negocio agregarUsuario = new ConexionSQL_Negocio();
                agregarUsuario.agregarUsuario(textboxApellido.Text, textboxNombre.Text, textboxTelefono.Text, fechaNacStr, textboxUsuario.Text, textboxContraseña.Text, comboboxRolUsuario.Text);
                LimpiarCajas();
                actualizarDatos();
                MessageBox.Show("Usuario agregado con éxito");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textboxID.Text == "")
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
            }
            else {
                // Eliminar usuario
                ConexionSQL_Negocio eliminarUsuario = new ConexionSQL_Negocio();
                eliminarUsuario.eliminarUsuario(textboxID.Text);
                LimpiarCajas();
                actualizarDatos();
                MessageBox.Show("Usuario eliminado con exito");
            }


        }

        private void botonEditarUsuario_Click(object sender, EventArgs e)
        {

            if (textboxID.Text == "")
            {
                MessageBox.Show("Seleccione un usuario para editar");
            }
            else {
                // Editar usuario
                ConexionSQL_Negocio editarUsuario = new ConexionSQL_Negocio();
                string fechaNac = calendarioFechaNac.Value.ToString("yyyy-MM-dd");
                editarUsuario.editarUsuario(textboxID.Text, textboxApellido.Text, textboxNombre.Text, textboxTelefono.Text, fechaNac, textboxUsuario.Text, textboxContraseña.Text, comboboxRolUsuario.Text);
                LimpiarCajas();
                actualizarDatos();
                MessageBox.Show("Usuario editado con exito");
            }


        }

        private void botonVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            volvermenu = true;
            this.Hide();
        }
    }
}
