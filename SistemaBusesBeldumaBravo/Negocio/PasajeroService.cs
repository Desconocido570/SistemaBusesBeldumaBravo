using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class PasajeroService
    {
        public bool ValidarPasajero(Pasajero pasajero)
        {
            if (string.IsNullOrWhiteSpace(pasajero.Cedula))
                return false;

            if (string.IsNullOrWhiteSpace(pasajero.Nombre))
                return false;

            if (string.IsNullOrWhiteSpace(pasajero.Apellido))
                return false;

            return true;
        }
    }
}