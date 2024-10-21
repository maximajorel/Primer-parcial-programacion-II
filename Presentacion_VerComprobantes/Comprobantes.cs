using Negocio;
namespace Presentacion_VerComprobantes
{
    public partial class formVerComprobantes : Form
    {
        public formVerComprobantes()
        {
            InitializeComponent();
        }

        private void formVerComprobantes_Load(object sender, EventArgs e)
        {
            // Mostrar comprobantes en dataGridComprobantes
            ConexionSQL_Negocio conexion = new ConexionSQL_Negocio();
            dataGridComprobantes.DataSource = conexion.verComprobantes();

        }
    }
}
