using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaBusesBeldumaBravo.Entidades;

namespace SistemaBusesBeldumaBravo.Negocio
{
    public class BoletoService
    {
        public decimal CalcularTotal(Boleto boleto)
        {
            return boleto.Valor;
        }

        public bool ValidarAsiento(int asiento)
        {
            return asiento > 0;
        }

        public bool ValidarBoleto(Boleto boleto)
        {
            if (boleto.IdPasajero <= 0)
                return false;

            if (boleto.IdViaje <= 0)
                return false;

            if (boleto.NumeroAsiento <= 0)
                return false;

            return true;
        }
    }
}