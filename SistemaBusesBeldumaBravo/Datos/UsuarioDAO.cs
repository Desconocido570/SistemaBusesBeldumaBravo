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
    public class UsuarioDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Insertar(Usuario usuario)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = @"INSERT INTO Usuarios
                              (Usuario,Clave,IdRol,Estado)
                              VALUES
                              (@Usuario,@Clave,@IdRol,@Estado)";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@Estado", usuario.Estado);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = "SELECT * FROM Usuarios";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Usuario u = new Usuario();

                    u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    u.NombreUsuario = dr["Usuario"].ToString();
                    u.Clave = dr["Clave"].ToString();
                    u.IdRol = Convert.ToInt32(dr["IdRol"]);
                    u.Estado = Convert.ToBoolean(dr["Estado"]);

                    lista.Add(u);
                }
            }

            return lista;
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = "DELETE FROM Usuarios WHERE IdUsuario=@id";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Login(string usuario, string clave)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    @"SELECT COUNT(*)
                      FROM Usuarios
                      WHERE Usuario=@Usuario
                      AND Clave=@Clave
                      AND Estado=1";

                SqlCommand cmd =
                    new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                cn.Open();

                int cantidad =
                    Convert.ToInt32(cmd.ExecuteScalar());

                return cantidad > 0;
            }
        }
        public bool Actualizar(Usuario usuario)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = @"UPDATE Usuarios
                       SET Usuario=@usuario,
                           Clave=@clave,
                           IdRol=@idRol,
                           Estado=@estado
                       WHERE IdUsuario=@id";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@idRol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                cmd.Parameters.AddWithValue("@id", usuario.IdUsuario);

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public Usuario Buscar(string nombreUsuario)
        {
            Usuario usuario = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = @"SELECT * FROM Usuarios
                       WHERE Usuario=@usuario";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = new Usuario();

                    usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    usuario.NombreUsuario = dr["Usuario"].ToString();
                    usuario.Clave = dr["Clave"].ToString();
                    usuario.IdRol = Convert.ToInt32(dr["IdRol"]);
                    usuario.Estado = Convert.ToBoolean(dr["Estado"]);
                }
            }

            return usuario;
        }
        public Usuario BuscarPorId(int id)
        {
            Usuario usuario = null;

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string sql = "SELECT * FROM Usuarios WHERE IdUsuario=@id";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = new Usuario();

                    usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    usuario.NombreUsuario = dr["Usuario"].ToString();
                    usuario.Clave = dr["Clave"].ToString();
                    usuario.IdRol = Convert.ToInt32(dr["IdRol"]);
                    usuario.Estado = Convert.ToBoolean(dr["Estado"]);
                }
            }

            return usuario;
        }
    }
}
