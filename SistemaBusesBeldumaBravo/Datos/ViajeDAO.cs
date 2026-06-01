using System.Data.SqlClient;
using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class ViajeDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Insertar(Viaje viaje)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Viajes
                (
                    IdBus,
                    IdConductor,
                    IdRuta,
                    FechaSalida,
                    FechaLlegada,
                    Estado
                )
                VALUES
                (
                    @IdBus,
                    @IdConductor,
                    @IdRuta,
                    @FechaSalida,
                    @FechaLlegada,
                    @Estado
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdBus", viaje.IdBus);
                cmd.Parameters.AddWithValue("@IdConductor", viaje.IdConductor);
                cmd.Parameters.AddWithValue("@IdRuta", viaje.IdRuta);
                cmd.Parameters.AddWithValue("@FechaSalida", viaje.FechaSalida);
                cmd.Parameters.AddWithValue("@FechaLlegada", viaje.FechaLlegada);
                cmd.Parameters.AddWithValue("@Estado", viaje.Estado);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}