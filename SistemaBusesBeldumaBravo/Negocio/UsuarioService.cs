using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaBusesBeldumaBravo.Utilidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class UsuarioService
    {
        public string EncriptarClave(string clave)
        {
            return Encriptador.EncriptarSHA256(clave);
        }

        public bool ValidarUsuario(string usuario)
        {
            return !string.IsNullOrWhiteSpace(usuario);
        }

        public bool ValidarClave(string clave)
        {
            return clave.Length >= 6;
        }
    }
}