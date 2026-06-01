using System.Data;
using System.Data.SqlClient;
using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class EmpleadoDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Insertar(Empleado empleado)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                @"INSERT INTO Empleados
                (
                    Cedula,
                    Nombre,
                    Apellido,
                    FechaNacimiento,
                    Sexo,
                    Telefono,
                    Correo,
                    Direccion,
                    FechaIngreso,
                    Sueldo,
                    Estado
                )
                VALUES
                (
                    @Cedula,
                    @Nombre,
                    @Apellido,
                    @FechaNacimiento,
                    @Sexo,
                    @Telefono,
                    @Correo,
                    @Direccion,
                    @FechaIngreso,
                    @Sueldo,
                    @Estado
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                cmd.Parameters.AddWithValue("@Sueldo", empleado.Sueldo);
                cmd.Parameters.AddWithValue("@Estado", empleado.Estado);

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
                        "SELECT * FROM Empleados",
                        cn);

                da.Fill(tabla);
            }

            return tabla;
        }
    }
}