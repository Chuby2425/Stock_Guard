using Capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_entidad;
using Microsoft.Win32;
using System.Diagnostics;


namespace Capa_negocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_Usuario = new CD_Usuario();
        public List<Usuario> listar() 
        {
            return objcd_Usuario.listar();
        }

        public int Registrar(Usuario obj,out string Mensaje)
        {
            Mensaje = string.Empty;

            if(obj.NombreUsuario == "")
            {
                Mensaje += "Es necesario el nombre del ususario\n";
            }

            if (obj.CorreoUsuario == "")
            {
                Mensaje += "Es necesario el correo del ususario\n";
            }

            if(obj.ContrasennaUsuario == "")
            {
                Mensaje += "Es necesario la clave del ususario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Usuario.Registrar(obj, out Mensaje);
            }
            

        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            
            
            Mensaje = string.Empty;

            if (obj.NombreUsuario == "")
            {
                Mensaje += "Es necesario el nombre del ususario\n";
            }

            if (obj.CorreoUsuario == "")
            {
                Mensaje += "Es necesario el nombre del ususario\n";
            }

            if (obj.ContrasennaUsuario == "")
            {
                Mensaje += "Es necesario la clave del ususario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Usuario.Editar(obj, out Mensaje);
            }
            
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_Usuario.Eliminar(obj, out Mensaje);
        }
    }
}
