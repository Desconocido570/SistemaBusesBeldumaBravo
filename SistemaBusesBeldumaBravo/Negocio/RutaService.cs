using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class RutaService
    {
        public bool ValidarRuta(Ruta ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta.Origen))
                return false;

            if (string.IsNullOrWhiteSpace(ruta.Destino))
                return false;

            if (ruta.Precio <= 0)
                return false;

            return true;
        }

        public decimal ObtenerPrecio(Ruta ruta)
        {
            return ruta.Precio;
        }
    }
}