using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{//Esto es lo de la tabla de proveedores 
    public class Proveedor
    {
        public int Id_Proveedores { get; set; } /// Esta es la Primary key
        public string NombreProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public string CorreoProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public bool EstadoProveedor { get; set; }
        public DateTime FechaCreacionProveedor { get; set; }
        
    }
}

