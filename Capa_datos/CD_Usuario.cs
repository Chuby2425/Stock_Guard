using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_entidad;
using System.Linq.Expressions;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Collections;


namespace Capa_datos
{
    public class CD_Usuario
    {
      public List <Usuario> listar() //con esto vemos lo que esta almacenado en la base de datos en el apartado de la tabla 
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.Id_Usuario,u.NombreUsuario,u.ContrasennaUsuario,u.CorreoUsuario,u.EstadoUsuario,r.Id_Rol,r.DescripcionRol from tbl_Usuarios u");
                    query.AppendLine("INNER JOIN tbl_Rol r on r.Id_Rol = u.Id_Rol_Usuario\r\n");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]),
                                NombreUsuario = dr["NombreUsuario"].ToString(),
                                ContrasennaUsuario = dr["ContrasennaUsuario"].ToString(),
                                CorreoUsuario = dr["CorreoUsuario"].ToString(),
                                EstadoUsuario = Convert.ToBoolean(dr["EstadoUsuario"]),
                                oRolU = new Rol(){Id_Rol = Convert.ToInt32(dr["Id_Rol"]),DescripcionRol = dr["DescripcionRol"].ToString(), } 
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
      }


      //Procedimiento alamacenado de registrar ususario 
       public int Registrar(Usuario obj, out string Mensaje)
        {
            int IdUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Agregar parámetros de entrada

                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", oconexion);

                    
                    cmd.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasenna", obj.ContrasennaUsuario);
                    cmd.Parameters.AddWithValue("@Correo", obj.CorreoUsuario);
                    cmd.Parameters.AddWithValue("@Estado", obj.EstadoUsuario);
                    cmd.Parameters.AddWithValue("@Id_Rol", obj.oRolU.Id_Rol);

                    cmd.Parameters.Add("@IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                        oconexion.Open();

                        cmd.ExecuteNonQuery();

                        IdUsuarioGenerado = Convert.ToInt32(cmd.Parameters["@IdUsuarioResultado"].Value);
                        Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();

                    
                }
            }
            catch (Exception ex)
            {
                IdUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }

            return IdUsuarioGenerado;
       }
        
        //Procedimiento almacenado de Editar ususario
        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EditarUsuario", oconexion);

                    cmd.Parameters.AddWithValue("@IdUsuario", obj.Id_Usuario);
                    cmd.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasenna", obj.ContrasennaUsuario);
                    cmd.Parameters.AddWithValue("@Correo", obj.CorreoUsuario);
                    cmd.Parameters.AddWithValue("@Estado", obj.EstadoUsuario);
                    cmd.Parameters.AddWithValue("@Id_Rol", obj.oRolU.Id_Rol);

                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }


            return respuesta;
        }

        //Procedimiento almacenado eliminar 
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.Id_Usuario);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}
