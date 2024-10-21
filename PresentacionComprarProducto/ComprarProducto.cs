using Negocio;
using System.Data;
namespace PresentacionComprarProducto
{
    public partial class ComprarProducto : Form
    {
        List<string> listaEmpleados;
        List<string> listaClientes;


        public void obtenerNombreEmpleados()
        {
            ConexionSQL_Negocio nombreEmpleados = new ConexionSQL_Negocio();
            listaEmpleados = nombreEmpleados.obtenerNombresEmpleados();

        }
        public void obtenerNombreClientes() {
            ConexionSQL_Negocio nombreClientes = new ConexionSQL_Negocio();
            listaClientes = nombreClientes.obtenerNombresClientes();
        }
        public void cargarComboBoxClientes()
        {
            foreach (string nombre in listaClientes)
            {
                comboBoxNombreClientes.Items.Add(nombre);
            }
        }
        public void cargarComboBoxEmpleados()
        {
            foreach (string nombre in listaEmpleados)
            {
                comboBoxEmpleados.Items.Add(nombre);
            }
        }

        public ComprarProducto()
        {
            InitializeComponent();


        }
        private void ComprarProducto_Load(object sender, EventArgs e)
        {
            obtenerNombreEmpleados();
            obtenerNombreClientes();
            cargarComboBoxClientes();
            cargarComboBoxEmpleados();
            ConexionSQL_Negocio conexionNegocio = new ConexionSQL_Negocio();
            DataTable productos = conexionNegocio.verComprarProducto();
            tablaProductos.DataSource = productos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
