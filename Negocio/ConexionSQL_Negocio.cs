using System;
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
    }
}
