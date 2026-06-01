using System.Data.SqlClient;
using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class RutaDAO
    {
        private ConexionBD conexion = new ConexionBD();

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
    }
}
