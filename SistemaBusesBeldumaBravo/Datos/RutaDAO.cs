using SistemaBusesBeldumaBravo.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class RutaDAO
    {
        private ConexionBD conexion = new ConexionBD();

        // INSERTAR
        public bool Insertar(Ruta ruta)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Rutas
                (
                    Origen,
                    Destino,
                    Distancia,
                    Precio
                )
                VALUES
                (
                    @Origen,
                    @Destino,
                    @Distancia,
                    @Precio
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Origen", ruta.Origen);
                cmd.Parameters.AddWithValue("@Destino", ruta.Destino);
                cmd.Parameters.AddWithValue("@Distancia", ruta.Distancia);
                cmd.Parameters.AddWithValue("@Precio", ruta.Precio);

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
                        "SELECT * FROM Rutas",
                        cn);

                da.Fill(tabla);
            }

            return tabla;
        }

        // BUSCAR POR ID
        public Ruta BuscarPorId(int id)
        {
            Ruta ruta = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "SELECT * FROM Rutas WHERE IdRuta=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                SqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    ruta = new Ruta();

                    ruta.IdRuta =
                        Convert.ToInt32(dr["IdRuta"]);

                    ruta.Origen =
                        dr["Origen"].ToString();

                    ruta.Destino =
                        dr["Destino"].ToString();

                    ruta.Distancia =
                        Convert.ToDecimal(dr["Distancia"]);

                    ruta.Precio =
                        Convert.ToDecimal(dr["Precio"]);
                }
            }

            return ruta;
        }

        // ACTUALIZAR
        public bool Actualizar(Ruta ruta)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"UPDATE Rutas
                  SET
                    Origen=@Origen,
                    Destino=@Destino,
                    Distancia=@Distancia,
                    Precio=@Precio
                  WHERE IdRuta=@IdRuta";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdRuta", ruta.IdRuta);
                cmd.Parameters.AddWithValue("@Origen", ruta.Origen);
                cmd.Parameters.AddWithValue("@Destino", ruta.Destino);
                cmd.Parameters.AddWithValue("@Distancia", ruta.Distancia);
                cmd.Parameters.AddWithValue("@Precio", ruta.Precio);

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
                    "DELETE FROM Rutas WHERE IdRuta=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
