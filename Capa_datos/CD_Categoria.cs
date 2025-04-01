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
    public  class CD_Categoria
    {

        public List<Categoria> listar() //con esto vemos lo que esta almacenado en la base de datos en el apartado de la tabla 
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT Id_Categoria,DescripcionCategoria,EstadoCategoria FROM tbl_Categoria");
                
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                Id_Categoria = Convert.ToInt32(dr["Id_Categoria"]),
                                DescripcionCategoria = dr["DescripcionCategoria"].ToString(),   
                                EstadoCategoria = Convert.ToBoolean(dr["EstadoCategoria"]),


                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }


        //Procedimiento alamacenado de registrar Categoria 
        public int Registrar(Categoria obj, out string Mensaje)
        {
            int IdCategoriaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Agregar parámetros de entrada

                    SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria", oconexion);


                    cmd.Parameters.AddWithValue("@Descripcion", obj.DescripcionCategoria);
                    cmd.Parameters.AddWithValue("@Estado", obj.EstadoCategoria);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    IdCategoriaGenerado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();


                }
            }
            catch (Exception ex)
            {
                IdCategoriaGenerado = 0;
                Mensaje = ex.Message;
            }

            return IdCategoriaGenerado;
        }

        //Procedimiento almacenado de Editar Categoria
        public bool Editar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EditarCategoria", oconexion);

                    cmd.Parameters.AddWithValue("@IdCategoria", obj.Id_Categoria);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.DescripcionCategoria);
                    cmd.Parameters.AddWithValue("@Estado", obj.EstadoCategoria);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
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

        //Procedimiento almacenado eliminar categoria
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", oconexion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.Id_Categoria);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }


    }
}
