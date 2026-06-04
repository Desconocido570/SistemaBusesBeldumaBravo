using SistemaBusesBeldumaBravo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class BusDAO
    {
        private ConexionBD conexion = new ConexionBD();

        // INSERTAR
        public bool Insertar(Bus bus)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Buses
                (
                    Placa,
                    Marca,
                    Modelo,
                    Anio,
                    Capacidad,
                    Estado
                )
                VALUES
                (
                    @Placa,
                    @Marca,
                    @Modelo,
                    @Anio,
                    @Capacidad,
                    @Estado
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Placa", bus.Placa);
                cmd.Parameters.AddWithValue("@Marca", bus.Marca);
                cmd.Parameters.AddWithValue("@Modelo", bus.Modelo);
                cmd.Parameters.AddWithValue("@Anio", bus.Anio);
                cmd.Parameters.AddWithValue("@Capacidad", bus.Capacidad);
                cmd.Parameters.AddWithValue("@Estado", bus.Estado);

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
                        "SELECT * FROM Buses",
                        cn);

                da.Fill(tabla);
            }

            return tabla;
        }

        // BUSCAR POR ID
        public Bus BuscarPorId(int id)
        {
            Bus bus = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "SELECT * FROM Buses WHERE IdBus=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                SqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    bus = new Bus();

                    bus.IdBus =
                        Convert.ToInt32(dr["IdBus"]);

                    bus.Placa =
                        dr["Placa"].ToString();

                    bus.Marca =
                        dr["Marca"].ToString();

                    bus.Modelo =
                        dr["Modelo"].ToString();

                    bus.Anio =
                        Convert.ToInt32(dr["Anio"]);

                    bus.Capacidad =
                        Convert.ToInt32(dr["Capacidad"]);

                    bus.Estado =
                        dr["Estado"].ToString();
                }
            }

            return bus;
        }

        // ACTUALIZAR
        public bool Actualizar(Bus bus)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"UPDATE Buses
                  SET
                    Placa=@Placa,
                    Marca=@Marca,
                    Modelo=@Modelo,
                    Anio=@Anio,
                    Capacidad=@Capacidad,
                    Estado=@Estado
                  WHERE IdBus=@IdBus";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdBus", bus.IdBus);
                cmd.Parameters.AddWithValue("@Placa", bus.Placa);
                cmd.Parameters.AddWithValue("@Marca", bus.Marca);
                cmd.Parameters.AddWithValue("@Modelo", bus.Modelo);
                cmd.Parameters.AddWithValue("@Anio", bus.Anio);
                cmd.Parameters.AddWithValue("@Capacidad", bus.Capacidad);
                cmd.Parameters.AddWithValue("@Estado", bus.Estado);

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
                    "DELETE FROM Buses WHERE IdBus=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
