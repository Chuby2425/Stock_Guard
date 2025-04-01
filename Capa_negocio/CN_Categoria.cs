﻿using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_Categoria = new CD_Categoria();
        public List<Categoria> listar()
        {
            return objcd_Categoria.listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.DescripcionCategoria == "")
            {
                Mensaje += "Es necesario la descripcion de la ususario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Categoria.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Categoria obj, out string Mensaje)
        {


            Mensaje = string.Empty;

            if (obj.DescripcionCategoria == "")
            {
                Mensaje += "Es necesario la descripcion de la ususario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Categoria.Editar(obj, out Mensaje);
            }


        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }





    }
}
