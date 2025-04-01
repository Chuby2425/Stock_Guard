using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Detalle_Salida
    {
        public int Id_DetalleSalida { get; set; } /// Esta es la Primary key
        public int CantidadDetalleSalida { get; set; }
        public DateTime FechaDetalleSalida { get; set; }
        public Producto oProductoDs { get; set; }

    }
}
