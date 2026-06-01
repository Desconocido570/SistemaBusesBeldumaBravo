using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{

        public class Boleto
        {
            public int IdBoleto { get; set; }

            public int IdPasajero { get; set; }

            public int IdViaje { get; set; }

            public int NumeroAsiento { get; set; }

            public decimal Valor { get; set; }

            public DateTime FechaCompra { get; set; }

            public Boleto()
            {
                FechaCompra = DateTime.Now;
            }
        }
    }
