using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace SistemaBusesBeldumaBravo.Utilidades
{
    public static class Validaciones
    {
        public static bool EsCedulaValida(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                return false;

            return cedula.Length == 10;
        }

        public static bool EsCorreoValido(string correo)
        {
            string patron =
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(correo, patron);
        }

        public static bool EsTelefonoValido(string telefono)
        {
            return telefono.Length >= 7;
        }

        public static bool EsNumero(string valor)
        {
            decimal numero;

            return decimal.TryParse(
                valor,
                out numero);
        }

        public static bool CampoVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
    }
}
