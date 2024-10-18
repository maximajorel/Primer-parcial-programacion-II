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
    }
}
