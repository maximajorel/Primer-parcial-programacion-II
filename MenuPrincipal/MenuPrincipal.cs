using PresentacionActualizarRoles;
using PresentacionComprarProducto;
using PresentacionVenderProducto;
using PresentacionConsultaMovimientos;
using Negocio;
namespace MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        public string usuario { get; set; }
        public string contraseña  { get; set; }
        public string rol;

        public void verificarRol()
        {
            ConexionSQL_Negocio verificarRol = new ConexionSQL_Negocio();
            rol = verificarRol.verificarRol(usuario, contraseña);

        }

        // Habilitar o deshabilitar botones segun su rol

        public void validarRoles() {
            if (rol == "Operador")
            {

                botonActualizacionEmpleados.Enabled = false;
                botonConsultaMovimientos.Enabled = false;

            }
            else if (rol == "Auditor")
            {
                botonActualizacionEmpleados.Enabled = false;
            }
            else { 
                botonActualizacionEmpleados.Enabled = false;
                botonCompraProducto.Enabled = false;
                botonConsultaMovimientos.Enabled = false;
                botonVentaDeProductos.Enabled = false;
            }
        }

        public MenuPrincipal()
        {
            InitializeComponent();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            verificarRol();
            validarRoles();
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
            


        }

        private void botonCompraProducto_Click(object sender, EventArgs e)
        {
            ComprarProducto comprarProducto = new ComprarProducto();
            comprarProducto.Show();
            
        }

        private void botonVentaDeProductos_Click(object sender, EventArgs e)
        {
            VenderProducto venderProducto = new VenderProducto();
            venderProducto.Show();
            
        }

        private void botonConsultaMovimientos_Click(object sender, EventArgs e)
        {
          ConsultaMovimiento consultaMovimientos  = new ConsultaMovimiento();
            consultaMovimientos.Show();
            
            


        }
    }
}
