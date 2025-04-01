using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Entrada
    {
        public int Id_Entrada { get; set; } /// Esta es la Primary key
        public DateTime FechaEntrada { get; set; }
        public string NumeroFactura { get; set; }
        public bool EstadoProducto { get; set; }
        public Usuario oUsuarioE { get; set; }
        public Proveedor oProveedorE { get; set; }
        public string TipoDocumento { get; set; }
        public List<Detalle_Entrada> oDetalleEntradaE { get; set; }
    }
}
