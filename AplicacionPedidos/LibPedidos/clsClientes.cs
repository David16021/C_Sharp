using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidos
{
    public class clsClientes : clsPersonas
    {
        public string Rfc { get; set; }
        public int idCliente 
        {
            get { return IdPersona; }
            set { IdPersona = value; }
        }

        public override string ToString()
        {
            string cadena = $"idCliente = {idCliente.ToString()} NombreCompleto = {NombreCompleto} Rfc = {Rfc}";
            return cadena;
        }
    }
}

