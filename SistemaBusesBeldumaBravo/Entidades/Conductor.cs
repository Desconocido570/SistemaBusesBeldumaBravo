using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{
   
        public class Conductor : Empleado
        {
            public int IdConductor { get; set; }

            public string Licencia { get; set; }

            public string TipoLicencia { get; set; }

            public DateTime FechaVencimiento { get; set; }

            public override string MostrarDatos()
            {
                return $"Conductor: {NombreCompleto}";
            }
        }
    }

