using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio
{
    public class CN_Producto
    {

        private CD_Productos objcd_Producto = new CD_Productos();
        public List<Producto> listar()
        {
            return objcd_Producto.listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.CodigoProducto == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.NombreProducto == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.DescripcionProducto == "")
            {
                Mensaje += "Es necesario ingresar la descripcion del producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Producto obj, out string Mensaje)
        {


            Mensaje = string.Empty;


            if (obj.CodigoProducto == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.NombreProducto == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.DescripcionProducto == "")
            {
                Mensaje += "Es necesario ingresar la descripcion del producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
