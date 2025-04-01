using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Categoria
    {
        public int Id_Categoria { get; set; } /// Esta es la Primary key
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public bool EstadoCategoria { get; set; }
        public DateTime FechaCreacionProveedor { get; set; }



    }
}
