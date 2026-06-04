using SistemaBusesBeldumaBravo.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class EmpleadoDAO
    {
        private ConexionBD conexion = new ConexionBD();

        // INSERTAR
        public bool Insertar(Empleado empleado)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = @"INSERT INTO Empleados
                (
                    Cedula,
                    Nombre,
                    Apellido,
                    FechaNacimiento,
                    Telefono,
                    Correo,
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
                    @Telefono,
                    @Correo,
                    @FechaIngreso,
                    @Sueldo,
                    @Estado
                )";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                cmd.Parameters.AddWithValue("@Sueldo", empleado.Sueldo);
                cmd.Parameters.AddWithValue("@Estado", empleado.Estado);

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
                        "SELECT * FROM Empleados",
                        cn);

                da.Fill(tabla);
            }

            return tabla;
        }

        // BUSCAR
        public Empleado BuscarPorCedula(string cedula)
        {
            Empleado empleado = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "SELECT * FROM Empleados WHERE Cedula=@Cedula";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Cedula", cedula);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    empleado = new Empleado();

                    empleado.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                    empleado.Cedula = dr["Cedula"].ToString();
                    empleado.Nombre = dr["Nombre"].ToString();
                    empleado.Apellido = dr["Apellido"].ToString();
                    empleado.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    empleado.Telefono = dr["Telefono"].ToString();
                    empleado.Correo = dr["Correo"].ToString();
                    empleado.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                    empleado.Sueldo = Convert.ToDecimal(dr["Sueldo"]);
                    empleado.Estado = Convert.ToBoolean(dr["Estado"]);
                }
            }

            return empleado;
        }

        // ACTUALIZAR
        public bool Actualizar(Empleado empleado)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = @"UPDATE Empleados
                               SET Nombre=@Nombre,
                                   Apellido=@Apellido,
                                   FechaNacimiento=@FechaNacimiento,
                                   Telefono=@Telefono,
                                   Correo=@Correo,
                                   FechaIngreso=@FechaIngreso,
                                   Sueldo=@Sueldo,
                                   Estado=@Estado
                               WHERE Cedula=@Cedula";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                cmd.Parameters.AddWithValue("@Sueldo", empleado.Sueldo);
                cmd.Parameters.AddWithValue("@Estado", empleado.Estado);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ELIMINAR
        public bool Eliminar(string cedula)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "DELETE FROM Empleados WHERE Cedula=@Cedula";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Cedula", cedula);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public Empleado BuscarPorId(int id)
        {
            Empleado empleado = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    "SELECT * FROM Empleados WHERE IdEmpleado=@Id";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    empleado = new Empleado();

                    empleado.IdEmpleado =
                        Convert.ToInt32(dr["IdEmpleado"]);

                    empleado.Cedula =
                        dr["Cedula"].ToString();

                    empleado.Nombre =
                        dr["Nombre"].ToString();

                    empleado.Apellido =
                        dr["Apellido"].ToString();

                    empleado.FechaNacimiento =
                        Convert.ToDateTime(dr["FechaNacimiento"]);

                    empleado.Telefono =
                        dr["Telefono"].ToString();

                    empleado.Correo =
                        dr["Correo"].ToString();

                    empleado.FechaIngreso =
                        Convert.ToDateTime(dr["FechaIngreso"]);

                    empleado.Sueldo =
                        Convert.ToDecimal(dr["Sueldo"]);

                    empleado.Estado =
                        Convert.ToBoolean(dr["Estado"]);
                }
            }

            return empleado;
        }
    }
}