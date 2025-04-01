using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;

namespace Capa_negocio
{
    public  class CN_Permiso
    {
        private CD_Permiso objcd_Permiso = new CD_Permiso();

        public List<Permisos> listar(int idUsuario)
        {
            return objcd_Permiso.listar(idUsuario);

        }
    }
}
