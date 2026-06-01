using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{
    
        public class Ruta
        {
            public int IdRuta { get; set; }

            public string Origen { get; set; }

            public string Destino { get; set; }

            public decimal Distancia { get; set; }

            public decimal Precio { get; set; }

            public override string ToString()
            {
                return $"{Origen} - {Destino}";
            }
        }
    }

