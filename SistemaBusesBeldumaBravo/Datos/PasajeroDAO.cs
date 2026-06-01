using System.Data;
using System.Data.SqlClient;
using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class PasajeroDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Insertar(Pasajero pasajero)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Pasajeros
                (
                    Cedula,
                    Nombre,
                    Apellido,
                    Telefono
                )
                VALUES
                (
                    @Cedula,
                    @Nombre,
                    @Apellido,
                    @Telefono
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Cedula", pasajero.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", pasajero.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", pasajero.Telefono);

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
                        "SELECT * FROM Pasajeros",
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
                    "DELETE FROM Pasajeros WHERE IdPasajero=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}