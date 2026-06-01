using System.Data;
using System.Data.SqlClient;
using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class BoletoDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Insertar(Boleto boleto)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Boletos
                (
                    IdPasajero,
                    IdViaje,
                    NumeroAsiento,
                    Valor,
                    FechaCompra
                )
                VALUES
                (
                    @IdPasajero,
                    @IdViaje,
                    @NumeroAsiento,
                    @Valor,
                    @FechaCompra
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdPasajero", boleto.IdPasajero);
                cmd.Parameters.AddWithValue("@IdViaje", boleto.IdViaje);
                cmd.Parameters.AddWithValue("@NumeroAsiento", boleto.NumeroAsiento);
                cmd.Parameters.AddWithValue("@Valor", boleto.Valor);
                cmd.Parameters.AddWithValue("@FechaCompra", boleto.FechaCompra);

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
                        "SELECT * FROM Boletos",
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
                    "DELETE FROM Boletos WHERE IdBoleto=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}