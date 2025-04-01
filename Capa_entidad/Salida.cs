using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Salida
    {   
        public int Id_Salida{  get; set; }
        public DateTime FechaSalida { get; set; }
        public Usuario oUsuarioS {  get; set; }
        public string NumeroFactura { get; set; }
        public List <Detalle_Salida> oDetalleSalidaS { get; set; }
        public string TipoDocumento { get; set; }
    }
}
