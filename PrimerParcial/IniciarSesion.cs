using Negocio;
using MenuPrincipal;
namespace PrimerParcial
{
    public partial class IniciarSesion : Form
    {
        ConexionSQL_Negocio conexion = new ConexionSQL_Negocio();

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {

            if (conexion.iniciarSesion(textboxUsuario.Text, textBoxContrase�a.Text) == 1)
            {
                MenuPrincipal.MenuPrincipal menu = new MenuPrincipal.MenuPrincipal();
                menu.usuario = textboxUsuario.Text;
                menu.contrase�a = textBoxContrase�a.Text;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contrase�a es incorrecto");
            }
        }

        private void textboxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
