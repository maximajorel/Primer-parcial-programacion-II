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
            
            string fechaNac = calendarioFechaNac.Value.ToString("yyyy-MM-dd");

            Negocio.ConexionSQL_Negocio conexion = new Negocio.ConexionSQL_Negocio();
            conexion.agregarCliente(textboxNombre.Text, textboxApellido.Text, textboxTelefono.Text, fechaNac, numericDescuento.Text);
            dataGridClientes.DataSource = conexion.verClientes();
            MessageBox.Show("Cliente agregado con exito");
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
            else {
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
            if (textboxID.Text == "") { 
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
    }
}
