using PresentacionActualizarRoles;
using PresentacionComprarProducto;
using PresentacionVenderProducto;
using PresentacionConsultaMovimientos;
namespace MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void botonActualizacionEmpleados_Click(object sender, EventArgs e)
        {
            // Mostrar la ventana actualizarRoles, y cuando se cierre, mostrar esta ventana
            actualizarRoles actualizarRoles = new actualizarRoles();       
            actualizarRoles.Show();
            this.Hide();


        }

        private void botonCompraProducto_Click(object sender, EventArgs e)
        {
            ComprarProducto comprarProducto = new ComprarProducto();
            comprarProducto.Show();
            this.Hide();
        }

        private void botonVentaDeProductos_Click(object sender, EventArgs e)
        {
            VenderProducto venderProducto = new VenderProducto();
            venderProducto.Show();
            this.Hide();
        }

        private void botonConsultaMovimientos_Click(object sender, EventArgs e)
        {
          ConsultaMovimiento consultaMovimientos  = new ConsultaMovimiento();
            consultaMovimientos.Show();
            this.Hide();
            


        }
    }
}
