using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBusesBeldumaBravo.Entidades
{
        public class Usuario
        {
            public int IdUsuario { get; set; }

            public string NombreUsuario { get; set; }

            public string Clave { get; set; }

            public int IdRol { get; set; }

            public bool Estado { get; set; }

            public DateTime FechaCreacion { get; set; }

            public Usuario()
            {
                FechaCreacion = DateTime.Now;
                Estado = true;
            }
        }
    }

