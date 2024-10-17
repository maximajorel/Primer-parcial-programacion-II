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
    }
}
