using Negocio;
using System.Data;
namespace PresentacionVenderProducto
{
    public partial class VenderProducto : Form
    {
        public VenderProducto()
        {
            InitializeComponent();
            ConexionSQL_Negocio conexion = new ConexionSQL_Negocio();
            DataTable tabla = conexion.verVentaProducto();
            tablaProductos.DataSource = tabla;

        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
