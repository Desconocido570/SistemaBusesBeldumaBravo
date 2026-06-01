using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Utilidades
{
    public static class Sesion
    {
        // Pull Request Prueba 2026
        public static int IdUsuario { get; set; }

        public static string Usuario { get; set; }

        public static int IdRol { get; set; }

        public static string NombreRol { get; set; }

        public static bool Activa { get; set; }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            Usuario = "";
            IdRol = 0;
            NombreRol = "";
            Activa = false;
        }
    }
}