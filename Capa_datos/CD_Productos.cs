using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Capa_datos
{
    public class CD_Productos
    {
        public List<Producto> listar() //con esto vemos lo que esta almacenado en la base de datos en el apartado de la tabla 
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT Id_Producto, NombreProducto, p.DescripcionProducto,c.Id_Categoria,c.DescripcionCategoria[DescripcionCategoria],StockProducto,CodigoProducto,p.EstadoProducto FROM tbl_Productos p\r\n");
                    query.AppendLine("INNER JOIN tbl_Categoria c ON c.Id_Categoria = p.Id_CategoriaProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //revisar bien el orden de todo base de datos no es el mismo orden que productos 
                            lista.Add(new Producto()
                            {
                                Id_Producto = Convert.ToInt32(dr["Id_Producto"]),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                DescripcionProducto = dr["DescripcionProducto"].ToString(),
                                oCategoria = new Categoria() { Id_Categoria = Convert.ToInt32(dr["Id_Categoria"]),DescripcionCategoria = dr["DescripcionCategoria"].ToString() },
                                StockProducto = Convert.ToInt32(dr["StockProducto"].ToString()),
                                EstadoProducto = Convert.ToBoolean(dr["EstadoProducto"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }
            return lista;
        }


        //Procedimiento alamacenado de registrar ususario 
        public int Registrar(Producto obj, out string Mensaje)
        {
            int IdProductoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Agregar parámetros de entrada

                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", oconexion);


                    cmd.Parameters.AddWithValue("@Codigo", obj.CodigoProducto);
                    cmd.Parameters.AddWithValue("@Nombre", obj.NombreProducto);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.DescripcionProducto);
                    cmd.Parameters.AddWithValue("@IdCategoria", obj.oCategoria.Id_Categoria);
                    cmd.Parameters.AddWithValue("@Estado", obj.EstadoProducto);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    IdProductoGenerado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();


                }
            }
            catch (Exception ex)
            {
                IdProductoGenerado = 0;
                Mensaje = ex.Message;
            }

            return IdProductoGenerado;
        }

        //Procedimiento almacenado de Editar ususario
        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EditarProducto", oconexion);

                    cmd.Parameters.AddWithValue("@IdProducto", obj.Id_Producto);
                    cmd.Parameters.AddWithValue("@Codigo", obj.CodigoProducto);
                    cmd.Parameters.AddWithValue("@Nombre", obj.NombreProducto);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.DescripcionProducto);
                    cmd.Parameters.AddWithValue("@IdCategoria", obj.oCategoria.Id_Categoria);
                    cmd.Parameters.AddWithValue("@Estado", obj.EstadoProducto);
                    

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

        //Procedimiento almacenado eliminar 
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.Id_Producto);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
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
