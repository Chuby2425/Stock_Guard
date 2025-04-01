using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio
{
    public class CN_Rol
    {
        private CD_Rol objcd_Rol = new CD_Rol();

        public List<Rol> listar()
        {
            return objcd_Rol.listar();

        }

    }
}
