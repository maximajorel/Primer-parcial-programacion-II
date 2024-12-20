using Negocio;
namespace Presentacion_AgregarCliente

{
    public partial class formPresentacionClientes : Form
    {
        public formPresentacionClientes()
        {
            InitializeComponent();
        }


        // Limpiar todos los textbox
        public void LimpiarCajas()
        {
            textboxID.Text = "";
            textboxNombre.Text = "";
            textboxApellido.Text = "";
            textboxTelefono.Text = "";
            calendarioFechaNac.Text = "";
            numericDescuento.Text = "";
        }
        private void formPresentacionClientes_Load_1(object sender, EventArgs e)
        {
            Negocio.ConexionSQL_Negocio conexion = new Negocio.ConexionSQL_Negocio();
            dataGridClientes.DataSource = conexion.verClientes();

        }
        // Click agregar cliente
        private void botonAgregarCliente_Click(object sender, EventArgs e)
        {
            DateTime fechaNac = calendarioFechaNac.Value;
            DateTime maxFechaNac = new DateTime(2010, 12, 31);

            if (fechaNac > maxFechaNac)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser posterior a 2010.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textboxNombre.Text) ||
                string.IsNullOrWhiteSpace(textboxApellido.Text) ||
                string.IsNullOrWhiteSpace(textboxTelefono.Text) ||
                string.IsNullOrWhiteSpace(numericDescuento.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios.");
            }
            else
            {
                string fechaNacStr = calendarioFechaNac.Value.ToString("yyyy-MM-dd");
                Negocio.ConexionSQL_Negocio conexion = new Negocio.ConexionSQL_Negocio();
                conexion.agregarCliente(textboxNombre.Text, textboxApellido.Text, textboxTelefono.Text, fechaNacStr, numericDescuento.Text);
                dataGridClientes.DataSource = conexion.verClientes();
                MessageBox.Show("Cliente agregado con �xito");
            }
        }
        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Rellenar campos de texto segun la fila seleccionada
            textboxID.Text = dataGridClientes.SelectedCells[0].Value.ToString();
            textboxNombre.Text = dataGridClientes.SelectedCells[1].Value.ToString();
            textboxApellido.Text = dataGridClientes.SelectedCells[2].Value.ToString();
            textboxTelefono.Text = dataGridClientes.SelectedCells[3].Value.ToString();
            calendarioFechaNac.Text = dataGridClientes.SelectedCells[4].Value.ToString();
            numericDescuento.Text = dataGridClientes.SelectedCells[5].Value.ToString();


        }

        private void botonLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void botonEditarCliente_Click(object sender, EventArgs e)
        {
            if (textboxID.Text == "")
            {
                MessageBox.Show("Seleccione un cliente para editar");
            }
            else
            {
                string fechaNac = calendarioFechaNac.Value.ToString("yyyy-MM-dd");
                Negocio.ConexionSQL_Negocio conexion = new Negocio.ConexionSQL_Negocio();
                conexion.editarCliente(textboxID.Text, textboxNombre.Text, textboxApellido.Text, textboxTelefono.Text, fechaNac, numericDescuento.Text);
                dataGridClientes.DataSource = conexion.verClientes();
                LimpiarCajas();
                MessageBox.Show("Cliente editado con exito");
            }

        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            if (textboxID.Text == "")
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
            }

            else
            {

                Negocio.ConexionSQL_Negocio conexion = new Negocio.ConexionSQL_Negocio();
                conexion.eliminarCliente(textboxID.Text);
                dataGridClientes.DataSource = conexion.verClientes();
                LimpiarCajas();
                MessageBox.Show("Cliente eliminado con exito");
            }

        }

        private void textboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir numeros en el nombre o caracteres especiales
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten n�meros o caracteres especiales en el nombre");
            }
        }

        private void textboxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir numeros en el nombre o caracteres especiales
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten n�meros o caracteres especiales en el nombre");
            }
        }

        private void textboxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir letras en el telefono o caracteres especiales
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras o caracteres especiales en el tel�fono");
            }
        }
    }
}
