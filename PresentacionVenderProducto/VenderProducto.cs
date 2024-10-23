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

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VenderProducto_Load(object sender, EventArgs e)
        {
            ConexionSQL_Negocio conexion = new ConexionSQL_Negocio();
            DataTable tabla = conexion.verVentaProducto();
            tablaProductos.DataSource = tabla;



            DataTable tablaClientes = conexion.verClientes();
            dataGridViewClientes.DataSource = tablaClientes;
        }
    }
}
