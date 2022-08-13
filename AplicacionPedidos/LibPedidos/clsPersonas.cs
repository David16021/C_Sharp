using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidos
{
    public class clsPersonas
    {
        private int _idPersona;
        private string _NombreCompleto;

        protected int IdPersona {
            get => _idPersona;
            set => _idPersona = value;
        }
        public string NombreCompleto {
            get => _NombreCompleto;
            set => _NombreCompleto = value;
        }
        public clsPersonas()
        {
            _idPersona = 0;
            _NombreCompleto = String.Empty;
        }
    }
}
