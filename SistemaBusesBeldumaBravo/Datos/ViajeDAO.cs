using SistemaBusesBeldumaBravo.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class ViajeDAO
    {
        private ConexionBD conexion = new ConexionBD();

        // INSERTAR
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

        // LISTAR
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM Viajes",
                        cn);

                da.Fill(tabla);
            }

            return tabla;
        }

        // BUSCAR POR ID
        public Viaje BuscarPorId(int id)
        {
            Viaje viaje = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "SELECT * FROM Viajes WHERE IdViaje=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    viaje = new Viaje();

                    viaje.IdViaje = Convert.ToInt32(dr["IdViaje"]);
                    viaje.IdBus = Convert.ToInt32(dr["IdBus"]);
                    viaje.IdConductor = Convert.ToInt32(dr["IdConductor"]);
                    viaje.IdRuta = Convert.ToInt32(dr["IdRuta"]);
                    viaje.FechaSalida = Convert.ToDateTime(dr["FechaSalida"]);
                    viaje.FechaLlegada = Convert.ToDateTime(dr["FechaLlegada"]);
                    viaje.Estado = dr["Estado"].ToString();
                }
            }

            return viaje;
        }

        // ACTUALIZAR
        public bool Actualizar(Viaje viaje)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"UPDATE Viajes
                  SET
                    IdBus=@IdBus,
                    IdConductor=@IdConductor,
                    IdRuta=@IdRuta,
                    FechaSalida=@FechaSalida,
                    FechaLlegada=@FechaLlegada,
                    Estado=@Estado
                  WHERE IdViaje=@IdViaje";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdViaje", viaje.IdViaje);
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

        // ELIMINAR
        public bool Eliminar(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "DELETE FROM Viajes WHERE IdViaje=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}