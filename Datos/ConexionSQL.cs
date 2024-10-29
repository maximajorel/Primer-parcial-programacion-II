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
        static string stringConexion = "server= DESKTOP-RME9LD8\\SQLEXPRESS;database= primerparcial;integrated security =true;TrustServerCertificate=True;";
        SqlConnection conexion = new SqlConnection(stringConexion);

        // Funcion para consultar login

        public int loginUsuario(string usuario, string contraseña)
        {
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
        public DataTable verUsuarios()
        {
            conexion.Open();
            string consulta = "SELECT * FROM Empleado";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        // Funcion para ver toda la informacion de todos los productos

        public DataTable detalleTotalProductos()
        {
            conexion.Open();
            string consulta = "SELECT * FROM Producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        // Funcion para compra productos (Aca filtramos un toque las columnas que se muestran)

        public DataTable verCompraProducto()
        {

            conexion.Open();
            string consulta = "SELECT id, Codigo, NombreProducto, Stock from Producto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        // Funcion para venta productos (Tambien se filtra la info, similar a compra pero con la de porcentaje de ganancia)

        public DataTable verVentaProducto()
        {

            conexion.Open();
            string consulta = "SELECT id,NombreProducto, Stock, PrecioCosto, PorcentajeGanancia from Producto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conexion.Close();
            return tabla;

        }

        // Funcion para agregar usuarios (Aca se insertan los datos de los usuarios)

        public void agregarUsuario(string nombre, string apellido, string telefono, string fechaNac, string usuario, string contraseña, string rol)
        {

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

        // Verificar rol

        public string verificarRol(string usuario, string contraseña)
        {
            string rol = "";
            try
            {
                conexion.Open();
                string consulta = $"select rolEmpleado from Empleado where Usuario = '{usuario}' and Clave = '{contraseña}'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                rol = comando.ExecuteScalar()?.ToString() ?? "";
                conexion.Close();
            }
            catch
            {
                // Mensaje de error
                Console.WriteLine("No se encontró el rol");
            }
            return rol;
        }

        // Traer nombre y apellido del empleado segun usuario y clave

        public string traerNombreApellido(string usuario, string contraseña)
        {
            string nombreApellido = "";
            try
            {
                conexion.Open();
                string consulta = $"select Nombre, Apellido from Empleado where Usuario = '{usuario}' and Clave = '{contraseña}'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    nombreApellido = reader["Nombre"].ToString() + " " + reader["Apellido"].ToString();
                }
                conexion.Close();
            }
            catch
            {
                // Mensaje de error
                Console.WriteLine("No se encontró el nombre y apellido");
            }
            return nombreApellido;
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



        // Ver comprobantes en datatable
        public DataTable verComprobantes()
        {
            conexion.Open();
            string consulta = "SELECT * FROM ComprobantesEmitidos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        // Ver Cliente
        public DataTable verClientes()
        {
            conexion.Open();
            string comando = "SELECT * FROM Cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(comando, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;

        }

        // Agregar cliente
        public void agregarCliente(string apellido, string nombre, string telefono, string fechaNac, string descuento)
        {


            conexion.Open();
            string consulta = $"insert into Cliente (Apellido, Nombre, Telefono, FechaNac, Descuento) values ('{apellido}', '{nombre}', '{telefono}', '{fechaNac}', '{descuento}');";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        // Editar cliente
        public void editarCliente(string id, string apellido, string nombre, string telefono, string fechaNac, string descuento)
        {
            conexion.Open();
            string consulta = $"update Cliente set Apellido = '{apellido}', Nombre = '{nombre}', Telefono = '{telefono}', FechaNac = '{fechaNac}', Descuento = '{descuento}' where Codigo = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        // Eliminar cliente
        public void eliminarCliente(string id)
        {
            conexion.Open();
            string consulta = $"delete from Cliente where Codigo = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        // Obtener todos los nombre y apellido del empleado y guardarlo en una lista
        public List<string> obtenerNombreApellidoEmpleado()
        {
            List<string> lista = new List<string>();
            conexion.Open();
            string consulta = "select Nombre, Apellido from Empleado";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(reader["Nombre"].ToString() + " " + reader["Apellido"].ToString());
            }
            conexion.Close();
            return lista;
        }

        // Obtener todos los Apellido y Nombre de Cliente
        public List<string> obtenerNombreApellidoCliente()
        {
            List<string> lista = new List<string>();
            conexion.Open();
            string consulta = "select Nombre, Apellido from Cliente";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(reader["Apellido"].ToString() + " " + reader["Nombre"].ToString());
            }
            conexion.Close();
            return lista;
        }


        // Porcentaje de ganancia
        public double porcentajeGananciaProducto(string id)
        {

            conexion.Open();
            string consulta = $"select PorcentajeGanancia from Producto where id='{id}'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            double porcentaje = Convert.ToDouble(comando.ExecuteScalar());
            conexion.Close();
            return porcentaje;


        }

        // Precio costo producto
        public double precioCostoProducto(string id)
        {

            conexion.Open();
            string consulta = $"select PrecioCosto from Producto where id='{id}'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            double porcentaje = Convert.ToDouble(comando.ExecuteScalar());
            conexion.Close();
            return porcentaje;


        }
        // Cargar comprobante
        public void cargarComprobante(string tipo, string Numero, string Fecha, string Empleado, string Cliente, string Monto) { 
            
            conexion.Open();
            string consulta = $"insert into ComprobantesEmitidos (Tipo, Numero, Fecha, Empleado, Cliente, Monto) values ('{tipo}', '{Numero}', '{Fecha}', '{Empleado}', '{Cliente}', '{Monto}');";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }

        // Sumar stock a un producto 
        public void sumarStockProducto(string id, string cantidad)
        {
            conexion.Open();
            string consulta = $"update Producto set Stock = Stock + {cantidad} where id = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        // Restar stock a un producto
        public void restarStockProducto(string id, string cantidad)
        {
            conexion.Open();
            string consulta = $"update Producto set Stock = Stock - {cantidad} where id = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        // Ver stock de un producto
        public int verStockProducto(string id)
        {
            conexion.Open();
            string consulta = $"select Stock from Producto where id = {id}";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int stock = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();
            return stock;
        }

    }
}
