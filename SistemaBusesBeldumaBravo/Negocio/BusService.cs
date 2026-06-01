using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class BusService
    {
        public bool ValidarBus(Bus bus)
        {
            if (string.IsNullOrWhiteSpace(bus.Placa))
                return false;

            if (bus.Capacidad <= 0)
                return false;

            return true;
        }

        public bool Disponible(Bus bus)
        {
            return bus.Estado == "Disponible";
        }
    }
}