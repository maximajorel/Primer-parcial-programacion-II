using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ConexionSQL_Negocio
    {
        ConexionSql conexion = new ConexionSql();

        public int iniciarSesion(string usuario, string contraseña)
        {
            return conexion.loginUsuario(usuario, contraseña);
        }

        public DataTable verUsuarios()
        {
            return conexion.verUsuarios();
        }
        public DataTable verDetalleCompletoProductos() { 
            return conexion.detalleTotalProductos();
        }
        public DataTable verComprarProducto() { 
            return conexion.verCompraProducto();
        }
        public DataTable verVentaProducto()
        {
            return conexion.verVentaProducto();
        }
        
        public void agregarUsuario(string apellido, string nombre, string telefono, string fechaNac, string usuario, string contraseña, string rol)
        {
            conexion.agregarUsuario(apellido, nombre, telefono, fechaNac, usuario, contraseña, rol);
        }

        public void eliminarUsuario( string id)
        {
           conexion.eliminarUsuario(id);
        }

        public void editarUsuario(string id, string apellido, string nombre, string telefono, string fechaNac, string usuario, string contraseña, string rol)
        {
            conexion.editarUsuario(id, apellido, nombre, telefono, fechaNac, usuario, contraseña, rol);
        }

        public void agregarProducto(string codigo, string nombreProducto, string nombreCorto, string precioCosto, string stock, string stockMinimo, string porcentajeGanancia) { 
            conexion.agregarProducto(codigo, nombreProducto, nombreCorto, precioCosto, stock, stockMinimo, porcentajeGanancia);
        }
      
        public void editarProducto(string id, string codigo, string nombreProducto, string nombreCorto, string precioCosto, string stock, string stockMinimo, string porcentajeGanancia)
        {
            conexion.editarProducto(id, codigo, nombreProducto, nombreCorto, precioCosto, stock, stockMinimo, porcentajeGanancia);
        }

        public void eliminarProducto(string id) { 
            conexion.eliminarProducto(id);
        }
        public string verificarRol(string usuario, string contraseña)
        {
            return conexion.verificarRol(usuario, contraseña);
        }
        public string nombreyApellido(string usuario, string contraseña)
        {
             return conexion.traerNombreApellido(usuario, contraseña);
        }
        public DataTable verComprobantes()
        {
            return conexion.verComprobantes();
        }
        public DataTable verClientes() { 
            
            return conexion.verClientes();

        }      
        public void agregarCliente(string apellido, string nombre, string telefono, string fechaNac, string descuento)
        {
            conexion.agregarCliente(apellido, nombre, telefono, fechaNac, descuento);
        }        
        public void editarCliente(string id, string apellido, string nombre, string telefono, string fechaNac, string descuento)
        {
            conexion.editarCliente(id, apellido, nombre, telefono, fechaNac, descuento);
        }
        public void eliminarCliente(string id)
        {
            conexion.eliminarCliente(id);
        }

        // Obtener nombre y apellido de cliente
        public List<String> obtenerNombresEmpleados() {

            return conexion.obtenerNombreApellidoEmpleado();
        
        }











    }

}
