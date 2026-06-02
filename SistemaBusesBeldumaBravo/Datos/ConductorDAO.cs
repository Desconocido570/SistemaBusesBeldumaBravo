using SistemaBusesBeldumaBravo.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class ConductorDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Insertar(Conductor conductor)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Conductores
                (
                    IdEmpleado,
                    Licencia,
                    TipoLicencia,
                    FechaVencimiento
                )
                VALUES
                (
                    @IdEmpleado,
                    @Licencia,
                    @TipoLicencia,
                    @FechaVencimiento
                )";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdEmpleado", conductor.IdEmpleado);
                cmd.Parameters.AddWithValue("@Licencia", conductor.Licencia);
                cmd.Parameters.AddWithValue("@TipoLicencia", conductor.TipoLicencia);
                cmd.Parameters.AddWithValue("@FechaVencimiento", conductor.FechaVencimiento);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM Conductores",
                        cn);

                da.Fill(tabla);
            }

            return tabla;
        }

        public Conductor BuscarPorId(int id)
        {
            Conductor conductor = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "SELECT * FROM Conductores WHERE IdConductor=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    conductor = new Conductor();

                    conductor.IdConductor =
                        Convert.ToInt32(dr["IdConductor"]);

                    conductor.IdEmpleado =
                        Convert.ToInt32(dr["IdEmpleado"]);

                    conductor.Licencia =
                        dr["Licencia"].ToString();

                    conductor.TipoLicencia =
                        dr["TipoLicencia"].ToString();

                    conductor.FechaVencimiento =
                        Convert.ToDateTime(dr["FechaVencimiento"]);
                }
            }

            return conductor;
        }

        public bool Actualizar(Conductor conductor)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"UPDATE Conductores
                  SET
                    IdEmpleado=@IdEmpleado,
                    Licencia=@Licencia,
                    TipoLicencia=@TipoLicencia,
                    FechaVencimiento=@FechaVencimiento
                  WHERE IdConductor=@IdConductor";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdEmpleado", conductor.IdEmpleado);
                cmd.Parameters.AddWithValue("@Licencia", conductor.Licencia);
                cmd.Parameters.AddWithValue("@TipoLicencia", conductor.TipoLicencia);
                cmd.Parameters.AddWithValue("@FechaVencimiento", conductor.FechaVencimiento);
                cmd.Parameters.AddWithValue("@IdConductor", conductor.IdConductor);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "DELETE FROM Conductores WHERE IdConductor=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}