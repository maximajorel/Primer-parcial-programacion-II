using Negocio;
using System.Data;
namespace PresentacionComprarProducto
{
    public partial class ComprarProducto : Form
    {
        public ComprarProducto()
        {
            InitializeComponent();
            ConexionSQL_Negocio conexionNegocio = new ConexionSQL_Negocio();
            DataTable productos = conexionNegocio.verComprarProducto();
            tablaProductos.DataSource = productos;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComprarProducto_Load(object sender, EventArgs e)
        {

        }

    }
}
