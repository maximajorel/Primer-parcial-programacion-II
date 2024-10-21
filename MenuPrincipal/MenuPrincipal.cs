using PresentacionActualizarRoles;
using PresentacionComprarProducto;
using PresentacionVenderProducto;
using PresentacionConsultaMovimientos;
using Negocio;
using Presentacion_VerComprobantes;
using Presentacion_AgregarCliente;
namespace MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string rol;
        bool mostrarmenu = false;
        public void verificarRol()
        {
            ConexionSQL_Negocio verificarRol = new ConexionSQL_Negocio();
            rol = verificarRol.verificarRol(usuario, contraseña);

        }

        // Funcion para volver al menu

        /*
        public void volverMenu()
        {
            PresentacionActualizarRoles.actualizarRoles actualizarRoles = new PresentacionActualizarRoles.actualizarRoles();
            mostrarmenu = actualizarRoles.volvermenu;

            while (mostrarmenu) { 
            
            }
                      
             this.Show();
             mostrarmenu = false;
            

                
        }
        */

        // Habilitar o deshabilitar botones segun su rol

        public void validarRoles()
        {
            if (rol == "Operador")
            {
                labelRolUsuarioDinamico.Text = "Operador";
                botonActualizacionEmpleados.Enabled = false;
                botonConsultaMovimientos.Enabled = false;

            }
            else if (rol == "Auditor")
            {
                labelRolUsuarioDinamico.Text = "Auditor";
                botonActualizacionEmpleados.Enabled = false;
            }
            else if (rol == "Administrador")
            {
                labelRolUsuarioDinamico.Text = "Administrador";
                botonActualizacionEmpleados.Enabled = true;
                botonCompraProducto.Enabled = true;
                botonConsultaMovimientos.Enabled = true;
                botonVentaDeProductos.Enabled = true;
            }
            else
            {
                labelRolUsuarioDinamico.Text = "No tiene rol asignado, contactese con el administrador";
                botonActualizacionEmpleados.Enabled = false;
                botonCompraProducto.Enabled = false;
                botonConsultaMovimientos.Enabled = false;
                botonVentaDeProductos.Enabled = false;
                buttonVerComprobantes.Enabled = false;

            }
        }
        public void obtenerNombre()
        {

            ConexionSQL_Negocio obtenernombre = new ConexionSQL_Negocio();
            string usuario = "Anonimo";
            usuario = obtenernombre.nombreyApellido(this.usuario, this.contraseña);
            labelUsuarioDinamico.Text = usuario;


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
            obtenerNombre();
            verificarRol();
            validarRoles();
            //  volverMenu();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void botonActualizacionEmpleados_Click(object sender, EventArgs e)
        {
            // Mostrar la ventana actualizarRoles
            actualizarRoles actualizarRoles = new actualizarRoles();
            actualizarRoles.Show();
            // this.Hide();


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
            ConsultaMovimiento consultaMovimientos = new ConsultaMovimiento();
            consultaMovimientos.Show();
        }

        private void buttonVerComprobantes_Click(object sender, EventArgs e)
        {
            Presentacion_VerComprobantes.formVerComprobantes verComprobantes = new Presentacion_VerComprobantes.formVerComprobantes();
            verComprobantes.Show();
        }

        private void buttonGestionarClientes_Click(object sender, EventArgs e)
        {
            Presentacion_AgregarCliente.formPresentacionClientes formPresentacionClientes = new Presentacion_AgregarCliente.formPresentacionClientes();
            formPresentacionClientes.Show();
        }
    }
}
