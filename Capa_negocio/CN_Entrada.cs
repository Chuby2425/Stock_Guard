using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio
{
    public class CN_Entrada
    {
        private CD_Entrada objcd_Entrada = new CD_Entrada();
        public int ObtenerCorrelativo()
        {
            return objcd_Entrada.ObtenerCorrelativo();
        }

        public bool Registrar(Entrada obj, DataTable DetalleEntrada, out string Mensaje)
        {
           return objcd_Entrada.Registrar(obj,DetalleEntrada, out Mensaje);  
        }

        public Entrada obtenerEntrada(string numero)
        {
            Entrada oEntrada = objcd_Entrada.ObtenerEntrada(numero);

            if (oEntrada.Id_Entrada != 0)
            {
                List<Detalle_Entrada> odetalle_Entrada = objcd_Entrada.ObtenerDetalleEntrada(oEntrada.Id_Entrada);

                oEntrada.oDetalleEntradaE = odetalle_Entrada;
            }
            return oEntrada;
        }
    }
}
