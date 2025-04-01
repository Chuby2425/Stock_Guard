using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Capa_datos
{
    public class Conexion// esto es para la conexion de base de datos 
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["Cadena_conexion"].ToString();

    }
}
