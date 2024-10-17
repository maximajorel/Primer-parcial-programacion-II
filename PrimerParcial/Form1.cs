using Negocio;
namespace PrimerParcial
{
    public partial class Form1 : Form
    {
        ConexionSQL_Negocio conexion = new ConexionSQL_Negocio();
        public Form1()
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
            }
            else {
                MessageBox.Show("Dato incorrecto");
            }
        }
    }
}
