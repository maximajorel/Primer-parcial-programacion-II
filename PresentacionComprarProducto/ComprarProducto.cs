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
        public void limpiarCampos()
        {

            textBoxIDProducto.Text = "";
            textBoxNombreProducto.Text = "";
            textBoxNumeroFactura.Text = "";
            comboBoxEmpleados.Text = "";
            comboBoxNombreClientes.Text = "";
            numericUpCantidadProducto.Value = 0;
            labelTotalCompraProducto.Text = "0";


        }
        public void RealizarCalculo()
        {

            double porcentajeGanancia = obtenerPorcentajeGanancia(textBoxIDProducto.Text);
            double precioCosto = obtenerPrecioCosto(textBoxIDProducto.Text);
            int cantidadProductos = Convert.ToInt32(numericUpCantidadProducto.Text);
            double total = (porcentajeGanancia / 100) * precioCosto * cantidadProductos;
            labelTotalCompraProducto.Text = total.ToString();
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


        private void numericUpCantidadProducto_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxIDProducto.Text))
            {
                double porcentajeGanancia = obtenerPorcentajeGanancia(textBoxIDProducto.Text);
                double precioCosto = obtenerPrecioCosto(textBoxIDProducto.Text);
                int cantidadProductos = Convert.ToInt32(numericUpCantidadProducto.Text);
                double total = (porcentajeGanancia / 100) * precioCosto * cantidadProductos;
                labelTotalCompraProducto.Text = total.ToString();
            }
        }

        private void buttonLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDProducto.Text = tablaProductos.SelectedCells[0].Value.ToString();
            textBoxNombreProducto.Text = tablaProductos.SelectedCells[2].Value.ToString();
            RealizarCalculo();

        }

        private void buttonCargarFactura_Click(object sender, EventArgs e)
        {
            if (textBoxIDProducto.Text == "" || textBoxNumeroFactura.Text == "" || texboxTipoComprobante.Text == "" || dateTimePicker1.Text == "" || comboBoxEmpleados.Text == "" || comboBoxNombreClientes.Text == "")
            {

                MessageBox.Show("Por favor llene todos los campos");    



            }
            else {
                ConexionSQL_Negocio cargarFactura = new ConexionSQL_Negocio();
                RealizarCalculo();
                string Tipo = texboxTipoComprobante.Text;
                string NumeroFactura = textBoxNumeroFactura.Text;
                string Fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string NombreCliente = comboBoxNombreClientes.Text;
                string NombreEmpleado = comboBoxEmpleados.Text;
                string montoTotal = labelTotalCompraProducto.Text;
                cargarFactura.cargarComprobante(Tipo, NumeroFactura, Fecha, NombreEmpleado, NombreCliente, montoTotal);
                cargarFactura.actualizarStock(textBoxIDProducto.Text, numericUpCantidadProducto.Text);
                limpiarCampos();
                MessageBox.Show("Compra Realizada con exito");
            }


        }
    }
}
