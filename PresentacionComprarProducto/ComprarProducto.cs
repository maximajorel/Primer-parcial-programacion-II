using Negocio;
using System.Data;
namespace PresentacionComprarProducto
{
    public partial class ComprarProducto : Form
    {
        List<string> listaEmpleados;


        public void obtenerNombreEmpleados() {
            ConexionSQL_Negocio nombreEmpleados = new ConexionSQL_Negocio();
            listaEmpleados = nombreEmpleados.obtenerNombresEmpleados();

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
            cargarComboBoxEmpleados();
            ConexionSQL_Negocio conexionNegocio = new ConexionSQL_Negocio();
            DataTable productos = conexionNegocio.verComprarProducto();
            tablaProductos.DataSource = productos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
