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
    }
}
