using SistemaBusesBeldumaBravo.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class PasajeroDAO
    {
        private ConexionBD conexion = new ConexionBD();

        // INSERTAR
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

        // LISTAR
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

        // BUSCAR POR ID
        public Pasajero BuscarPorId(int id)
        {
            Pasajero pasajero = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "SELECT * FROM Pasajeros WHERE IdPasajero=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                SqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    pasajero = new Pasajero();

                    pasajero.IdPasajero =
                        Convert.ToInt32(dr["IdPasajero"]);

                    pasajero.Cedula =
                        dr["Cedula"].ToString();

                    pasajero.Nombre =
                        dr["Nombre"].ToString();

                    pasajero.Apellido =
                        dr["Apellido"].ToString();

                    pasajero.Telefono =
                        dr["Telefono"].ToString();
                }
            }

            return pasajero;
        }

        // ACTUALIZAR
        public bool Actualizar(Pasajero pasajero)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"UPDATE Pasajeros
                  SET
                    Cedula=@Cedula,
                    Nombre=@Nombre,
                    Apellido=@Apellido,
                    Telefono=@Telefono
                  WHERE IdPasajero=@IdPasajero";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdPasajero", pasajero.IdPasajero);
                cmd.Parameters.AddWithValue("@Cedula", pasajero.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", pasajero.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", pasajero.Telefono);

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