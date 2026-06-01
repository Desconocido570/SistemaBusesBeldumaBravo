using System.Data;
using System.Data.SqlClient;
using SistemaBusesBeldumaBravo.Entidades;

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