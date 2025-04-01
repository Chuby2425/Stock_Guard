using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    // Esta parte es para la tabla de roles 
    public class Rol
    {
        public int Id_Rol {get; set;} /// Esta es la Primary key
        public string DescripcionRol { get; set; }
        public DateTime FechaCreacionRol { get; set; }

    }
}
