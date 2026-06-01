using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{
        public class Viaje
        {
            public int IdViaje { get; set; }

            public int IdBus { get; set; }

            public int IdConductor { get; set; }

            public int IdRuta { get; set; }

            public DateTime FechaSalida { get; set; }

            public DateTime FechaLlegada { get; set; }

            public string Estado { get; set; }
        }
    }

