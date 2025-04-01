using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio
{
    public class CN_Salida
    {
        private CD_Salida objcd_salida = new CD_Salida();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_salida.RestarStock(idproducto, cantidad);
        }
        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcd_salida.SumarStock(idproducto, cantidad);
        }
        public int ObtenerCorrelativo()
        {
            return objcd_salida.ObtenerCorrelativo();
        }
        public bool Registrar(Salida obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_salida.Registrar(obj, DetalleVenta, out Mensaje);
        }


        public Salida ObtenerVenta(string numero)
        {
            Salida oSalida = objcd_salida.ObtenerVenta(numero);

            if (oSalida.Id_Salida != 0)
            {
                List<Detalle_Salida> oDetaaleSalida = objcd_salida.ObtenerDetalleSalida(oSalida.Id_Salida);
                oSalida.oDetalleSalidaS = oDetaaleSalida;
            }

            return oSalida;
        }



    }
}
