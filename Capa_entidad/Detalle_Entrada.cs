using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Detalle_Entrada
    {
        public int Id_DetalleEntrada { get; set; } /// Esta es la Primary key
        public int CantidadDetalleEntrada { get; set; }
        public Producto oProductoDE { get; set; }
    }
}
