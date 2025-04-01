using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    // Esta parte es para la tabla de permisos 
    public class Permisos
    {
        public int Id_Permiso { get; set; } /// Esta es la Primary key
        public string DescripcionPermiso { get; set; }
        public Rol oRolP { get; set; }
        public string NombreMenuPermiso { get; set; }
        public DateTime FechaCreacionPermiso { get; set; }
    }
}
