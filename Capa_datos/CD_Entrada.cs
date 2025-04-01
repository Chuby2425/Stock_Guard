using Capa_entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class CD_Entrada
    {
        //con esto obtenemos los correlativos de el numero de factura 
        public int ObtenerCorrelativo()
        {
            int IdCorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT COALESCE(MAX(CAST(NumeroFacturaEntrada AS INT)), 0) + 1 FROM tbl_Entradas");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    IdCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine("Correlativo obtenido: " + IdCorrelativo); // Debug en consola
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); // Debug en consola
                    IdCorrelativo = 0;
                }
            }
            return IdCorrelativo;
        }


        public bool Registrar(Entrada obj,DataTable DetalleEntrada,out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarEntrada",oconexion);
                    cmd.Parameters.AddWithValue("@Id_UsuarioEntrada", obj.oUsuarioE.Id_Usuario);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroFacturaEntrada",obj.NumeroFactura);
                    cmd.Parameters.AddWithValue("@DetalleCompra",DetalleEntrada);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;


                    oconexion.Open();
                    cmd.ExecuteNonQuery();  



                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje= ex.Message;
                }
            }
            return Respuesta;
        }

        public Entrada ObtenerEntrada(string numero)
        {
            Entrada obj = new Entrada();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT C.Id_Entrada,");
                    query.AppendLine("U.NombreUsuario,");
                    query.AppendLine("c.TipoDocumento,c.NumeroFacturaEntrada,CONVERT(CHAR(10), c.FechaEntrada,103)[FechaRegistro]");
                    query.AppendLine("FROM tbl_Entradas c");
                    query.AppendLine("inner join tbl_Usuarios u on u.Id_Usuario = c.Id_UsuarioEntrada");
                    query.AppendLine("where c.NumeroFacturaEntrada = @numero");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero",numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            obj = new Entrada()
                            {
                                Id_Entrada = Convert.ToInt32(dr["Id_Entrada"]),
                                oUsuarioE = new Usuario() {NombreUsuario= dr["NombreUsuario"].ToString()},
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroFactura = dr["NumeroFacturaEntrada"].ToString(),
                                FechaEntrada = Convert.ToDateTime(dr["FechaRegistro"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = new Entrada();
                }
            }
            return obj;
        }

        public List<Detalle_Entrada> ObtenerDetalleEntrada(int idEntrada)
        {
            List<Detalle_Entrada>oLista = new List<Detalle_Entrada>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {


                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.NombreProducto,dc.CantidadDetalleEntrada");
                    query.AppendLine("FROM tbl_DetalleEntradas dc");
                    query.AppendLine("INNER JOIN tbl_Productos p ON p.Id_Producto = dc.Id_ProductoDetalleEntrada");
                    query.AppendLine("WHERE dc.Id_EntradaDetalleEntrada = @IdEntrada");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@IdEntrada", idEntrada);
                    cmd.CommandType = System.Data.CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Entrada()
                            {
                                oProductoDE = new Producto() { NombreProducto = dr["NombreProducto"].ToString() },
                                CantidadDetalleEntrada = Convert.ToInt32(dr["CantidadDetalleEntrada"].ToString())
                            });
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                oLista = new List<Detalle_Entrada>();
            }
            return oLista;
        }
    }
}
