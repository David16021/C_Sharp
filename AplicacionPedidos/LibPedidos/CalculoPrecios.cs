using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidos
{
    internal static class CalculoPrecios
    {
        internal static decimal DesglosaImpuestos(decimal precio, decimal porcentajeIva, decimal porcentajeIeps,
                                        out decimal montoIva, out decimal montoIeps)
        {
            decimal resultado = 0;
            resultado = precio / (1 + porcentajeIva / 100m);
            montoIva = Math.Round(resultado * (porcentajeIva / 100m), 2);
            resultado = resultado / (1+ porcentajeIeps / 100m);
            montoIeps = Math.Round(resultado * (porcentajeIeps / 100m), 2);
            return Math.Round(resultado,2);
        }
    }
}
