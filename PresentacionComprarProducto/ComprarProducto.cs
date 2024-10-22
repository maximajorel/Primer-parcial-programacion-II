using Negocio;
using System.Data;
namespace PresentacionComprarProducto
{
    public partial class ComprarProducto : Form
    {
        List<string> listaEmpleados;
        List<string> listaClientes;


        public double obtenerPrecioCosto(string id)
        {

            ConexionSQL_Negocio obtenerPrecioCosto = new ConexionSQL_Negocio();
            return obtenerPrecioCosto.obtenerPrecioCostoProducto(id);

        }
        public double obtenerPorcentajeGanancia(string id)
        {

            ConexionSQL_Negocio obtenerPorcentajeGanancia = new ConexionSQL_Negocio();
            return obtenerPorcentajeGanancia.obtenerGananciaProducto(id);
        }

        public void obtenerNombreEmpleados()
        {
            ConexionSQL_Negocio nombreEmpleados = new ConexionSQL_Negocio();
            listaEmpleados = nombreEmpleados.obtenerNombresEmpleados();

        }
        public void obtenerNombreClientes()
        {
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
            textBoxIDProducto.Text = tablaProductos.CurrentRow.Cells[0].Value.ToString();
            textBoxNombreProducto.Text = tablaProductos.CurrentRow.Cells[2].Value.ToString();
        }
        
        private void numericUpCantidadProducto_ValueChanged(object sender, EventArgs e)
        {
            double porcentajeGanancia = obtenerPorcentajeGanancia(textBoxIDProducto.Text);
            double precioCosto = obtenerPrecioCosto(textBoxIDProducto.Text);
            int cantidadProductos = Convert.ToInt32(numericUpCantidadProducto.Text);
            double total = (porcentajeGanancia / 100) * precioCosto * cantidadProductos;
            labelTotalCompraProducto.Text = total.ToString();


        }
    }
}
