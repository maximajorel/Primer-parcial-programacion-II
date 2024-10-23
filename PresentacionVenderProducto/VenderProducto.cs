using Negocio;
using System.Data;
namespace PresentacionVenderProducto
{
    public partial class VenderProducto : Form
    {
        public VenderProducto()
        {
            InitializeComponent();


        }

        private double calcularTotal()
        {
            double precioCosto = Convert.ToDouble(tablaProductos.SelectedCells[3].Value);
            double cantidad = Convert.ToDouble(numericUpDownCantidadProducto.Value);
            double porcentajeGanancia = Convert.ToDouble(tablaProductos.SelectedCells[4].Value);
            double porcentajeDescuento = Convert.ToDouble(dataGridViewClientes.SelectedCells[5].Value);
            double precioVenta = precioCosto * (1 + porcentajeGanancia / 100);
            double precioFinal = precioVenta * cantidad * (1 - porcentajeDescuento / 100);
            return precioFinal;

        }
        private void actualizarTablas() {
            ConexionSQL_Negocio conexion = new ConexionSQL_Negocio();
            DataTable tabla = conexion.verVentaProducto();
            tablaProductos.DataSource = tabla;
            DataTable tablaClientes = conexion.verClientes();
            dataGridViewClientes.DataSource = tablaClientes;
        }
        private void limpiarCampos()
        {
            textBoxIdProducto.Text = "";
            numericUpDownCantidadProducto.Value = 0;
            textBoxIdCliente.Text = "";
            textBoxApellidoNombre.Text = "";
            labelTotalProductoFinal.Text = "$0";
        }
        public List<string> listaEmpleados;
        private void obtenerNombreEmpleados() {
            ConexionSQL_Negocio conexion = new ConexionSQL_Negocio();
             listaEmpleados = conexion.obtenerNombresEmpleados();
        }
        private void llenarNombreEmpleados() {

            foreach (string nombre in listaEmpleados) {
                comboBoxVendedor.Items.Add(nombre);
            }
        }

        private void VenderProducto_Load(object sender, EventArgs e)
        {
            obtenerNombreEmpleados();
            llenarNombreEmpleados();
            actualizarTablas();




        }


        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIdProducto.Text = tablaProductos.SelectedCells[0].Value.ToString();
            numericUpDownCantidadProducto.Maximum = Convert.ToInt32(tablaProductos.SelectedCells[2].Value);
            labelTotalProductoFinal.Text = "$" + calcularTotal().ToString();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIdCliente.Text = dataGridViewClientes.SelectedCells[0].Value.ToString();
            textBoxApellidoNombre.Text = dataGridViewClientes.SelectedCells[1].Value.ToString() + " " + dataGridViewClientes.SelectedCells[2].Value.ToString();
            labelTotalProductoFinal.Text = "$" + calcularTotal().ToString();
        }

        private void numericUpDownCantidadProducto_ValueChanged(object sender, EventArgs e)
        {
            labelTotalProductoFinal.Text = "$" + calcularTotal().ToString();
        }

        private void buttonLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void buttonRealizarVenta_Click(object sender, EventArgs e)
        {
            calcularTotal();
            ConexionSQL_Negocio realizarVenta = new ConexionSQL_Negocio();
            string Tipo = textBoxTipoFactura.Text + " - Venta";
            string numeroFactura = numericUpDownNumeroFactura.Text;
            string Fecha = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
            string nombreEmpleado = comboBoxVendedor.Text;
            string nombreCliente = textBoxApellidoNombre.Text;
            string montoTotal = calcularTotal().ToString();

            realizarVenta.cargarComprobante(Tipo, numeroFactura, Fecha, nombreEmpleado, nombreCliente, montoTotal);
            realizarVenta.restarStockProducto(textBoxIdProducto.Text, numericUpDownCantidadProducto.Text);
            MessageBox.Show("Venta realizada con exito");
            actualizarTablas();
            limpiarCampos();

        }
    }
}
