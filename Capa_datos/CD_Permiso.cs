using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class CD_Permiso
    {
            public List<Permisos> listar(int idUsuario)
            {
                List<Permisos> lista = new List<Permisos>();

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try // esto es para el capturador de errores 
                    {

                        // esl s.builder lo que me ayuda es hacer unos saltos de line para la sentencia
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("SELECT p.Id_Rol_Permiso,p.NombreMenuPermiso FROM tbl_Permisos p");
                        query.AppendLine("INNER JOIN tbl_Rol r on r.Id_Rol = p.Id_Rol_Permiso");
                        query.AppendLine("INNER JOIN tbl_Usuarios u on u.Id_Rol_Usuario = r.Id_Rol");
                        query.AppendLine("WHERE u.Id_Usuario = @idUsuario");

                       
                        SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.CommandType = CommandType.Text;


                        oconexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                lista.Add(new Permisos()
                                {
                                    oRolP = new Rol() { Id_Rol = Convert.ToInt32(dr["Id_Rol_Permiso"]),},
                                    NombreMenuPermiso = dr ["NombreMenuPermiso"].ToString(),
                                   
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                      Console.WriteLine("Error: " + ex.Message);
                      lista = new List<Permisos>();
                    }

                }
                return lista;
            }


        }

    }

