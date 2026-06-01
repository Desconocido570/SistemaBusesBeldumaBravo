using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{
  
        public class Administrador : Empleado
        {
            public string Cargo { get; set; }

            public override string MostrarDatos()
            {
                return $"Administrador: {NombreCompleto}";
            }
        }
    }

