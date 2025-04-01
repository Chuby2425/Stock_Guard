using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio
{
    public class CN_reportes
    {
        private CD_Reportes objcd_reporte = new CD_Reportes();

        public List<ReporteEntrada> Compra(string fechainicio, string fechafin, int idproducto)
        {
            return objcd_reporte.Compra(fechainicio, fechafin,idproducto);
        }

        public List<ReporteSalida> Venta(string fechainicio, string fechafin)
        {
            return objcd_reporte.Venta(fechainicio, fechafin);
        }

    }
}
