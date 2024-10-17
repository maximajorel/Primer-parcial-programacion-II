using System.Data;
using Negocio;
namespace PresentacionActualizarRoles
{
    public partial class actualizarRoles : Form
    {
        private ConexionSQL_Negocio consultaUsuarios;
        public actualizarRoles()
        {
            InitializeComponent();           

        }

        private void actualizarRoles_Load(object sender, EventArgs e)

        {
             ConexionSQL_Negocio consultaUsuarios = new ConexionSQL_Negocio(); ;
        DataTable usuarios = consultaUsuarios.verUsuarios();
            tablaUsuarios.DataSource = usuarios;
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
