using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Datos
{
    public class ConexionBD
    {
        private string cadenaConexion =
            @"Server=JOEBELDUMAPC\SQLEXPRESS;
              Database=SistemaBuses;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
