using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{
        public class Bitacora
        {
            public int IdBitacora { get; set; }

            public int IdUsuario { get; set; }

            public string Usuario { get; set; }

            public string Accion { get; set; }

            public string Modulo { get; set; }

            public string Descripcion { get; set; }

            public DateTime FechaHora { get; set; }

            public string Equipo { get; set; }

            public string IpEquipo { get; set; }

            public Bitacora()
            {
                FechaHora = DateTime.Now;
            }

            public override string ToString()
            {
                return $"{FechaHora} - {Usuario} - {Accion}";
            }
        }
    }

