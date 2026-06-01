using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class EmpleadoService
    {
        public bool ValidarEmpleado(Empleado empleado)
        {
            if (string.IsNullOrWhiteSpace(empleado.Cedula))
                return false;

            if (string.IsNullOrWhiteSpace(empleado.Nombre))
                return false;

            if (string.IsNullOrWhiteSpace(empleado.Apellido))
                return false;

            if (empleado.Sueldo <= 0)
                return false;

            return true;
        }

        public int CalcularEdad(Empleado empleado)
        {
            return System.DateTime.Now.Year -
                   empleado.FechaNacimiento.Year;
        }
    }
}