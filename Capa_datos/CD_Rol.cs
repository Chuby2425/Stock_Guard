using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class CD_Rol
    {
            public List<Rol> listar()
            {
                List<Rol> lista = new List<Rol>();

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try // esto es para el capturador de errores 
                    {

                        // esl s.builder lo que me ayuda es hacer unos saltos de line para la sentencia/ importante columnas de la base datos 
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("SELECT Id_Rol,DescripcionRol FROM tbl_Rol");

                        SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                lista.Add(new Rol()
                                {
                                    Id_Rol = Convert.ToInt32(dr["Id_Rol"]),
                                    DescripcionRol = dr["DescripcionRol"].ToString(),
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                return lista;
            }
    }
}
