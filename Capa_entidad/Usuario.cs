using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    // Esta parte es para la tabla de usuarios 
    public class Usuario
    {   
        public int Id_Usuario { get; set; } /// Esta es la Primary key
        public string NombreUsuario { get; set; }
        public string ContrasennaUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public DateTime FechaRegistroUsuario { get; set; }
        public DateTime FechaInactivacionUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public Rol oRolU { get; set; }
        public string NombreMenuPermiso { get; set; }
        
    }


}

