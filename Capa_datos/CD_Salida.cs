using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_entidad;

namespace Capa_datos
{
    public class CD_Salida
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
                    query.AppendLine("SELECT COALESCE(MAX(CAST(NumeroDocumentoSalida AS INT)), 0) + 1 FROM tbl_Salidas");
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

        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update tbl_Productos set StockProducto = StockProducto - @cantidad where Id_Producto = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update tbl_Productos set StockProducto = StockProducto + @cantidad where Id_Producto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool Registrar(Salida obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("@Id_UsuarioSalida", obj.oUsuarioS.Id_Usuario);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroFacturaSalida", obj.NumeroFactura);
                    cmd.Parameters.AddWithValue("@DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

        public Salida ObtenerVenta(string numero)
        {

            Salida obj = new Salida();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select v.Id_Salida,u.NombreUsuario,");
                    query.AppendLine("v.TipoDocumento,v.NumeroDocumentoSalida,");
                    query.AppendLine("CONVERT(CHAR(10), v.FechaSalida,103)[FechaRegistro]");
                    query.AppendLine("from tbl_Salidas v");
                    query.AppendLine("INNER JOIN tbl_Usuarios u ON u.Id_Usuario = v.IdUsuarioSalida");
                    query.AppendLine("Where v.NumeroDocumentoSalida = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            obj = new Salida()
                            {
                                Id_Salida = int.Parse(dr["Id_Salida"].ToString()),
                                oUsuarioS = new Usuario() { NombreUsuario = dr["NombreUsuario"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroFactura = dr["NumeroDocumentoSalida"].ToString(),
                                FechaSalida = Convert.ToDateTime(dr["FechaRegistro"])
                            };
                        }
                    }

                }
                catch
                {
                    obj = new Salida();
                }
                return obj;
            }
        }

        public List<Detalle_Salida> ObtenerDetalleSalida(int idsalida)
        {
            List<Detalle_Salida> oLista = new List<Detalle_Salida>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT p.NombreProducto,dv.CantidadDetalleSalida from tbl_DetalleSalida dv");
                    query.AppendLine("INNER JOIN tbl_Productos p ON p.Id_Producto = dv.Id_ProductoDetalleSalida");
                    query.AppendLine("WHERE dv.Id_DetalleSalida = @idsalida");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idsalida", idsalida);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Salida()
                            {
                                oProductoDs = new Producto() { NombreProducto = dr["NombreProducto"].ToString() },
                                CantidadDetalleSalida = Convert.ToInt32(dr["CantidadDetalleSalida"].ToString()),

                            });
                        }
                    }

                }
                catch
                {
                    oLista = new List<Detalle_Salida>();
                }
            }
            return oLista;
        }
    }
}