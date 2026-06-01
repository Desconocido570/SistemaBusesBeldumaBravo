using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{
  public class Empleado : Persona
        {
        public int IdEmpleado { get; set; }

        public DateTime FechaIngreso { get; set; }

        public decimal Sueldo { get; set; }

        public bool Estado { get; set; }

        public override string MostrarDatos()
        {
            return $"Empleado: {NombreCompleto}";
        }
    }
    }


