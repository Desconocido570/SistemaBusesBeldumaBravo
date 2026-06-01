using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class ViajeService
    {
        public bool ValidarViaje(Viaje viaje)
        {
            if (viaje.FechaLlegada <= viaje.FechaSalida)
                return false;

            return true;
        }

        public TimeSpan DuracionViaje(Viaje viaje)
        {
            return viaje.FechaLlegada -
                   viaje.FechaSalida;
        }
    }
}