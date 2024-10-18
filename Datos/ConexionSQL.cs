using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;


namespace Datos
{
    public class ConexionSql
    {
        static string stringConexion = "server= MAXIPC\\PROGRAMACIONII;database= primerparcial;integrated security =true;TrustServerCertificate=True;";
        SqlConnection conexion = new SqlConnection(stringConexion);

        // Funcion para consultar login

        public int loginUsuario(string usuario, string contraseña) { 
            conexion.Open();
            int resultado;

            // Consulta inicio de sesión

            string consultaLogin = $"select count(*) from Empleado where Usuario='{usuario}' and Clave='{contraseña}'";

            // Hago la consulta

            SqlCommand aplicarConsulta = new SqlCommand(consultaLogin, conexion);

            resultado = Convert.ToInt32(aplicarConsulta.ExecuteScalar());
            conexion.Close();
            return resultado;
        }

        // Funcion para ver todos los usuarios
        public DataTable verUsuarios() {
            conexion.Open();
            string consulta = "SELECT * FROM Empleado";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            
            conexion.Close();
            return tabla;
        }
        // Funcion para ver toda la informacion de todos los productos

        public DataTable detalleTotalProductos() { 
            conexion.Open();
            string consulta = "SELECT * FROM Producto";
            SqlDataAdapter adaptador = new SqlDataAdapter (consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        // Funcion para compra productos (Aca filtramos un toque las columnas que se muestran)

        public DataTable verCompraProducto() { 

            conexion.Open();
            string consulta = "SELECT NombreProducto, Stock from Producto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        // Funcion para venta productos (Tambien se filtra la info, similar a compra pero con la de porcentaje de ganancia)

        public DataTable verVentaProducto() {

            conexion.Open();
            string consulta = "SELECT NombreProducto, Stock, PrecioCosto, PorcentajeGanancia from Producto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;

        }

        // Funcion para agregar usuarios (Aca se insertan los datos de los usuarios)

        public void agregarUsuario(string nombre, string apellido, string telefono, string fechaNac, string usuario, string contraseña, string rol) { 
        
            conexion.Open();
            string consulta = $"insert into Empleado (Apellido, Nombre, Telefono, FechaNac, Usuario, Clave,rolEmpleado) values ('{nombre}', '{apellido}', '{telefono}','{fechaNac}','{usuario}','{contraseña}','{rol}');";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        // Eliminar usuario
        public void eliminarUsuario(string id)
        {
            conexion.Open();
            string consulta = $"delete from Empleado where id = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Editar usuarios 
        public void editarUsuario(string id, string nombre, string apellido, string telefono, string fechaNac, string usuario, string contraseña, string rol)
        {
            conexion.Open();
            string consulta = $"update Empleado set Apellido = '{apellido}', Nombre = '{nombre}', Telefono = '{telefono}', FechaNac = '{fechaNac}', Usuario = '{usuario}', Clave = '{contraseña}', rolEmpleado = '{rol}' where id = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Funcion para agregar producto
        public void agregarProducto(string codigo, string nombreProducto, string nombreCorto, string precioCosto, string stock, string stockMinimo, string porcentajeGanancia)
        {
            conexion.Open();
            string consulta = $"insert into Producto (Codigo, NombreProducto, NombreCorto, PrecioCosto, Stock, StockMinimo, PorcentajeGanancia) values ('{codigo}', '{nombreProducto}', '{nombreCorto}', '{precioCosto}', '{stock}', '{stockMinimo}', '{porcentajeGanancia}');";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Editar producto
        public void editarProducto(string id, string codigo, string nombreProducto, string nombreCorto, string precioCosto, string stock, string stockMinimo, string porcentajeGanancia)
        {
            conexion.Open();
            string consulta = $"update Producto set Codigo = '{codigo}', NombreProducto = '{nombreProducto}', NombreCorto = '{nombreCorto}', PrecioCosto = '{precioCosto}', Stock = '{stock}', StockMinimo = '{stockMinimo}', PorcentajeGanancia = '{porcentajeGanancia}' where id = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Eliminar producto
        public void eliminarProducto(string id)
        {
            conexion.Open();
            string consulta = $"delete from Producto where id = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }

}
