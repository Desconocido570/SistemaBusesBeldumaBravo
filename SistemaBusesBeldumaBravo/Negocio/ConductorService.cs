using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class ConductorService
    {
        public bool LicenciaVigente(Conductor conductor)
        {
            return conductor.FechaVencimiento > DateTime.Now;
        }

        public bool ValidarLicencia(Conductor conductor)
        {
            return !string.IsNullOrWhiteSpace(conductor.Licencia);
        }
    }
}