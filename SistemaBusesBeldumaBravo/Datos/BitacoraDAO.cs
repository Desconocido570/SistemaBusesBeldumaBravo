using SistemaBusesBeldumaBravo.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class BitacoraDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public void Insertar(Bitacora bitacora)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Bitacora
                (
                    IdUsuario,
                    Usuario,
                    Accion,
                    Modulo,
                    FechaHora,
                    Descripcion,
                    Equipo,
                    IpEquipo
                )
                VALUES
                (
                    @IdUsuario,
                    @Usuario,
                    @Accion,
                    @Modulo,
                    @FechaHora,
                    @Descripcion,
                    @Equipo,
                    @IpEquipo
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdUsuario", bitacora.IdUsuario);
                cmd.Parameters.AddWithValue("@Usuario", bitacora.Usuario);
                cmd.Parameters.AddWithValue("@Accion", bitacora.Accion);
                cmd.Parameters.AddWithValue("@Modulo", bitacora.Modulo);
                cmd.Parameters.AddWithValue("@FechaHora", bitacora.FechaHora);
                cmd.Parameters.AddWithValue("@Descripcion", bitacora.Descripcion);
                cmd.Parameters.AddWithValue("@Equipo", bitacora.Equipo);
                cmd.Parameters.AddWithValue("@IpEquipo", bitacora.IpEquipo);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }
     
            public DataTable Listar()
            {
                DataTable tabla = new DataTable();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    SqlDataAdapter da =
                        new SqlDataAdapter(
                            "SELECT * FROM Bitacora ORDER BY Fecha DESC",
                            cn);

                    da.Fill(tabla);
                }

                return tabla;
            }
        }
    }
