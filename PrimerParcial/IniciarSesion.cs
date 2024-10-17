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
             
            if (conexion.iniciarSesion(textboxUsuario.Text, textBoxContraseña.Text) == 1) {
                MessageBox.Show("Ok");
                MenuPrincipal.MenuPrincipal menu = new MenuPrincipal.MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Dato incorrecto");
            }
        }
    }
}
