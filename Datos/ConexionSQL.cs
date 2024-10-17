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


namespace Datos
{
    public class ConexionSql
    {
        static string stringConexion = "server = MAXIPC\\PROGRAMACIONII; database= primerparcial; integrated security =true; TrustServerCertificate=True;";
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
    }
}
